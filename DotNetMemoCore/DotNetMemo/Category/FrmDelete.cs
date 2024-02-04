//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;
////[0] 네임스페이스 선언
//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;

//namespace Category
//{
//	/// <summary>
//	/// FrmDelete에 대한 요약 설명입니다.
//	/// </summary>
//	public class FrmDelete : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.Button btnDelete;
//		private System.Windows.Forms.TextBox txtCategoryID;
//		private System.Windows.Forms.Label label4;
//		/// <summary>
//		/// 필수 디자이너 변수입니다.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmDelete()
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
//			this.btnDelete.Text = "삭제";
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
//			this.label4.Text = "카테고리번호:";
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
//			//[1] 변수 선언부
//			string strCategoryID = 
//				this.txtCategoryID.Text.Trim();
//			string strSql = "DeleteCategory";
//			//[2] 커넥션
//			SqlConnection objCon = new SqlConnection();
//			//objCon.ConnectionString = "server=(local);database=Category;uid=Category;pwd=Category;";
//			objCon.ConnectionString = 
//                ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
//            objCon.Open();
//			//[3] 커멘드
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;
//			objCmd.CommandType = CommandType.StoredProcedure;
//			//[!] 파라미터 1개 추가
//			objCmd.Parameters.Add("@CategoryID", SqlDbType.Int);
//			objCmd.Parameters["@CategoryID"].Value = strCategoryID;
//			//[!] 실행
//			int intResult = objCmd.ExecuteNonQuery();
//			if(intResult == 1)	
//			{
//				MessageBox.Show("삭제되었습니다.");
//			}
//			objCon.Close();		
//		}
//	}
//}
