namespace Jigsaw
{
    partial class Form1 
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonImageBrowser = new System.Windows.Forms.Button();
            this.textboxImagePath = new System.Windows.Forms.TextBox();
            this.groupboxPuzzle = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLevel4 = new System.Windows.Forms.Button();
            this.buttonLevel3 = new System.Windows.Forms.Button();
            this.buttonLevel2 = new System.Windows.Forms.Button();
            this.buttonLevel1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonImageBrowser);
            this.groupBox1.Controls.Add(this.textboxImagePath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Image";
            // 
            // buttonImageBrowser
            // 
            this.buttonImageBrowser.Location = new System.Drawing.Point(488, 17);
            this.buttonImageBrowser.Name = "buttonImageBrowser";
            this.buttonImageBrowser.Size = new System.Drawing.Size(75, 23);
            this.buttonImageBrowser.TabIndex = 1;
            this.buttonImageBrowser.Text = "Choose";
            this.buttonImageBrowser.UseVisualStyleBackColor = true;
            this.buttonImageBrowser.Click += new System.EventHandler(this.buttonImageBrowser_Click);
            // 
            // textboxImagePath
            // 
            this.textboxImagePath.Location = new System.Drawing.Point(7, 20);
            this.textboxImagePath.Name = "textboxImagePath";
            this.textboxImagePath.Size = new System.Drawing.Size(461, 20);
            this.textboxImagePath.TabIndex = 0;
            // 
            // groupboxPuzzle
            // 
            this.groupboxPuzzle.Location = new System.Drawing.Point(12, 58);
            this.groupboxPuzzle.Name = "groupboxPuzzle";
            this.groupboxPuzzle.Size = new System.Drawing.Size(427, 280);
            this.groupboxPuzzle.TabIndex = 1;
            this.groupboxPuzzle.TabStop = false;
            this.groupboxPuzzle.Text = "Puzzle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLevel4);
            this.groupBox2.Controls.Add(this.buttonLevel3);
            this.groupBox2.Controls.Add(this.buttonLevel2);
            this.groupBox2.Controls.Add(this.buttonLevel1);
            this.groupBox2.Location = new System.Drawing.Point(462, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Play Mode";
            // 
            // buttonLevel4
            // 
            this.buttonLevel4.Location = new System.Drawing.Point(26, 117);
            this.buttonLevel4.Name = "buttonLevel4";
            this.buttonLevel4.Size = new System.Drawing.Size(75, 23);
            this.buttonLevel4.TabIndex = 3;
            this.buttonLevel4.Text = "Level 4";
            this.buttonLevel4.UseVisualStyleBackColor = true;
            this.buttonLevel4.Click += new System.EventHandler(this.buttonLevel4_Click);
            // 
            // buttonLevel3
            // 
            this.buttonLevel3.Location = new System.Drawing.Point(26, 88);
            this.buttonLevel3.Name = "buttonLevel3";
            this.buttonLevel3.Size = new System.Drawing.Size(75, 23);
            this.buttonLevel3.TabIndex = 2;
            this.buttonLevel3.Text = "Level 3";
            this.buttonLevel3.UseVisualStyleBackColor = true;
            this.buttonLevel3.Click += new System.EventHandler(this.buttonLevel3_Click);
            // 
            // buttonLevel2
            // 
            this.buttonLevel2.Location = new System.Drawing.Point(26, 59);
            this.buttonLevel2.Name = "buttonLevel2";
            this.buttonLevel2.Size = new System.Drawing.Size(75, 23);
            this.buttonLevel2.TabIndex = 1;
            this.buttonLevel2.Text = "Level 2";
            this.buttonLevel2.UseVisualStyleBackColor = true;
            this.buttonLevel2.Click += new System.EventHandler(this.buttonLevel2_Click);
            // 
            // buttonLevel1
            // 
            this.buttonLevel1.Location = new System.Drawing.Point(26, 29);
            this.buttonLevel1.Name = "buttonLevel1";
            this.buttonLevel1.Size = new System.Drawing.Size(75, 23);
            this.buttonLevel1.TabIndex = 0;
            this.buttonLevel1.Text = "Level 1";
            this.buttonLevel1.UseVisualStyleBackColor = true;
            this.buttonLevel1.Click += new System.EventHandler(this.buttonLevel1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelStatus);
            this.groupBox3.Location = new System.Drawing.Point(462, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 117);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(6, 16);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(24, 13);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Idle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 350);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupboxPuzzle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Puzzle Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonImageBrowser;
        private System.Windows.Forms.TextBox textboxImagePath;
        private System.Windows.Forms.GroupBox groupboxPuzzle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonLevel4;
        private System.Windows.Forms.Button buttonLevel3;
        private System.Windows.Forms.Button buttonLevel2;
        private System.Windows.Forms.Button buttonLevel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelStatus;
    }
}

