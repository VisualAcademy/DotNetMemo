﻿namespace MyWinForms.Sample
{
    partial class FrmKeyDown
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
            // FrmKeyDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "FrmKeyDown";
            this.Text = "FrmKeyDown";
            this.Load += new System.EventHandler(this.FrmKeyDown_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmKeyDown_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKeyDown_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}