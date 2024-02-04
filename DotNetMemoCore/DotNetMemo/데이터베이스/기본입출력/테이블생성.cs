using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[0]
using System.Data;//
using System.Data.SqlClient;//

namespace CSharp_Database{
	public class 복습 : System.Windows.Forms.Form{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		#region +
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 복습()
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

		#region Windows Form Designer generated code
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(72, 40);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "데이터베이스 연결/해제";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(72, 88);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(160, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "테이블 생성";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label1.Location = new System.Drawing.Point(0, 142);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 23);
			this.label1.TabIndex = 2;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// 복습
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 165);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.label1,
																																	this.button2,
																																	this.button1});
			this.Name = "복습";
			this.Text = "복습";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void button1_Click(object sender, System.EventArgs e){
			//[1] 
			SqlConnection objCon = new SqlConnection();
			//[2]
			objCon.ConnectionString = 
				"server=(local);database=Web;uid=Web;pwd=Web;";
			try
			{
				//[3] 
				objCon.Open();
				//[4]
				if(objCon.State == ConnectionState.Open)
				{
					this.label1.Text = "데이터베이스가 연결되었습니다.\n" 
						+ "데이터베이스 : " + objCon.Database + "\n"
						+ "연결문자열 : " + objCon.ConnectionString + "\n"
						+ "서버버전 : " + objCon.ServerVersion;
				}
			}
			catch(Exception ex)
			{
				this.label1.Text = "데이터베이스가 연결되지 않았습니다.\n" 
					+ ex.ToString();
			}
			finally
			{
				if(objCon != null)
				{
					//[5] 
					objCon.Close();
				}
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			SqlConnection objCon = new SqlConnection();
			objCon.ConnectionString = 
				"server=(local);database=Web;uid=Web;pwd=Web;";
			objCon.Open();

			//[1] Command 클래스의 인스턴스 생성
			SqlCommand objCmd = new SqlCommand();
			//[2] 어떤 연결을 사용?
			objCmd.Connection = objCon;
			//[3] 어떤 명령을 수행?
			objCmd.CommandText = @"
				Create Table dbo.Memo
				(
					Num Int Identity(1, 1) Primary Key Not Null,	--번호
					Name VarChar(25) Null,			--이름
					Email VarChar(100) Null,			--이메일
					Title VarChar(150) Null,			--제목
					PostDate DateTime Default GetDate()	--작성일	
				)
			";
			//[4] 명령어가 어떤 타입인지?
			objCmd.CommandType = CommandType.Text;//일반 SQL문
			//[5] 반환값이 없는 명령어 실행 : Select 제외
			objCmd.ExecuteNonQuery();

			objCon.Close();
		}
	}
}






