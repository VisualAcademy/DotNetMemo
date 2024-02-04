namespace DotNetMemo.Practices.Chapter04
{
    partial class FrmDialogs
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
            this.SuspendLayout();
            // 
            // FrmDialogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 121);
            this.Name = "FrmDialogs";
            this.Text = "폼과 대화상자";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDialogs_FormClosing);
            this.Load += new System.EventHandler(this.FrmDialogs_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}