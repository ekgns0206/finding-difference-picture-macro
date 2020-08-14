using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using Module;

namespace Tools
{
    public partial class AddSpriteDialog : Form
    {
        private MainForm _owner;

        public Sprite.Template Template { get; private set; }

        private AddSpriteDialog(MainForm owner, byte[] templateBytes)
        {
            InitializeComponent();
            this._owner = owner;

            using (var stream = new MemoryStream(templateBytes))
            {
                this._previewTemplateBox.Image = System.Drawing.Image.FromStream(stream);
            }
        }


        public AddSpriteDialog(MainForm owner, string filename) : this(owner, File.ReadAllBytes(filename))
        {
            //this._spriteThresholdLabel.Text = (this._spriteThresholdTrackBar.Value / 100.0f).ToString("0.00") + "%";
            this.thresholdTextBox.Text = (this._spriteThresholdTrackBar.Value / 100.0f).ToString("0.00");

            this.Template = new Sprite.Template(this._spriteNameTextBox.Text, File.ReadAllBytes(filename), this._spriteThresholdTrackBar.Value / 10000.0f);
        }

        public AddSpriteDialog(MainForm owner, Sprite.Template sprite) : this(owner, sprite.Bytes)
        {
            this._spriteNameTextBox.Text = sprite.Name;
            this._spriteThresholdTrackBar.Value = (int)(sprite.Threshold * 10000);

            //this._spriteThresholdLabel.Text = (this._spriteThresholdTrackBar.Value / 100.0f).ToString("0.00") + "%";
            this.thresholdTextBox.Text = (this._spriteThresholdTrackBar.Value / 100.0f).ToString("0.00");
            this.Template = sprite;

            if (sprite.Color != null)
            {
                this.color.Text = ColorTranslator.ToHtml(sprite.Color.Value);
                this.errorFactor.Text = sprite.ErrorFactor.ToString();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._spriteNameTextBox.Text.Length == 0)
                    throw new Exception("스프라이트 이름을 입력하세요.");

                if (this._spriteThresholdTrackBar.Value == 0)
                    throw new Exception("임계치는 0이 될 수 없습니다.");

                foreach (var item in this._owner.Status.Keys)
                {
                    if (item.Equals(this._spriteNameTextBox.Text))
                        throw new Exception("해당 스프라이트 이름은 이미 존재합니다.");
                }

                this.Template.Name = this._spriteNameTextBox.Text;
                this.Template.Threshold = this._spriteThresholdTrackBar.Value / 10000.0f;
                if (this.color.Text == string.Empty)
                {
                    this.Template.Color = null;
                    this.Template.ErrorFactor = 0.0f;
                }
                else
                {
                    this.Template.Color = ColorTranslator.FromHtml(this.color.Text);
                    this.Template.ErrorFactor = float.Parse(this.errorFactor.Text);
                }


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException exc)
            {
                MessageBox.Show("정확한 수치를 입력해야 합니다.");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void _spriteNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.Template == null)
                return;

            this.Template.Name = this._spriteNameTextBox.Text;
        }

        private void _spriteThresholdTrackBar_Scroll(object sender, EventArgs e)
        {
            if (this.Template == null)
                return;

            this.Template.Threshold = this._spriteThresholdTrackBar.Value / 10000.0f;
            //this._spriteThresholdLabel.Text = string.Format("{0}%", (this._spriteThresholdTrackBar.Value / 100.0f).ToString("0.00"));
            this.thresholdTextBox.Text = (this._spriteThresholdTrackBar.Value / 100.0f).ToString("0.00");
        }

        private void _spriteRequirementCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Template == null)
                return;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void color_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            this.color.Text = ColorTranslator.ToHtml(dialog.Color);
        }

        private void color_TextChanged(object sender, EventArgs e)
        {
            this.errorFactor.ReadOnly = (this.color.Text.Length == 0);
        }

        private void thresholdTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var percentage = float.Parse(this.thresholdTextBox.Text);
                this._spriteThresholdTrackBar.Value = (int)(percentage * 100);
            }
            catch (Exception)
            { }
        }
    }
}