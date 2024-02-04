using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.링크레이블
{
	/// <summary>
	/// FrmLinkLabel : HTML의 링크 모양의 레이블
	/// </summary>
	public class FrmLinkLabel : System.Windows.Forms.Form
	{
		#region Controls
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.LinkLabel lnkUrl;
		private System.Windows.Forms.LinkLabel lnkCDrive;
		private System.Windows.Forms.LinkLabel lnkNotepad;
		#endregion

		#region Private Members
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		#region Constructors
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
		#endregion

		#region Protected Methods
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
		#endregion

		#region Windows Form Designer generated code
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
			this.lnkUrl = new System.Windows.Forms.LinkLabel();
			this.lnkCDrive = new System.Windows.Forms.LinkLabel();
			this.lnkNotepad = new System.Windows.Forms.LinkLabel();
			this.btnClose = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(24, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(230, 29);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "작성자 : 강사";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "홈페이지 : ";
			// 
			// lnkUrl
			// 
			this.lnkUrl.LinkVisited = true;
			this.lnkUrl.Location = new System.Drawing.Point(88, 88);
			this.lnkUrl.Name = "lnkUrl";
			this.lnkUrl.Size = new System.Drawing.Size(192, 23);
			this.lnkUrl.TabIndex = 3;
			this.lnkUrl.TabStop = true;
			this.lnkUrl.Text = "http://www.dotnetkorea.com/";
			this.lnkUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// lnkCDrive
			// 
			this.lnkCDrive.LinkVisited = true;
			this.lnkCDrive.Location = new System.Drawing.Point(104, 128);
			this.lnkCDrive.Name = "lnkCDrive";
			this.lnkCDrive.Size = new System.Drawing.Size(152, 23);
			this.lnkCDrive.TabIndex = 4;
			this.lnkCDrive.TabStop = true;
			this.lnkCDrive.Text = "로컬 C 드라이브 열기";
			this.lnkCDrive.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// lnkNotepad
			// 
			this.lnkNotepad.LinkVisited = true;
			this.lnkNotepad.Location = new System.Drawing.Point(104, 168);
			this.lnkNotepad.Name = "lnkNotepad";
			this.lnkNotepad.Size = new System.Drawing.Size(144, 23);
			this.lnkNotepad.TabIndex = 5;
			this.lnkNotepad.TabStop = true;
			this.lnkNotepad.Text = "메모장(편집기) 열기";
			this.lnkNotepad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(104, 240);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "확인(&O)";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "로컬경로 : ";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "프로그램 :";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 200);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "버전(주/부/빌/수) : ";
			// 
			// lblVersion
			// 
			this.lblVersion.Location = new System.Drawing.Point(136, 200);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.TabIndex = 10;
			// 
			// FrmLinkLabel
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(280, 285);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lnkNotepad);
			this.Controls.Add(this.lnkCDrive);
			this.Controls.Add(this.lnkUrl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "FrmLinkLabel";
			this.Text = "프로그램 정보";
			this.Load += new System.EventHandler(this.FrmLinkLabel_Load);
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		//로컬 경로 이동 링크 버튼 만들기
		private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("C:\\");
		}
		//확인 버튼
		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();//닫기
		}
		//홈페이지 이동 링크 버튼 만들기
		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.lnkUrl.VisitedLinkColor = Color.Black;//클릭 후 색상
			System.Diagnostics.Process.Start(
				"IExplore", "http://www.dotnetkorea.com/");
		}
		//패스가 지정된 프로그램 실행
		private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("notepad");
			this.lnkNotepad.VisitedLinkColor = Color.Black;//클릭 후 색상
		}

		private void FrmLinkLabel_Load(object sender, System.EventArgs e)
		{
			this.lblVersion.Text = 
				System.Environment.Version.ToString();//버전 표시
		}
		#endregion
	}
}
