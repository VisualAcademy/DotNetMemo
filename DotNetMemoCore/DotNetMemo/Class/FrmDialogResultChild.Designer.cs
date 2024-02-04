namespace MyWinForms.Class
{
    partial class FrmDialogResultChild
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
            this.txtReturn = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtChild = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtReturn
            // 
            this.txtReturn.Location = new System.Drawing.Point(66, 107);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(100, 21);
            this.txtReturn.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(77, 68);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtChild
            // 
            this.txtChild.Location = new System.Drawing.Point(66, 31);
            this.txtChild.Name = "txtChild";
            this.txtChild.Size = new System.Drawing.Size(100, 21);
            this.txtChild.TabIndex = 3;
            // 
            // FrmDialogResultChild
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 159);
            this.Controls.Add(this.txtReturn);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtChild);
            this.Name = "FrmDialogResultChild";
            this.Text = "FrmDialogResultChild";
            this.Load += new System.EventHandler(this.FrmDialogResultChild_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReturn;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtChild;
    }
}