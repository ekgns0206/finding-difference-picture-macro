namespace Tools
{
    partial class AddSpriteDialog
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorFactor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._spriteThresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this._spriteNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this._previewTemplateBox = new System.Windows.Forms.PictureBox();
            this.thresholdTextBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._spriteThresholdTrackBar)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._previewTemplateBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.cancelButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 52);
            this.panel2.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(604, 17);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(685, 17);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 369);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.thresholdTextBox);
            this.panel3.Controls.Add(this.errorFactor);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.color);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this._spriteThresholdTrackBar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this._spriteNameTextBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(435, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 369);
            this.panel3.TabIndex = 3;
            // 
            // errorFactor
            // 
            this.errorFactor.Location = new System.Drawing.Point(74, 89);
            this.errorFactor.Name = "errorFactor";
            this.errorFactor.Size = new System.Drawing.Size(251, 21);
            this.errorFactor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "오차범위";
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(74, 62);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(251, 21);
            this.color.TabIndex = 3;
            this.color.Click += new System.EventHandler(this.color_Click);
            this.color.TextChanged += new System.EventHandler(this.color_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "색상";
            // 
            // _spriteThresholdTrackBar
            // 
            this._spriteThresholdTrackBar.Location = new System.Drawing.Point(74, 36);
            this._spriteThresholdTrackBar.Maximum = 10000;
            this._spriteThresholdTrackBar.Name = "_spriteThresholdTrackBar";
            this._spriteThresholdTrackBar.Size = new System.Drawing.Size(198, 45);
            this._spriteThresholdTrackBar.TabIndex = 1;
            this._spriteThresholdTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this._spriteThresholdTrackBar.Value = 9500;
            this._spriteThresholdTrackBar.Scroll += new System.EventHandler(this._spriteThresholdTrackBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "임계값";
            // 
            // _spriteNameTextBox
            // 
            this._spriteNameTextBox.Location = new System.Drawing.Point(74, 4);
            this._spriteNameTextBox.Name = "_spriteNameTextBox";
            this._spriteNameTextBox.Size = new System.Drawing.Size(251, 21);
            this._spriteNameTextBox.TabIndex = 0;
            this._spriteNameTextBox.TextChanged += new System.EventHandler(this._spriteNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this._previewTemplateBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 369);
            this.panel4.TabIndex = 0;
            // 
            // _previewTemplateBox
            // 
            this._previewTemplateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._previewTemplateBox.Location = new System.Drawing.Point(0, 0);
            this._previewTemplateBox.Name = "_previewTemplateBox";
            this._previewTemplateBox.Size = new System.Drawing.Size(435, 369);
            this._previewTemplateBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._previewTemplateBox.TabIndex = 0;
            this._previewTemplateBox.TabStop = false;
            // 
            // thresholdTextBox
            // 
            this.thresholdTextBox.Location = new System.Drawing.Point(278, 36);
            this.thresholdTextBox.Name = "thresholdTextBox";
            this.thresholdTextBox.Size = new System.Drawing.Size(47, 21);
            this.thresholdTextBox.TabIndex = 8;
            this.thresholdTextBox.TextChanged += new System.EventHandler(this.thresholdTextBox_TextChanged);
            // 
            // AddSpriteDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AddSpriteDialog";
            this.Text = "AddSpriteDialog";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._spriteThresholdTrackBar)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._previewTemplateBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar _spriteThresholdTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _spriteNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox _previewTemplateBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.TextBox errorFactor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox thresholdTextBox;
    }
}