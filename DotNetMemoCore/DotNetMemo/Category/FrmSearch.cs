//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;
////
//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;

//namespace Category
//{
//	/// <summary>
//	/// FrmSearch�� ���� ��� �����Դϴ�.
//	/// </summary>
//	public class FrmSearch : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.ComboBox comSearchField;
//		private System.Windows.Forms.TextBox txtSearchQuery;
//		private System.Windows.Forms.Button btnSearch;
//		private System.Windows.Forms.DataGrid ctlSearchList;
//		/// <summary>
//		/// �ʼ� �����̳� �����Դϴ�.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmSearch()
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
//			this.comSearchField = new System.Windows.Forms.ComboBox();
//			this.txtSearchQuery = new System.Windows.Forms.TextBox();
//			this.btnSearch = new System.Windows.Forms.Button();
//			this.ctlSearchList = new System.Windows.Forms.DataGrid();
//			((System.ComponentModel.ISupportInitialize)(this.ctlSearchList)).BeginInit();
//			this.SuspendLayout();
//			// 
//			// comSearchField
//			// 
//			this.comSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//			this.comSearchField.Items.AddRange(new object[] {
//																												"CategoryName",
//																												"SuperCategory"});
//			this.comSearchField.Location = new System.Drawing.Point(16, 24);
//			this.comSearchField.Name = "comSearchField";
//			this.comSearchField.Size = new System.Drawing.Size(121, 20);
//			this.comSearchField.TabIndex = 0;
//			// 
//			// txtSearchQuery
//			// 
//			this.txtSearchQuery.Location = new System.Drawing.Point(160, 24);
//			this.txtSearchQuery.Name = "txtSearchQuery";
//			this.txtSearchQuery.TabIndex = 1;
//			this.txtSearchQuery.Text = "";
//			// 
//			// btnSearch
//			// 
//			this.btnSearch.Location = new System.Drawing.Point(296, 24);
//			this.btnSearch.Name = "btnSearch";
//			this.btnSearch.TabIndex = 2;
//			this.btnSearch.Text = "�˻�";
//			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
//			// 
//			// ctlSearchList
//			// 
//			this.ctlSearchList.DataMember = "";
//			this.ctlSearchList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
//			this.ctlSearchList.Location = new System.Drawing.Point(16, 64);
//			this.ctlSearchList.Name = "ctlSearchList";
//			this.ctlSearchList.Size = new System.Drawing.Size(352, 176);
//			this.ctlSearchList.TabIndex = 3;
//			// 
//			// FrmSearch
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(384, 253);
//			this.Controls.Add(this.ctlSearchList);
//			this.Controls.Add(this.btnSearch);
//			this.Controls.Add(this.txtSearchQuery);
//			this.Controls.Add(this.comSearchField);
//			this.Name = "FrmSearch";
//			this.Text = "FrmSearch";
//			((System.ComponentModel.ISupportInitialize)(this.ctlSearchList)).EndInit();
//			this.ResumeLayout(false);

//		}
//		#endregion

//		private void btnSearch_Click(object sender, System.EventArgs e)
//		{
//			//[1] ���� �����
//			string strSearchField = 
//				this.comSearchField.Text.Trim();
//			string strSearchQuery = 
//				this.txtSearchQuery.Text.Trim();
//			string strSql = "SearchCategory";
//			//[2] Ŀ�ؼ�
//			SqlConnection objCon = new SqlConnection();
//            //objCon.ConnectionString = "server=(local);database=Category;uid=Category;pwd=Category;";
//            objCon.ConnectionString =
//                ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
//            objCon.Open();
//			//[3] Ŀ���
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;
//			objCmd.CommandType = CommandType.StoredProcedure;
//			//[!] �Ķ���� 1�� �߰�
//			objCmd.Parameters.Add("@SearchField", SqlDbType.NVarChar, 50);
//			objCmd.Parameters["@SearchField"].Value = strSearchField;
//			objCmd.Parameters.Add("@SearchQuery", SqlDbType.NVarChar, 50);
//			objCmd.Parameters["@SearchQuery"].Value = strSearchQuery;
//			//[4] �����;����
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			//[5] �����ͼ�
//			DataSet objDs = new DataSet();
//			objDa.Fill(objDs, "Categories");
//			//[6] �����ͱ׸���
//			this.ctlSearchList.DataSource = 
//				objDs.Tables["Categories"].DefaultView;
//			//[7] �ݱ�
//			objCon.Close();
//		}
//	}
//}
