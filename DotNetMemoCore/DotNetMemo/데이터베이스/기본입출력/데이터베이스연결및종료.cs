//SqlConnection Ŭ���� : SQL Server�� ���� �� ����.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows
{
	public class �����ͺ��̽���������� : System.Windows.Forms.Form
	{
		#region +
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Button btnConnection;
		private System.ComponentModel.Container components = null;

		public �����ͺ��̽����������()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
		}

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

		#region Windows Form Designer generated code
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnConnection = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnConnection
			// 
			this.btnConnection.Location = new System.Drawing.Point(64, 88);
			this.btnConnection.Name = "btnConnection";
			this.btnConnection.Size = new System.Drawing.Size(168, 23);
			this.btnConnection.TabIndex = 0;
			this.btnConnection.Text = "�����ͺ��̽� ����";
			this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Location = new System.Drawing.Point(64, 40);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(168, 23);
			this.lblDisplay.TabIndex = 1;
			// 
			// �����ͺ��̽����������
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 141);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.lblDisplay,
																																	this.btnConnection});
			this.Name = "�����ͺ��̽����������";
			this.Text = "�����ͺ��̽����������";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		//SQL Server ���� �� ���� ����
		private void btnConnection_Click(object sender, System.EventArgs e)
		{
			//[1] SqlConnection Ŭ������ �ν��Ͻ� ����
			System.Data.SqlClient.SqlConnection objCon = 
				new System.Data.SqlClient.SqlConnection();
			//[2] ConnectionString �Ӽ� ����
			objCon.ConnectionString = 
				"server=(local);database=pubs;uid=sa;pwd=1234;";//4���� ����
			//[3] Open() �޼��� ���� : ����
			objCon.Open();
			//[4] State �Ӽ� : ConnectionState ������
			if(objCon.State == System.Data.ConnectionState.Open)
			{
				this.lblDisplay.Text = "�����ͺ��̽��� ����Ǿ����ϴ�.";
			}
			//[5] Close() �޼��� ���� : ����
      objCon.Close();
		}
	}
}
