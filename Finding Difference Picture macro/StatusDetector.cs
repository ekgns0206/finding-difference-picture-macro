//using Module;
//using OpenCvSharp;
//using System;
//using System.Collections.Generic;
//using System.IO;

//namespace SUDOKU_macro
//{
//    public class StatusDetector
//    {
//        private Dictionary<string, Sprite> _spriteTable;

//        private Dictionary<string, Status> _statusTable;

//        private Mat _sourceFrame;
//        public Mat SourceFrame
//        {
//            get
//            {
//                return this._sourceFrame;
//            }
//        }

//        private Mat _destFrame;
//        public Mat DestFrame
//        {
//            get
//            {
//                return this._destFrame;
//            }
//        }

//        private Status _detectedStatus;
//        public Status DetectedStatus
//        {
//            get
//            {
//                return this._detectedStatus;
//            }
//        }

//        private DetectedInfo[] _detectedSprites;

//        public StatusDetector()
//        {
//            this._spriteTable = new Dictionary<string, Sprite>();
//            this._statusTable = new Dictionary<string, Status>();

//            this.LoadStatusFile("templates/template.krc");
//        }

//        public bool UpdateFrame(Mat frame)
//        {
//            this._sourceFrame = frame.Clone();
//            this._destFrame = frame.Clone();

//            this._detectedStatus = this.findStatus(out this._detectedSprites);
//            if (this._detectedStatus == null)
//                return false;

//            foreach (var detectedSprite in this._detectedSprites)
//            {
//                Cv2.Rectangle(this._destFrame, detectedSprite.Area, Scalar.LimeGreen, 2);

//                var baseLine = 0;
//                var text = string.Format("{0}({1}%)", detectedSprite.Sprite.Name, (int)(detectedSprite.Threshold * 100));
//                var font = HersheyFonts.HersheyPlain;
//                var textSize = Cv2.GetTextSize(text, font, 1.0, 1, out baseLine);
//                var padding = new Size(3, 3);
//                textSize.Width += (padding.Width * 2);
//                textSize.Height += (padding.Height * 2);

//                var nameLabelPosition = new Point(detectedSprite.Area.X, detectedSprite.Area.Y - textSize.Height);
//                Cv2.Rectangle(this._destFrame, new Rect(nameLabelPosition, textSize), Scalar.LimeGreen, -1,LineTypes.Filled);

//                nameLabelPosition.X += padding.Width;
//                nameLabelPosition.Y += (textSize.Height - padding.Height);
//                Cv2.PutText(this._destFrame, text, nameLabelPosition, font, 1.0, Scalar.White);
//            }

//            return true;
//        }

//        private DetectedInfo[] findSprites(Sprite sprite)
//        {
//            var detectedSprites = new List<DetectedInfo>();

//            var sourceGray = this._sourceFrame.CvtColor(ColorConversionCodes.BGR2GRAY);
//            var templateGray = sprite.Template.CvtColor(ColorConversionCodes.BGR2GRAY);
//            var result = new Mat(sourceGray.Rows - templateGray.Rows + 1, sourceGray.Cols - templateGray.Cols + 1, MatType.CV_32FC1);

//            Cv2.MatchTemplate(sourceGray, templateGray, result, TemplateMatchModes.CCoeffNormed);
//            Cv2.Threshold(result, result, sprite.Threshold, 1.0, ThresholdTypes.Tozero);

//            while (true)
//            {
//                double minval, maxval;
//                Point minloc, maxloc;
//                Cv2.MinMaxLoc(result, out minval, out maxval, out minloc, out maxloc);
//                if (maxval < sprite.Threshold)
//                    break;

//                var detectedRect = new Rect(new Point(maxloc.X, maxloc.Y), new Size(templateGray.Width, templateGray.Height));
//                detectedSprites.Add(new DetectedInfo(sprite, detectedRect, maxval));

//                var outRect = new Rect();
//                Cv2.FloodFill(result, maxloc, new Scalar(0), out outRect, new Scalar(0.1), new Scalar(1.0));
//            }

//            return detectedSprites.ToArray();
//        }

//        public DetectedInfo[] findSprites(string name)
//        {
//            try
//            {
//                if (this._detectedStatus == null)
//                    return null;

//                foreach (var sprite in this._detectedStatus.Sprites)
//                {
//                    var detectedInfo = this.findSprites(sprite);
//                    if (detectedInfo == null)
//                        continue;

//                    return detectedInfo;
//                }

//                return null;
//            }
//            catch (Exception e)
//            {
//                return null;
//            }
//        }

//        private DetectedInfo[] isMatchStatus(Status status)
//        {
//            var ret = new List<DetectedInfo>();
//            foreach (var sprite in status.Sprites)
//            {
//                var detectedRects = this.findSprites(sprite);
//                if (detectedRects.Length == 0 && sprite.Requirement)
//                    return null;

//                ret.AddRange(detectedRects);
//            }

//            return ret.ToArray();
//        }

//        private Status findStatus(out DetectedInfo[] detectedSprites)
//        {
//            foreach (var pair in this._statusTable)
//            {
//                detectedSprites = this.isMatchStatus(pair.Value);
//                if (detectedSprites == null)
//                    continue;

//                return pair.Value;
//            }

//            detectedSprites = null;
//            return null;
//        }

//        public bool LoadStatusFile(string filename)
//        {
//            using (var reader = new BinaryReader(File.Open(filename, FileMode.Open)))
//            {
//                this._spriteTable.Clear();
//                var spriteSize = reader.ReadInt32();
//                for (var i = 0; i < spriteSize; i++)
//                {
//                    var name = reader.ReadString();
//                    var threshold = reader.ReadSingle();
//                    var requirement = reader.ReadBoolean();
//                    var templateSize = reader.ReadInt32();
//                    var template = Cv2.ImDecode(reader.ReadBytes(templateSize), ImreadModes.AnyColor);

//                    this._spriteTable.Add(name, new Sprite(name, template, requirement, threshold));
//                }

//                this._statusTable.Clear();
//                var statusSize = reader.ReadInt32();
//                for (var i = 0; i < statusSize; i++)
//                {
//                    var name = reader.ReadString();
//                    var script = reader.ReadString();
//                    var status = new Status(name, script);

//                    var containsSpriteSize = reader.ReadInt32();
//                    for (var i2 = 0; i2 < containsSpriteSize; i2++)
//                    {
//                        var sprite = this._spriteTable[reader.ReadString()];
//                        status.Sprites.Add(sprite);
//                    }
//                    this._statusTable.Add(name, status);
//                }
//            }

//            return true;
//        }

//        public Point FindOffset(string name)
//        {
//            foreach (var detectedSprite in this._detectedSprites)
//            {
//                if (detectedSprite.Sprite.Name.Equals(name))
//                    return new Point(detectedSprite.Area.X + detectedSprite.Area.Width / 2.0,
//                                     detectedSprite.Area.Y + detectedSprite.Area.Height / 2.0);
//            }

//            throw new Exception("Could not find offset");
//        }
//    }
//}