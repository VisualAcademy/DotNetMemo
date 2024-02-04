using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//
using System.Data;
using System.Data.SqlClient;

namespace CSharp_Database
{
	public class 명령어실행 : System.Windows.Forms.Form
	{
		#region +
		private System.Windows.Forms.Button btnCommand;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 명령어실행()
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
			this.btnCommand = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCommand
			// 
			this.btnCommand.Location = new System.Drawing.Point(72, 32);
			this.btnCommand.Name = "btnCommand";
			this.btnCommand.Size = new System.Drawing.Size(240, 23);
			this.btnCommand.TabIndex = 0;
			this.btnCommand.Text = "tempdb에 테이블 생성";
			this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
			// 
			// 명령어실행
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(376, 93);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.btnCommand});
			this.Name = "명령어실행";
			this.Text = "명령어실행";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void btnCommand_Click(object sender, System.EventArgs e)
		{
			SqlConnection objCon = new SqlConnection();
			objCon.ConnectionString = 
				"server=(local);database=tempdb;uid=sa;pwd=pass;";//4가지 정보
			objCon.Open();

			//[1] SqlCommand 클래스의 인스턴스 생성
			SqlCommand objCmd = new SqlCommand();
			//[2] Connectin 속성 : 어떤 커넥션(objCon)을 사용할건지
			objCmd.Connection = objCon;
			//[3] CommandText 속성 : 어떤 명령어(SQL문)을 실행할건지
			objCmd.CommandText = 
				"Create Table dbo.Test(Num Int, Name VarChar(10))";
			//[4] CommandType 속성 : 명령어가 어떤 타입인지(SQL, SP)
			objCmd.CommandType = CommandType.Text;//일반 SQL문
			//[5] ExecuteNonQuery() 메서드 : 반환값이 없는 명령 실행
			objCmd.ExecuteNonQuery();
      
			objCon.Close();
		}
	}
}
