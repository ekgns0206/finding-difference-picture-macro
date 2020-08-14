using IronPython.Runtime;
using FINDING_DIFFERENCE_PICTURE.Module;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Text;

namespace FINDING_DIFFERENCE_PICTURE
{
    public enum OperationType
    {
        Software, Hardware
    }

    public class App : IDisposable
    {
#region IMPORT WINDOWS APIs
        [DllImport("user32.dll", SetLastError = true)]  
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

        [DllImport("gdi32.dll")]
        static extern IntPtr CreateBitmap(int nWidth, int nHeight, uint cPlanes, uint cBitsPerPel, IntPtr lpvBits);

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool PostMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern bool ClientToScreen(IntPtr hWnd, ref System.Drawing.Point lpPoint);

        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        public static extern IntPtr GetParent(IntPtr hWnd);


        public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);






#pragma warning disable 649
        internal struct INPUT
        {
            public UInt32 Type;
            public MOUSEKEYBDHARDWAREINPUT Data;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct MOUSEKEYBDHARDWAREINPUT
        {
            [FieldOffset(0)]
            public HARDWAREINPUT Hardware;
            [FieldOffset(0)]
            public KEYBDINPUT Keyboard;
            [FieldOffset(0)]
            public MOUSEINPUT Mouse;

        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct HARDWAREINPUT
        {
            public uint Msg;
            public ushort ParamL;
            public ushort ParamH;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct KEYBDINPUT
        {
            public ushort Vk;
            public ushort Scan;
            public uint Flags;
            public uint Time;
            public IntPtr ExtraInfo;
        }


        internal struct MOUSEINPUT
        {
            public Int32 X;
            public Int32 Y;
            public UInt32 MouseData;
            public UInt32 Flags;
            public UInt32 Time;
            public IntPtr ExtraInfo;
        }

#pragma warning restore 649
        #endregion

        public delegate void OnFrameHandler(Mat frame);

        private Thread streamingThread;
        public System.Drawing.Point previousCursorPosition;
        private bool disposed = false;
        private OperationType operationType = OperationType.Software;

        public event OnFrameHandler OnFrame;

        public IntPtr Hwnd { get; private set; }

        public Mat Frame
        {
            get
            {
                return ProcessCapture.Capture(this.Hwnd);
            }
        }

        public Rectangle Area
        {
            get
            {
                return ProcessCapture.GetArea(this.Hwnd);
            }
        }

        public PythonTuple PyArea
        {
            get
            {
                return this.Area.ToTuple();
            }
        }

        private IntPtr _foregroundActiveHandle;
        public IntPtr ForegroundActiveHandle
        {
            get
            {
                return this._foregroundActiveHandle;
            }
            private set
            {
                if(value == this.Hwnd)
                    return;

                this._foregroundActiveHandle = value;
            }
        }

        public bool IsStreaming { get; private set; }

        public App(string className, OperationType operationType)
        {
            this.Hwnd = this.FindAppHandle(className);
            if (this.Hwnd == IntPtr.Zero)
                throw new Exception("Could not find the app");

            this.operationType = operationType;
        }

        ~App()
        {
            this.Dispose(false);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(this.disposed)
                return;

            if (disposing)
            {

            }

            this.Release();
            this.disposed = true;
        }

        private IntPtr FindAppHandle(string className)
        {
            foreach (var process in Process.GetProcesses())
            {
                if (process.MainWindowHandle == (IntPtr)0x00170E10)
                {
                    Console.WriteLine("asd");
                }

                try
                {
                    if (process.ProcessName.Equals(className) && process.MainWindowHandle != IntPtr.Zero)
                        return process.MainWindowHandle;
                }
                catch (Exception e)
                {
                    continue;
                }
            }

            return IntPtr.Zero;
        }

        public void SetActive(bool active, int sleepTime = 0)
        {
            if(this.operationType == OperationType.Hardware && sleepTime != 0)
                Thread.Sleep(sleepTime);

            if(active)
            {
                this.ForegroundActiveHandle = GetForegroundWindow();
                SetForegroundWindow(this.Hwnd);
            }
            else
            {
                SetForegroundWindow(this.ForegroundActiveHandle);
            }
        }

        private void MouseAction(MouseButtons button, bool down, System.Drawing.Point location)
        {
            if (this.operationType == OperationType.Hardware)
            {
                var area = this.Area;
                var beforeLocation = Cursor.Position;
                var flag = (uint)0x0002; // base : left down

                if(!down)
                    flag = flag << 1;

                if(button != MouseButtons.Left)
                    flag = flag << 2;

                /// set cursor on coords, and press mouse
                Cursor.Position = new System.Drawing.Point(area.X + location.X, area.Y + location.Y);
                this.SetActive(true, 0);

                var action = new INPUT();
                action.Type = 0; /// input type mouse
                action.Data.Mouse.Flags = flag;

                var inputs = new INPUT[] { action };
                SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

                this.SetActive(false, 50);
                Cursor.Position = beforeLocation;
            }
            else
            {
                if (button == MouseButtons.Left)
                    PostMessage(this.Hwnd, down ? 0x201 : 0x202, new IntPtr(down ? 0x0001 : 0x0000), new IntPtr(location.Y * 0x10000 + location.X));
                else
                    PostMessage(this.Hwnd, down ? 0x204 : 0x205, new IntPtr(down ? 0x0002 : 0x0000), new IntPtr(location.Y * 0x10000 + location.X));
            }
        }

        public void MouseDown(MouseButtons button, System.Drawing.Point location)
        {
            this.MouseAction(button, true, location);
        }

        public void MouseDown(string button, int x, int y)
        {
            this.MouseDown(button.Equals("left") ? MouseButtons.Left : MouseButtons.Right, new System.Drawing.Point(x, y));
        }

        public void MouseUp(MouseButtons button, System.Drawing.Point location)
        {
            this.MouseAction(button, false, location);
        }

        public void MouseUp(string button, int x, int y)
        {
            this.MouseUp(button.Equals("left") ? MouseButtons.Left : MouseButtons.Right, new System.Drawing.Point(x, y));
        }

        public void Click(MouseButtons button, System.Drawing.Point location)
        {
            if (this.operationType == OperationType.Hardware)
            {
                //var beforeLocation = Cursor.Position;
                this.StoreCursorPosition(location);
                var flag = (uint)0x0002;

                if(button != MouseButtons.Left)
                    flag = flag << 2;

                this.SetActive(true, 0);

                var down = new INPUT();
                down.Type = 0;
                down.Data.Mouse.Flags = flag;

                var up = new INPUT();
                up.Type = 0;
                up.Data.Mouse.Flags = flag << 1;

                var inputs = new INPUT[] { down, up };
                SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

                this.SetActive(false, 50);
                this.RestoreCursorPosition();
                //this.SetCursorPosition(beforeLocation);
            }
            else
            {
                this.MouseDown(button, location);
                this.MouseUp(button, location);
            }
        }

        public void StoreCursorPosition(System.Drawing.Point location)
        {
            var area = this.Area;
            this.previousCursorPosition = Cursor.Position;

            Cursor.Position = new System.Drawing.Point(area.X + location.X, area.Y + location.Y);
        }

        public void RestoreCursorPosition()
        {
            Cursor.Position = this.previousCursorPosition;
        }

        public void StoreCursorPosition(int x, int y)
        {
            this.StoreCursorPosition(new System.Drawing.Point(x, y));
        }

        public void KeyPress(Keys key, int sleepTime = 100)
        {
            if (this.operationType == OperationType.Hardware)
            {
                this.SetActive(true, sleepTime);

                var down = new INPUT();
                down.Type = 1;
                down.Data.Keyboard.Vk = (ushort)key;
                down.Data.Keyboard.Scan = 0;
                down.Data.Keyboard.Flags = 0x0000;
                down.Data.Keyboard.Time = 0;
                down.Data.Keyboard.ExtraInfo = IntPtr.Zero;

                var up = new INPUT();
                up.Type = 1;
                up.Data.Keyboard.Vk = (ushort)key;
                up.Data.Keyboard.Scan = 0;
                up.Data.Keyboard.Flags = 0x0002;
                up.Data.Keyboard.Time = 0;
                up.Data.Keyboard.ExtraInfo = IntPtr.Zero;

                var inputs = new INPUT[] { down, up };
                SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

                this.SetActive(false, sleepTime);
            }
            else
            {
                this.KeyDown(key);
                this.KeyUp(key);
            }
        }

        public void KeyPress(string key, int sleepTime = 100)
        {
            foreach(var c in key)
                this.KeyPress((Keys)c, sleepTime);
        }

        public void KeyDown(Keys key, int sleepTime = 100)
        {
            if (this.operationType == OperationType.Hardware)
            {
                this.SetActive(true, sleepTime);

                var down = new INPUT();
                down.Type = 1;
                down.Data.Keyboard.Vk = (ushort)key;
                down.Data.Keyboard.Scan = 0;
                down.Data.Keyboard.Flags = 0;
                down.Data.Keyboard.Time = 0;
                down.Data.Keyboard.ExtraInfo = IntPtr.Zero;

                var inputs = new INPUT[] { down };
                SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

                this.SetActive(false, sleepTime);
            }
            else
            {
                SendMessage(this.Hwnd, 0x0100, new IntPtr((int)key), IntPtr.Zero);
            }
        }

        public void KeyUp(Keys key, int sleepTime = 100)
        {
            if (this.operationType == OperationType.Hardware)
            {
                this.SetActive(true, sleepTime);

                var up = new INPUT();
                up.Type = 1;
                up.Data.Keyboard.Vk = (ushort)key;
                up.Data.Keyboard.Scan = 0;
                up.Data.Keyboard.Flags = 2;
                up.Data.Keyboard.Time = 0;
                up.Data.Keyboard.ExtraInfo = IntPtr.Zero;

                var inputs = new INPUT[] { up };
                SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

                /// return mouse 
                this.SetActive(false, sleepTime);
            }
            else
            {
                SendMessage(this.Hwnd, 0x0101, new IntPtr((int)key), IntPtr.Zero);
            }
        }

        public void Click(MouseButtons button, int x, int y)
        {
            this.Click(button, new System.Drawing.Point(x, y));
        }

        public void Click(string button, int x, int y)
        {
            this.Click(button.Equals("left") ? MouseButtons.Left : MouseButtons.Right, x, y);
        }

        public void Click(string button, System.Drawing.Point point)
        {
            this.Click(button.Equals("left") ? MouseButtons.Left : MouseButtons.Right, point.X, point.Y);
        }

        public void Click(string button, OpenCvSharp.Point point)
        {
            this.Click(button.Equals("left") ? MouseButtons.Left : MouseButtons.Right, point.X, point.Y);
        }

        public void Click(int x, int y)
        {
            this.Click(MouseButtons.Left, x, y);
        }

        public void Click(System.Drawing.Point point)
        {
            this.Click(point.X, point.Y);
        }

        public void Click(OpenCvSharp.Point point)
        {
            this.Click(point.X, point.Y);
        }

        public void Click(PythonTuple point)
        {
            this.Click((int)point[0], (int)point[1]);
        }

        public void Escape()
        {
            this.KeyPress(Keys.Escape);
        }

        public void SendMessage(int message, IntPtr w, IntPtr l)
        {
            App.SendMessage(this.Hwnd, message, w, l);
        }

        public bool Start()
        {
            if(this.IsStreaming)
                return false;

            if(this.streamingThread != null)
                return false;

            this.IsStreaming = true;
            this.streamingThread = new Thread(new ThreadStart(this.StreamingThreadRoutine));
            this.streamingThread.Start();
            return true;
        }

        public void Release()
        {
            this.IsStreaming = false;
            this.streamingThread = null;
        }

        private void StreamingThreadRoutine()
        {
            while (this.IsStreaming)
            {
                try
                {
                    this.OnFrame?.Invoke(this.Frame);
                    this.Frame.Dispose();
                }
                catch (Exception)
                { }
            }
        }
    }
}