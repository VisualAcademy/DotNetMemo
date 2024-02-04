////[0] 네임스페이스 추가
//using System.Data.OleDb; //

//namespace AddressApplication.ADONET
//{
//    /// <summary>
//    /// FrmOleDbConnection에 대한 요약 설명입니다.
//    /// </summary>
//    public class FrmOleDbConnection : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.Button btnOleDbConnection;
//		private System.Windows.Forms.Label lblDisplay;
//		/// <summary>
//		/// 필수 디자이너 변수입니다.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmOleDbConnection()
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
//			this.btnOleDbConnection = new System.Windows.Forms.Button();
//			this.lblDisplay = new System.Windows.Forms.Label();
//			this.SuspendLayout();
//			// 
//			// btnOleDbConnection
//			// 
//			this.btnOleDbConnection.Location = new System.Drawing.Point(136, 24);
//			this.btnOleDbConnection.Name = "btnOleDbConnection";
//			this.btnOleDbConnection.Size = new System.Drawing.Size(136, 23);
//			this.btnOleDbConnection.TabIndex = 0;
//			this.btnOleDbConnection.Text = "Access DB 연결";
//			this.btnOleDbConnection.Click += new System.EventHandler(this.btnOleDbConnection_Click);
//			// 
//			// lblDisplay
//			// 
//			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
//			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
//			this.lblDisplay.Location = new System.Drawing.Point(0, 78);
//			this.lblDisplay.Name = "lblDisplay";
//			this.lblDisplay.Size = new System.Drawing.Size(424, 23);
//			this.lblDisplay.TabIndex = 1;
//			// 
//			// FrmOleDbConnection
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(424, 101);
//			this.Controls.Add(this.lblDisplay);
//			this.Controls.Add(this.btnOleDbConnection);
//			this.Name = "FrmOleDbConnection";
//			this.Text = "OleDbConnection 클래스 : 데이터베이스 연결(Access,Oracle)";
//			this.ResumeLayout(false);

//		}
//		#endregion

//		private void btnOleDbConnection_Click(object sender, System.EventArgs e)
//		{
//			//[1] OleDbConnection 클래스 인스턴스
//			OleDbConnection objCon = 
//				new OleDbConnection();
//			//[2] .ConnectionString 속성 지정:UDL
//			objCon.ConnectionString = 
//				@"Provider=Microsoft.Jet.OLEDB.4.0;
//					Data Source=C:\CSharp\" + 
//				@"AddressApplication\Database\" + 
//				@"AddressDB.mdb;" + 
//					"Persist Security Info=False";
//			//[3] .Open() 메서드
//			objCon.Open();
//			//[!] Process
//			this.lblDisplay.Text = "연결 성공";
//			//[4] .Close() 메서드
//			objCon.Close();
//		}

//	}
//}
