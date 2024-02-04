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
//	public class 삭제 : System.Windows.Forms.Form
//	{
//		#region Private Fields
//		private System.Windows.Forms.Label label1;
//		private System.Windows.Forms.DataGrid dgList;
//		private System.Windows.Forms.TextBox txtNum;
//		private System.Windows.Forms.Button btnDelete;
//		#endregion
//		#region +
//		/// <summary>
//		/// 필수 디자이너 변수입니다.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public 삭제()
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
//			this.dgList = new System.Windows.Forms.DataGrid();
//			this.txtNum = new System.Windows.Forms.TextBox();
//			this.btnDelete = new System.Windows.Forms.Button();
//			this.label1 = new System.Windows.Forms.Label();
//			((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
//			this.SuspendLayout();
//			// 
//			// dgList
//			// 
//			this.dgList.DataMember = "";
//			this.dgList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
//			this.dgList.Location = new System.Drawing.Point(16, 16);
//			this.dgList.Name = "dgList";
//			this.dgList.ReadOnly = true;
//			this.dgList.Size = new System.Drawing.Size(136, 144);
//			this.dgList.TabIndex = 0;
//			// 
//			// txtNum
//			// 
//			this.txtNum.Location = new System.Drawing.Point(256, 56);
//			this.txtNum.Name = "txtNum";
//			this.txtNum.Size = new System.Drawing.Size(80, 21);
//			this.txtNum.TabIndex = 1;
//			this.txtNum.Text = "";
//			// 
//			// btnDelete
//			// 
//			this.btnDelete.Location = new System.Drawing.Point(208, 96);
//			this.btnDelete.Name = "btnDelete";
//			this.btnDelete.Size = new System.Drawing.Size(96, 23);
//			this.btnDelete.TabIndex = 2;
//			this.btnDelete.Text = "삭제";
//			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
//			// 
//			// label1
//			// 
//			this.label1.Location = new System.Drawing.Point(152, 56);
//			this.label1.Name = "label1";
//			this.label1.TabIndex = 3;
//			this.label1.Text = "삭제할 글 번호 :";
//			// 
//			// 삭제
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(360, 173);
//			this.Controls.Add(this.label1);
//			this.Controls.Add(this.btnDelete);
//			this.Controls.Add(this.txtNum);
//			this.Controls.Add(this.dgList);
//			this.Name = "삭제";
//			this.Text = "삭제";
//			this.Load += new System.EventHandler(this.삭제_Load);
//			((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
//			this.ResumeLayout(false);

//		}
//		#endregion
//		#endregion
//		//인라인 SQL문
//		private void 삭제_Load(object sender, System.EventArgs e)
//		{
//			//[1] 변수
//			string strSql = "Select Num, Title From Basic";
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
//		//저장프로시저
//		private void btnDelete_Click(object sender, System.EventArgs e)
//		{
//			//[1] 변수
//			string strNum = this.txtNum.Text;
//			string strSql = "DeleteBasic";
//			//[2] 연결
//			SqlConnection objCon = new SqlConnection();
//			objCon.ConnectionString = "server=(local);database=Basic;pwd=Basic;uid=Basic;";
//			objCon.Open();
//			//[3] 명령
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;
//			objCmd.CommandType =CommandType.StoredProcedure;
//			//[!] SQL 파라미터(매개변수) 추가
//			objCmd.Parameters.Add("@Num", SqlDbType.Int);
//			objCmd.Parameters["@Num"].Value = strNum;
//			objCmd.ExecuteNonQuery();//실행
//			//[4] 닫기/종료			
//			objCon.Close(); this.txtNum.Text = "";
//			//[5] 데이터 새로 읽어오기
//			삭제_Load(null, null);
//		}
//	}
//}
