using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.�������������̾�α�
{
	public class FrmFolderBrowserDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		#region +
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmFolderBrowserDialog()
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
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			// 
			// FrmFolderBrowserDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 69);
			this.Name = "FrmFolderBrowserDialog";
			this.Text = "FrmFolderBrowserDialog";
			this.Load += new System.EventHandler(this.FrmFolderBrowserDialog_Load);

		}
		#endregion
		#endregion
		private void FrmFolderBrowserDialog_Load(object sender, System.EventArgs e)
		{
			this.folderBrowserDialog1.ShowDialog();
			MessageBox.Show(folderBrowserDialog1.SelectedPath);
		}
	}
}
