using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[1] 네임스페이스 추가
using System.Data;
using System.Data.SqlClient;

namespace CSharp_Database
{
	public class 데이터베이스연결및종료예외처리 : System.Windows.Forms.Form
	{
		#region +
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 데이터베이스연결및종료예외처리()
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
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(96, 144);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 64);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// 데이터베이스연결및종료예외처리
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.label1,
																																	this.button1});
			this.Name = "데이터베이스연결및종료예외처리";
			this.Text = "데이터베이스연결및종료예외처리";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void button1_Click(object sender, System.EventArgs e)
		{
			//[2] SqlConnectin 클래스
			SqlConnection objCon = new SqlConnection();
			//[3] ConnectionString 속성
			objCon.ConnectionString = 
				"server=(local);database=pubs;uid=sa;pwd=pass1;";
			try{
				//[4] Open() 메서드
				objCon.Open();
				//[5] State 속성
				if(objCon.State == ConnectionState.Open)
				{
					this.label1.Text = "연결 완료.";
				}
			}
			catch(Exception ex){
				this.label1.Text = "연결되지 않음.\n===============" 
					+ ex.Message;
			}
			finally{
				//[6] Close() 메서드
				objCon.Close();		
				this.label1.Text += "이것이 실행될까요???";	
			}			
			//[7] 해제
			//objCon.Dispose();//objCon = null;
		}
	}
}
