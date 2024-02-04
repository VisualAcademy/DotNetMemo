using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.�������¾����̾�α�
{
	public class FrmPageSetupDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		#region +
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmPageSetupDialog()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
		}

		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(88, 152);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "������ ����";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(0, 0);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(288, 136);
			this.listBox1.TabIndex = 1;
			// 
			// FrmPageSetupDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 190);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button1);
			this.Name = "FrmPageSetupDialog";
			this.Text = "FrmPageSetupDialog";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		//This method displays a PageSetupDialog object. If the
		// user clicks OK in the dialog, selected results of
		// the dialog are displayed in ListBox1.
		private void button1_Click(System.Object sender, System.EventArgs e)
		{                 
			// Initialize the dialog's PrinterSettings property to hold user
			// defined printer settings.
			pageSetupDialog1.PageSettings = 
				new System.Drawing.Printing.PageSettings();

			// Initialize dialog's PrinterSettings property to hold user
			// set printer settings.
			pageSetupDialog1.PrinterSettings = 
				new System.Drawing.Printing.PrinterSettings();

			//Do not show the network in the printer dialog.
			pageSetupDialog1.ShowNetwork = false;

			//Show the dialog storing the result.
			DialogResult result = pageSetupDialog1.ShowDialog();

			// If the result is OK, display selected settings in
			// ListBox1. These values can be used when printing the
			// document.
			if ( result == DialogResult.OK)
			{
				object[] results = new object[]{ 
					pageSetupDialog1.PageSettings.Margins, 
					pageSetupDialog1.PageSettings.PaperSize, 
					pageSetupDialog1.PageSettings.Landscape, 
					pageSetupDialog1.PrinterSettings.PrinterName, 
					pageSetupDialog1.PrinterSettings.PrintRange};
				listBox1.Items.AddRange(results);
			}
		}    
	}
}
