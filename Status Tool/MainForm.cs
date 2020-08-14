using Module;
using System;
using System.IO;
using System.Windows.Forms;

namespace Tools
{
    public partial class MainForm : Form
    {
        private string _spriteFileName;
        private string _statusFileName;

        public Sprite Sprite { get; private set; }
        public Status Status { get; private set; }

        public MainForm()
        {
            this.Sprite = new Sprite();
            this.Status = new Status(this.Sprite);

            InitializeComponent();

            this._statusListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this._spriteListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this._bindedSpriteListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void clear()
        {
            this.Sprite.Clear();
            this.Status.Clear();

            this._spriteListView.Items.Clear();
            this._statusListView.Items.Clear();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.clear();
            this._spriteFileName = null;
            this._statusFileName = null;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Browse resource files";
            dialog.DefaultExt = "ksp";
            dialog.Filter = "resource file (*.ksp)|*.ksp";
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            this._spriteFileName = dialog.FileName;
            this.Sprite = new Sprite();
            this.Sprite.load(dialog.FileName);


            dialog.DefaultExt = "kst";
            dialog.FileName = string.Empty;
            dialog.Filter = "resource file (*.kst)|*.kst";
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            this._statusFileName = dialog.FileName;
            this.Status = new Status(this.Sprite);
            this.Status.load(dialog.FileName);

            foreach (var sprite in this.Sprite.Values)
            {
                var item = this._spriteListView.Items.Add(sprite.Name);
                item.SubItems.Add(sprite.Threshold.ToString("0.00"));
                item.SubItems.Add(sprite.Bytes.Length.ToString());
                item.Tag = sprite;
            }

            foreach (var status in this.Status.Values)
            {
                var item = this._statusListView.Items.Add(status.Name);
                item.SubItems.Add(status.Script);
                item.Tag = status;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._spriteFileName == null)
            {
                var dialog = new SaveFileDialog();
                dialog.DefaultExt = "ksp";
                dialog.Filter = "KPU sprite file (*.ksp)|*.ksp";
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                this._spriteFileName = dialog.FileName;
            }
            this.Sprite.save(this._spriteFileName);


            if (this._statusFileName == null)
            {
                var dialog = new SaveFileDialog();
                dialog.FileName = string.Empty;
                dialog.DefaultExt = "kst";
                dialog.Filter = "KPU status file (*.kst)|*.kst";
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;
                this._statusFileName = dialog.FileName;
            }

            this.Status.save(this._statusFileName);
        }

        private void addSpriteButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Browse sprite files";
            dialog.DefaultExt = "png";
            dialog.Filter = "image file (*.png, *.jpg, *.jpeg)|*.png;*.jpg;*.jpeg";
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            var spriteDialog = new AddSpriteDialog(this, dialog.FileName);
            if (spriteDialog.ShowDialog() != DialogResult.OK)
                return;

            var createdSprite = spriteDialog.Template;
            this.Sprite.Add(createdSprite.Name, createdSprite);

            var item = this._spriteListView.Items.Add(createdSprite.Name);
            item.SubItems.Add(createdSprite.Threshold.ToString("0.00"));
            item.SubItems.Add(createdSprite.Bytes.Length.ToString());
            item.Tag = createdSprite;
        }

        private void modifySpriteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = this._spriteListView.SelectedItems[0];
                var sprite = selectedItem.Tag as Sprite.Template;

                var spriteDialog = new AddSpriteDialog(this, sprite);
                if (spriteDialog.ShowDialog() != DialogResult.OK)
                    return;

                selectedItem.Text = sprite.Name;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void _addStatusButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._statusNameTextBox.Text.Length == 0)
                    throw new Exception("Status의 이름을 입력하세요.");

                if (this._scriptPathTextBox.Text.Length == 0)
                    throw new Exception("스크립트 경로를 입력하세요.");

                if (this.Status.ContainsKey(this._statusNameTextBox.Text))
                    throw new Exception("이미 존재하는 Status입니다.");

                var status = new Status.Element(this._statusNameTextBox.Text, this._scriptPathTextBox.Text);
                var item = this._statusListView.Items.Add(status.Name);
                item.SubItems.Add(status.Script);
                item.Tag = status;
                this.Status.Add(this._statusNameTextBox.Text, status);
            }
            catch (Exception exc)
            {
                MessageBox.Show(this, exc.Message);
            }
        }

        private void _spriteListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = this._spriteListView.SelectedItems[0];
                var sprite = selectedItem.Tag as Sprite.Template;
                this._templateBox.Image = System.Drawing.Image.FromStream(new MemoryStream(sprite.Bytes));
            }
            catch (Exception)
            { }
        }

        private void _statusListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = this._statusListView.SelectedItems[0];
                var status = selectedItem.Tag as Status.Element;
                this._statusNameTextBox.Text = status.Name;
                this._scriptPathTextBox.Text = status.Script;

                this._bindedSpriteListView.Items.Clear();
                foreach (var component in status.Components)
                    this._bindedSpriteListView.Items.Add(component.template.Name).Tag = component;
            }
            catch (Exception)
            {

            }
        }

        private void _removeStatusButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem selectedStatusItem in this._statusListView.SelectedItems)
                {
                    var status = selectedStatusItem.Tag as Status.Element;
                    this.Status.Remove(status.Name);
                    selectedStatusItem.Remove();
                }
            }
            catch (Exception)
            { }
        }

        private void _modifyStatusButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = this._statusListView.SelectedItems[0];
                var status = selectedItem.Tag as Status.Element;

                if (this._statusNameTextBox.Text.Length == 0)
                    throw new Exception("Status의 이름을 입력하세요.");

                if (this._scriptPathTextBox.Text.Length == 0)
                    throw new Exception("스크립트 경로를 입력하세요.");

                this.Status.Remove(status.Name);

                status.Name = this._statusNameTextBox.Text;
                status.Script = this._scriptPathTextBox.Text;
                this.Status.Add(status.Name, status);

                selectedItem.Text = status.Name;
            }
            catch (Exception)
            { }
        }

        private void _removeSpriteButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem selectedItem in this._spriteListView.SelectedItems)
                {
                    var sprite = selectedItem.Tag as Sprite.Template;
                    this.Sprite.Remove(sprite.Name);
                    selectedItem.Remove();
                }
            }
            catch (Exception)
            { }
        }

        private void templatePictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var pictureBox = sender as PictureBox;
            if (pictureBox.SizeMode == PictureBoxSizeMode.CenterImage)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void _browseScriptButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Browse python script files";
            dialog.DefaultExt = "krc";
            dialog.Filter = "Python script file (*.py)|*.py";
            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            this._scriptPathTextBox.Text = dialog.FileName;
        }

        private void _browseIdleSprites_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = this._statusListView.SelectedItems[0];
                var status = selectedItem.Tag as Status.Element;

                var dialog = new IdleSpriteDialog(this, status);
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                status.Components.AddRange(dialog.Components);

                this._bindedSpriteListView.Items.Clear();
                foreach (var component in status.Components)
                {
                    var item = this._bindedSpriteListView.Items.Add(component.template.Name);
                    item.SubItems.Add(component.requirement.ToString());
                    item.Tag = component;
                }
                    
            }
            catch (Exception)
            { }
        }

        private void _bindedSpriteListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = this._bindedSpriteListView.SelectedItems[0];
                var sprite = selectedItem.Tag as Sprite.Template;

                this._bindedSpriteBox.Image = System.Drawing.Image.FromStream(new MemoryStream(sprite.Bytes));
            }
            catch (Exception)
            { }
        }
    }
}