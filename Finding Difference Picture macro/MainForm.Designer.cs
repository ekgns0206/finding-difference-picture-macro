namespace FINDING_DIFFERENCE_PICTURE
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.historyTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.initializeScript = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.disposeScript = new System.Windows.Forms.TextBox();
            this.frameScript = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.browseSpriteButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.appClassName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spriteResourceTextBox = new System.Windows.Forms.TextBox();
            this.browseProcess = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hardwareType = new System.Windows.Forms.RadioButton();
            this.softwareType = new System.Windows.Forms.RadioButton();
            this.pythonPath = new System.Windows.Forms.TextBox();
            this.browsePython = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusResourceTextBox = new System.Windows.Forms.TextBox();
            this.browseStatusButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.execute = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.defaultTimer = new System.Windows.Forms.Timer(this.components);
            this.streamingBox = new FINDING_DIFFERENCE_PICTURE.Control.StreamingBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.settingPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 561);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
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
            this.splitContainer1.Panel1.Controls.Add(this.streamingBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.settingPanel);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(994, 529);
            this.splitContainer1.SplitterDistance = 657;
            this.splitContainer1.TabIndex = 1;
            // 
            // settingPanel
            // 
            this.settingPanel.Controls.Add(this.historyTextBox);
            this.settingPanel.Controls.Add(this.panel3);
            this.settingPanel.Controls.Add(this.groupBox2);
            this.settingPanel.Controls.Add(this.groupBox1);
            this.settingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingPanel.Location = new System.Drawing.Point(0, 0);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(333, 497);
            this.settingPanel.TabIndex = 5;
            // 
            // historyTextBox
            // 
            this.historyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyTextBox.Location = new System.Drawing.Point(0, 320);
            this.historyTextBox.Multiline = true;
            this.historyTextBox.Name = "historyTextBox";
            this.historyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historyTextBox.Size = new System.Drawing.Size(333, 177);
            this.historyTextBox.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.statusNameLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 288);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(333, 32);
            this.panel3.TabIndex = 5;
            // 
            // statusNameLabel
            // 
            this.statusNameLabel.AutoSize = true;
            this.statusNameLabel.Location = new System.Drawing.Point(13, 10);
            this.statusNameLabel.Name = "statusNameLabel";
            this.statusNameLabel.Size = new System.Drawing.Size(0, 12);
            this.statusNameLabel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(333, 115);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "스크립트";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.initializeScript, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.disposeScript, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.frameScript, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(313, 80);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "초기화";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // initializeScript
            // 
            this.initializeScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initializeScript.Location = new System.Drawing.Point(96, 3);
            this.initializeScript.Name = "initializeScript";
            this.initializeScript.Size = new System.Drawing.Size(214, 22);
            this.initializeScript.TabIndex = 0;
            this.initializeScript.Text = "init.py";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "프레임";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "디스포즈";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // disposeScript
            // 
            this.disposeScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disposeScript.Location = new System.Drawing.Point(96, 55);
            this.disposeScript.Name = "disposeScript";
            this.disposeScript.Size = new System.Drawing.Size(214, 22);
            this.disposeScript.TabIndex = 7;
            this.disposeScript.Text = "dispose.py";
            // 
            // frameScript
            // 
            this.frameScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameScript.Location = new System.Drawing.Point(96, 29);
            this.frameScript.Name = "frameScript";
            this.frameScript.Size = new System.Drawing.Size(214, 22);
            this.frameScript.TabIndex = 8;
            this.frameScript.Text = "frame.py";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(333, 173);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "기본설정";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.browseSpriteButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.appClassName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.spriteResourceTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.browseProcess, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.pythonPath, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.browsePython, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.statusResourceTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.browseStatusButton, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(313, 138);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // browseSpriteButton
            // 
            this.browseSpriteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseSpriteButton.Location = new System.Drawing.Point(283, 30);
            this.browseSpriteButton.Name = "browseSpriteButton";
            this.browseSpriteButton.Size = new System.Drawing.Size(27, 21);
            this.browseSpriteButton.TabIndex = 5;
            this.browseSpriteButton.Text = "...";
            this.browseSpriteButton.UseVisualStyleBackColor = true;
            this.browseSpriteButton.Click += new System.EventHandler(this.browseSpriteButton_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "클래스";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // appClassName
            // 
            this.appClassName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appClassName.Location = new System.Drawing.Point(96, 3);
            this.appClassName.Name = "appClassName";
            this.appClassName.Size = new System.Drawing.Size(181, 22);
            this.appClassName.TabIndex = 0;
            this.appClassName.Text = "pmlauncher";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "스프라이트";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spriteResourceTextBox
            // 
            this.spriteResourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spriteResourceTextBox.Location = new System.Drawing.Point(96, 30);
            this.spriteResourceTextBox.Name = "spriteResourceTextBox";
            this.spriteResourceTextBox.Size = new System.Drawing.Size(181, 22);
            this.spriteResourceTextBox.TabIndex = 3;
            // 
            // browseProcess
            // 
            this.browseProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseProcess.Location = new System.Drawing.Point(283, 3);
            this.browseProcess.Name = "browseProcess";
            this.browseProcess.Size = new System.Drawing.Size(27, 21);
            this.browseProcess.TabIndex = 4;
            this.browseProcess.Text = "...";
            this.browseProcess.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hardwareType);
            this.panel2.Controls.Add(this.softwareType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(96, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 24);
            this.panel2.TabIndex = 7;
            // 
            // hardwareType
            // 
            this.hardwareType.AutoSize = true;
            this.hardwareType.Checked = true;
            this.hardwareType.Dock = System.Windows.Forms.DockStyle.Left;
            this.hardwareType.Location = new System.Drawing.Point(51, 0);
            this.hardwareType.Name = "hardwareType";
            this.hardwareType.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.hardwareType.Size = new System.Drawing.Size(51, 24);
            this.hardwareType.TabIndex = 9;
            this.hardwareType.TabStop = true;
            this.hardwareType.Text = "HW";
            this.hardwareType.UseVisualStyleBackColor = true;
            // 
            // softwareType
            // 
            this.softwareType.AutoSize = true;
            this.softwareType.Dock = System.Windows.Forms.DockStyle.Left;
            this.softwareType.Location = new System.Drawing.Point(0, 0);
            this.softwareType.Name = "softwareType";
            this.softwareType.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.softwareType.Size = new System.Drawing.Size(51, 24);
            this.softwareType.TabIndex = 8;
            this.softwareType.Text = "SW";
            this.softwareType.UseVisualStyleBackColor = true;
            // 
            // pythonPath
            // 
            this.pythonPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pythonPath.Location = new System.Drawing.Point(96, 84);
            this.pythonPath.Name = "pythonPath";
            this.pythonPath.Size = new System.Drawing.Size(181, 22);
            this.pythonPath.TabIndex = 3;
            this.pythonPath.Text = "D:\\Program Files (x86)\\Python\\Python27";
            // 
            // browsePython
            // 
            this.browsePython.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browsePython.Location = new System.Drawing.Point(283, 84);
            this.browsePython.Name = "browsePython";
            this.browsePython.Size = new System.Drawing.Size(27, 21);
            this.browsePython.TabIndex = 5;
            this.browsePython.Text = "...";
            this.browsePython.UseVisualStyleBackColor = true;
            this.browsePython.Click += new System.EventHandler(this.browsePython_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "작동형식";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "파이썬 경로";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 27);
            this.label8.TabIndex = 2;
            this.label8.Text = "상태 리소스";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusResourceTextBox
            // 
            this.statusResourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusResourceTextBox.Location = new System.Drawing.Point(96, 57);
            this.statusResourceTextBox.Name = "statusResourceTextBox";
            this.statusResourceTextBox.Size = new System.Drawing.Size(181, 22);
            this.statusResourceTextBox.TabIndex = 3;
            // 
            // browseStatusButton
            // 
            this.browseStatusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browseStatusButton.Location = new System.Drawing.Point(283, 57);
            this.browseStatusButton.Name = "browseStatusButton";
            this.browseStatusButton.Size = new System.Drawing.Size(27, 21);
            this.browseStatusButton.TabIndex = 5;
            this.browseStatusButton.Text = "...";
            this.browseStatusButton.UseVisualStyleBackColor = true;
            this.browseStatusButton.Click += new System.EventHandler(this.browseSpriteButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.execute);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 497);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 32);
            this.panel1.TabIndex = 0;
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(253, 6);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(75, 23);
            this.execute.TabIndex = 0;
            this.execute.Text = "시작";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // streamingBox
            // 
            this.streamingBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streamingBox.Frame = null;
            this.streamingBox.Location = new System.Drawing.Point(0, 0);
            this.streamingBox.Name = "streamingBox";
            this.streamingBox.Size = new System.Drawing.Size(657, 529);
            this.streamingBox.TabIndex = 0;
            this.streamingBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.streamingBox_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MainForm";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.settingPanel.ResumeLayout(false);
            this.settingPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage2;
        private Control.StreamingBox streamingBox;
        private System.Windows.Forms.Panel settingPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox initializeScript;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox disposeScript;
        private System.Windows.Forms.TextBox frameScript;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button browseSpriteButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox appClassName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox spriteResourceTextBox;
        private System.Windows.Forms.Button browseProcess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Timer defaultTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton hardwareType;
        private System.Windows.Forms.RadioButton softwareType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pythonPath;
        private System.Windows.Forms.Button browsePython;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox statusResourceTextBox;
        private System.Windows.Forms.Button browseStatusButton;
        private System.Windows.Forms.TextBox historyTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label statusNameLabel;
    }
}

