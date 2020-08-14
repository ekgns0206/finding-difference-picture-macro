using Module;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Tools
{
    public partial class IdleSpriteDialog : Form
    {
        private MainForm _owner;

        private List<Status.Element.Component> _selectedSprites = new List<Status.Element.Component>();
        public Status.Element.Component[] Components
        {
            get
            {
                return this._selectedSprites.ToArray();
            }
        }

        public IdleSpriteDialog(MainForm owner, Status.Element status)
        {
            InitializeComponent();

            this._owner = owner;
            foreach(var sprite in this._owner.Sprite.Values)
            {
                if(status.Contains(sprite))
                    continue;

                var item = this._idleSpriteListView.Items.Add(sprite.Name);
                item.Tag = sprite;
            }
        }

        private void _addSpriteButton_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in this._idleSpriteListView.SelectedItems)
            {
                var template = item.Tag as Sprite.Template;
                this._selectedSprites.Add(new Status.Element.Component(template, this.requirementCheckBox.Checked));
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void _idleSpriteListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = this._idleSpriteListView.SelectedItems[0];
                var sprite = selectedItem.Tag as Sprite.Template;

                this._bindedTemplateBox.Image = System.Drawing.Image.FromStream(new MemoryStream(sprite.Bytes));
            }
            catch(Exception)
            { }
        }

        private void _bindedTemplateBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this._bindedTemplateBox.SizeMode == PictureBoxSizeMode.CenterImage)
            {
                this._bindedTemplateBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                this._bindedTemplateBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }
    }
}
