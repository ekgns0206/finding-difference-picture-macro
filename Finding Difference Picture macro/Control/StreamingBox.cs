using OpenCvSharp;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FINDING_DIFFERENCE_PICTURE.Control
{
    public class StreamingBox : Panel
    {
        private Mat frame;
        public Mat Frame
        {
            get
            {
                return this.frame;
            }
            set
            {
                if(value == null)
                    return;

                this.frame = value.Clone();
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.Invalidate();
                }));
            }
        }

        public StreamingBox()
        {
            this.DoubleBuffered = true;
            this.Paint += StreamingBox_Paint;
        }

        private void StreamingBox_Paint(object sender, PaintEventArgs e)
        {
            if (this.Frame == null)
                return;

            var newSize = new OpenCvSharp.Size(this.frame.Width, this.frame.Height);
            var newFrame = this.Frame.Resize(newSize);
            var bitmap = Image.FromStream(new MemoryStream(newFrame.ToBytes()));
            e.Graphics.DrawImage(bitmap, this.ClientRectangle);
        }
    }
}