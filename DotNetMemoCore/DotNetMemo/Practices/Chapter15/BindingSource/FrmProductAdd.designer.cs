﻿namespace DotNetMemo
{
    partial class FrmProductAdd
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
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CancelButtonControl = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.OrderTextBox = new System.Windows.Forms.TextBox();
            this.DiscontinuedCheckBox = new System.Windows.Forms.CheckBox();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(140, 34);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(243, 21);
            this.CategoryTextBox.TabIndex = 19;
            this.CategoryTextBox.TabStop = false;
            // 
            // CancelButtonControl
            // 
            this.CancelButtonControl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButtonControl.Location = new System.Drawing.Point(296, 175);
            this.CancelButtonControl.Name = "CancelButtonControl";
            this.CancelButtonControl.Size = new System.Drawing.Size(87, 21);
            this.CancelButtonControl.TabIndex = 31;
            this.CancelButtonControl.Text = "Cancel";
            this.CancelButtonControl.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(202, 175);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(87, 21);
            this.OKButton.TabIndex = 30;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(16, 37);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 12);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Category";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(16, 159);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(78, 12);
            this.Label7.TabIndex = 28;
            this.Label7.Text = "Discontinued";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(16, 138);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(86, 12);
            this.Label6.TabIndex = 26;
            this.Label6.Text = "Units on Order";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(16, 114);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(82, 12);
            this.Label5.TabIndex = 24;
            this.Label5.Text = "Units in Stock";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(16, 90);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(59, 12);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Unit Price";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(16, 66);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(99, 12);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Quantity Per Unit";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 12);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Name";
            // 
            // OrderTextBox
            // 
            this.OrderTextBox.Location = new System.Drawing.Point(140, 131);
            this.OrderTextBox.Name = "OrderTextBox";
            this.OrderTextBox.Size = new System.Drawing.Size(243, 21);
            this.OrderTextBox.TabIndex = 27;
            // 
            // DiscontinuedCheckBox
            // 
            this.DiscontinuedCheckBox.AutoSize = true;
            this.DiscontinuedCheckBox.Location = new System.Drawing.Point(140, 159);
            this.DiscontinuedCheckBox.Name = "DiscontinuedCheckBox";
            this.DiscontinuedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.DiscontinuedCheckBox.TabIndex = 29;
            this.DiscontinuedCheckBox.UseVisualStyleBackColor = true;
            // 
            // StockTextBox
            // 
            this.StockTextBox.Location = new System.Drawing.Point(140, 107);
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.Size = new System.Drawing.Size(243, 21);
            this.StockTextBox.TabIndex = 25;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(140, 83);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(243, 21);
            this.PriceTextBox.TabIndex = 23;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(140, 59);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(243, 21);
            this.QuantityTextBox.TabIndex = 21;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(140, 10);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(243, 21);
            this.NameTextBox.TabIndex = 17;
            // 
            // FrmProductAdd
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButtonControl;
            this.ClientSize = new System.Drawing.Size(399, 207);
            this.ControlBox = false;
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.CancelButtonControl);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.OrderTextBox);
            this.Controls.Add(this.DiscontinuedCheckBox);
            this.Controls.Add(this.StockTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmProductAdd";
            this.Text = "상품 등록";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox CategoryTextBox;
        internal System.Windows.Forms.Button CancelButtonControl;
        internal System.Windows.Forms.Button OKButton;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox OrderTextBox;
        internal System.Windows.Forms.CheckBox DiscontinuedCheckBox;
        internal System.Windows.Forms.TextBox StockTextBox;
        internal System.Windows.Forms.TextBox PriceTextBox;
        internal System.Windows.Forms.TextBox QuantityTextBox;
        internal System.Windows.Forms.TextBox NameTextBox;
    }
}