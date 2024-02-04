using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[0] ���ӽ����̽� �߰�
using System.Data;
using System.Data.SqlClient;

namespace CSharp_Windows.�⺻���Խ���
{
	/// <summary>
	/// ������ ���� ��� �����Դϴ�.
	/// </summary>
	public class ���� : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtHomePage;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtContent;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comEncoding;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnModify;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Button btnView;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ����()
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
			this.txtHomePage = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnModify = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtContent = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.comEncoding = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.btnView = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtHomePage
			// 
			this.txtHomePage.Location = new System.Drawing.Point(144, 112);
			this.txtHomePage.Name = "txtHomePage";
			this.txtHomePage.TabIndex = 33;
			this.txtHomePage.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 120);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 16);
			this.label8.TabIndex = 32;
			this.label8.Text = "Ȩ������:";
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.btnCancel.Location = new System.Drawing.Point(168, 241);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 31;
			this.btnCancel.Text = "�ٽþ���";
			// 
			// btnModify
			// 
			this.btnModify.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.btnModify.Location = new System.Drawing.Point(40, 241);
			this.btnModify.Name = "btnModify";
			this.btnModify.TabIndex = 30;
			this.btnModify.Text = "����";
			this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(144, 208);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.TabIndex = 29;
			this.txtPassword.Text = "";
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(144, 160);
			this.txtContent.Multiline = true;
			this.txtContent.Name = "txtContent";
			this.txtContent.TabIndex = 28;
			this.txtContent.Text = "";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(144, 136);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.TabIndex = 27;
			this.txtTitle.Text = "";
			this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(144, 88);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.TabIndex = 26;
			this.txtEmail.Text = "";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(144, 64);
			this.txtName.Name = "txtName";
			this.txtName.TabIndex = 25;
			this.txtName.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 208);
			this.label7.Name = "label7";
			this.label7.TabIndex = 24;
			this.label7.Text = "��ȣ:";
			// 
			// comEncoding
			// 
			this.comEncoding.Items.AddRange(new object[] {
																																																	"Text",
																																																	"HTML",
																																																	"Mixed"});
			this.comEncoding.Location = new System.Drawing.Point(144, 184);
			this.comEncoding.Name = "comEncoding";
			this.comEncoding.Size = new System.Drawing.Size(100, 20);
			this.comEncoding.TabIndex = 23;
			this.comEncoding.Text = "Text";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 184);
			this.label6.Name = "label6";
			this.label6.TabIndex = 22;
			this.label6.Text = "���ڵ�:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 21;
			this.label5.Text = "����:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 136);
			this.label4.Name = "label4";
			this.label4.TabIndex = 20;
			this.label4.Text = "����:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 96);
			this.label3.Name = "label3";
			this.label3.TabIndex = 19;
			this.label3.Text = "�̸���:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 72);
			this.label2.Name = "label2";
			this.label2.TabIndex = 18;
			this.label2.Text = "�̸�:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("����", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 32);
			this.label1.TabIndex = 17;
			this.label1.Text = "�⺻���Խ��� �ۼ���";
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(64, 40);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(48, 21);
			this.txtNum.TabIndex = 34;
			this.txtNum.Text = "";
			// 
			// btnView
			// 
			this.btnView.Location = new System.Drawing.Point(120, 40);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(160, 23);
			this.btnView.TabIndex = 35;
			this.btnView.Text = "������ �� ��������";
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(16, 48);
			this.label9.Name = "label9";
			this.label9.TabIndex = 36;
			this.label9.Text = "��ȣ:";
			// 
			// ����
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.txtHomePage);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnModify);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtContent);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comEncoding);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label9);
			this.Name = "����";
			this.Text = "����";
			this.ResumeLayout(false);

		}
		#endregion
		//������ �� �������� : Select : Inline
		private void btnView_Click(object sender, System.EventArgs e)
		{
			//[1] ����
			string strNum = this.txtNum.Text;//��ȣ
			string strSql = //�ζ��� SQL��
				"Select * From Basic Where Num = " + strNum;
			//[2] ����
			SqlConnection objCon = new SqlConnection();
			objCon.ConnectionString = "server=(local);database=Basic;pwd=Basic;uid=Basic;";
			objCon.Open();
			//[3] ��ɾ�
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = strSql;
			objCmd.CommandType =CommandType.Text;
			//[4] ���
			SqlDataReader objDr = objCmd.ExecuteReader();
			while(objDr.Read())	//���ǿ� �´� �����͸� ���ε�
			{
				this.txtName.Text = objDr["Name"].ToString();
				this.txtEmail.Text = objDr["Email"].ToString();
				txtHomePage.Text = 
					objDr["HomePage"].ToString();
				txtTitle.Text = objDr["Title"].ToString();
				txtContent.Text = objDr["Content"].ToString();
				comEncoding.Text =objDr["Encoding"].ToString();
				txtPassword.Text =objDr["Password"].ToString();
			}
			objDr.Close();
			//[5] �ݱ�/����
			objCon.Close();
		}
		//���� ��ư : Update : SP
		private void btnModify_Click(object sender, System.EventArgs e)
		{
			//[1] ����
			#region ���� �����
			string strNum = this.txtNum.Text;//��ȣ
			string strName = this.txtName.Text;
			string strEmail = this.txtEmail.Text;
			string strHomePage = txtHomePage.Text;
			string strTitle = txtTitle.Text;
			string strContent = txtContent.Text;
			string strEncoding = comEncoding.Text;
			string strPassword = txtPassword.Text;
			string strSql = "ModifyBasic";//�������ν���
			#endregion
			//[2] ����
			SqlConnection objCon = new SqlConnection();
			objCon.ConnectionString = "server=(local);database=Basic;pwd=Basic;uid=Basic;";
			objCon.Open();
			//[3] ��ɾ�
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = strSql;
			objCmd.CommandType =CommandType.StoredProcedure;
			//[!] �Ķ���� �߰�
			#region �ĸ����� �߰�
			objCmd.Parameters.Add("@Name", SqlDbType.VarChar, 25);
			objCmd.Parameters["@Name"].Value = strName;
			objCmd.Parameters.Add("@Email", SqlDbType.VarChar, 50);
			objCmd.Parameters["@Email"].Value = strEmail;
			objCmd.Parameters.Add("@HomePage", SqlDbType.VarChar, 100);
			objCmd.Parameters["@HomePage"].Value = strHomePage;			
			objCmd.Parameters.Add("@Title", SqlDbType.VarChar, 150);
			objCmd.Parameters["@Title"].Value = strTitle;
			objCmd.Parameters.Add("@Content", SqlDbType.Text);
			objCmd.Parameters["@Content"].Value = strContent;
			objCmd.Parameters.Add("@Encoding", SqlDbType.VarChar, 10);
			objCmd.Parameters["@Encoding"].Value = strEncoding;
			objCmd.Parameters.Add("@Password", SqlDbType.VarChar, 20);
			objCmd.Parameters["@Password"].Value = strPassword;
			objCmd.Parameters.Add("@Num", SqlDbType.Int);
			objCmd.Parameters["@Num"].Value = strNum;
			#endregion			
			objCmd.ExecuteNonQuery();
			//[5] �ݱ�/����			
			objCon.Close();
		}
	}
}
