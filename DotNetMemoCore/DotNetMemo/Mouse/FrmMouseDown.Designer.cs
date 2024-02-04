namespace MyWinForms.Mouse
{
    partial class FrmMouseDown
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
            // FrmMouseDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "FrmMouseDown";
            this.Text = "FrmMouseDown";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMouseDown_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMouseDown_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMouseDown_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
    }
}