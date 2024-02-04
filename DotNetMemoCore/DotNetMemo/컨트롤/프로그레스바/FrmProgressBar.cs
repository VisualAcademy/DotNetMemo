using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.���α׷�����
{
	/// <summary>
	/// FrmProgressBar�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmProgressBar : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button btnCommand;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmProgressBar()
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
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnCommand = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(56, 40);
			this.progressBar1.Maximum = 1000000;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(200, 23);
			this.progressBar1.TabIndex = 0;
			// 
			// btnCommand
			// 
			this.btnCommand.Location = new System.Drawing.Point(56, 104);
			this.btnCommand.Name = "btnCommand";
			this.btnCommand.Size = new System.Drawing.Size(200, 23);
			this.btnCommand.TabIndex = 1;
			this.btnCommand.Text = "���� �ɸ��� �۾� ����";
			this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
			// 
			// FrmProgressBar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 173);
			this.Controls.Add(this.btnCommand);
			this.Controls.Add(this.progressBar1);
			this.Name = "FrmProgressBar";
			this.Text = "FrmProgressBar";
			this.ResumeLayout(false);

		}
		#endregion

		// ���� �ɸ��� �۾� ���� �̺�Ʈ �ڵ鷯
		private void btnCommand_Click(object sender, System.EventArgs e)
		{
			for(int i = 1;i <= 1000000;i++)
			{
				//this.progressBar1.Value = i;
				this.progressBar1.Increment(10);
			}
		}
	}
}
