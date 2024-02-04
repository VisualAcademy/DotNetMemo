using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[0]
using System.Net;

namespace CSharp_Network.강의샘플
{
	/// <summary>
	/// 일_아이피주소출력프로그램에 대한 요약 설명입니다.
	/// </summary>
	public class 가_아이피주소출력프로그램 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.ListBox listBox1;
		#region +
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 가_아이피주소출력프로그램()
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
			this.btnOK = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "주소입력 : ";
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(80, 24);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(200, 21);
			this.txtUrl.TabIndex = 1;
			this.txtUrl.Text = "";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(88, 232);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(136, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "확인";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// listBox1
			// 
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(8, 56);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(272, 160);
			this.listBox1.TabIndex = 3;
			// 
			// 가_아이피주소출력프로그램
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.label1);
			this.Name = "가_아이피주소출력프로그램";
			this.Text = "일_아이피주소출력프로그램";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void btnOK_Click(object sender, System.EventArgs e)
		{
			////IPHostEntry : 호스트 상세 정보 제공 클래스
			//System.Net.IPHostEntry host = 
			//	//Dns : 호스트 이름을 IP 주소로 변환
			//	System.Net.Dns.Resolve(this.txtUrl.Text);

   //         this.listBox1.Items.Add("호스트 이름 : " + host.HostName);
			//this.listBox1.Items.Add("아이피 주소 리스트 : ");
			//for(int i = 0;i < host.AddressList.Length;i++)
			//{
			//	//IPAddress : IP 주소 제공
			//	System.Net.IPAddress ip = host.AddressList[i];
			//	this.listBox1.Items.Add(String.Format("[{0}]", ip));
			//}
		}
	}
}
