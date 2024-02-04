//using System;
//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;

//namespace AddressApplication
//{
//    /// <summary>
//    /// FrmSearch에 대한 요약 설명입니다.
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
//		/// 필수 디자이너 변수입니다.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmSearch()
//		{
//			//
//			// Windows Form 디자이너 지원에 필요합니다.
//			//
//			InitializeComponent();

//			//
//			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
//			//
//		}

//		/// <summary>
//		/// 사용 중인 모든 리소스를 정리합니다.
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

//        #region Windows Form 디자이너에서 생성한 코드
//        /// <summary>
//		/// 디자이너 지원에 필요한 메서드입니다.
//		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
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
//			this.btnSearch.Text = "검색";
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
//			this.btnSearchDataView.Text = "검색(DataView)";
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
//			this.Text = "검색";
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
//			//[1] 변수 선언부
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
//			//[!] SQL Parameter 추가
//			objCmd.Parameters.Add(
//				"@SearchField", SqlDbType.VarChar, 25);
//			objCmd.Parameters[
//				"@SearchField"].Value = strSearchField;
//			objCmd.Parameters.Add(
//				"@SearchQuery", SqlDbType.VarChar, 25);
//			objCmd.Parameters[
//				"@SearchQuery"].Value = strSearchQuery;
//			//[4] DataAdapter : 실행할 명령어 지정
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			//[5] DataSet : Fill()로 실행후 그결과값 담기
//			DataSet objDs = new DataSet();
//			objDa.Fill(objDs, "Address");
//			//[6] DataGrid:DataSet,_Table,_View출력
//			this.dgSearchList.DataSource = 
//				objDs.Tables["Address"].DefaultView;
//		}

//		// DataView 클래스를 사용한 검색
//		private void btnSearchDataView_Click(object sender, System.EventArgs e)
//		{
//			//[1] 변수 선언부
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
//			//[4] 데이터어댑터
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			//[5] 데이터셋
//			DataSet objDs = new DataSet();
//			objDa.Fill(objDs, "Address");
//			//[6] 데이터뷰 : 필터링
//			//[a] 데이터뷰 클래스의 인스턴스 생성
//			DataView objDv = new DataView();
//			//[b] DataTable의 DefaulView를 통한 뷰 객체 반환
//			objDv = objDs.Tables["Address"].DefaultView;
//			//[c] .RowFilter속성을 통한 필터링(조건처리)
//      objDv.RowFilter = 
//				String.Format("{0} Like '%{1}%'",
//				strSearchField, strSearchQuery);
////				strSearchField + " Like '%" 
////				+ strSearchQuery + "%'";
//			//[7] 데이터그리드
//			this.dgSearchList.DataSource = objDv;
//		}

//	}
//}
