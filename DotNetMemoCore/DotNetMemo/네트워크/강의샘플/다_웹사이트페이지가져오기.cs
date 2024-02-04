using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//
using System.Net;
using System.Text;
using System.IO;

namespace CSharp_Network.강의샘플
{
	/// <summary>
	/// 다_웹사이트페이지가져오기에 대한 요약 설명입니다.
	/// </summary>
	public class 다_웹사이트페이지가져오기 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Button btnGet;
		private System.Windows.Forms.TextBox txtSource;
		#region +
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 다_웹사이트페이지가져오기()
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
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.btnGet = new System.Windows.Forms.Button();
			this.txtSource = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(496, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "웹 페이지 읽어오기";
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(0, 32);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(408, 21);
			this.txtUrl.TabIndex = 1;
			this.txtUrl.Text = "";
			// 
			// btnGet
			// 
			this.btnGet.Location = new System.Drawing.Point(416, 32);
			this.btnGet.Name = "btnGet";
			this.btnGet.TabIndex = 2;
			this.btnGet.Text = "가져오기";
			this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
			// 
			// txtSource
			// 
			this.txtSource.Location = new System.Drawing.Point(0, 56);
			this.txtSource.Multiline = true;
			this.txtSource.Name = "txtSource";
			this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtSource.Size = new System.Drawing.Size(488, 456);
			this.txtSource.TabIndex = 3;
			this.txtSource.Text = "";
			// 
			// 다_웹사이트페이지가져오기
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(496, 525);
			this.Controls.Add(this.txtSource);
			this.Controls.Add(this.btnGet);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.label1);
			this.Name = "다_웹사이트페이지가져오기";
			this.Text = "다_웹사이트페이지가져오기";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void btnGet_Click(object sender, System.EventArgs e)
		{
			//웹 페이지 연결
			System.Net.WebRequest request = WebRequest.Create(this.txtUrl.Text.Trim());

			//서버가 보내는 스트림 연결
			System.Net.WebResponse response = request.GetResponse();
			System.IO.Stream stream = response.GetResponseStream();

			//스트림에서 데이터 읽기
			StreamReader read = new StreamReader(stream, System.Text.Encoding.Default);
			
			//문자열을 효율적으로 처리하기 위해 StringBuilder 클래스 선언
			StringBuilder strData = new StringBuilder();

			//문장 단위로 데이터 읽어오기
			while(read.ReadLine() != null)
			{
				strData.Append(read.ReadLine() + "\r\n");
			}

			//스트림 닫기
			read.Close();

			//화면에 출력
			this.txtSource.Text = strData.ToString();
		}
	}
}
