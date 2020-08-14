using IronPython.Hosting;
using IronPython.Runtime;
using Microsoft.Scripting.Hosting;
using Microsoft.WindowsAPICodePack.Dialogs;
using Module;
using OpenCvSharp;
using FINDING_DIFFERENCE_PICTURE.Module;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace FINDING_DIFFERENCE_PICTURE
{
    public partial class MainForm : Form
    {
        public const int MAXIMUM_IDLE_TIME = 1000 * 30;

        private Random random = new Random();
        private Sprite _sprite;
        private Status _status;
        private ScriptRuntime pythonRuntime;
        private string _lastStatusName = string.Empty;
        private Stopwatch _stopwatch = new Stopwatch();

        public PythonDictionary Sprite { get; private set; }
        public PythonDictionary Status { get; private set; }
        public PythonDictionary Timers { get; private set; }
        public PythonDictionary State { get; private set; }

        public App app { get; private set; }
        public Detector Detector { get; private set; }

        public bool InitStopWatch { get; set; }

        public string History
        {
            set
            {
                this.historyTextBox.Invoke(new MethodInvoker(delegate ()
                {
                    this.historyTextBox.AppendText(string.Format("[{0}] {1}", DateTime.Now.ToString("HH:mm/ss"), value));
                    this.historyTextBox.AppendText(Environment.NewLine);
                }));
            }
        }

        private string StatusName
        {
            set
            {
                this.statusNameLabel.Invoke(new MethodInvoker(delegate ()
                {
                    this.statusNameLabel.Text = value;
                }));
            }
        }

        private bool running = false;
        public bool Running
        {
            get
            {
                return this.running;
            }
            set
            {
                this.running = value;
            }
        }

        public MainForm()
        {
            this.Timers = new PythonDictionary();
            this.State = new PythonDictionary();

            InitializeComponent();

            this.spriteResourceTextBox.Text = Path.Combine(Directory.GetCurrentDirectory(), "templates", "sprite.ksp");
            this.statusResourceTextBox.Text = Path.Combine(Directory.GetCurrentDirectory(), "templates", "status.kst");
        }

        private void App_OnFrame(OpenCvSharp.Mat frame)
        {
            try
            {
                this.streamingBox.Frame = frame;

                if (this.Running)
                    this.ExecPython(this.frameScript.Text, frame);

                var points = new Dictionary<string, OpenCvSharp.Point>();
                var statusName = this.Detector.Detect(frame, out points);
                if (statusName == null)
                {
                    this.StatusName = "UNKNOWN";
                    return;
                }
                this.StatusName = statusName;

                if (this._lastStatusName.Equals(statusName))
                {
                    this._stopwatch.Stop();
                    if (this._stopwatch.ElapsedMilliseconds > MAXIMUM_IDLE_TIME || this.InitStopWatch)
                    {
                        this.History = "초기화합니다.";
                        this._lastStatusName = string.Empty;
                        this._stopwatch.Reset();
                        this.InitStopWatch = false;
                    }

                    this._stopwatch.Start();
                }
                else
                {
                    this.ExecPython(this._status[statusName].Script, frame, points.ToDict(), true);
                    this._lastStatusName = statusName;
                    this._stopwatch.Reset();
                }
            }
            catch (Exception e)
            {
                return;
            }
        }

        private object ExecPython(string fname, Mat frame = null, object parameter = null, bool log = false)
        {
            try
            {
                var script = string.Format("scripts/{0}", fname);
                dynamic scope = this.pythonRuntime.UseFile(script);
                var ret = scope.callback(this, frame, this.Sprite, this.State, parameter);
                if (log)
                {
                    this.History = string.Format("{0} 스크립트를 호출했습니다.", script);
                    if (ret != null)
                        this.History = string.Format("{0}의 반환값 : {1}", script, ret);
                }

                return ret;
            }
            catch (System.IO.FileNotFoundException)
            {
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        private void streamingBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.app != null)
                    this.app.KeyPress((Keys)'W');
            }
        }

        private void randomTimer_Tick(object status)
        {
            var script = status as string;
            this.ExecPython(script);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.app != null)
                this.app.Release();

            if (this.pythonRuntime != null)
                this.pythonRuntime.Shutdown();

            this.ExecPython(this.disposeScript.Text);
        }

        private void noxPlayerFrameBox_MouseDown(object sender, MouseEventArgs e)
        {

        }

        public System.Threading.Timer SetTimer(string name, int interval, string script)
        {
            if (this.Timers.ContainsKey(name))
                return null;

            var createdTimer = new System.Threading.Timer(this.randomTimer_Tick, script, interval, System.Threading.Timeout.Infinite);
            this.Timers.Add(name, createdTimer);

            return createdTimer;
        }

        public void UnsetTimer(string name)
        {
            if (this.Timers.ContainsKey(name) == false)
                return;

            var timer = this.Timers[name] as System.Threading.Timer;
            timer.Dispose();
            this.Timers.Remove(name);
        }

        private void execute_Click(object sender, EventArgs e)
        {
            this.Running = !this.Running;
            this.execute.Text = this.Running ? "중지" : "시작";
            this.settingPanel.Enabled = !this.Running;

            if (this.Running)
            {
                try
                {
                    if (this.app != null)
                        this.app.Dispose();

                    this._lastStatusName = string.Empty;
                    this.loadPythonModules(this.pythonPath.Text);
                    this.loadResources(this.spriteResourceTextBox.Text, this.statusResourceTextBox.Text);

                    this.app = new App(this.appClassName.Text, this.softwareType.Checked ? OperationType.Software : OperationType.Hardware);
                    this.app.OnFrame += App_OnFrame;
                    this.app.Start();

                    this.ExecPython(this.initializeScript.Text);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                this.app.Release();
                this.app = null;
            }
        }

        private void loadPythonModules(string path)
        {
            if (path.Length == 0)
                throw new Exception("You must set a valid python path.");

            if (Directory.Exists(path) == false)
                throw new Exception(string.Format("{0} path does not exist.", path));

            if (File.Exists(Path.Combine(path, "python.exe")) == false)
                throw new Exception(string.Format("Cannot find python.exe file in {0}.", path));

            if (this.pythonRuntime != null)
                this.pythonRuntime.Shutdown();

            this.pythonRuntime = Python.CreateRuntime();
            var engine = this.pythonRuntime.GetEngine("IronPython");
            var paths = engine.GetSearchPaths();
            paths.Add(path);
            paths.Add(Path.Combine(path, "DLLs"));
            paths.Add(Path.Combine(path, "lib"));
            paths.Add(Path.Combine(path, "lib\\site-packages"));
            paths.Add(Path.Combine(Directory.GetCurrentDirectory(), "scripts"));
            engine.SetSearchPaths(paths);
        }

        private void loadResources(string spriteFileName, string statusFileName)
        {
            this._sprite = new Sprite();
            if (this._sprite.load(spriteFileName) == false)
                throw new Exception("스프라이트 파일을 읽어올 수 없습니다.");

            this._status = new Status(this._sprite);
            if (this._status.load(statusFileName) == false)
                throw new Exception("상태 파일을 읽어올 수 없습니다.");

            this.Sprite = this._sprite.ToDict();
            this.Status = this._status.ToDict();
            this.Detector = new Detector(this._sprite, this._status);
        }

        private void browseSpriteButton_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Path.GetDirectoryName(this.spriteResourceTextBox.Text);

            if (dialog.ShowDialog() != CommonFileDialogResult.Ok)
                return;

            this.spriteResourceTextBox.Text = dialog.FileName;
        }

        private void browsePython_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Path.GetDirectoryName(this.statusResourceTextBox.Text);

            if (dialog.ShowDialog() != CommonFileDialogResult.Ok)
                return;

            this.pythonPath.Text = dialog.FileName;
        }

        private Nullable<int> MatchNumber(Mat source)
        {
            var maximum = 0.0;
            var percentage = 0.0;
            var selected = new Nullable<int>();
            for (var num = 9; num > 0; num--)
            {
                var location = this._sprite[num.ToString()].MatchTo(source, ref percentage, null as Nullable<OpenCvSharp.Point>, null as Nullable<OpenCvSharp.Size>, true, false);
                if (location == null)
                    continue;

                if (percentage > maximum)
                {
                    selected = num;
                    maximum = percentage;
                }
            }

            return selected;
        }

        public IronPython.Runtime.List Partition(Mat frame)
        {
            var components = new Mat[3, 3, 3, 3];
            var componentsInt = new Nullable<int>[3, 3, 3, 3];
            var begin = new OpenCvSharp.Point(11, 159);
            var size = new OpenCvSharp.Size(180, 180);

            for (var row = 0; row < 3; row++)
            {
                for (var col = 0; col < 3; col++)
                {
                    var partition = frame.Clone(new Rect(new OpenCvSharp.Point(begin.X + (size.Width + 1) * col, begin.Y + (size.Height + 1) * row), size));
                    this.ExtractPartitionComponents(partition, row, col, components);
                }
            }

            var pythonList = new List();
            for (var i1 = 0; i1 < 3; i1++)
            {
                var outerRowList = new List();
                for (var i2 = 0; i2 < 3; i2++)
                {
                    var outerColumnList = new List();
                    for (var i3 = 0; i3 < 3; i3++)
                    {
                        var innerRowList = new List();
                        for (var i4 = 0; i4 < 3; i4++)
                        {
                            var innerColumnList = new List();
                            try
                            {
                                var num = this.MatchNumber(components[i1, i2, i3, i4]);
                                if (num == null)
                                    throw new Exception();

                                //Console.WriteLine("{0} {1} {2} {3} : {4}", i1, i2, i3, i4, num);
                                innerRowList.Add(num);
                            }
                            catch (Exception)
                            {
                                for (var i = 0; i < 9; i++)
                                    innerColumnList.Add(i + 1);
                                innerRowList.Add(innerColumnList);
                                //Console.WriteLine("{0} {1} {2} {3} : {4}", i1, i2, i3, i4, "unknown");
                            }
                        }
                        outerColumnList.Add(innerRowList);
                    }
                    outerRowList.Add(outerColumnList);
                }
                pythonList.Add(outerRowList);
            }
            Console.WriteLine(Environment.NewLine + Environment.NewLine + Environment.NewLine);

            return pythonList;
        }

        private void ExtractPartitionComponents(Mat frame, int sourceRow, int sourceColumn, Mat[,,,] frames)
        {
            var size = new OpenCvSharp.Size(60, 60);
            for (var row = 0; row < 3; row++)
            {
                for (var col = 0; col < 3; col++)
                {
                    var component = frame.Clone(new Rect(new OpenCvSharp.Point(size.Width * col, size.Height * row), size));
                    frames[sourceRow, sourceColumn, row, col] = component;
                }
            }
        }

        public List<Rect>[] Compare(Mat frame, OpenCvSharp.Point offset1, OpenCvSharp.Point offset2, OpenCvSharp.Size size, int threshold = 64, int count = 5)
        {
            var source1 = new Mat(frame, new Rect(offset1, size));
            var source2 = new Mat(frame, new Rect(offset2, size));

            var difference = new Mat();
            Cv2.Absdiff(source1, source2, difference);

            difference = difference.Threshold(threshold, 255, ThresholdTypes.Binary); // 이거 애매함
            difference = difference.MedianBlur(5);

            var kernel = Mat.Ones(5, 5, MatType.CV_8UC1);
            difference = difference.Dilate(kernel);
            difference = difference.CvtColor(ColorConversionCodes.BGR2GRAY);

            var percentage = Cv2.CountNonZero(difference) * 100.0f / (difference.Width * difference.Height);
            if (percentage > 10.0f)
                return null;

            var labels = new Mat();
            var stats = new Mat();
            var centroids = new Mat();
            var countLabels = difference.ConnectedComponentsWithStats(labels, stats, centroids);

            var areaList1 = new List<Rect>();
            var areaList2 = new List<Rect>();
            for (var i = 1; i < countLabels; i++)
            {
                var x = stats.Get<int>(i, 0);
                var y = stats.Get<int>(i, 1);
                var width = stats.Get<int>(i, 2);
                var height = stats.Get<int>(i, 3);
                areaList1.Add(new Rect(offset1.X + x, offset1.Y + y, width, height));
                areaList2.Add(new Rect(offset2.X + x, offset2.Y + y, width, height));
            }

            areaList1.Sort((area1, area2) => area1.Width * area1.Height > area2.Width * area2.Height ? -1 : 1);
            areaList2.Sort((area1, area2) => area1.Width * area1.Height > area2.Width * area2.Height ? -1 : 1);

            var cloned = frame.Clone();
            foreach (var area in areaList1)
                cloned.Rectangle(area, new Scalar(0, 0, 255));

            //Cv2.ImShow("before", cloned);
            //Cv2.WaitKey(0);
            //Cv2.DestroyAllWindows();
            //cloned.Dispose();

            var deletedList = new List<Rect>();
            var basedLength = 250;
            for (var i1 = 0; i1 < areaList1.Count; i1++)
            {
                if (deletedList.Contains(areaList1[i1]))
                    continue;

                for (var i2 = i1 + 1; i2 < areaList1.Count; i2++)
                {
                    var scaleLength = Math.Min(50, (int)(10 + 250 / ((Math.Max(areaList1[i1].Width, areaList1[i1].Height) + Math.Max(areaList1[i2].Width, areaList1[i2].Height)) / 2.0f)));
                    var scaledArea = new Rect(areaList1[i1].X - scaleLength, areaList1[i1].Y - scaleLength, areaList1[i1].Width + scaleLength * 2, areaList1[i1].Height + scaleLength * 2);
                    var overlapped = scaledArea & areaList1[i2];
                    if (overlapped.Width != 0 && overlapped.Height != 0)
                        deletedList.Add(areaList1[i2]);
                }
            }

            foreach (var deleted in deletedList)
                areaList1.Remove(deleted);

            cloned = frame.Clone();
            foreach (var area in areaList1)
                cloned.Rectangle(area, new Scalar(0, 0, 255));

            //Cv2.ImShow("after", cloned);
            //Cv2.WaitKey(0);
            //Cv2.DestroyAllWindows();
            //cloned.Dispose();


            if (areaList1.Count != count)
            {
                if (threshold < 0)
                    return null;

                return Compare(frame, offset1, offset2, size, threshold - 1, count);
            }

            deletedList.Clear();
            for (var i1 = 0; i1 < areaList2.Count; i1++)
            {
                if (deletedList.Contains(areaList2[i1]))
                    continue;

                for (var i2 = i1 + 1; i2 < areaList2.Count; i2++)
                {
                    var scaleLength = Math.Min(50, (int)(10 + 250 / ((Math.Max(areaList2[i1].Width, areaList2[i1].Height) + Math.Max(areaList2[i2].Width, areaList2[i2].Height)) / 2.0f)));
                    var scaledArea = new Rect(areaList2[i1].X - scaleLength, areaList2[i1].Y - scaleLength, areaList2[i1].Width + scaleLength * 2, areaList2[i1].Height + scaleLength * 2);
                    var overlapped = scaledArea & areaList2[i2];
                    if (overlapped.Width != 0 && overlapped.Height != 0)
                        deletedList.Add(areaList2[i2]);
                }
            }

            foreach (var deleted in deletedList)
                areaList2.Remove(deleted);

            return new List<Rect>[] { areaList1, areaList2 };
        }

        public IronPython.Runtime.List Compare(Mat frame, PythonTuple offset1, PythonTuple offset2, PythonTuple size, int threshold = 64, int count = 5)
        {
            try
            {
                var areaLists = this.Compare(frame, new OpenCvSharp.Point((int)offset1[0], (int)offset1[1]), new OpenCvSharp.Point((int)offset2[0], (int)offset2[1]), new OpenCvSharp.Size((int)size[0], (int)size[1]), threshold, count);
                if (areaLists == null)
                    throw new Exception();

                var pythonAreaLists = new IronPython.Runtime.List();
                foreach (var areaList in areaLists)
                {
                    var pythonAreaList = new IronPython.Runtime.List();
                    foreach (var area in areaList)
                    {
                        var pythonArea = new PythonTuple(new object[] { area.X, area.Y, area.Width, area.Height });
                        pythonAreaList.Add(pythonArea);
                    }
                    pythonAreaLists.Add(pythonAreaList);
                }

                return pythonAreaLists;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool DrawRectangles(List<Rect> areas, uint color = 0xffff0000)
        {
            var frame = this.streamingBox.Frame;
            if (frame == null)
                return false;

            frame = frame.Clone();
            foreach (var area in areas)
            {
                var r = (color & 0x00ff0000) >> 4;
                var g = (color & 0x0000ff00) >> 2;
                var b = (color & 0x000000ff);
                frame.Rectangle(area, new Scalar(b, g, r));
            }
            this.streamingBox.Frame = frame;
            frame.Dispose();
            return true;
        }

        public bool DrawRectangles(IronPython.Runtime.List areas, uint color = 0xffff0000)
        {
            try
            {
                var csAreaList = new List<Rect>();
                foreach (var area in areas)
                {
                    var pythonArea = area as PythonTuple;
                    csAreaList.Add(new Rect((int)pythonArea[0], (int)pythonArea[1], (int)pythonArea[2], (int)pythonArea[3]));
                }

                return this.DrawRectangles(csAreaList, color);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Sleep(int m)
        {
            Thread.Sleep(m);
        }
    }
}