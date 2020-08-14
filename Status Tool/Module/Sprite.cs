using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Module
{
    public class Sprite : Dictionary<string, Sprite.Template>
    {
        public class Template
        {
            public string Name { get; set; }
            public byte[] Bytes { get; set; }
            public float Threshold { get; set; }
            public Nullable<Color> Color { get; set; }
            public float ErrorFactor { get; set; }

            public Template(string name, byte[] template, float threshold = 0.95f)
            {
                this.Name = name;
                this.Bytes = template;
                this.Threshold = threshold;
                this.Color = null;
            }

            public Template(string name, byte[] template, float threshold, Color color, float errorFactor = 0.2f) : this(name, template, threshold)
            {
                this.Color = color;
                this.ErrorFactor = errorFactor;
            }
        }

        public bool load(string filename)
        {
            try
            {
                using (var reader = new BinaryReader(File.Open(filename, FileMode.Open)))
                {
                    var spriteSize = reader.ReadInt32();
                    for (var i = 0; i < spriteSize; i++)
                    {
                        var name = reader.ReadString();
                        var threshold = reader.ReadSingle();
                        var templateSize = reader.ReadInt32();
                        var template = reader.ReadBytes(templateSize);
                        var usedColor = reader.ReadBoolean();
                        if (usedColor)
                            this.Add(name, new Sprite.Template(name, template, threshold, Color.FromArgb(reader.ReadInt32()), reader.ReadSingle()));
                        else
                            this.Add(name, new Sprite.Template(name, template, threshold));
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool save(string filename)
        {
            try
            {
                using (var writer = new BinaryWriter(File.Open(filename, FileMode.Create)))
                {
                    writer.Write(this.Count);                               // write script count : 4 bytes
                    foreach (var sprite in this.Values)
                    {
                        writer.Write(sprite.Name);                          // write sprite name : length + value
                        writer.Write(sprite.Threshold);                     // write threshold : 4bytes
                        writer.Write(sprite.Bytes.Length);                  // write bytes length : 4bytes
                        writer.Write(sprite.Bytes);                         // write bytes : bytes length
                        writer.Write(sprite.Color != null);
                        if (sprite.Color != null)
                        {
                            writer.Write(sprite.Color.Value.ToArgb());
                            writer.Write(sprite.ErrorFactor);
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
