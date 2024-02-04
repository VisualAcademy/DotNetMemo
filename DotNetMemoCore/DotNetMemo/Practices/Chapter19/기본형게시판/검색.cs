//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;
////[0] 네임스페이스 추가
//using System.Data;
//using System.Data.SqlClient;

//namespace CSharp_Windows.기본형게시판
//{
//	/// <summary>
//	/// 검색에 대한 요약 설명입니다.
//	/// </summary>
//	public class 검색 : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.ComboBox comSearchField;
//		private System.Windows.Forms.TextBox txtSearchQuery;
//		private System.Windows.Forms.Button btnSearch;
//		private System.Windows.Forms.DataGrid dgList;
//		private System.Windows.Forms.Button cmdSearch;
//		/// <summary>
//		/// 필수 디자이너 변수입니다.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public 검색()
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
//		}

//		#region Windows Form 디자이너에서 생성한 코드
//		/// <summary>
//		/// 디자이너 지원에 필요한 메서드입니다.
//		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
//		/// </summary>
//		private void InitializeComponent()
//		{
//			this.comSearchField = new System.Windows.Forms.ComboBox();
//			this.txtSearchQuery = new System.Windows.Forms.TextBox();
//			this.btnSearch = new System.Windows.Forms.Button();
//			this.dgList = new System.Windows.Forms.DataGrid();
//			this.cmdSearch = new System.Windows.Forms.Button();
//			((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
//			this.SuspendLayout();
//			// 
//			// comSearchField
//			// 
//			this.comSearchField.Items.AddRange(new object[] {
//																																																				"Name",
//																																																				"Title",
//																																																				"Content",
//																																																				"All"});
//			this.comSearchField.Location = new System.Drawing.Point(16, 24);
//			this.comSearchField.Name = "comSearchField";
//			this.comSearchField.Size = new System.Drawing.Size(121, 20);
//			this.comSearchField.TabIndex = 0;
//			this.comSearchField.Text = "Name";
//			// 
//			// txtSearchQuery
//			// 
//			this.txtSearchQuery.Location = new System.Drawing.Point(144, 24);
//			this.txtSearchQuery.Name = "txtSearchQuery";
//			this.txtSearchQuery.TabIndex = 1;
//			this.txtSearchQuery.Text = "";
//			// 
//			// btnSearch
//			// 
//			this.btnSearch.Location = new System.Drawing.Point(248, 8);
//			this.btnSearch.Name = "btnSearch";
//			this.btnSearch.TabIndex = 2;
//			this.btnSearch.Text = "검색";
//			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
//			// 
//			// dgList
//			// 
//			this.dgList.DataMember = "";
//			this.dgList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
//			this.dgList.Location = new System.Drawing.Point(16, 64);
//			this.dgList.Name = "dgList";
//			this.dgList.Size = new System.Drawing.Size(312, 192);
//			this.dgList.TabIndex = 3;
//			// 
//			// cmdSearch
//			// 
//			this.cmdSearch.Location = new System.Drawing.Point(248, 40);
//			this.cmdSearch.Name = "cmdSearch";
//			this.cmdSearch.TabIndex = 4;
//			this.cmdSearch.Text = "검색";
//			this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
//			// 
//			// 검색
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(344, 273);
//			this.Controls.Add(this.cmdSearch);
//			this.Controls.Add(this.dgList);
//			this.Controls.Add(this.btnSearch);
//			this.Controls.Add(this.txtSearchQuery);
//			this.Controls.Add(this.comSearchField);
//			this.Name = "검색";
//			this.Text = "검색";
//			((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
//			this.ResumeLayout(false);

//		}
//		#endregion

//		//인라인 SQL 방식
//		private void btnSearch_Click(object sender, System.EventArgs e)
//		{
//			//[1] 변수
//			string strSearchField = 
//				comSearchField.Text;//필드
//			string strSearchQuery = 
//				txtSearchQuery.Text;//검색어
//			string strSql = String.Empty;
//			if(strSearchField.ToLower() == "all"){
//				strSql = @"
//					Select * From Basic
//					Where 
//						Name Like '%" + strSearchQuery + @"%'
//						Or
//						Title Like '%" + strSearchQuery + @"%'
//						Or
//						Content Like '%" + strSearchQuery + @"%'
//				";
//			}
//			else{ //변수처리 : 홍길동 -> " + 변수 + @"
//				strSql = @"
//					Select * From Basic 
//					Where 
//					" + strSearchField + @" Like '%" 
//					+ strSearchQuery + @"%'
//				";
//			}
//			//[2] 연결
//			SqlConnection objCon = new SqlConnection();
//			objCon.ConnectionString = "server=(local);database=Basic;pwd=Basic;uid=Basic;";
//			objCon.Open();
//			//[3] 명령
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;
//			objCmd.CommandType = CommandType.Text;
//			//[4] 출력 : 데이터어댑터+데이터셋+데이트그리드
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			DataSet objDs = new DataSet();
//			objDa.Fill(objDs, "Basic");
//			this.dgList.DataSource = objDs.Tables["Basic"];
//		}

//		//저장 프로시저 : 필터링 기법
//		private void cmdSearch_Click(object sender, System.EventArgs e)
//		{
//			//[1] 변수
//			string strSearchField = 
//				comSearchField.Text;//필드
//			string strSearchQuery = 
//				txtSearchQuery.Text;//검색어
//			string strSql = "SearchBasic";
//			string strFilter = String.Empty;
//			if(strSearchField.ToLower() == "all"){
//				strFilter = String.Format(
//					"Name Like '%{0}%' Or Title Like '%{0}%' Or Content Like '%{0}%'", strSearchQuery);
//			}
//			else{
//				strFilter = String.Format("{0} Like '%{1}%'"
//					, strSearchField, strSearchQuery);
//			}				
//			//[2] 연결
//			SqlConnection objCon = new SqlConnection();
//			objCon.ConnectionString = "server=(local);database=Basic;pwd=Basic;uid=Basic;";
//			objCon.Open();
//			//[3] 명령
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;
//			objCmd.CommandType = CommandType.Text;
//			//[4] 출력 : 데이터어댑터+데이터셋+데이트그리드
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			DataSet objDs = new DataSet();
//			objDa.Fill(objDs, "Basic");
//			//[!] 검색 : 필터링 
//			DataView objDv =	//[1]DataView 형식으로 반환
//				objDs.Tables["Basic"].DefaultView;
//			objDv.RowFilter = strFilter;//[2]조건에 맞는 항목검색
//			this.dgList.DataSource = objDv;//[3]DataView 출력
//		}
//	}
//}
