namespace MyWinForms.Controls
{
    partial class FrmListView
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
            this.lstScore = new System.Windows.Forms.ListView();
            this.colKor = new System.Windows.Forms.ColumnHeader();
            this.colEng = new System.Windows.Forms.ColumnHeader();
            this.colTot = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lstScore
            // 
            this.lstScore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colKor,
            this.colEng,
            this.colTot});
            this.lstScore.Location = new System.Drawing.Point(12, 12);
            this.lstScore.Name = "lstScore";
            this.lstScore.Size = new System.Drawing.Size(260, 196);
            this.lstScore.TabIndex = 0;
            this.lstScore.UseCompatibleStateImageBehavior = false;
            this.lstScore.View = System.Windows.Forms.View.Details;
            // 
            // colKor
            // 
            this.colKor.Text = "국어";
            // 
            // colEng
            // 
            this.colEng.Text = "영어";
            // 
            // colTot
            // 
            this.colTot.Text = "총점";
            // 
            // FrmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 234);
            this.Controls.Add(this.lstScore);
            this.Name = "FrmListView";
            this.Text = "FrmListView";
            this.Load += new System.EventHandler(this.FrmListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstScore;
        private System.Windows.Forms.ColumnHeader colKor;
        private System.Windows.Forms.ColumnHeader colEng;
        private System.Windows.Forms.ColumnHeader colTot;
    }
}