using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmFolderBrowserDialog�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmFolderBrowserDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button btnFind;
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
			this.btnFind = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(104, 40);
			this.btnFind.Name = "btnFind";
			this.btnFind.TabIndex = 0;
			this.btnFind.Text = "ã�ƺ���...";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// FrmFolderBrowserDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(280, 109);
			this.Controls.Add(this.btnFind);
			this.Name = "FrmFolderBrowserDialog";
			this.Text = "FrmFolderBrowserDialog";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnFind_Click(object sender, System.EventArgs e)
		{
			
			if(this.folderBrowserDialog1.ShowDialog() ==
				DialogResult.OK)
			{
				// ���õ� ��� ���
				MessageBox.Show(
					this.folderBrowserDialog1.SelectedPath);
			}
		}
	}
}
