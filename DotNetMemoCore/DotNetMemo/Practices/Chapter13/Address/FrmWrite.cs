using System;
using System.Data; //
using System.Data.SqlClient; //
using System.Configuration;

namespace AddressApplication
{
    /// <summary>
    /// FrmWrite : �ּҷ� ������ ����
    /// </summary>
    public class FrmWrite : System.Windows.Forms.Form
	{
		#region Controls
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtMobile;
		private System.Windows.Forms.TextBox txtZipCode;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Button btnWrite;
		private System.Windows.Forms.Button btnClear;
		#endregion

		#region Private Members
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		#region Constructors
		public FrmWrite()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
		}
		#endregion

		#region Protected Methods
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtMobile = new System.Windows.Forms.TextBox();
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.btnWrite = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "�̸�:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "�̸���:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 64);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "��ȭ��ȣ:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 80);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "�޴�����ȣ:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 104);
			this.label5.Name = "label5";
			this.label5.TabIndex = 4;
			this.label5.Text = "�����ȣ:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 128);
			this.label6.Name = "label6";
			this.label6.TabIndex = 5;
			this.label6.Text = "�ּ�:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(120, 16);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(176, 21);
			this.txtName.TabIndex = 6;
			this.txtName.Text = "";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(120, 37);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(176, 21);
			this.txtEmail.TabIndex = 7;
			this.txtEmail.Text = "";
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(120, 58);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(176, 21);
			this.txtPhone.TabIndex = 8;
			this.txtPhone.Text = "";
			// 
			// txtMobile
			// 
			this.txtMobile.Location = new System.Drawing.Point(120, 79);
			this.txtMobile.Name = "txtMobile";
			this.txtMobile.Size = new System.Drawing.Size(176, 21);
			this.txtMobile.TabIndex = 9;
			this.txtMobile.Text = "";
			// 
			// txtZipCode
			// 
			this.txtZipCode.Location = new System.Drawing.Point(120, 100);
			this.txtZipCode.Name = "txtZipCode";
			this.txtZipCode.Size = new System.Drawing.Size(176, 21);
			this.txtZipCode.TabIndex = 10;
			this.txtZipCode.Text = "";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(120, 121);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(176, 21);
			this.txtAddress.TabIndex = 11;
			this.txtAddress.Text = "";
			// 
			// btnWrite
			// 
			this.btnWrite.Location = new System.Drawing.Point(80, 168);
			this.btnWrite.Name = "btnWrite";
			this.btnWrite.TabIndex = 12;
			this.btnWrite.Text = "����";
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(192, 168);
			this.btnClear.Name = "btnClear";
			this.btnClear.TabIndex = 13;
			this.btnClear.Text = "�ٽþ���";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// FrmWrite
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(328, 205);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnWrite);
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
			this.Name = "FrmWrite";
			this.Text = "�Է�";
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void btnWrite_Click(object sender, System.EventArgs e)
		{
			//[1] ���� �����
			string strName = 
				this.txtName.Text.Trim();
			string strEmail = this.txtEmail.Text;
			string strPhone = this.txtPhone.Text;
			string strMobile = txtMobile.Text;
			string strZipCode = txtZipCode.Text;
			string strAddress = txtAddress.Text;
			string strSql = String.Empty;
			strSql = "WriteAddress";//�������ν�����
			#region SQL Parameter ���
//			strSql = @"
//				Insert Address
//				Values
//				(
//					@Name,
//					@Email,
//					@Phone,
//					@Mobile,
//					@ZipCode,
//					@Address,
//					GetDate()
//				)
//			";
			#endregion
			#region Inline SQL
//			//ȫ�浿 -> " + �ش纯�� + "
//			strSql = "Insert Address Values('" 
//				+ strName + "','" + strEmail 
//				+ "','" + strPhone + "','" 
//				+ strMobile + "','" + strZipCode 
//				+ "','" + strAddress 
//				+ "',GetDate())";
			#endregion
			#region �Է� ���ù�
//			strSql = @"
//				Insert Address
//				Values('ȫ�浿','h@h.com',
//					'114','119',
//					'123-445','����',
//					GetDate())
//			";
			#endregion
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
			//[!] ����
			objCmd.ExecuteNonQuery();
			//[4] ������
			this.btnClear_Click(null, null);
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			this.txtName.Text = "";
			this.txtEmail.Clear();
			this.txtPhone.Text = String.Empty;

			this.txtMobile.Clear();
			this.txtZipCode.Text = "";
			this.txtAddress.Text = "";
		}
		#endregion
	}
}
