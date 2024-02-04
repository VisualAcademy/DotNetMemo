using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[0] 
using System.Data;
using System.Data.SqlClient;

namespace CSharp_Database{
	public class 데이터읽어오기 : System.Windows.Forms.Form{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRead;
		#region +
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 데이터읽어오기()
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnRead = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(360, 264);
			this.label1.TabIndex = 0;
			// 
			// btnRead
			// 
			this.btnRead.Location = new System.Drawing.Point(64, 304);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(248, 23);
			this.btnRead.TabIndex = 1;
			this.btnRead.Text = "데이터 읽어오기";
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// 데이터읽어오기
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(384, 341);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.btnRead,
																																	this.label1});
			this.Name = "데이터읽어오기";
			this.Text = "데이터읽어오기";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void btnRead_Click(object sender, System.EventArgs e){
			SqlConnection objCon = new SqlConnection();
			objCon.ConnectionString = 
				"server=(local);database=Web;uid=Web;pwd=Web;";
			objCon.Open();
				
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = "Select * From Memo";
			objCmd.CommandType = CommandType.Text;

			//[1] 반환값이 있는 경우(Select문) : ExecuteReader()
			SqlDataReader objDr;//선언
			objDr = objCmd.ExecuteReader();//반환
			//[2] Read() 메서드를 사용 반복
			string strMsg = "";
			while(objDr.Read())
			{
				//[3] 출력
				strMsg += "번호 : " + objDr["Num"] + "\t\t";	//필드명 사용
				strMsg += "이름 : " + objDr[1] + "\t\t\n";			//서수 사용
				strMsg += "메모 : " + objDr.GetString(3) + "\t\t";//메서드 사용
				strMsg += "작성일 : " + objDr.GetDateTime(4) + "\t\t\n";
			}
			this.label1.Text = strMsg;
			//[4] Close() 메서드로 리더 클래스 종료
			objDr.Close();

			objCon.Close();
		}
	}
}
