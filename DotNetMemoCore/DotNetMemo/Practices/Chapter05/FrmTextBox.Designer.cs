namespace MyWinForms.Controls
{
    partial class FrmTextBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSingleLine = new System.Windows.Forms.TextBox();
            this.txtMultiLine = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMaskedText = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRichTextBox = new System.Windows.Forms.RichTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReadOnly = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "싱글라인 텍스트박스";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "멀티라인 텍스트박스";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "패스워드 텍스트박스";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "마스크 텍스트박스";
            // 
            // txtSingleLine
            // 
            this.txtSingleLine.Location = new System.Drawing.Point(168, 13);
            this.txtSingleLine.Name = "txtSingleLine";
            this.txtSingleLine.Size = new System.Drawing.Size(100, 21);
            this.txtSingleLine.TabIndex = 4;
            // 
            // txtMultiLine
            // 
            this.txtMultiLine.Location = new System.Drawing.Point(168, 44);
            this.txtMultiLine.Multiline = true;
            this.txtMultiLine.Name = "txtMultiLine";
            this.txtMultiLine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMultiLine.Size = new System.Drawing.Size(100, 48);
            this.txtMultiLine.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(168, 104);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 6;
            // 
            // txtMaskedText
            // 
            this.txtMaskedText.Location = new System.Drawing.Point(168, 145);
            this.txtMaskedText.Mask = "000-9000-0000";
            this.txtMaskedText.Name = "txtMaskedText";
            this.txtMaskedText.Size = new System.Drawing.Size(100, 21);
            this.txtMaskedText.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "리치 텍스트박스";
            // 
            // txtRichTextBox
            // 
            this.txtRichTextBox.Location = new System.Drawing.Point(168, 231);
            this.txtRichTextBox.Name = "txtRichTextBox";
            this.txtRichTextBox.Size = new System.Drawing.Size(100, 96);
            this.txtRichTextBox.TabIndex = 9;
            this.txtRichTextBox.Text = "";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(21, 304);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "읽기전용 텍스트박스";
            // 
            // txtReadOnly
            // 
            this.txtReadOnly.Location = new System.Drawing.Point(168, 181);
            this.txtReadOnly.Name = "txtReadOnly";
            this.txtReadOnly.ReadOnly = true;
            this.txtReadOnly.Size = new System.Drawing.Size(100, 21);
            this.txtReadOnly.TabIndex = 12;
            this.txtReadOnly.Text = "안녕하세요";
            // 
            // FrmTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 379);
            this.Controls.Add(this.txtReadOnly);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtRichTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaskedText);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMultiLine);
            this.Controls.Add(this.txtSingleLine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTextBox";
            this.Text = "FrmTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSingleLine;
        private System.Windows.Forms.TextBox txtMultiLine;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.MaskedTextBox txtMaskedText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtRichTextBox;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReadOnly;
    }
}