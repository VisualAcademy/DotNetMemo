namespace MyWinForms.Controls
{
    partial class FrmCheckBoxRadioButton
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
            this.lblFavorites = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.chkSeeSharp = new System.Windows.Forms.CheckBox();
            this.chkAspNet = new System.Windows.Forms.CheckBox();
            this.chkSilverlight = new System.Windows.Forms.CheckBox();
            this.rdoMan = new System.Windows.Forms.RadioButton();
            this.optWomen = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFavorites
            // 
            this.lblFavorites.AutoSize = true;
            this.lblFavorites.Location = new System.Drawing.Point(12, 9);
            this.lblFavorites.Name = "lblFavorites";
            this.lblFavorites.Size = new System.Drawing.Size(59, 12);
            this.lblFavorites.TabIndex = 0;
            this.lblFavorites.Text = "관심사항?";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(12, 134);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(35, 12);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "성별?";
            // 
            // chkSeeSharp
            // 
            this.chkSeeSharp.AutoSize = true;
            this.chkSeeSharp.Location = new System.Drawing.Point(14, 34);
            this.chkSeeSharp.Name = "chkSeeSharp";
            this.chkSeeSharp.Size = new System.Drawing.Size(39, 16);
            this.chkSeeSharp.TabIndex = 2;
            this.chkSeeSharp.Text = "C#";
            this.chkSeeSharp.UseVisualStyleBackColor = true;
            // 
            // chkAspNet
            // 
            this.chkAspNet.AutoSize = true;
            this.chkAspNet.Checked = true;
            this.chkAspNet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAspNet.Location = new System.Drawing.Point(14, 56);
            this.chkAspNet.Name = "chkAspNet";
            this.chkAspNet.Size = new System.Drawing.Size(77, 16);
            this.chkAspNet.TabIndex = 3;
            this.chkAspNet.Text = "ASP.NET";
            this.chkAspNet.UseVisualStyleBackColor = true;
            // 
            // chkSilverlight
            // 
            this.chkSilverlight.AutoSize = true;
            this.chkSilverlight.Location = new System.Drawing.Point(14, 79);
            this.chkSilverlight.Name = "chkSilverlight";
            this.chkSilverlight.Size = new System.Drawing.Size(78, 16);
            this.chkSilverlight.TabIndex = 4;
            this.chkSilverlight.Text = "Silverlight";
            this.chkSilverlight.UseVisualStyleBackColor = true;
            // 
            // rdoMan
            // 
            this.rdoMan.AutoSize = true;
            this.rdoMan.Location = new System.Drawing.Point(14, 162);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(47, 16);
            this.rdoMan.TabIndex = 5;
            this.rdoMan.TabStop = true;
            this.rdoMan.Text = "남자";
            this.rdoMan.UseVisualStyleBackColor = true;
            // 
            // optWomen
            // 
            this.optWomen.AutoSize = true;
            this.optWomen.Location = new System.Drawing.Point(14, 185);
            this.optWomen.Name = "optWomen";
            this.optWomen.Size = new System.Drawing.Size(47, 16);
            this.optWomen.TabIndex = 6;
            this.optWomen.TabStop = true;
            this.optWomen.Text = "여자";
            this.optWomen.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(164, 27);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(118, 79);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(121, 122);
            this.txtResult.TabIndex = 8;
            // 
            // FrmCheckBoxRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 219);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.optWomen);
            this.Controls.Add(this.rdoMan);
            this.Controls.Add(this.chkSilverlight);
            this.Controls.Add(this.chkAspNet);
            this.Controls.Add(this.chkSeeSharp);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblFavorites);
            this.Name = "FrmCheckBoxRadioButton";
            this.Text = "FrmCheckBoxRadioButton";
            this.Load += new System.EventHandler(this.FrmCheckBoxRadioButton_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFavorites;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.CheckBox chkSeeSharp;
        private System.Windows.Forms.CheckBox chkAspNet;
        private System.Windows.Forms.CheckBox chkSilverlight;
        private System.Windows.Forms.RadioButton rdoMan;
        private System.Windows.Forms.RadioButton optWomen;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtResult;
    }
}