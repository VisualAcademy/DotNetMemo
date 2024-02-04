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
	/// 입력에 대한 요약 설명입니다.
	/// </summary>
	public class 입력 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comEncoding;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtContent;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtHomePage;
		private System.Windows.Forms.Button btnWrite;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 입력()
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
			this.comEncoding = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtContent = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnWrite = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.txtHomePage = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "기본형게시판 글쓰기";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "이름:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 71);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "이메일:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 117);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "제목:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 140);
			this.label5.Name = "label5";
			this.label5.TabIndex = 4;
			this.label5.Text = "내용:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 163);
			this.label6.Name = "label6";
			this.label6.TabIndex = 5;
			this.label6.Text = "인코딩:";
			// 
			// comEncoding
			// 
			this.comEncoding.Items.AddRange(new object[] {
																																																	"Text",
																																																	"HTML",
																																																	"Mixed"});
			this.comEncoding.Location = new System.Drawing.Point(144, 165);
			this.comEncoding.Name = "comEncoding";
			this.comEncoding.Size = new System.Drawing.Size(100, 20);
			this.comEncoding.TabIndex = 6;
			this.comEncoding.Text = "Text";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 186);
			this.label7.Name = "label7";
			this.label7.TabIndex = 7;
			this.label7.Text = "암호:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(144, 40);
			this.txtName.Name = "txtName";
			this.txtName.TabIndex = 8;
			this.txtName.Text = "";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(144, 65);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.TabIndex = 9;
			this.txtEmail.Text = "";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(144, 115);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.TabIndex = 10;
			this.txtTitle.Text = "";
			this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(144, 140);
			this.txtContent.Multiline = true;
			this.txtContent.Name = "txtContent";
			this.txtContent.TabIndex = 11;
			this.txtContent.Text = "";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(144, 189);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.TabIndex = 12;
			this.txtPassword.Text = "";
			// 
			// btnWrite
			// 
			this.btnWrite.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.btnWrite.Location = new System.Drawing.Point(40, 232);
			this.btnWrite.Name = "btnWrite";
			this.btnWrite.TabIndex = 13;
			this.btnWrite.Text = "저장";
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.btnCancel.Location = new System.Drawing.Point(168, 232);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 14;
			this.btnCancel.Text = "다시쓰기";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 94);
			this.label8.Name = "label8";
			this.label8.TabIndex = 15;
			this.label8.Text = "홈페이지:";
			// 
			// txtHomePage
			// 
			this.txtHomePage.Location = new System.Drawing.Point(144, 90);
			this.txtHomePage.Name = "txtHomePage";
			this.txtHomePage.TabIndex = 16;
			this.txtHomePage.Text = "";
			// 
			// 입력
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.txtHomePage);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnWrite);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtContent);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comEncoding);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "입력";
			this.Text = "입력";
			this.ResumeLayout(false);

		}
		#endregion

		//저장 버튼
		private void btnWrite_Click(object sender, System.EventArgs e)
		{
			#region //[1] 변수선언부
			string strName = this.txtName.Text;
			string strEmail = this.txtEmail.Text;
			string strHomePage = this.txtHomePage.Text;
			string strTitle = txtTitle.Text;
			string strContent = txtContent.Text;
			string strEncoding = comEncoding.SelectedText;
			string strPassword = txtPassword.Text;
			string strSql = "WriteBasic";//저장프로시저
			#endregion
			#region //[2] 커넥션
			SqlConnection objCon = new SqlConnection();
			objCon.ConnectionString = "server=(local);database=Basic;uid=Basic;pwd=Basic;";
			objCon.Open();
			#endregion
			#region //[3] 커멘드
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = strSql;
			objCmd.CommandType =CommandType.StoredProcedure;
			
			#region //[!]파라미터 추가
			objCmd.Parameters.Add("@Name", SqlDbType.VarChar, 25);
			objCmd.Parameters["@Name"].Value = strName;
			objCmd.Parameters.Add("@Email", SqlDbType.VarChar, 50);
			objCmd.Parameters["@Email"].Value = strEmail;
			objCmd.Parameters.Add("@Title", SqlDbType.VarChar, 150);
			objCmd.Parameters["@Title"].Value = strTitle;
			objCmd.Parameters.Add("@PostIP", SqlDbType.VarChar, 10);
			objCmd.Parameters["@PostIP"].Value = "127.0.0.1";
			objCmd.Parameters.Add("@Content", SqlDbType.Text);
			objCmd.Parameters["@Content"].Value = strContent;
			objCmd.Parameters.Add("@Password", SqlDbType.VarChar, 20);
			objCmd.Parameters["@Password"].Value = strPassword;
			objCmd.Parameters.Add("@Encoding", SqlDbType.VarChar, 10);
			objCmd.Parameters["@Encoding"].Value = strEncoding;
			objCmd.Parameters.Add("@HomePage", SqlDbType.VarChar, 100);
			objCmd.Parameters["@HomePage"].Value = strHomePage;
			#endregion

			objCmd.ExecuteNonQuery();
			#endregion
			//[4] 닫기
			objCon.Close();
			//[5] 종료
		}
	}
}
