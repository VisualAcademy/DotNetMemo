namespace MyWinForms.Controls
{
    partial class FrmComboListBox
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
            this.lstButton = new System.Windows.Forms.ComboBox();
            this.lstIcon = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstButton
            // 
            this.lstButton.FormattingEnabled = true;
            this.lstButton.Items.AddRange(new object[] {
            "OK",
            "OKCancel",
            "YesNo",
            "YesNoCancel",
            "RetryCancel",
            "AbortRetryIgnore"});
            this.lstButton.Location = new System.Drawing.Point(12, 46);
            this.lstButton.Name = "lstButton";
            this.lstButton.Size = new System.Drawing.Size(121, 20);
            this.lstButton.TabIndex = 0;
            this.lstButton.Text = "- 선택 -";
            // 
            // lstIcon
            // 
            this.lstIcon.FormattingEnabled = true;
            this.lstIcon.ItemHeight = 12;
            this.lstIcon.Location = new System.Drawing.Point(152, 46);
            this.lstIcon.Name = "lstIcon";
            this.lstIcon.Size = new System.Drawing.Size(120, 88);
            this.lstIcon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "버튼의 종류";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "아이콘의 종류";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 143);
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.Size = new System.Drawing.Size(100, 21);
            this.txtText.TabIndex = 4;
            this.txtText.Text = "메시지박스";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(100, 192);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 238);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 12);
            this.lblResult.TabIndex = 6;
            // 
            // FrmComboListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstIcon);
            this.Controls.Add(this.lstButton);
            this.Name = "FrmComboListBox";
            this.Text = "FrmComboListBox";
            this.Load += new System.EventHandler(this.FrmComboListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstButton;
        private System.Windows.Forms.ListBox lstIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblResult;
    }
}