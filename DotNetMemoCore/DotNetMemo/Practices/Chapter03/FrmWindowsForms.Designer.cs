namespace DotNetMemo.Practices.Chapter03
{
    partial class FrmWindowsForms
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
            // FrmWindowsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 319);
            this.Name = "FrmWindowsForms";
            this.Text = "제목 영역";
            this.Load += new System.EventHandler(this.FrmWindowsForms_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FrmWindowsForms_MouseDoubleClick);
            this.ResumeLayout(false);

        }

        #endregion
    }
}