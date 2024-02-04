//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace CSharp_Windows.Applications
//{
//	/// <summary>
//	/// FrmNotepad에 대한 요약 설명입니다.
//	/// </summary>
//	public class FrmNotepad : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.MainMenu mmNotepad;
//		private System.Windows.Forms.TextBox txtInput;
//		private System.Windows.Forms.MenuItem menuItem1;
//		private System.Windows.Forms.MenuItem menuItem2;
//		private System.Windows.Forms.MenuItem menuItem3;
//		private System.Windows.Forms.MenuItem menuItem4;
//		private System.Windows.Forms.MenuItem menuItem5;
//		private System.Windows.Forms.MenuItem menuItem6;
//		private System.Windows.Forms.MenuItem menuItem7;
//		private System.Windows.Forms.MenuItem menuItem8;
//		private System.Windows.Forms.MenuItem menuItem9;
//		private System.Windows.Forms.MenuItem menuItem10;
//		private System.Windows.Forms.MenuItem menuItem11;
//		private System.Windows.Forms.MenuItem menuItem12;
//		private System.Windows.Forms.MenuItem menuItem13;
//		private System.Windows.Forms.MenuItem menuItem14;
//		private System.Windows.Forms.MenuItem menuItem15;
//		/// <summary>
//		/// 필수 디자이너 변수입니다.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmNotepad()
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
//			this.mmNotepad = new System.Windows.Forms.MainMenu();
//			this.txtInput = new System.Windows.Forms.TextBox();
//			this.menuItem1 = new System.Windows.Forms.MenuItem();
//			this.menuItem2 = new System.Windows.Forms.MenuItem();
//			this.menuItem3 = new System.Windows.Forms.MenuItem();
//			this.menuItem4 = new System.Windows.Forms.MenuItem();
//			this.menuItem5 = new System.Windows.Forms.MenuItem();
//			this.menuItem6 = new System.Windows.Forms.MenuItem();
//			this.menuItem7 = new System.Windows.Forms.MenuItem();
//			this.menuItem8 = new System.Windows.Forms.MenuItem();
//			this.menuItem9 = new System.Windows.Forms.MenuItem();
//			this.menuItem10 = new System.Windows.Forms.MenuItem();
//			this.menuItem11 = new System.Windows.Forms.MenuItem();
//			this.menuItem12 = new System.Windows.Forms.MenuItem();
//			this.menuItem13 = new System.Windows.Forms.MenuItem();
//			this.menuItem14 = new System.Windows.Forms.MenuItem();
//			this.menuItem15 = new System.Windows.Forms.MenuItem();
//			this.SuspendLayout();
//			// 
//			// mmNotepad
//			// 
//			this.mmNotepad.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																							this.menuItem1,
//																																							this.menuItem2,
//																																							this.menuItem3,
//																																							this.menuItem4});
//			// 
//			// txtInput
//			// 
//			this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
//			this.txtInput.Location = new System.Drawing.Point(0, 0);
//			this.txtInput.Multiline = true;
//			this.txtInput.Name = "txtInput";
//			this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
//			this.txtInput.Size = new System.Drawing.Size(320, 162);
//			this.txtInput.TabIndex = 0;
//			this.txtInput.Text = "";
//			// 
//			// menuItem1
//			// 
//			this.menuItem1.Index = 0;
//			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																							this.menuItem5,
//																																							this.menuItem6,
//																																							this.menuItem7,
//																																							this.menuItem8,
//																																							this.menuItem9,
//																																							this.menuItem10,
//																																							this.menuItem11,
//																																							this.menuItem12,
//																																							this.menuItem13});
//			this.menuItem1.Text = "파일(&F)";
//			// 
//			// menuItem2
//			// 
//			this.menuItem2.Index = 1;
//			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																							this.menuItem14});
//			this.menuItem2.Text = "편집(&E)";
//			// 
//			// menuItem3
//			// 
//			this.menuItem3.Index = 2;
//			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																							this.menuItem15});
//			this.menuItem3.Text = "서식(&O)";
//			// 
//			// menuItem4
//			// 
//			this.menuItem4.Index = 3;
//			this.menuItem4.Text = "도움말(&H)";
//			// 
//			// menuItem5
//			// 
//			this.menuItem5.Index = 0;
//			this.menuItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
//			this.menuItem5.Text = "새로 만들기(&N)";
//			// 
//			// menuItem6
//			// 
//			this.menuItem6.Index = 1;
//			this.menuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
//			this.menuItem6.Text = "열기(&O)...";
//			// 
//			// menuItem7
//			// 
//			this.menuItem7.Index = 2;
//			this.menuItem7.Text = "저장(&S)";
//			// 
//			// menuItem8
//			// 
//			this.menuItem8.Index = 3;
//			this.menuItem8.Text = "다른 이름으로 저장(&A)";
//			// 
//			// menuItem9
//			// 
//			this.menuItem9.Index = 4;
//			this.menuItem9.Text = "-";
//			// 
//			// menuItem10
//			// 
//			this.menuItem10.Index = 5;
//			this.menuItem10.Text = "페이지 설정(&U)...";
//			// 
//			// menuItem11
//			// 
//			this.menuItem11.Index = 6;
//			this.menuItem11.Text = "인쇄(&P)...";
//			// 
//			// menuItem12
//			// 
//			this.menuItem12.Index = 7;
//			this.menuItem12.Text = "-";
//			// 
//			// menuItem13
//			// 
//			this.menuItem13.Index = 8;
//			this.menuItem13.Text = "끝내기(&X)";
//			// 
//			// menuItem14
//			// 
//			this.menuItem14.Enabled = false;
//			this.menuItem14.Index = 0;
//			this.menuItem14.Text = "실행 취소(&U)";
//			// 
//			// menuItem15
//			// 
//			this.menuItem15.Checked = true;
//			this.menuItem15.Index = 0;
//			this.menuItem15.Text = "자동 줄 바꿈(&W)";
//			// 
//			// FrmNotepad
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(320, 162);
//			this.Controls.Add(this.txtInput);
//			this.Menu = this.mmNotepad;
//			this.Name = "FrmNotepad";
//			this.Text = "FrmNotepad";
//			this.ResumeLayout(false);

//		}
//		#endregion
//	}
//}
