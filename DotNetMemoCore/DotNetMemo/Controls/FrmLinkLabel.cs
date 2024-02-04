using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// Form1에 대한 요약 설명입니다.
	/// </summary>
	public class FrmLinkLabel : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.LinkLabel lnkUrl;
		private System.Windows.Forms.LinkLabel lnkCDrive;
		private System.Windows.Forms.LinkLabel lnkNotepad;
		private System.Windows.Forms.Label lblVersion;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmLinkLabel()
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
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmLinkLabel));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lnkUrl = new System.Windows.Forms.LinkLabel();
			this.lnkCDrive = new System.Windows.Forms.LinkLabel();
			this.lnkNotepad = new System.Windows.Forms.LinkLabel();
			this.lblVersion = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(48, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(232, 32);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "홈페이지 :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(48, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "로컬경로 :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(48, 176);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "프로그램 :";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(48, 216);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "버전(주/부/빌/수) :";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(136, 272);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 24);
			this.button1.TabIndex = 5;
			this.button1.Text = "확인(&O)";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lnkUrl
			// 
			this.lnkUrl.Location = new System.Drawing.Point(128, 96);
			this.lnkUrl.Name = "lnkUrl";
			this.lnkUrl.Size = new System.Drawing.Size(176, 23);
			this.lnkUrl.TabIndex = 6;
			this.lnkUrl.TabStop = true;
			this.lnkUrl.Text = "http://www.dotnetkorea.com";
			this.lnkUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUrl_LinkClicked);
			// 
			// lnkCDrive
			// 
			this.lnkCDrive.Location = new System.Drawing.Point(128, 136);
			this.lnkCDrive.Name = "lnkCDrive";
			this.lnkCDrive.Size = new System.Drawing.Size(152, 23);
			this.lnkCDrive.TabIndex = 7;
			this.lnkCDrive.TabStop = true;
			this.lnkCDrive.Text = "로컬 C 드라이브 열기";
			this.lnkCDrive.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCDrive_LinkClicked);
			// 
			// lnkNotepad
			// 
			this.lnkNotepad.Location = new System.Drawing.Point(128, 176);
			this.lnkNotepad.Name = "lnkNotepad";
			this.lnkNotepad.Size = new System.Drawing.Size(144, 23);
			this.lnkNotepad.TabIndex = 8;
			this.lnkNotepad.TabStop = true;
			this.lnkNotepad.Text = "메모장(편집기) 열기";
			this.lnkNotepad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNotepad_LinkClicked);
			// 
			// lblVersion
			// 
			this.lblVersion.Location = new System.Drawing.Point(176, 216);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(144, 24);
			this.lblVersion.TabIndex = 9;
			// 
			// FrmLinkLabel
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(376, 333);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.lnkNotepad);
			this.Controls.Add(this.lnkCDrive);
			this.Controls.Add(this.lnkUrl);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "FrmLinkLabel";
			this.Text = "프로그램 정보";
			this.Load += new System.EventHandler(this.FrmLinkLabel_Load);
			this.ResumeLayout(false);

		}
		#endregion
		#region 링크레이블 컨트롤
		//로컬 경로 이동 링크 버튼 만들기
		private void lnkCDrive_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("c:\\");
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();	//닫기
		}
		//홈페이지 이동 링크 버튼 만들기
		private void lnkUrl_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.lnkUrl.VisitedLinkColor = Color.Black;	//클릭 후 색상
			System.Diagnostics.Process.Start
				("IExplore", "http://www.dotnetkorea.com/");
		}
		//패스가 지정된 프로그램 실행
		private void lnkNotepad_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("notepad");
			this.lnkNotepad.VisitedLinkColor = Color.Black;	//클릭 후 색상
		}
		//
		private void FrmLinkLabel_Load(object sender, System.EventArgs e)
		{
			this.lblVersion.Text = System.Environment.Version.ToString();
		}
		#endregion

	}
}
