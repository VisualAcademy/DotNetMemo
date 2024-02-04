//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;

//namespace AddressApplication
//{
//    /// <summary>
//    /// FrmList에 대한 요약 설명입니다.
//    /// </summary>
//    public class FrmList : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.DataGrid dataGrid1;

//        #region +
//        /// <summary>
//		/// 필수 디자이너 변수입니다.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmList()
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
//			this.dataGrid1 = new System.Windows.Forms.DataGrid();
//			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
//			this.SuspendLayout();
//			// 
//			// dataGrid1
//			// 
//			this.dataGrid1.DataMember = "";
//			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
//			this.dataGrid1.Location = new System.Drawing.Point(16, 16);
//			this.dataGrid1.Name = "dataGrid1";
//			this.dataGrid1.Size = new System.Drawing.Size(416, 192);
//			this.dataGrid1.TabIndex = 0;
//			// 
//			// FrmList
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(448, 221);
//			this.Controls.Add(this.dataGrid1);
//			this.Name = "FrmList";
//			this.Text = "출력";
//			this.Load += new System.EventHandler(this.FrmList_Load);
//			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
//			this.ResumeLayout(false);

//		}
//		#endregion

//		private void FrmList_Load(object sender, System.EventArgs e)
//		{
//			//[1] 커넥션
//			SqlConnection objCon = new SqlConnection();
//			objCon.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
//			objCon.Open();
//			//[2] 커멘드
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = "ListAddress";//SP
//				//"Select * From Address";//Inline SQL
//			objCmd.CommandType = CommandType.StoredProcedure;
//			//[3] 데이터어댑터
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			//[4] 데이터셋
//			DataSet objDs = new DataSet();
//			objDa.Fill(objDs, "Address");
//			//[5] 데이터그리드
//			this.dataGrid1.DataSource = objDs;
//		}
//	}
//}
