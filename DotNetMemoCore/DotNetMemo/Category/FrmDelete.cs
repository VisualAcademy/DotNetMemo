//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;
////[0] ���ӽ����̽� ����
//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;

//namespace Category
//{
//	/// <summary>
//	/// FrmDelete�� ���� ��� �����Դϴ�.
//	/// </summary>
//	public class FrmDelete : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.Button btnDelete;
//		private System.Windows.Forms.TextBox txtCategoryID;
//		private System.Windows.Forms.Label label4;
//		/// <summary>
//		/// �ʼ� �����̳� �����Դϴ�.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmDelete()
//		{
//			//
//			// Windows Form �����̳� ������ �ʿ��մϴ�.
//			//
//			InitializeComponent();

//			//
//			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
//			//
//		}

//		/// <summary>
//		/// ��� ���� ��� ���ҽ��� �����մϴ�.
//		/// </summary>
//		protected override void Dispose( bool disposing )
//		{
//			if( disposing )
//			{
//				if(components != null)
//				{
//					components.Dispose();
//				}
//			}
//			base.Dispose( disposing );
//		}

//		#region Windows Form �����̳ʿ��� ������ �ڵ�
//		/// <summary>
//		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
//		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
//		/// </summary>
//		private void InitializeComponent()
//		{
//			this.btnDelete = new System.Windows.Forms.Button();
//			this.txtCategoryID = new System.Windows.Forms.TextBox();
//			this.label4 = new System.Windows.Forms.Label();
//			this.SuspendLayout();
//			// 
//			// btnDelete
//			// 
//			this.btnDelete.Location = new System.Drawing.Point(208, 24);
//			this.btnDelete.Name = "btnDelete";
//			this.btnDelete.TabIndex = 19;
//			this.btnDelete.Text = "����";
//			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
//			// 
//			// txtCategoryID
//			// 
//			this.txtCategoryID.Location = new System.Drawing.Point(96, 24);
//			this.txtCategoryID.Name = "txtCategoryID";
//			this.txtCategoryID.TabIndex = 18;
//			this.txtCategoryID.Text = "";
//			// 
//			// label4
//			// 
//			this.label4.Location = new System.Drawing.Point(8, 24);
//			this.label4.Name = "label4";
//			this.label4.TabIndex = 17;
//			this.label4.Text = "ī�װ���ȣ:";
//			// 
//			// FrmDelete
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(292, 77);
//			this.Controls.Add(this.btnDelete);
//			this.Controls.Add(this.txtCategoryID);
//			this.Controls.Add(this.label4);
//			this.Name = "FrmDelete";
//			this.Text = "FrmDelete";
//			this.ResumeLayout(false);

//		}
//		#endregion

//		private void btnDelete_Click(object sender, System.EventArgs e)
//		{
//			//[1] ���� �����
//			string strCategoryID = 
//				this.txtCategoryID.Text.Trim();
//			string strSql = "DeleteCategory";
//			//[2] Ŀ�ؼ�
//			SqlConnection objCon = new SqlConnection();
//			//objCon.ConnectionString = "server=(local);database=Category;uid=Category;pwd=Category;";
//			objCon.ConnectionString = 
//                ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
//            objCon.Open();
//			//[3] Ŀ���
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;
//			objCmd.CommandType = CommandType.StoredProcedure;
//			//[!] �Ķ���� 1�� �߰�
//			objCmd.Parameters.Add("@CategoryID", SqlDbType.Int);
//			objCmd.Parameters["@CategoryID"].Value = strCategoryID;
//			//[!] ����
//			int intResult = objCmd.ExecuteNonQuery();
//			if(intResult == 1)	
//			{
//				MessageBox.Show("�����Ǿ����ϴ�.");
//			}
//			objCon.Close();		
//		}
//	}
//}
