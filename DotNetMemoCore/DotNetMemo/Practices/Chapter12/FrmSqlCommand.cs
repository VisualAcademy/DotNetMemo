using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[0] 
using System.Data; // 
using System.Data.SqlClient; // 

namespace AddressApplication.ADONET
{
	/// <summary>
	/// FrmSqlCommand�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmSqlCommand : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnDrop;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmSqlCommand()
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
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnDrop = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(56, 16);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(224, 23);
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "���̺� ����";
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnDrop
			// 
			this.btnDrop.Location = new System.Drawing.Point(56, 56);
			this.btnDrop.Name = "btnDrop";
			this.btnDrop.Size = new System.Drawing.Size(224, 23);
			this.btnDrop.TabIndex = 1;
			this.btnDrop.Text = "���̺� ����";
			this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
			// 
			// FrmSqlCommand
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(376, 93);
			this.Controls.Add(this.btnDrop);
			this.Controls.Add(this.btnCreate);
			this.Name = "FrmSqlCommand";
			this.Text = "SqlCommand Ŭ���� : SQL Server�� ��ɾ� ����";
			this.ResumeLayout(false);

		}
		#endregion

		// ���̺� ����
		private void btnCreate_Click(object sender, System.EventArgs e)
		{
			SqlConnection objCon = 
				new SqlConnection(); 
			objCon.ConnectionString = 
				"server=(local);database=AddressDB;" + 
				"uid=AddressUid;pwd=AddressPwd;";
			objCon.Open();
			//[1] SqlCommand Ŭ������ �ν��Ͻ� ����
			SqlCommand objCmd = new SqlCommand();
			//[2] .Connection �Ӽ� ���� : Ŀ�ؼ� ��ü
      objCmd.Connection = objCon;
			//[3] .CommandText �Ӽ� : ������ ��ɾ�
			objCmd.CommandText = @"
				Create Table dbo.Test
				(Num Int Identity, Name VarChar(25))
			";
			//[4] .CommandType �Ӽ� : CommandType ������			
      objCmd.CommandType = 
				CommandType.Text; // �Ϲ� SQL��
			//[5] .Execute???() �޼��� : ����
			objCmd.ExecuteNonQuery();//!Select
			objCon.Close();
		}

		// ���̺� ����
		private void btnDrop_Click(object sender, System.EventArgs e)
		{
			SqlConnection objCon = 
				new SqlConnection(
					@"Data Source=(local);
						Initial Catalog=AddressDB;
						User ID=AddressUid;
						Password=AddressPwd;");
			objCon.Open();
			//[1] Ŀ��� Ŭ����
			SqlCommand objCmd = new SqlCommand();
			//[2] Ŀ�ؼ� �Ӽ�
			objCmd.Connection = objCon;
			//[3] Ŀ��� �ؽ�Ʈ �Ӽ�
			objCmd.CommandText = 
				"Drop Table dbo.Test";
      //[4] Ŀ��� Ÿ�� �Ӽ�
			objCmd.CommandType = CommandType.Text;
			//[5] ����
			objCmd.ExecuteNonQuery();
			objCon.Close();
		}
	}
}
