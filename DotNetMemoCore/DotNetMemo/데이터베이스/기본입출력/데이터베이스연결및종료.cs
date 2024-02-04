//SqlConnection 클래스 : SQL Server에 연결 및 종료.
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows
{
	public class 데이터베이스연결및종료 : System.Windows.Forms.Form
	{
		#region +
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Button btnConnection;
		private System.ComponentModel.Container components = null;

		public 데이터베이스연결및종료()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}

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
			this.btnConnection = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnConnection
			// 
			this.btnConnection.Location = new System.Drawing.Point(64, 88);
			this.btnConnection.Name = "btnConnection";
			this.btnConnection.Size = new System.Drawing.Size(168, 23);
			this.btnConnection.TabIndex = 0;
			this.btnConnection.Text = "데이터베이스 연결";
			this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Location = new System.Drawing.Point(64, 40);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(168, 23);
			this.lblDisplay.TabIndex = 1;
			// 
			// 데이터베이스연결및종료
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 141);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.lblDisplay,
																																	this.btnConnection});
			this.Name = "데이터베이스연결및종료";
			this.Text = "데이터베이스연결및종료";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		//SQL Server 연결 및 연결 종료
		private void btnConnection_Click(object sender, System.EventArgs e)
		{
			//[1] SqlConnection 클래스의 인스턴스 생성
			System.Data.SqlClient.SqlConnection objCon = 
				new System.Data.SqlClient.SqlConnection();
			//[2] ConnectionString 속성 지정
			objCon.ConnectionString = 
				"server=(local);database=pubs;uid=sa;pwd=1234;";//4가지 정보
			//[3] Open() 메서드 실행 : 연결
			objCon.Open();
			//[4] State 속성 : ConnectionState 열거형
			if(objCon.State == System.Data.ConnectionState.Open)
			{
				this.lblDisplay.Text = "데이터베이스가 연결되었습니다.";
			}
			//[5] Close() 메서드 실행 : 종료
      objCon.Close();
		}
	}
}
