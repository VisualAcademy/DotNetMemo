using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[0] ���ӽ����̽� ����
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Category
{
	/// <summary>
	/// FrmModify�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmModify : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnModify;
		private System.Windows.Forms.TextBox txtAlign;
		private System.Windows.Forms.TextBox txtSuperCategory;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.TextBox txtCategoryID;
		private System.Windows.Forms.Label label4;
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

		#region Windows Form �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnModify = new System.Windows.Forms.Button();
			this.txtAlign = new System.Windows.Forms.TextBox();
			this.txtSuperCategory = new System.Windows.Forms.TextBox();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnView = new System.Windows.Forms.Button();
			this.txtCategoryID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnModify
			// 
			this.btnModify.Location = new System.Drawing.Point(112, 160);
			this.btnModify.Name = "btnModify";
			this.btnModify.TabIndex = 13;
			this.btnModify.Text = "����";
			this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
			// 
			// txtAlign
			// 
			this.txtAlign.Location = new System.Drawing.Point(160, 120);
			this.txtAlign.Name = "txtAlign";
			this.txtAlign.TabIndex = 12;
			this.txtAlign.Text = "";
			// 
			// txtSuperCategory
			// 
			this.txtSuperCategory.Location = new System.Drawing.Point(160, 88);
			this.txtSuperCategory.Name = "txtSuperCategory";
			this.txtSuperCategory.TabIndex = 11;
			this.txtSuperCategory.Text = "";
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(160, 56);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.TabIndex = 10;
			this.txtCategoryName.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(40, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "���ļ���:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "�θ�ī�װ���ȣ:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(40, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "ī�װ���:";
			// 
			// btnView
			// 
			this.btnView.Location = new System.Drawing.Point(208, 16);
			this.btnView.Name = "btnView";
			this.btnView.TabIndex = 16;
			this.btnView.Text = "�󼼺���";
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// txtCategoryID
			// 
			this.txtCategoryID.Location = new System.Drawing.Point(96, 16);
			this.txtCategoryID.Name = "txtCategoryID";
			this.txtCategoryID.TabIndex = 15;
			this.txtCategoryID.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.TabIndex = 14;
			this.label4.Text = "ī�װ���ȣ:";
			// 
			// FrmModify
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 189);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.txtCategoryID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnModify);
			this.Controls.Add(this.txtAlign);
			this.Controls.Add(this.txtSuperCategory);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmModify";
			this.Text = "FrmModify";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnView_Click(object sender, System.EventArgs e)
		{
			//[1] ���� �����
			string strCategoryID = 
				this.txtCategoryID.Text.Trim();
			string strSql = "ViewCategory";
			//[2] Ŀ�ؼ�
			SqlConnection objCon = new SqlConnection();
            //objCon.ConnectionString = "server=(local);database=Category;uid=Category;pwd=Category;";
            objCon.ConnectionString =
                ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            objCon.Open();
			//[3] Ŀ���
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = strSql;
			objCmd.CommandType = CommandType.StoredProcedure;
			//[!] �Ķ���� 1�� �߰�
			objCmd.Parameters.Add("@CategoryID", SqlDbType.Int);
			objCmd.Parameters["@CategoryID"].Value = strCategoryID;
			//[4] �����͸���
			SqlDataReader objDr = 
				objCmd.ExecuteReader();
			//[!] ���ε�
			while(objDr.Read())
			{
				this.txtCategoryName.Text = 
					objDr["CategoryName"].ToString();
				this.txtSuperCategory.Text = 
					objDr["SuperCategory"].ToString();
				this.txtAlign.Text = 
					objDr["Align"].ToString();
			}
			//[5] �ݱ�
			objDr.Close();
			objCon.Close();
		}

		private void btnModify_Click(object sender, System.EventArgs e)
		{
			//[1] ���� �����
			string strCategoryID = 
				this.txtCategoryID.Text.Trim();
			string strCategoryName = 
				this.txtCategoryName.Text.Trim();
			string strSql = "ModifyCategory";
			//[2] Ŀ�ؼ�
			SqlConnection objCon = new SqlConnection();
            //objCon.ConnectionString = "server=(local);database=Category;uid=Category;pwd=Category;";
            objCon.ConnectionString =
                ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            objCon.Open();

			//[3] Ŀ���
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = strSql;
			objCmd.CommandType = CommandType.StoredProcedure;
			//[!] �Ķ���� 3�� �߰�
			objCmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar, 50);
			objCmd.Parameters["@CategoryName"].Value = strCategoryName;
			objCmd.Parameters.Add("@CategoryID", SqlDbType.Int);
			objCmd.Parameters["@CategoryID"].Value = strCategoryID;
			//[!] ExecuteNonQuery()
			objCmd.ExecuteNonQuery();
			MessageBox.Show("�����Ǿ����ϴ�.");
			//[4] �ݱ�
			objCon.Close();
		}
	}
}
