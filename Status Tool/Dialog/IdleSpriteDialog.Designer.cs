namespace Tools
{
    partial class IdleSpriteDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._idleSpriteListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._bindedTemplateBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.requirementCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._addSpriteButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bindedTemplateBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._idleSpriteListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._bindedTemplateBox);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(636, 443);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 0;
            // 
            // _idleSpriteListView
            // 
            this._idleSpriteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this._idleSpriteListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._idleSpriteListView.FullRowSelect = true;
            this._idleSpriteListView.Location = new System.Drawing.Point(0, 0);
            this._idleSpriteListView.Name = "_idleSpriteListView";
            this._idleSpriteListView.Size = new System.Drawing.Size(260, 443);
            this._idleSpriteListView.TabIndex = 0;
            this._idleSpriteListView.UseCompatibleStateImageBehavior = false;
            this._idleSpriteListView.View = System.Windows.Forms.View.Details;
            this._idleSpriteListView.SelectedIndexChanged += new System.EventHandler(this._idleSpriteListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // _bindedTemplateBox
            // 
            this._bindedTemplateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bindedTemplateBox.Location = new System.Drawing.Point(0, 0);
            this._bindedTemplateBox.Name = "_bindedTemplateBox";
            this._bindedTemplateBox.Size = new System.Drawing.Size(372, 376);
            this._bindedTemplateBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._bindedTemplateBox.TabIndex = 5;
            this._bindedTemplateBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.requirementCheckBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 26);
            this.panel2.TabIndex = 4;
            // 
            // requirementCheckBox
            // 
            this.requirementCheckBox.AutoSize = true;
            this.requirementCheckBox.Checked = true;
            this.requirementCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.requirementCheckBox.Location = new System.Drawing.Point(4, 7);
            this.requirementCheckBox.Name = "requirementCheckBox";
            this.requirementCheckBox.Size = new System.Drawing.Size(95, 16);
            this.requirementCheckBox.TabIndex = 0;
            this.requirementCheckBox.Text = "Requirement";
            this.requirementCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._addSpriteButton);
            this.panel1.Controls.Add(this._cancelButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 402);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(372, 41);
            this.panel1.TabIndex = 0;
            // 
            // _addSpriteButton
            // 
            this._addSpriteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._addSpriteButton.Location = new System.Drawing.Point(217, 5);
            this._addSpriteButton.Name = "_addSpriteButton";
            this._addSpriteButton.Size = new System.Drawing.Size(75, 31);
            this._addSpriteButton.TabIndex = 0;
            this._addSpriteButton.Text = "Add";
            this._addSpriteButton.UseVisualStyleBackColor = true;
            this._addSpriteButton.Click += new System.EventHandler(this._addSpriteButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._cancelButton.Location = new System.Drawing.Point(292, 5);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(75, 31);
            this._cancelButton.TabIndex = 1;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // IdleSpriteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 443);
            this.Controls.Add(this.splitContainer1);
            this.Name = "IdleSpriteDialog";
            this.Text = "IdleSpriteDialog";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._bindedTemplateBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _addSpriteButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.ListView _idleSpriteListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox _bindedTemplateBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox requirementCheckBox;
    }
}