using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[0] 
using System.Data;
using System.Data.SqlClient;

namespace CSharp_Database{
	public class �������о���� : System.Windows.Forms.Form{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRead;
		#region +
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public �������о����()
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnRead = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(360, 264);
			this.label1.TabIndex = 0;
			// 
			// btnRead
			// 
			this.btnRead.Location = new System.Drawing.Point(64, 304);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(248, 23);
			this.btnRead.TabIndex = 1;
			this.btnRead.Text = "������ �о����";
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// �������о����
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(384, 341);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.btnRead,
																																	this.label1});
			this.Name = "�������о����";
			this.Text = "�������о����";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void btnRead_Click(object sender, System.EventArgs e){
			SqlConnection objCon = new SqlConnection();
			objCon.ConnectionString = 
				"server=(local);database=Web;uid=Web;pwd=Web;";
			objCon.Open();
				
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = "Select * From Memo";
			objCmd.CommandType = CommandType.Text;

			//[1] ��ȯ���� �ִ� ���(Select��) : ExecuteReader()
			SqlDataReader objDr;//����
			objDr = objCmd.ExecuteReader();//��ȯ
			//[2] Read() �޼��带 ��� �ݺ�
			string strMsg = "";
			while(objDr.Read())
			{
				//[3] ���
				strMsg += "��ȣ : " + objDr["Num"] + "\t\t";	//�ʵ�� ���
				strMsg += "�̸� : " + objDr[1] + "\t\t\n";			//���� ���
				strMsg += "�޸� : " + objDr.GetString(3) + "\t\t";//�޼��� ���
				strMsg += "�ۼ��� : " + objDr.GetDateTime(4) + "\t\t\n";
			}
			this.label1.Text = strMsg;
			//[4] Close() �޼���� ���� Ŭ���� ����
			objDr.Close();

			objCon.Close();
		}
	}
}
