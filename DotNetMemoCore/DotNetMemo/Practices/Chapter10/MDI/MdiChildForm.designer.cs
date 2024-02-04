namespace DotNetMemo
{
    partial class MdiChildForm
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
            this.documentTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // documentTextBox
            // 
            this.documentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentTextBox.Location = new System.Drawing.Point(0, 0);
            this.documentTextBox.Name = "documentTextBox";
            this.documentTextBox.Size = new System.Drawing.Size(341, 252);
            this.documentTextBox.TabIndex = 0;
            this.documentTextBox.Text = "";
            // 
            // MdiChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 252);
            this.Controls.Add(this.documentTextBox);
            this.Name = "MdiChildForm";
            this.Text = "새 문서";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox documentTextBox;

    }
}