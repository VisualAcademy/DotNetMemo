//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;
////
//using System.Net;
//using System.Net.Sockets;
//using System.IO;
//using System.Threading;

//namespace CSharp_Network.강의샘플
//{
//	/// <summary>
//	/// 라_타임서버에 대한 요약 설명입니다.
//	/// </summary>
//	public class 라_타임서버 : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.Button btnStart;
//		private System.Windows.Forms.Button btnEnd;
//		private System.Windows.Forms.Button btnTimeClient;
//		#region +
//		/// <summary>
//		/// 필수 디자이너 변수입니다.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public 라_타임서버()
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
//			this.btnStart = new System.Windows.Forms.Button();
//			this.btnEnd = new System.Windows.Forms.Button();
//			this.btnTimeClient = new System.Windows.Forms.Button();
//			this.SuspendLayout();
//			// 
//			// btnStart
//			// 
//			this.btnStart.Location = new System.Drawing.Point(24, 16);
//			this.btnStart.Name = "btnStart";
//			this.btnStart.Size = new System.Drawing.Size(136, 23);
//			this.btnStart.TabIndex = 0;
//			this.btnStart.Text = "타임 서버 시작";
//			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
//			// 
//			// btnEnd
//			// 
//			this.btnEnd.Location = new System.Drawing.Point(24, 56);
//			this.btnEnd.Name = "btnEnd";
//			this.btnEnd.Size = new System.Drawing.Size(136, 23);
//			this.btnEnd.TabIndex = 1;
//			this.btnEnd.Text = "타임 서버 종료";
//			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
//			// 
//			// btnTimeClient
//			// 
//			this.btnTimeClient.Location = new System.Drawing.Point(24, 96);
//			this.btnTimeClient.Name = "btnTimeClient";
//			this.btnTimeClient.Size = new System.Drawing.Size(136, 23);
//			this.btnTimeClient.TabIndex = 2;
//			this.btnTimeClient.Text = "타임 클라이언트 실행";
//			this.btnTimeClient.Click += new System.EventHandler(this.btnTimeClient_Click);
//			// 
//			// 라_타임서버
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(184, 133);
//			this.Controls.Add(this.btnTimeClient);
//			this.Controls.Add(this.btnEnd);
//			this.Controls.Add(this.btnStart);
//			this.Name = "라_타임서버";
//			this.Text = "라_타임서버";
//			this.ResumeLayout(false);

//		}
//		#endregion
//		#endregion
//		public NetworkStream stream;//네트워크 스트림
//		public const int port = 7007;//타임 서버 포트

//		System.Net.Sockets.TcpListener listener = null;//TCP 리스너

//		StreamWriter write = null; // 쓰기 스트림

//		Thread th = null;//스레드

//		private void Accept()
//		{
//			try
//			{
//				//listener = new System.Net.Sockets.TcpListener(port);
//				listener.Start();
//			}
//			catch(Exception ex)
//			{
//				MessageBox.Show("에러메시지 : " + ex.StackTrace);
//			}
//			btnStart.Enabled = false;
//			btnEnd.Enabled = true;

//			System.Net.Sockets.Socket client = listener.AcceptSocket();

//			if(client.Connected)
//			{
//				stream = new NetworkStream(client);
//				write = new StreamWriter(stream);
//				write.WriteLine(DateTime.Now);//현재 시간 전송
//				write.Flush();
//			}
//		}

//		private void Stop()
//		{
//			try
//			{
//				listener.Stop();
//			}
//			catch(Exception ex)
//			{
//				MessageBox.Show("에러 메시지 : " + ex.StackTrace);
//			}
//			btnStart.Enabled = true;
//			btnEnd.Enabled = false;
//		}

//		private void btnStart_Click(object sender, System.EventArgs e)
//		{
//			th = new Thread(new ThreadStart(Accept));
//			th.Start();
//		}

//		private void btnEnd_Click(object sender, System.EventArgs e)
//		{
//			this.Stop();
//			try
//			{
//				th.Abort();
//			}
//			catch
//			{
			
//			}
//		}

//		private void btnTimeClient_Click(object sender, System.EventArgs e)
//		{
//			마_타임클라이언트 client = new 마_타임클라이언트();
//			client.Show();
//		}
//	}
//}
