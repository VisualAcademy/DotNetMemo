using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace CSharp_Network.강의샘플
{
	/// <summary>
	/// 이_웹사이트정보출력프로그램에 대한 요약 설명입니다.
	/// </summary>
	public class 나_웹사이트정보출력프로그램 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtWebsite;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox txtDisplay;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 나_웹사이트정보출력프로그램()
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
			this.txtWebsite = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.txtDisplay = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "정보를 출력할 웹사이트 : ";
			// 
			// txtWebsite
			// 
			this.txtWebsite.Location = new System.Drawing.Point(8, 24);
			this.txtWebsite.Name = "txtWebsite";
			this.txtWebsite.Size = new System.Drawing.Size(424, 21);
			this.txtWebsite.TabIndex = 1;
			this.txtWebsite.Text = "";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(352, 0);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(80, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "확인";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// txtDisplay
			// 
			this.txtDisplay.Location = new System.Drawing.Point(8, 48);
			this.txtDisplay.Multiline = true;
			this.txtDisplay.Name = "txtDisplay";
			this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtDisplay.Size = new System.Drawing.Size(424, 224);
			this.txtDisplay.TabIndex = 3;
			this.txtDisplay.Text = "";
			// 
			// 나_웹사이트정보출력프로그램
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(440, 285);
			this.Controls.Add(this.txtDisplay);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtWebsite);
			this.Controls.Add(this.label1);
			this.Name = "나_웹사이트정보출력프로그램";
			this.Text = "이_웹사이트정보출력프로그램";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient();
			try
			{
				client.Connect(this.txtWebsite.Text.Trim(), 80);	
			}
			catch
			{
				MessageBox.Show("서버에 접속할 수 없습니다.");
			}

			Stream stream = client.GetStream();

			string msg = "GET /default.asp HTTP/1.0\r\n\n";
			Byte [] byteSend = System.Text.Encoding.Default.GetBytes(msg.ToCharArray());

			stream.Write(byteSend, 0, byteSend.Length);

			stream.Flush();

			byte [] response = new byte[256];
			int size = stream.Read(response, 0, response.Length);

			this.txtDisplay.AppendText("받은 바이트 수 : " + size + "Byte \r\n");
			this.txtDisplay.AppendText("서버에서 보내준 메시지 : \r\n");
			this.txtDisplay.AppendText(System.Text.Encoding.Default.GetString(response));
		}
	}
}
