using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.BuiltInClass
{
	/// <summary>
	/// FrmDirectoryInfo에 대한 요약 설명입니다.
	/// </summary>
	public class FrmDirectoryInfo : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmDirectoryInfo()
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "C:\\Program Files\\Internet Explorer";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(40, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "전체 경로 :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(40, 72);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "디렉터리 이름:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(40, 96);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "생성일 : ";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(40, 120);
			this.label5.Name = "label5";
			this.label5.TabIndex = 4;
			this.label5.Text = "속성:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(40, 144);
			this.label6.Name = "label6";
			this.label6.TabIndex = 5;
			this.label6.Text = "루트 경로:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(40, 168);
			this.label7.Name = "label7";
			this.label7.TabIndex = 6;
			this.label7.Text = "부모 디렉터리";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(160, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(192, 23);
			this.label8.TabIndex = 7;
			this.label8.Text = "label8";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(160, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(192, 23);
			this.label9.TabIndex = 8;
			this.label9.Text = "label9";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(160, 96);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(192, 23);
			this.label10.TabIndex = 9;
			this.label10.Text = "label10";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(160, 120);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(192, 23);
			this.label11.TabIndex = 10;
			this.label11.Text = "label11";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(160, 144);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(192, 23);
			this.label12.TabIndex = 11;
			this.label12.Text = "label12";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(160, 168);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(192, 23);
			this.label13.TabIndex = 12;
			this.label13.Text = "label13";
			// 
			// label14
			// 
			this.label14.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label14.Location = new System.Drawing.Point(0, 206);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(592, 23);
			this.label14.TabIndex = 13;
			this.label14.Text = "교재 100 / 102페이지 참고";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(376, 56);
			this.label15.Name = "label15";
			this.label15.TabIndex = 14;
			this.label15.Text = "폴더명:";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(376, 79);
			this.label16.Name = "label16";
			this.label16.TabIndex = 15;
			this.label16.Text = "파일명:";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(376, 102);
			this.label17.Name = "label17";
			this.label17.TabIndex = 16;
			this.label17.Text = "확장자:";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(376, 125);
			this.label18.Name = "label18";
			this.label18.TabIndex = 17;
			this.label18.Text = "생성일:";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(376, 148);
			this.label19.Name = "label19";
			this.label19.TabIndex = 18;
			this.label19.Text = "파일크기:";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(376, 171);
			this.label20.Name = "label20";
			this.label20.TabIndex = 19;
			this.label20.Text = "파일속성:";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(488, 48);
			this.label21.Name = "label21";
			this.label21.TabIndex = 20;
			this.label21.Text = "label21";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(488, 73);
			this.label22.Name = "label22";
			this.label22.TabIndex = 21;
			this.label22.Text = "label22";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(488, 98);
			this.label23.Name = "label23";
			this.label23.TabIndex = 22;
			this.label23.Text = "label23";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(488, 123);
			this.label24.Name = "label24";
			this.label24.TabIndex = 23;
			this.label24.Text = "label24";
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(488, 148);
			this.label25.Name = "label25";
			this.label25.TabIndex = 24;
			this.label25.Text = "label25";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(488, 173);
			this.label26.Name = "label26";
			this.label26.TabIndex = 25;
			this.label26.Text = "label26";
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(392, 16);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(144, 23);
			this.label27.TabIndex = 26;
			this.label27.Text = "C:\\boot.ini";
			// 
			// FrmDirectoryInfo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(592, 229);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmDirectoryInfo";
			this.Text = "FrmDirectoryInfo";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
