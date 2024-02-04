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
	/// FrmWrite�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmWrite : System.Windows.Forms.Form
	{
		#region Controls
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.TextBox txtSuperCategory;
		private System.Windows.Forms.TextBox txtAlign;
		private System.Windows.Forms.Button btnWrite;
		#endregion

		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.txtSuperCategory = new System.Windows.Forms.TextBox();
			this.txtAlign = new System.Windows.Forms.TextBox();
			this.btnWrite = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "ī�װ���:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "�θ�ī�װ���ȣ:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "���ļ���:";
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(152, 32);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.TabIndex = 3;
			this.txtCategoryName.Text = "";
			// 
			// txtSuperCategory
			// 
			this.txtSuperCategory.Location = new System.Drawing.Point(152, 64);
			this.txtSuperCategory.Name = "txtSuperCategory";
			this.txtSuperCategory.TabIndex = 4;
			this.txtSuperCategory.Text = "";
			// 
			// txtAlign
			// 
			this.txtAlign.Location = new System.Drawing.Point(152, 96);
			this.txtAlign.Name = "txtAlign";
			this.txtAlign.TabIndex = 5;
			this.txtAlign.Text = "";
			// 
			// btnWrite
			// 
			this.btnWrite.Location = new System.Drawing.Point(104, 136);
			this.btnWrite.Name = "btnWrite";
			this.btnWrite.TabIndex = 6;
			this.btnWrite.Text = "����";
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			// 
			// FrmWrite
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 173);
			this.Controls.Add(this.btnWrite);
			this.Controls.Add(this.txtAlign);
			this.Controls.Add(this.txtSuperCategory);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmWrite";
			this.Text = "FrmWrite";
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void btnWrite_Click(object sender, System.EventArgs e)
		{
			//[1] ���� �����
			string strCategoryName = 
				this.txtCategoryName.Text.Trim();
			string strSuperCategory = 
				this.txtSuperCategory.Text.Trim();
			string strAlign = 
				this.txtAlign.Text.Trim();
			string strSql = "WriteCategory";
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
			objCmd.Parameters.Add("@SuperCategory", SqlDbType.Int);
			objCmd.Parameters["@SuperCategory"].Value = strSuperCategory;
			objCmd.Parameters.Add("@Align", SqlDbType.SmallInt);
			objCmd.Parameters["@Align"].Value = strAlign;

			//[!] ExecuteNonQuery()
			objCmd.ExecuteNonQuery();
			MessageBox.Show("����Ǿ����ϴ�.");

			//[4] �ݱ�
			objCon.Close();
		}
		#endregion
	}
}
