﻿namespace UserControls
{
    partial class PersonControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(13, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(29, 12);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "나이";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(17, 12);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "성";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 12);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "이름";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(93, 90);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(116, 21);
            this.AgeTextBox.TabIndex = 8;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(93, 54);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(116, 21);
            this.LastNameTextBox.TabIndex = 7;
            // 
            // FirstTextBox
            // 
            this.FirstTextBox.Location = new System.Drawing.Point(93, 12);
            this.FirstTextBox.Name = "FirstTextBox";
            this.FirstTextBox.Size = new System.Drawing.Size(116, 21);
            this.FirstTextBox.TabIndex = 6;
            // 
            // PersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstTextBox);
            this.Name = "PersonControl";
            this.Size = new System.Drawing.Size(238, 127);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox AgeTextBox;
        internal System.Windows.Forms.TextBox LastNameTextBox;
        internal System.Windows.Forms.TextBox FirstTextBox;
    }
}
