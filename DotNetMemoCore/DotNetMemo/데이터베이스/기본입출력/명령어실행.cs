using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//
using System.Data;
using System.Data.SqlClient;

namespace CSharp_Database
{
	public class ��ɾ���� : System.Windows.Forms.Form
	{
		#region +
		private System.Windows.Forms.Button btnCommand;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ��ɾ����()
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

		#region Windows Form Designer generated code
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCommand = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCommand
			// 
			this.btnCommand.Location = new System.Drawing.Point(72, 32);
			this.btnCommand.Name = "btnCommand";
			this.btnCommand.Size = new System.Drawing.Size(240, 23);
			this.btnCommand.TabIndex = 0;
			this.btnCommand.Text = "tempdb�� ���̺� ����";
			this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
			// 
			// ��ɾ����
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(376, 93);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.btnCommand});
			this.Name = "��ɾ����";
			this.Text = "��ɾ����";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void btnCommand_Click(object sender, System.EventArgs e)
		{
			SqlConnection objCon = new SqlConnection();
			objCon.ConnectionString = 
				"server=(local);database=tempdb;uid=sa;pwd=pass;";//4���� ����
			objCon.Open();

			//[1] SqlCommand Ŭ������ �ν��Ͻ� ����
			SqlCommand objCmd = new SqlCommand();
			//[2] Connectin �Ӽ� : � Ŀ�ؼ�(objCon)�� ����Ұ���
			objCmd.Connection = objCon;
			//[3] CommandText �Ӽ� : � ��ɾ�(SQL��)�� �����Ұ���
			objCmd.CommandText = 
				"Create Table dbo.Test(Num Int, Name VarChar(10))";
			//[4] CommandType �Ӽ� : ��ɾ � Ÿ������(SQL, SP)
			objCmd.CommandType = CommandType.Text;//�Ϲ� SQL��
			//[5] ExecuteNonQuery() �޼��� : ��ȯ���� ���� ��� ����
			objCmd.ExecuteNonQuery();
      
			objCon.Close();
		}
	}
}
