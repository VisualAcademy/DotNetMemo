namespace MyWinForms.Controls
{
    partial class FrmButtonLableTextBox
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
            this.lblKor = new System.Windows.Forms.Label();
            this.lblEng = new System.Windows.Forms.Label();
            this.txtKor = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKor
            // 
            this.lblKor.AutoSize = true;
            this.lblKor.Location = new System.Drawing.Point(29, 26);
            this.lblKor.Name = "lblKor";
            this.lblKor.Size = new System.Drawing.Size(65, 12);
            this.lblKor.TabIndex = 0;
            this.lblKor.Text = "국어점수 : ";
            // 
            // lblEng
            // 
            this.lblEng.AutoSize = true;
            this.lblEng.Location = new System.Drawing.Point(29, 57);
            this.lblEng.Name = "lblEng";
            this.lblEng.Size = new System.Drawing.Size(61, 12);
            this.lblEng.TabIndex = 1;
            this.lblEng.Text = "영어점수 :";
            // 
            // txtKor
            // 
            this.txtKor.Location = new System.Drawing.Point(108, 23);
            this.txtKor.Name = "txtKor";
            this.txtKor.Size = new System.Drawing.Size(100, 21);
            this.txtKor.TabIndex = 2;
            this.txtKor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKor_KeyDown);
            // 
            // txtEng
            // 
            this.txtEng.Location = new System.Drawing.Point(108, 52);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(100, 21);
            this.txtEng.TabIndex = 3;
            this.txtEng.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEng_KeyDown);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(31, 101);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(122, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmButtonLableTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(232, 157);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtKor);
            this.Controls.Add(this.lblEng);
            this.Controls.Add(this.lblKor);
            this.Name = "FrmButtonLableTextBox";
            this.Text = "FrmButtonLableTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKor;
        private System.Windows.Forms.Label lblEng;
        private System.Windows.Forms.TextBox txtKor;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}