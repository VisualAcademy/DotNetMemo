using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AddressApplication
{
    /// <summary>
    /// FrmModify�� ���� ��� �����Դϴ�.
    /// </summary>
    public class FrmModify : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnModify;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtZipCode;
		private System.Windows.Forms.TextBox txtMobile;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Button btnLoad;

        #region +
        /// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmModify()
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
        #endregion

        #region Windows Form �����̳ʿ��� ������ �ڵ�
        /// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnClear = new System.Windows.Forms.Button();
			this.btnModify = new System.Windows.Forms.Button();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.txtMobile = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.btnLoad = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(216, 216);
			this.btnClear.Name = "btnClear";
			this.btnClear.TabIndex = 27;
			this.btnClear.Text = "�ٽþ���";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnModify
			// 
			this.btnModify.Location = new System.Drawing.Point(104, 216);
			this.btnModify.Name = "btnModify";
			this.btnModify.TabIndex = 26;
			this.btnModify.Text = "������Ʈ";
			this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(144, 168);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(176, 21);
			this.txtAddress.TabIndex = 25;
			this.txtAddress.Text = "";
			// 
			// txtZipCode
			// 
			this.txtZipCode.Location = new System.Drawing.Point(144, 144);
			this.txtZipCode.Name = "txtZipCode";
			this.txtZipCode.Size = new System.Drawing.Size(176, 21);
			this.txtZipCode.TabIndex = 24;
			this.txtZipCode.Text = "";
			// 
			// txtMobile
			// 
			this.txtMobile.Location = new System.Drawing.Point(144, 128);
			this.txtMobile.Name = "txtMobile";
			this.txtMobile.Size = new System.Drawing.Size(176, 21);
			this.txtMobile.TabIndex = 23;
			this.txtMobile.Text = "";
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(144, 104);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(176, 21);
			this.txtPhone.TabIndex = 22;
			this.txtPhone.Text = "";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(144, 80);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(176, 21);
			this.txtEmail.TabIndex = 21;
			this.txtEmail.Text = "";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(144, 64);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(176, 21);
			this.txtName.TabIndex = 20;
			this.txtName.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(40, 176);
			this.label6.Name = "label6";
			this.label6.TabIndex = 19;
			this.label6.Text = "�ּ�:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(40, 152);
			this.label5.Name = "label5";
			this.label5.TabIndex = 18;
			this.label5.Text = "�����ȣ:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(40, 128);
			this.label4.Name = "label4";
			this.label4.TabIndex = 17;
			this.label4.Text = "�޴�����ȣ:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(40, 112);
			this.label3.Name = "label3";
			this.label3.TabIndex = 16;
			this.label3.Text = "��ȭ��ȣ:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(40, 88);
			this.label2.Name = "label2";
			this.label2.TabIndex = 15;
			this.label2.Text = "�̸���:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(40, 64);
			this.label1.Name = "label1";
			this.label1.TabIndex = 14;
			this.label1.Text = "�̸�:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(48, 32);
			this.label7.Name = "label7";
			this.label7.TabIndex = 28;
			this.label7.Text = "��ȣ:";
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(136, 32);
			this.txtNum.Name = "txtNum";
			this.txtNum.TabIndex = 29;
			this.txtNum.Text = "";
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(248, 32);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.TabIndex = 30;
			this.btnLoad.Text = "�ε�";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// FrmModify
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(384, 269);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnModify);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtZipCode);
			this.Controls.Add(this.txtMobile);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmModify";
			this.Text = "����";
			this.ResumeLayout(false);

		}
		#endregion

		// FrmView.btnView
		private void btnLoad_Click(object sender, System.EventArgs e)
		{
			//[1] ���� �����
			string strNum = txtNum.Text.Trim();
			string strSql = "ViewAddress";
			//[2] Ŀ�ؼ�
			SqlConnection objCon = new SqlConnection();
            objCon.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            objCon.Open();
			//[3] Ŀ���
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = strSql;
			objCmd.CommandType = 
				CommandType.StoredProcedure;
			//[!] �Ķ���� �߰�
			objCmd.Parameters.Add("@Num", SqlDbType.Int);
			objCmd.Parameters["@Num"].Value = strNum;
			//[4] �����͸���
			SqlDataReader objDr = 
				objCmd.ExecuteReader();
			//[5] ���
			if (objDr.Read())
			{
				#region Data Bindings
				this.txtNum.Text = 
					objDr["Num"].ToString();//��ȣ
				this.txtName.Text = 
					objDr["Name"].ToString();//�̸�
				this.txtEmail.Text = 
					objDr["Email"].ToString();
				this.txtPhone.Text = 
					objDr["Phone"].ToString();
				this.txtMobile.Text = //[1]�ʵ��
					objDr["Mobile"].ToString();
				this.txtZipCode.Text = 
					objDr[5].ToString();//[2]����
				this.txtAddress.Text = 
					objDr.GetString(6);//[3]Get???()
				#endregion
			}
			else
			{
				MessageBox.Show("�ش� ������ ����");
			}
			//[6] ����
			objDr.Close();//
			objCon.Close();

		}

		// FrmWrite.btnWrite
		private void btnModify_Click(object sender, System.EventArgs e)
		{
			//[1] ���� �����
			string strNum = txtNum.Text;//
			string strName = 
				this.txtName.Text.Trim();
			string strEmail = this.txtEmail.Text;
			string strPhone = this.txtPhone.Text;
			string strMobile = txtMobile.Text;
			string strZipCode = txtZipCode.Text;
			string strAddress = txtAddress.Text;
			string strSql = String.Empty;
			strSql = "ModifyAddress";//�������ν�����
			//[2] Ŀ�ؼ�
			SqlConnection objCon = new SqlConnection();
            objCon.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            objCon.Open();
			//[3] Ŀ���
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = strSql;
			objCmd.CommandType = //CommandType.Text;
				CommandType.StoredProcedure;
			//[!] �Ķ���� �߰� : SQL SP/Paramter���
			objCmd.Parameters.Add(
				"@Name", SqlDbType.VarChar, 25);
			objCmd.Parameters["@Name"].Value = 
				strName;
			objCmd.Parameters.Add(
				"@Email", SqlDbType.VarChar, 100);
			objCmd.Parameters["@Email"].Value = 
				strEmail;
			objCmd.Parameters.Add(
				"@Phone", SqlDbType.VarChar, 15);
			objCmd.Parameters["@Phone"].Value = 
				strPhone;
			objCmd.Parameters.Add(
				"@Mobile", SqlDbType.VarChar, 15);
			objCmd.Parameters["@Mobile"].Value = 
				strMobile;
			objCmd.Parameters.Add(
				"@ZipCode", SqlDbType.VarChar, 7);
			objCmd.Parameters["@ZipCode"].Value = 
				strZipCode;
			objCmd.Parameters.Add(
				"@Address", SqlDbType.VarChar, 150);
			objCmd.Parameters["@Address"].Value = 
				strAddress;
			objCmd.Parameters.Add(
				"@Num", SqlDbType.Int);
			objCmd.Parameters["@Num"].Value = strNum;
			//[!] ����
			objCmd.ExecuteNonQuery();
			//[4] ������
			this.btnClear_Click(null, null);
		}

		// FrmWrite.btnClear
		private void btnClear_Click(object sender, System.EventArgs e)
		{
			this.txtNum.Text = "";
			this.txtName.Text = "";
			this.txtEmail.Clear();
			this.txtPhone.Text = String.Empty;
			this.txtMobile.Clear();
			this.txtZipCode.Text = "";
			this.txtAddress.Text = "";
		}
	}
}

