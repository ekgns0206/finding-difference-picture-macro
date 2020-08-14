namespace Tools
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._templateBox = new System.Windows.Forms.PictureBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this._spriteListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel12 = new System.Windows.Forms.Panel();
            this.addSpriteButton = new System.Windows.Forms.Button();
            this._removeSpriteButton = new System.Windows.Forms.Button();
            this._modifySpriteButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this._bindedSpriteListView = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._statusListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel10 = new System.Windows.Forms.Panel();
            this._addStatusButton = new System.Windows.Forms.Button();
            this._removeStatusButton = new System.Windows.Forms.Button();
            this._modifyStatusButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this._scriptPathTextBox = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this._browseScriptButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this._statusNameTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._bindedSpriteBox = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this._browseIdleSprites = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._templateBox)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bindedSpriteBox)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.helloToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 551);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sprite";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._templateBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel13);
            this.splitContainer1.Panel2.Controls.Add(this.panel12);
            this.splitContainer1.Size = new System.Drawing.Size(710, 519);
            this.splitContainer1.SplitterDistance = 429;
            this.splitContainer1.TabIndex = 0;
            // 
            // _templateBox
            // 
            this._templateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._templateBox.Location = new System.Drawing.Point(0, 0);
            this._templateBox.Name = "_templateBox";
            this._templateBox.Size = new System.Drawing.Size(429, 519);
            this._templateBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._templateBox.TabIndex = 0;
            this._templateBox.TabStop = false;
            this._templateBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.templatePictureBox_MouseDoubleClick);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this._spriteListView);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 37);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(277, 482);
            this.panel13.TabIndex = 4;
            // 
            // _spriteListView
            // 
            this._spriteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this._spriteListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._spriteListView.FullRowSelect = true;
            this._spriteListView.Location = new System.Drawing.Point(0, 0);
            this._spriteListView.Name = "_spriteListView";
            this._spriteListView.Size = new System.Drawing.Size(277, 482);
            this._spriteListView.TabIndex = 0;
            this._spriteListView.UseCompatibleStateImageBehavior = false;
            this._spriteListView.View = System.Windows.Forms.View.Details;
            this._spriteListView.SelectedIndexChanged += new System.EventHandler(this._spriteListView_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Threshold";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Template Size";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.addSpriteButton);
            this.panel12.Controls.Add(this._removeSpriteButton);
            this.panel12.Controls.Add(this._modifySpriteButton);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(277, 37);
            this.panel12.TabIndex = 3;
            // 
            // addSpriteButton
            // 
            this.addSpriteButton.Location = new System.Drawing.Point(3, 3);
            this.addSpriteButton.Name = "addSpriteButton";
            this.addSpriteButton.Size = new System.Drawing.Size(75, 23);
            this.addSpriteButton.TabIndex = 0;
            this.addSpriteButton.Text = "Add";
            this.addSpriteButton.UseVisualStyleBackColor = true;
            this.addSpriteButton.Click += new System.EventHandler(this.addSpriteButton_Click);
            // 
            // _removeSpriteButton
            // 
            this._removeSpriteButton.Location = new System.Drawing.Point(84, 3);
            this._removeSpriteButton.Name = "_removeSpriteButton";
            this._removeSpriteButton.Size = new System.Drawing.Size(75, 23);
            this._removeSpriteButton.TabIndex = 1;
            this._removeSpriteButton.Text = "Remove";
            this._removeSpriteButton.UseVisualStyleBackColor = true;
            this._removeSpriteButton.Click += new System.EventHandler(this._removeSpriteButton_Click);
            // 
            // _modifySpriteButton
            // 
            this._modifySpriteButton.Location = new System.Drawing.Point(165, 3);
            this._modifySpriteButton.Name = "_modifySpriteButton";
            this._modifySpriteButton.Size = new System.Drawing.Size(75, 23);
            this._modifySpriteButton.TabIndex = 2;
            this._modifySpriteButton.Text = "Modify";
            this._modifySpriteButton.UseVisualStyleBackColor = true;
            this._modifySpriteButton.Click += new System.EventHandler(this.modifySpriteButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(716, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(710, 519);
            this.panel2.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this._bindedSpriteListView);
            this.splitContainer2.Panel1.Controls.Add(this._statusListView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(710, 519);
            this.splitContainer2.SplitterDistance = 236;
            this.splitContainer2.TabIndex = 0;
            // 
            // _bindedSpriteListView
            // 
            this._bindedSpriteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader5});
            this._bindedSpriteListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bindedSpriteListView.FullRowSelect = true;
            this._bindedSpriteListView.Location = new System.Drawing.Point(0, 255);
            this._bindedSpriteListView.Name = "_bindedSpriteListView";
            this._bindedSpriteListView.Size = new System.Drawing.Size(236, 264);
            this._bindedSpriteListView.TabIndex = 1;
            this._bindedSpriteListView.UseCompatibleStateImageBehavior = false;
            this._bindedSpriteListView.View = System.Windows.Forms.View.Details;
            this._bindedSpriteListView.SelectedIndexChanged += new System.EventHandler(this._bindedSpriteListView_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Sprite Name";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Requirement";
            // 
            // _statusListView
            // 
            this._statusListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this._statusListView.Dock = System.Windows.Forms.DockStyle.Top;
            this._statusListView.FullRowSelect = true;
            this._statusListView.Location = new System.Drawing.Point(0, 0);
            this._statusListView.Name = "_statusListView";
            this._statusListView.Size = new System.Drawing.Size(236, 255);
            this._statusListView.TabIndex = 0;
            this._statusListView.UseCompatibleStateImageBehavior = false;
            this._statusListView.View = System.Windows.Forms.View.Details;
            this._statusListView.SelectedIndexChanged += new System.EventHandler(this._statusListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Script";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel10);
            this.splitContainer3.Panel1.Controls.Add(this.panel5);
            this.splitContainer3.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this._bindedSpriteBox);
            this.splitContainer3.Panel2.Controls.Add(this.panel11);
            this.splitContainer3.Size = new System.Drawing.Size(470, 519);
            this.splitContainer3.SplitterDistance = 85;
            this.splitContainer3.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this._addStatusButton);
            this.panel10.Controls.Add(this._removeStatusButton);
            this.panel10.Controls.Add(this._modifyStatusButton);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 52);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.panel10.Size = new System.Drawing.Size(470, 34);
            this.panel10.TabIndex = 0;
            // 
            // _addStatusButton
            // 
            this._addStatusButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._addStatusButton.Location = new System.Drawing.Point(176, 10);
            this._addStatusButton.Name = "_addStatusButton";
            this._addStatusButton.Size = new System.Drawing.Size(98, 21);
            this._addStatusButton.TabIndex = 0;
            this._addStatusButton.Text = "Add";
            this._addStatusButton.UseVisualStyleBackColor = true;
            this._addStatusButton.Click += new System.EventHandler(this._addStatusButton_Click);
            // 
            // _removeStatusButton
            // 
            this._removeStatusButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._removeStatusButton.Location = new System.Drawing.Point(274, 10);
            this._removeStatusButton.Name = "_removeStatusButton";
            this._removeStatusButton.Size = new System.Drawing.Size(98, 21);
            this._removeStatusButton.TabIndex = 1;
            this._removeStatusButton.Text = "Remove";
            this._removeStatusButton.UseVisualStyleBackColor = true;
            this._removeStatusButton.Click += new System.EventHandler(this._removeStatusButton_Click);
            // 
            // _modifyStatusButton
            // 
            this._modifyStatusButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._modifyStatusButton.Location = new System.Drawing.Point(372, 10);
            this._modifyStatusButton.Name = "_modifyStatusButton";
            this._modifyStatusButton.Size = new System.Drawing.Size(98, 21);
            this._modifyStatusButton.TabIndex = 2;
            this._modifyStatusButton.Text = "Modify";
            this._modifyStatusButton.UseVisualStyleBackColor = true;
            this._modifyStatusButton.Click += new System.EventHandler(this._modifyStatusButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(470, 25);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(112, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(358, 25);
            this.panel6.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this._scriptPathTextBox);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.panel9.Size = new System.Drawing.Size(260, 25);
            this.panel9.TabIndex = 2;
            // 
            // _scriptPathTextBox
            // 
            this._scriptPathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._scriptPathTextBox.Location = new System.Drawing.Point(0, 2);
            this._scriptPathTextBox.Name = "_scriptPathTextBox";
            this._scriptPathTextBox.Size = new System.Drawing.Size(260, 21);
            this._scriptPathTextBox.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this._browseScriptButton);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(260, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.panel8.Size = new System.Drawing.Size(98, 25);
            this.panel8.TabIndex = 1;
            // 
            // _browseScriptButton
            // 
            this._browseScriptButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._browseScriptButton.Location = new System.Drawing.Point(0, 1);
            this._browseScriptButton.Name = "_browseScriptButton";
            this._browseScriptButton.Size = new System.Drawing.Size(98, 23);
            this._browseScriptButton.TabIndex = 0;
            this._browseScriptButton.Text = "Browse";
            this._browseScriptButton.UseVisualStyleBackColor = true;
            this._browseScriptButton.Click += new System.EventHandler(this._browseScriptButton_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(112, 25);
            this.panel7.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Script Path";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 27);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this._statusNameTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(112, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 27);
            this.panel4.TabIndex = 2;
            // 
            // _statusNameTextBox
            // 
            this._statusNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._statusNameTextBox.Location = new System.Drawing.Point(0, 0);
            this._statusNameTextBox.Name = "_statusNameTextBox";
            this._statusNameTextBox.Size = new System.Drawing.Size(358, 21);
            this._statusNameTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 27);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status Name";
            // 
            // _bindedSpriteBox
            // 
            this._bindedSpriteBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._bindedSpriteBox.Location = new System.Drawing.Point(0, 0);
            this._bindedSpriteBox.Name = "_bindedSpriteBox";
            this._bindedSpriteBox.Size = new System.Drawing.Size(470, 389);
            this._bindedSpriteBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._bindedSpriteBox.TabIndex = 5;
            this._bindedSpriteBox.TabStop = false;
            this._bindedSpriteBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.templatePictureBox_MouseDoubleClick);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this._browseIdleSprites);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 389);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(5);
            this.panel11.Size = new System.Drawing.Size(470, 41);
            this.panel11.TabIndex = 0;
            // 
            // _browseIdleSprites
            // 
            this._browseIdleSprites.Dock = System.Windows.Forms.DockStyle.Right;
            this._browseIdleSprites.Location = new System.Drawing.Point(358, 5);
            this._browseIdleSprites.Name = "_browseIdleSprites";
            this._browseIdleSprites.Size = new System.Drawing.Size(107, 31);
            this._browseIdleSprites.TabIndex = 0;
            this._browseIdleSprites.Text = "Add Sprites";
            this._browseIdleSprites.UseVisualStyleBackColor = true;
            this._browseIdleSprites.Click += new System.EventHandler(this._browseIdleSprites_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 575);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._templateBox)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._bindedSpriteBox)).EndInit();
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.PictureBox _templateBox;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button _modifySpriteButton;
        private System.Windows.Forms.Button addSpriteButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView _statusListView;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox _statusNameTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox _scriptPathTextBox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button _browseScriptButton;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button _addStatusButton;
        private System.Windows.Forms.Button _removeStatusButton;
        private System.Windows.Forms.Button _modifyStatusButton;
        private System.Windows.Forms.Button _removeSpriteButton;
        private System.Windows.Forms.ListView _bindedSpriteListView;
        private System.Windows.Forms.PictureBox _bindedSpriteBox;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button _browseIdleSprites;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ListView _spriteListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

