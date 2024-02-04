//namespace MyWinForms.Controls
//{
//    partial class FrmTabControl
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.tabControl1 = new System.Windows.Forms.TabControl();
//            this.tabPage1 = new System.Windows.Forms.TabPage();
//            this.tabPage2 = new System.Windows.Forms.TabPage();
//            this.btnOK = new System.Windows.Forms.Button();
//            this.txtHome = new System.Windows.Forms.TextBox();
//            this.label1 = new System.Windows.Forms.Label();
//            this.groupBox1 = new System.Windows.Forms.GroupBox();
//            this.tbLevel = new System.Windows.Forms.TrackBar();
//            this.lblDisplay = new System.Windows.Forms.Label();
//            this.panel1 = new System.Windows.Forms.Panel();
//            this.tabControl1.SuspendLayout();
//            this.tabPage1.SuspendLayout();
//            this.tabPage2.SuspendLayout();
//            this.groupBox1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.tbLevel)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // tabControl1
//            // 
//            this.tabControl1.Controls.Add(this.tabPage1);
//            this.tabControl1.Controls.Add(this.tabPage2);
//            this.tabControl1.Location = new System.Drawing.Point(13, 13);
//            this.tabControl1.Name = "tabControl1";
//            this.tabControl1.SelectedIndex = 0;
//            this.tabControl1.Size = new System.Drawing.Size(267, 195);
//            this.tabControl1.TabIndex = 0;
//            // 
//            // tabPage1
//            // 
//            this.tabPage1.Controls.Add(this.panel1);
//            this.tabPage1.Controls.Add(this.label1);
//            this.tabPage1.Controls.Add(this.txtHome);
//            this.tabPage1.Location = new System.Drawing.Point(4, 21);
//            this.tabPage1.Name = "tabPage1";
//            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
//            this.tabPage1.Size = new System.Drawing.Size(259, 170);
//            this.tabPage1.TabIndex = 0;
//            this.tabPage1.Text = "일반";
//            this.tabPage1.UseVisualStyleBackColor = true;
//            // 
//            // tabPage2
//            // 
//            this.tabPage2.Controls.Add(this.groupBox1);
//            this.tabPage2.Location = new System.Drawing.Point(4, 21);
//            this.tabPage2.Name = "tabPage2";
//            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
//            this.tabPage2.Size = new System.Drawing.Size(259, 170);
//            this.tabPage2.TabIndex = 1;
//            this.tabPage2.Text = "보안";
//            this.tabPage2.UseVisualStyleBackColor = true;
//            // 
//            // btnOK
//            // 
//            this.btnOK.Location = new System.Drawing.Point(201, 231);
//            this.btnOK.Name = "btnOK";
//            this.btnOK.Size = new System.Drawing.Size(75, 23);
//            this.btnOK.TabIndex = 1;
//            this.btnOK.Text = "확인";
//            this.btnOK.UseVisualStyleBackColor = true;
//            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
//            // 
//            // txtHome
//            // 
//            this.txtHome.Location = new System.Drawing.Point(89, 14);
//            this.txtHome.Name = "txtHome";
//            this.txtHome.Size = new System.Drawing.Size(152, 21);
//            this.txtHome.TabIndex = 0;
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Location = new System.Drawing.Point(17, 17);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(65, 12);
//            this.label1.TabIndex = 1;
//            this.label1.Text = "홈페이지 : ";
//            // 
//            // groupBox1
//            // 
//            this.groupBox1.Controls.Add(this.lblDisplay);
//            this.groupBox1.Controls.Add(this.tbLevel);
//            this.groupBox1.Location = new System.Drawing.Point(20, 23);
//            this.groupBox1.Name = "groupBox1";
//            this.groupBox1.Size = new System.Drawing.Size(213, 117);
//            this.groupBox1.TabIndex = 0;
//            this.groupBox1.TabStop = false;
//            this.groupBox1.Text = "보안 수준";
//            // 
//            // tbLevel
//            // 
//            this.tbLevel.Location = new System.Drawing.Point(18, 20);
//            this.tbLevel.Maximum = 2;
//            this.tbLevel.Name = "tbLevel";
//            this.tbLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
//            this.tbLevel.Size = new System.Drawing.Size(45, 78);
//            this.tbLevel.TabIndex = 0;
//            this.tbLevel.Scroll += new System.EventHandler(this.tbLevel_Scroll);
//            // 
//            // lblDisplay
//            // 
//            this.lblDisplay.AutoSize = true;
//            this.lblDisplay.Location = new System.Drawing.Point(94, 20);
//            this.lblDisplay.Name = "lblDisplay";
//            this.lblDisplay.Size = new System.Drawing.Size(38, 12);
//            this.lblDisplay.TabIndex = 1;
//            this.lblDisplay.Text = "label2";
//            // 
//            // panel1
//            // 
//            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
//            this.panel1.Location = new System.Drawing.Point(19, 43);
//            this.panel1.Name = "panel1";
//            this.panel1.Size = new System.Drawing.Size(222, 1);
//            this.panel1.TabIndex = 2;
//            // 
//            // FrmTabControl
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(292, 266);
//            this.Controls.Add(this.btnOK);
//            this.Controls.Add(this.tabControl1);
//            this.Name = "FrmTabControl";
//            this.Text = "FrmTabControl";
//            this.Load += new System.EventHandler(this.FrmTabControl_Load);
//            this.tabControl1.ResumeLayout(false);
//            this.tabPage1.ResumeLayout(false);
//            this.tabPage1.PerformLayout();
//            this.tabPage2.ResumeLayout(false);
//            this.groupBox1.ResumeLayout(false);
//            this.groupBox1.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.tbLevel)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.TabControl tabControl1;
//        private System.Windows.Forms.TabPage tabPage1;
//        private System.Windows.Forms.TabPage tabPage2;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.TextBox txtHome;
//        private System.Windows.Forms.Button btnOK;
//        private System.Windows.Forms.GroupBox groupBox1;
//        private System.Windows.Forms.Panel panel1;
//        private System.Windows.Forms.Label lblDisplay;
//        private System.Windows.Forms.TrackBar tbLevel;
//    }
//}