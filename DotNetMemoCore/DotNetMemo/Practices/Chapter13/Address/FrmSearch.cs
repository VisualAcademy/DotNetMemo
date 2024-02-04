//using System;
//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;

//namespace AddressApplication
//{
//    /// <summary>
//    /// FrmSearch�� ���� ��� �����Դϴ�.
//    /// </summary>
//    public class FrmSearch : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.ComboBox comSearchField;
//		private System.Windows.Forms.TextBox txtSearchQuery;
//		private System.Windows.Forms.Button btnSearch;
//		private System.Windows.Forms.DataGrid dgSearchList;
//		private System.Windows.Forms.Button btnSearchDataView;

//        #region +
//        /// <summary>
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
//        }
//        #endregion

//        #region Windows Form �����̳ʿ��� ������ �ڵ�
//        /// <summary>
//		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
//		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
//		/// </summary>
//		private void InitializeComponent()
//		{
//			this.comSearchField = new System.Windows.Forms.ComboBox();
//			this.txtSearchQuery = new System.Windows.Forms.TextBox();
//			this.btnSearch = new System.Windows.Forms.Button();
//			this.dgSearchList = new System.Windows.Forms.DataGrid();
//			this.btnSearchDataView = new System.Windows.Forms.Button();
//			((System.ComponentModel.ISupportInitialize)(this.dgSearchList)).BeginInit();
//			this.SuspendLayout();
//			// 
//			// comSearchField
//			// 
//			this.comSearchField.Location = new System.Drawing.Point(8, 16);
//			this.comSearchField.Name = "comSearchField";
//			this.comSearchField.Size = new System.Drawing.Size(121, 20);
//			this.comSearchField.TabIndex = 0;
//			// 
//			// txtSearchQuery
//			// 
//			this.txtSearchQuery.Location = new System.Drawing.Point(144, 16);
//			this.txtSearchQuery.Name = "txtSearchQuery";
//			this.txtSearchQuery.Size = new System.Drawing.Size(120, 21);
//			this.txtSearchQuery.TabIndex = 1;
//			this.txtSearchQuery.Text = "";
//			// 
//			// btnSearch
//			// 
//			this.btnSearch.Location = new System.Drawing.Point(272, 16);
//			this.btnSearch.Name = "btnSearch";
//			this.btnSearch.Size = new System.Drawing.Size(64, 23);
//			this.btnSearch.TabIndex = 2;
//			this.btnSearch.Text = "�˻�";
//			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
//			// 
//			// dgSearchList
//			// 
//			this.dgSearchList.DataMember = "";
//			this.dgSearchList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
//			this.dgSearchList.Location = new System.Drawing.Point(8, 48);
//			this.dgSearchList.Name = "dgSearchList";
//			this.dgSearchList.Size = new System.Drawing.Size(440, 216);
//			this.dgSearchList.TabIndex = 3;
//			// 
//			// btnSearchDataView
//			// 
//			this.btnSearchDataView.Location = new System.Drawing.Point(344, 16);
//			this.btnSearchDataView.Name = "btnSearchDataView";
//			this.btnSearchDataView.Size = new System.Drawing.Size(104, 23);
//			this.btnSearchDataView.TabIndex = 4;
//			this.btnSearchDataView.Text = "�˻�(DataView)";
//			this.btnSearchDataView.Click += new System.EventHandler(this.btnSearchDataView_Click);
//			// 
//			// FrmSearch
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(456, 277);
//			this.Controls.Add(this.btnSearchDataView);
//			this.Controls.Add(this.dgSearchList);
//			this.Controls.Add(this.btnSearch);
//			this.Controls.Add(this.txtSearchQuery);
//			this.Controls.Add(this.comSearchField);
//			this.Name = "FrmSearch";
//			this.Text = "�˻�";
//			this.Load += new System.EventHandler(this.FrmSearch_Load);
//			((System.ComponentModel.ISupportInitialize)(this.dgSearchList)).EndInit();
//			this.ResumeLayout(false);

//		}
//		#endregion

//		private void FrmSearch_Load(object sender, System.EventArgs e)
//		{
//			this.comSearchField.Items.Add("Name");
//			this.comSearchField.Items.Add("Address");

//			this.comSearchField.SelectedIndex = 0;
//		}

//		private void btnSearch_Click(object sender, System.EventArgs e)
//		{
//			//[1] ���� �����
//			string strSearchField = 
//				comSearchField.Text;
//			string strSearchQuery = 
//				txtSearchQuery.Text;
//			string strSql = "SearchAddress";//SP
////				String.Format(
////				"Select * From Address " + 
////				"Where {0} Like '%{1}%'", 
////				strSearchField, strSearchQuery);
//			//MessageBox.Show(strSql);
//			//[2] Connection
//			SqlConnection objCon = new SqlConnection();
//            objCon.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
//            objCon.Open();
//			//[3] Command
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;//SP
//			objCmd.CommandType = CommandType.StoredProcedure;
//			//[!] SQL Parameter �߰�
//			objCmd.Parameters.Add(
//				"@SearchField", SqlDbType.VarChar, 25);
//			objCmd.Parameters[
//				"@SearchField"].Value = strSearchField;
//			objCmd.Parameters.Add(
//				"@SearchQuery", SqlDbType.VarChar, 25);
//			objCmd.Parameters[
//				"@SearchQuery"].Value = strSearchQuery;
//			//[4] DataAdapter : ������ ��ɾ� ����
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			//[5] DataSet : Fill()�� ������ �װ���� ���
//			DataSet objDs = new DataSet();
//			objDa.Fill(objDs, "Address");
//			//[6] DataGrid:DataSet,_Table,_View���
//			this.dgSearchList.DataSource = 
//				objDs.Tables["Address"].DefaultView;
//		}

//		// DataView Ŭ������ ����� �˻�
//		private void btnSearchDataView_Click(object sender, System.EventArgs e)
//		{
//			//[1] ���� �����
//			string strSearchField = comSearchField.Text;
//			string strSearchQuery = txtSearchQuery.Text;
//			string strSql = "ListAddress";
//			//[2] Connection
//			SqlConnection objCon = new SqlConnection();
//            objCon.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
//            objCon.Open();
//			//[3] Command
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;//SP
//			objCmd.CommandType = CommandType.StoredProcedure;
//			//[4] �����;����
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			//[5] �����ͼ�
//			DataSet objDs = new DataSet();
//			objDa.Fill(objDs, "Address");
//			//[6] �����ͺ� : ���͸�
//			//[a] �����ͺ� Ŭ������ �ν��Ͻ� ����
//			DataView objDv = new DataView();
//			//[b] DataTable�� DefaulView�� ���� �� ��ü ��ȯ
//			objDv = objDs.Tables["Address"].DefaultView;
//			//[c] .RowFilter�Ӽ��� ���� ���͸�(����ó��)
//      objDv.RowFilter = 
//				String.Format("{0} Like '%{1}%'",
//				strSearchField, strSearchQuery);
////				strSearchField + " Like '%" 
////				+ strSearchQuery + "%'";
//			//[7] �����ͱ׸���
//			this.dgSearchList.DataSource = objDv;
//		}

//	}
//}
