namespace MyWinForms.Controls
{
    partial class FrmCheckedListBoxFavorite
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
            this.lstFavorites = new System.Windows.Forms.CheckedListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.ctlSeletedList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ctlSeletedList)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFavorites
            // 
            this.lstFavorites.FormattingEnabled = true;
            this.lstFavorites.Location = new System.Drawing.Point(12, 41);
            this.lstFavorites.Name = "lstFavorites";
            this.lstFavorites.Size = new System.Drawing.Size(120, 84);
            this.lstFavorites.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(111, 12);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "당신의 관심사항은?";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(177, 41);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "선택\r\n";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // ctlSeletedList
            // 
            this.ctlSeletedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlSeletedList.Location = new System.Drawing.Point(12, 149);
            this.ctlSeletedList.Name = "ctlSeletedList";
            this.ctlSeletedList.RowTemplate.Height = 23;
            this.ctlSeletedList.Size = new System.Drawing.Size(240, 101);
            this.ctlSeletedList.TabIndex = 3;
            // 
            // FrmCheckedListBoxFavorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ctlSeletedList);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstFavorites);
            this.Name = "FrmCheckedListBoxFavorite";
            this.Text = "FrmCheckedListBoxFavorite";
            this.Load += new System.EventHandler(this.FrmCheckedListBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctlSeletedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstFavorites;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView ctlSeletedList;

    }
}