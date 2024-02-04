using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[0] 네임스페이스 추가
using System.Data;
using System.Data.SqlClient;

namespace CSharp_Windows.기본형게시판
{
	/// <summary>
	/// 상세에 대한 요약 설명입니다.
	/// </summary>
	public class 상세 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblHomePage;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtContent;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Button btnView;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 상세()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
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

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblHomePage = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.txtContent = new System.Windows.Forms.TextBox();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.btnView = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "번호:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "이름:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "이메일:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "홈페이지:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "제목:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 184);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "내용:";
			// 
			// lblName
			// 
			this.lblName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblName.Location = new System.Drawing.Point(80, 56);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(248, 23);
			this.lblName.TabIndex = 7;
			// 
			// lblEmail
			// 
			this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblEmail.Location = new System.Drawing.Point(80, 88);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(248, 23);
			this.lblEmail.TabIndex = 8;
			// 
			// lblHomePage
			// 
			this.lblHomePage.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblHomePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblHomePage.Location = new System.Drawing.Point(80, 120);
			this.lblHomePage.Name = "lblHomePage";
			this.lblHomePage.Size = new System.Drawing.Size(248, 23);
			this.lblHomePage.TabIndex = 9;
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTitle.Location = new System.Drawing.Point(80, 152);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(248, 23);
			this.lblTitle.TabIndex = 10;
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(80, 176);
			this.txtContent.Multiline = true;
			this.txtContent.Name = "txtContent";
			this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtContent.Size = new System.Drawing.Size(248, 72);
			this.txtContent.TabIndex = 11;
			this.txtContent.Text = "";
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(80, 24);
			this.txtNum.Name = "txtNum";
			this.txtNum.TabIndex = 12;
			this.txtNum.Text = "";
			// 
			// btnView
			// 
			this.btnView.Location = new System.Drawing.Point(216, 24);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(112, 23);
			this.btnView.TabIndex = 13;
			this.btnView.Text = "상세보기";
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// 상세
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(360, 261);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.txtContent);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblHomePage);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "상세";
			this.Text = "상세";
			this.ResumeLayout(false);

		}
		#endregion

		//상세보기 버튼 클릭
		private void btnView_Click(object sender, System.EventArgs e)
		{
			if(this.txtNum.Text == ""){
				MessageBox.Show("번호를 입력하세요.");
			}
			else{
				UpdateReadCountBasic();//[1]조회수 증가 함수 실행
				ViewBasic();//[2]상세보기 출력
			}
		}

		//[1]상세보기 로직 함수 : Select / 저장프로시저
		private void ViewBasic(){
			//[1] 변수 선언부
			string strNum = this.txtNum.Text;//번호
			string strSql = "ViewBasic";//저장프로시저
			//[2] 연결
			SqlConnection objCon = new SqlConnection();
			objCon.ConnectionString = "server=(local);database=Basic;pwd=Basic;uid=Basic;";
			objCon.Open();
			//[3] 명령어
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = strSql;
			objCmd.CommandType =CommandType.StoredProcedure;
			//[!] 매개변수 추가
			objCmd.Parameters.Add("@Num", SqlDbType.Int);
			objCmd.Parameters["@Num"].Value = strNum;
			//[4] 출력 : SqlDataReader 클래스를 사용
			SqlDataReader objDr = objCmd.ExecuteReader();//*
			if(objDr.Read())
			{
				this.lblName.Text = objDr["Name"].ToString();//이름필드출력
				this.lblEmail.Text = objDr["Email"].ToString();
				this.lblHomePage.Text = objDr["HomePage"].ToString();
				lblTitle.Text = objDr["Title"].ToString();
				txtContent.Text = objDr["Content"].ToString();
			}
			else
			{
				MessageBox.Show(strNum + "번 글이 없습니다.");
			}
			objDr.Close();
			//[5] 닫기
			objCon.Close();
			//[6] 종료
			this.txtNum.Text = "";
		}

		//[2]조회수 증가 함수 : Update / 인라인 SQL
		private void UpdateReadCountBasic(){
			//[1] 변수 선언부
			string strNum = this.txtNum.Text;//번호
			string strSql = "Update Basic Set ReadCount = ReadCount + 1 Where Num = " + strNum;//인라인 SQL
			//[2] 연결
			SqlConnection objCon = new SqlConnection();
			objCon.ConnectionString = "server=(local);database=Basic;pwd=Basic;uid=Basic;";
			objCon.Open();
			//[3] 명령어
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = strSql;
			objCmd.CommandType =CommandType.Text;
			objCmd.ExecuteNonQuery();
			//[4] 닫기
			objCon.Close();
		}
	}
}
