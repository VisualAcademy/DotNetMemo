namespace DotNetNote
{
    partial class FrmAbout
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
          this.btnOK = new System.Windows.Forms.Button();
          this.picWin2003png = new System.Windows.Forms.PictureBox();
          this.picWin2003bmp = new System.Windows.Forms.PictureBox();
          this.picIcon = new System.Windows.Forms.PictureBox();
          this.lblProductName = new System.Windows.Forms.Label();
          this.lblVersion = new System.Windows.Forms.Label();
          this.label2 = new System.Windows.Forms.Label();
          this.label3 = new System.Windows.Forms.Label();
          this.btnEula = new System.Windows.Forms.LinkLabel();
          this.label4 = new System.Windows.Forms.Label();
          this.lblUserName = new System.Windows.Forms.Label();
          this.lblComputerName = new System.Windows.Forms.Label();
          this.panel1 = new System.Windows.Forms.Panel();
          this.lblMemorySizeLabel = new System.Windows.Forms.Label();
          this.lblMemorySize = new System.Windows.Forms.Label();
          this.picBackground = new System.Windows.Forms.PictureBox();
          this.dnnAboutTimer = new System.Windows.Forms.Timer(this.components);
          ((System.ComponentModel.ISupportInitialize)(this.picWin2003png)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.picWin2003bmp)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
          this.SuspendLayout();
          // 
          // btnOK
          // 
          this.btnOK.Location = new System.Drawing.Point(395, 271);
          this.btnOK.Name = "btnOK";
          this.btnOK.Size = new System.Drawing.Size(75, 23);
          this.btnOK.TabIndex = 0;
          this.btnOK.Text = "확인";
          this.btnOK.UseVisualStyleBackColor = true;
          this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
          // 
          // picWin2003png
          // 
          this.picWin2003png.Dock = System.Windows.Forms.DockStyle.Top;
          this.picWin2003png.Image = ((System.Drawing.Image)(resources.GetObject("picWin2003png.Image")));
          this.picWin2003png.Location = new System.Drawing.Point(0, 0);
          this.picWin2003png.Name = "picWin2003png";
          this.picWin2003png.Size = new System.Drawing.Size(480, 85);
          this.picWin2003png.TabIndex = 1;
          this.picWin2003png.TabStop = false;
          // 
          // picWin2003bmp
          // 
          this.picWin2003bmp.Image = ((System.Drawing.Image)(resources.GetObject("picWin2003bmp.Image")));
          this.picWin2003bmp.Location = new System.Drawing.Point(0, 85);
          this.picWin2003bmp.Name = "picWin2003bmp";
          this.picWin2003bmp.Size = new System.Drawing.Size(480, 6);
          this.picWin2003bmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
          this.picWin2003bmp.TabIndex = 2;
          this.picWin2003bmp.TabStop = false;
          // 
          // picIcon
          // 
          this.picIcon.Location = new System.Drawing.Point(27, 113);
          this.picIcon.Name = "picIcon";
          this.picIcon.Size = new System.Drawing.Size(32, 32);
          this.picIcon.TabIndex = 3;
          this.picIcon.TabStop = false;
          // 
          // lblProductName
          // 
          this.lblProductName.AutoSize = true;
          this.lblProductName.Location = new System.Drawing.Point(89, 98);
          this.lblProductName.Name = "lblProductName";
          this.lblProductName.Size = new System.Drawing.Size(53, 12);
          this.lblProductName.TabIndex = 4;
          this.lblProductName.Text = "닷넷노트";
          // 
          // lblVersion
          // 
          this.lblVersion.AutoSize = true;
          this.lblVersion.Location = new System.Drawing.Point(91, 114);
          this.lblVersion.Name = "lblVersion";
          this.lblVersion.Size = new System.Drawing.Size(29, 12);
          this.lblVersion.TabIndex = 5;
          this.lblVersion.Text = "V1.0";
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Location = new System.Drawing.Point(93, 130);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(250, 12);
          this.label2.TabIndex = 6;
          this.label2.Text = "Copyright (C) 2006 DotNetNote Corporation ";
          // 
          // label3
          // 
          this.label3.AutoSize = true;
          this.label3.Location = new System.Drawing.Point(91, 163);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(57, 12);
          this.label3.TabIndex = 7;
          this.label3.Text = "이 제품은";
          // 
          // btnEula
          // 
          this.btnEula.AutoSize = true;
          this.btnEula.Location = new System.Drawing.Point(165, 163);
          this.btnEula.Name = "btnEula";
          this.btnEula.Size = new System.Drawing.Size(137, 12);
          this.btnEula.TabIndex = 8;
          this.btnEula.TabStop = true;
          this.btnEula.Text = "최종 사용자 사용권 계약";
          this.btnEula.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnEula_LinkClicked);
          // 
          // label4
          // 
          this.label4.AutoSize = true;
          this.label4.Location = new System.Drawing.Point(93, 184);
          this.label4.Name = "label4";
          this.label4.Size = new System.Drawing.Size(233, 12);
          this.label4.TabIndex = 9;
          this.label4.Text = "에 따라 다음 사람에게 사용이 허가됩니다.";
          // 
          // lblUserName
          // 
          this.lblUserName.AutoSize = true;
          this.lblUserName.Location = new System.Drawing.Point(118, 205);
          this.lblUserName.Name = "lblUserName";
          this.lblUserName.Size = new System.Drawing.Size(41, 12);
          this.lblUserName.TabIndex = 10;
          this.lblUserName.Text = "박용준";
          // 
          // lblComputerName
          // 
          this.lblComputerName.AutoSize = true;
          this.lblComputerName.Location = new System.Drawing.Point(118, 221);
          this.lblComputerName.Name = "lblComputerName";
          this.lblComputerName.Size = new System.Drawing.Size(41, 12);
          this.lblComputerName.TabIndex = 11;
          this.lblComputerName.Text = "우리집";
          // 
          // panel1
          // 
          this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
          this.panel1.Location = new System.Drawing.Point(91, 240);
          this.panel1.Name = "panel1";
          this.panel1.Size = new System.Drawing.Size(375, 1);
          this.panel1.TabIndex = 12;
          // 
          // lblMemorySizeLabel
          // 
          this.lblMemorySizeLabel.AutoSize = true;
          this.lblMemorySizeLabel.Location = new System.Drawing.Point(91, 248);
          this.lblMemorySizeLabel.Name = "lblMemorySizeLabel";
          this.lblMemorySizeLabel.Size = new System.Drawing.Size(236, 12);
          this.lblMemorySizeLabel.TabIndex = 13;
          this.lblMemorySizeLabel.Text = "Windows에서 사용할 수 있는 실제 메모리:";
          // 
          // lblMemorySize
          // 
          this.lblMemorySize.AutoSize = true;
          this.lblMemorySize.Location = new System.Drawing.Point(350, 248);
          this.lblMemorySize.Name = "lblMemorySize";
          this.lblMemorySize.Size = new System.Drawing.Size(45, 12);
          this.lblMemorySize.TabIndex = 14;
          this.lblMemorySize.Text = "1024KB";
          // 
          // picBackground
          // 
          this.picBackground.Location = new System.Drawing.Point(0, 85);
          this.picBackground.Name = "picBackground";
          this.picBackground.Size = new System.Drawing.Size(480, 6);
          this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
          this.picBackground.TabIndex = 15;
          this.picBackground.TabStop = false;
          // 
          // dnnAboutTimer
          // 
          this.dnnAboutTimer.Enabled = true;
          this.dnnAboutTimer.Tick += new System.EventHandler(this.dnnAboutTimer_Tick);
          // 
          // FrmAbout
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(480, 305);
          this.Controls.Add(this.lblMemorySize);
          this.Controls.Add(this.lblMemorySizeLabel);
          this.Controls.Add(this.panel1);
          this.Controls.Add(this.lblComputerName);
          this.Controls.Add(this.lblUserName);
          this.Controls.Add(this.label4);
          this.Controls.Add(this.btnEula);
          this.Controls.Add(this.label3);
          this.Controls.Add(this.label2);
          this.Controls.Add(this.lblVersion);
          this.Controls.Add(this.lblProductName);
          this.Controls.Add(this.picIcon);
          this.Controls.Add(this.picWin2003bmp);
          this.Controls.Add(this.picWin2003png);
          this.Controls.Add(this.btnOK);
          this.Controls.Add(this.picBackground);
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.Name = "FrmAbout";
          this.ShowIcon = false;
          this.Text = "메모장 정보";
          this.Load += new System.EventHandler(this.FrmAbout_Load);
          ((System.ComponentModel.ISupportInitialize)(this.picWin2003png)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.picWin2003bmp)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox picWin2003png;
        private System.Windows.Forms.PictureBox picWin2003bmp;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel btnEula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMemorySizeLabel;
        private System.Windows.Forms.Label lblMemorySize;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Timer dnnAboutTimer;
    }
}