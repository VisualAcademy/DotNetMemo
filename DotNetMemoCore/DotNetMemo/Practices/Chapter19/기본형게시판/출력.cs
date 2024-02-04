//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;
////[0] 네임스페이스추가
//using System.Data;
//using System.Data.SqlClient;
//using System.IO;
//using System.Xml;

//namespace CSharp_Windows.기본형게시판
//{
//	/// <summary>
//	/// 출력에 대한 요약 설명입니다.
//	/// </summary>
//	public class 출력 : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.Label label1;
//		private System.Windows.Forms.DataGrid dgList;
//		/// <summary>
//		/// 필수 디자이너 변수입니다.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public 출력()
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
//			this.label1 = new System.Windows.Forms.Label();
//			this.dgList = new System.Windows.Forms.DataGrid();
//			((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
//			this.SuspendLayout();
//			// 
//			// label1
//			// 
//			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
//			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
//			this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
//			this.label1.Location = new System.Drawing.Point(0, 0);
//			this.label1.Name = "label1";
//			this.label1.Size = new System.Drawing.Size(376, 32);
//			this.label1.TabIndex = 0;
//			this.label1.Text = "기본형게시판 리스트";
//			// 
//			// dgList
//			// 
//			this.dgList.DataMember = "";
//			this.dgList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
//			this.dgList.Location = new System.Drawing.Point(8, 40);
//			this.dgList.Name = "dgList";
//			this.dgList.Size = new System.Drawing.Size(360, 168);
//			this.dgList.TabIndex = 1;
//			// 
//			// 출력
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(376, 221);
//			this.Controls.Add(this.dgList);
//			this.Controls.Add(this.label1);
//			this.Name = "출력";
//			this.Text = "출력";
//			this.Load += new System.EventHandler(this.출력_Load);
//			((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
//			this.ResumeLayout(false);

//		}
//		#endregion

//		private void 출력_Load(object sender, System.EventArgs e)
//		{	
//			//[1] 변수 선언부
//			string strSql = "ListBasic";
//			//[2] 커넥션
//			SqlConnection objCon = new SqlConnection();
//			objCon.ConnectionString = "server=(local);database=Basic;User ID=Basic;Password=Basic;";
//			objCon.Open();
//			//[3] 명령어
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;
//			objCmd.CommandType = CommandType.StoredProcedure;
//			//[!] 출력 로직 : 데이터어댑터 + 데이터셋
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			DataSet objDs = new DataSet();
//			objDa.Fill(objDs, "Basic");
//			this.dgList.DataSource = objDs.Tables["Basic"];//
//			//dgList.DataBind();//WebForm
//			//[4] 닫기
//			objCon.Close();
//			//[5] 종료
//		}
//	}
//}
