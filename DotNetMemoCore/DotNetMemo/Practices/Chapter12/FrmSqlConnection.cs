using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[0] 네임스페이스 추가
using System.Data;//
using System.Data.SqlClient;//

namespace AddressApplication.ADONET
{
	/// <summary>
	/// FrmSqlConnection에 대한 요약 설명입니다.
	/// </summary>
	public class FrmSqlConnection : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnSqlConnection;
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Button btnExceptionHandling;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmSqlConnection()
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
			this.btnSqlConnection = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.btnExceptionHandling = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSqlConnection
			// 
			this.btnSqlConnection.Location = new System.Drawing.Point(72, 16);
			this.btnSqlConnection.Name = "btnSqlConnection";
			this.btnSqlConnection.Size = new System.Drawing.Size(184, 23);
			this.btnSqlConnection.TabIndex = 0;
			this.btnSqlConnection.Text = "데이터베이스 연결";
			this.btnSqlConnection.Click += new System.EventHandler(this.btnSqlConnection_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 102);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(320, 23);
			this.lblDisplay.TabIndex = 1;
			// 
			// btnExceptionHandling
			// 
			this.btnExceptionHandling.Location = new System.Drawing.Point(72, 56);
			this.btnExceptionHandling.Name = "btnExceptionHandling";
			this.btnExceptionHandling.Size = new System.Drawing.Size(184, 23);
			this.btnExceptionHandling.TabIndex = 2;
			this.btnExceptionHandling.Text = "데이터베이스 연결(예외 처리)";
			this.btnExceptionHandling.Click += new System.EventHandler(this.btnExceptionHandling_Click);
			// 
			// FrmSqlConnection
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(320, 125);
			this.Controls.Add(this.btnExceptionHandling);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.btnSqlConnection);
			this.Name = "FrmSqlConnection";
			this.Text = "SqlConnection 클래스 : 데이터베이스 연결";
			this.Load += new System.EventHandler(this.FrmSqlConnection_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmSqlConnection_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnSqlConnection_Click(object sender, System.EventArgs e)
		{
			//[1] SqlConnection 클래스의 인스턴스
			SqlConnection objCon = 
				new SqlConnection(); 
			//[2] .ConnectionString 속성 4가지 정보
			objCon.ConnectionString = 
				"server=(local);" + 
				"database=AddressDB;" + 
				"uid=AddressUid;pwd=AddressPwd;";
			//[3] .Open() 메서드 데이터베이스 연결 시도
			objCon.Open();
			//[!] Process 
			this.lblDisplay.Text = "연결 성공";
			//[4] .Close() 메서드 연결 닫기
			objCon.Close();
		}

		// 데이터베이스 연결(예외처리)
		private void btnExceptionHandling_Click(object sender, System.EventArgs e)
		{
			SqlConnection objCon = 
				new SqlConnection();
			objCon.ConnectionString = 
				"Data Source=127.0.0.1;" + 
				"Initial Catalog=AddressDB;" + 
				"User ID=AddressUid;" + 
				"Password=AddressPwd__;";

			try{ // 예외 발생할 만한 코드 작성				
				objCon.Open();
				//[!] Process
				this.lblDisplay.Text = "연결 성공";
			}
			catch(Exception ex){ // 예외 내용 처리				
				this.lblDisplay.Text = ex.Message;
			}
			finally{ // 예외 발생/미발생 무조건 실행
				// .State 속성 : 현재 연결 상태
				// - ConnectionState 열거형
				if (objCon.State == 
					ConnectionState.Open){
					objCon.Close();
				}
			}

		}
	}
}
