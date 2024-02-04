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
	/// �Է¿� ���� ��� �����Դϴ�.
	/// </summary>
	public class �Է� : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comEncoding;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtContent;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtHomePage;
		private System.Windows.Forms.Button btnWrite;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public �Է�()
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.comEncoding = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtContent = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnWrite = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.txtHomePage = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("����", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "�⺻���Խ��� �۾���";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "�̸�:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 71);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "�̸���:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 117);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "����:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 140);
			this.label5.Name = "label5";
			this.label5.TabIndex = 4;
			this.label5.Text = "����:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 163);
			this.label6.Name = "label6";
			this.label6.TabIndex = 5;
			this.label6.Text = "���ڵ�:";
			// 
			// comEncoding
			// 
			this.comEncoding.Items.AddRange(new object[] {
																																																	"Text",
																																																	"HTML",
																																																	"Mixed"});
			this.comEncoding.Location = new System.Drawing.Point(144, 165);
			this.comEncoding.Name = "comEncoding";
			this.comEncoding.Size = new System.Drawing.Size(100, 20);
			this.comEncoding.TabIndex = 6;
			this.comEncoding.Text = "Text";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 186);
			this.label7.Name = "label7";
			this.label7.TabIndex = 7;
			this.label7.Text = "��ȣ:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(144, 40);
			this.txtName.Name = "txtName";
			this.txtName.TabIndex = 8;
			this.txtName.Text = "";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(144, 65);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.TabIndex = 9;
			this.txtEmail.Text = "";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(144, 115);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.TabIndex = 10;
			this.txtTitle.Text = "";
			this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(144, 140);
			this.txtContent.Multiline = true;
			this.txtContent.Name = "txtContent";
			this.txtContent.TabIndex = 11;
			this.txtContent.Text = "";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(144, 189);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.TabIndex = 12;
			this.txtPassword.Text = "";
			// 
			// btnWrite
			// 
			this.btnWrite.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.btnWrite.Location = new System.Drawing.Point(40, 232);
			this.btnWrite.Name = "btnWrite";
			this.btnWrite.TabIndex = 13;
			this.btnWrite.Text = "����";
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.btnCancel.Location = new System.Drawing.Point(168, 232);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 14;
			this.btnCancel.Text = "�ٽþ���";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 94);
			this.label8.Name = "label8";
			this.label8.TabIndex = 15;
			this.label8.Text = "Ȩ������:";
			// 
			// txtHomePage
			// 
			this.txtHomePage.Location = new System.Drawing.Point(144, 90);
			this.txtHomePage.Name = "txtHomePage";
			this.txtHomePage.TabIndex = 16;
			this.txtHomePage.Text = "";
			// 
			// �Է�
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.txtHomePage);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnWrite);
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
			this.Name = "�Է�";
			this.Text = "�Է�";
			this.ResumeLayout(false);

		}
		#endregion

		//���� ��ư
		private void btnWrite_Click(object sender, System.EventArgs e)
		{
			#region //[1] ���������
			string strName = this.txtName.Text;
			string strEmail = this.txtEmail.Text;
			string strHomePage = this.txtHomePage.Text;
			string strTitle = txtTitle.Text;
			string strContent = txtContent.Text;
			string strEncoding = comEncoding.SelectedText;
			string strPassword = txtPassword.Text;
			string strSql = "WriteBasic";//�������ν���
			#endregion
			#region //[2] Ŀ�ؼ�
			SqlConnection objCon = new SqlConnection();
			objCon.ConnectionString = "server=(local);database=Basic;uid=Basic;pwd=Basic;";
			objCon.Open();
			#endregion
			#region //[3] Ŀ���
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = strSql;
			objCmd.CommandType =CommandType.StoredProcedure;
			
			#region //[!]�Ķ���� �߰�
			objCmd.Parameters.Add("@Name", SqlDbType.VarChar, 25);
			objCmd.Parameters["@Name"].Value = strName;
			objCmd.Parameters.Add("@Email", SqlDbType.VarChar, 50);
			objCmd.Parameters["@Email"].Value = strEmail;
			objCmd.Parameters.Add("@Title", SqlDbType.VarChar, 150);
			objCmd.Parameters["@Title"].Value = strTitle;
			objCmd.Parameters.Add("@PostIP", SqlDbType.VarChar, 10);
			objCmd.Parameters["@PostIP"].Value = "127.0.0.1";
			objCmd.Parameters.Add("@Content", SqlDbType.Text);
			objCmd.Parameters["@Content"].Value = strContent;
			objCmd.Parameters.Add("@Password", SqlDbType.VarChar, 20);
			objCmd.Parameters["@Password"].Value = strPassword;
			objCmd.Parameters.Add("@Encoding", SqlDbType.VarChar, 10);
			objCmd.Parameters["@Encoding"].Value = strEncoding;
			objCmd.Parameters.Add("@HomePage", SqlDbType.VarChar, 100);
			objCmd.Parameters["@HomePage"].Value = strHomePage;
			#endregion

			objCmd.ExecuteNonQuery();
			#endregion
			//[4] �ݱ�
			objCon.Close();
			//[5] ����
		}
	}
}
