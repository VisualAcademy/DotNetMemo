using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[0] 
using System.Data; // 
using System.Data.SqlClient; // 

namespace AddressApplication.ADONET
{
	/// <summary>
	/// FrmSqlCommand에 대한 요약 설명입니다.
	/// </summary>
	public class FrmSqlCommand : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnDrop;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmSqlCommand()
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
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnDrop = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(56, 16);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(224, 23);
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "테이블 생성";
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnDrop
			// 
			this.btnDrop.Location = new System.Drawing.Point(56, 56);
			this.btnDrop.Name = "btnDrop";
			this.btnDrop.Size = new System.Drawing.Size(224, 23);
			this.btnDrop.TabIndex = 1;
			this.btnDrop.Text = "테이블 삭제";
			this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
			// 
			// FrmSqlCommand
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(376, 93);
			this.Controls.Add(this.btnDrop);
			this.Controls.Add(this.btnCreate);
			this.Name = "FrmSqlCommand";
			this.Text = "SqlCommand 클래스 : SQL Server에 명령어 전달";
			this.ResumeLayout(false);

		}
		#endregion

		// 테이블 생성
		private void btnCreate_Click(object sender, System.EventArgs e)
		{
			SqlConnection objCon = 
				new SqlConnection(); 
			objCon.ConnectionString = 
				"server=(local);database=AddressDB;" + 
				"uid=AddressUid;pwd=AddressPwd;";
			objCon.Open();
			//[1] SqlCommand 클래스의 인스턴스 생성
			SqlCommand objCmd = new SqlCommand();
			//[2] .Connection 속성 지정 : 커넥션 객체
      objCmd.Connection = objCon;
			//[3] .CommandText 속성 : 실행할 명령어
			objCmd.CommandText = @"
				Create Table dbo.Test
				(Num Int Identity, Name VarChar(25))
			";
			//[4] .CommandType 속성 : CommandType 열거형			
      objCmd.CommandType = 
				CommandType.Text; // 일반 SQL문
			//[5] .Execute???() 메서드 : 실행
			objCmd.ExecuteNonQuery();//!Select
			objCon.Close();
		}

		// 테이블 삭제
		private void btnDrop_Click(object sender, System.EventArgs e)
		{
			SqlConnection objCon = 
				new SqlConnection(
					@"Data Source=(local);
						Initial Catalog=AddressDB;
						User ID=AddressUid;
						Password=AddressPwd;");
			objCon.Open();
			//[1] 커멘드 클래스
			SqlCommand objCmd = new SqlCommand();
			//[2] 커넥션 속성
			objCmd.Connection = objCon;
			//[3] 커멘드 텍스트 속성
			objCmd.CommandText = 
				"Drop Table dbo.Test";
      //[4] 커멘드 타입 속성
			objCmd.CommandType = CommandType.Text;
			//[5] 실행
			objCmd.ExecuteNonQuery();
			objCon.Close();
		}
	}
}
