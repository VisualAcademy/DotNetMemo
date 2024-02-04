//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace CSharp_Windows.편집메뉴처리
//{
//	/// <summary>
//	/// FrmEditMenu에 대한 요약 설명입니다.
//	/// </summary>
//	public class FrmEditMenu : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.MainMenu mmFrmEditMenu;
//		private System.Windows.Forms.MenuItem menuItem1;
//		private System.Windows.Forms.MenuItem menuItem2;
//		private System.Windows.Forms.MenuItem menuItem3;
//		private System.Windows.Forms.MenuItem menuItem4;
//		private System.Windows.Forms.MenuItem menuItem5;
//		private System.Windows.Forms.MenuItem menuItem6;
//		private System.Windows.Forms.MenuItem menuItem7;
//		private System.Windows.Forms.MenuItem menuItem8;
//		private System.Windows.Forms.MenuItem menuItem9;
//		private System.Windows.Forms.TextBox textBox1;
//		private System.Windows.Forms.TextBox textBox2;
//		/// <summary>
//		/// 필수 디자이너 변수입니다.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmEditMenu()
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

//		#region Windows Form Designer generated code
//		/// <summary>
//		/// 디자이너 지원에 필요한 메서드입니다.
//		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
//		/// </summary>
//		private void InitializeComponent()
//		{
//			this.mmFrmEditMenu = new System.Windows.Forms.MainMenu();
//			this.menuItem1 = new System.Windows.Forms.MenuItem();
//			this.menuItem2 = new System.Windows.Forms.MenuItem();
//			this.menuItem3 = new System.Windows.Forms.MenuItem();
//			this.menuItem4 = new System.Windows.Forms.MenuItem();
//			this.menuItem5 = new System.Windows.Forms.MenuItem();
//			this.menuItem6 = new System.Windows.Forms.MenuItem();
//			this.menuItem7 = new System.Windows.Forms.MenuItem();
//			this.menuItem8 = new System.Windows.Forms.MenuItem();
//			this.menuItem9 = new System.Windows.Forms.MenuItem();
//			this.textBox1 = new System.Windows.Forms.TextBox();
//			this.textBox2 = new System.Windows.Forms.TextBox();
//			this.SuspendLayout();
//			// 
//			// mmFrmEditMenu
//			// 
//			this.mmFrmEditMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																									this.menuItem1});
//			// 
//			// menuItem1
//			// 
//			this.menuItem1.Index = 0;
//			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																							this.menuItem2,
//																																							this.menuItem3,
//																																							this.menuItem4,
//																																							this.menuItem5,
//																																							this.menuItem6,
//																																							this.menuItem7,
//																																							this.menuItem8,
//																																							this.menuItem9});
//			this.menuItem1.Text = "편집(&E)";
//			// 
//			// menuItem2
//			// 
//			this.menuItem2.Index = 0;
//			this.menuItem2.Text = "취소";
//			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
//			// 
//			// menuItem3
//			// 
//			this.menuItem3.Index = 1;
//			this.menuItem3.Text = "-";
//			// 
//			// menuItem4
//			// 
//			this.menuItem4.Index = 2;
//			this.menuItem4.Text = "잘라내기";
//			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
//			// 
//			// menuItem5
//			// 
//			this.menuItem5.Index = 3;
//			this.menuItem5.Text = "복사";
//			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
//			// 
//			// menuItem6
//			// 
//			this.menuItem6.Index = 4;
//			this.menuItem6.Text = "붙여넣기";
//			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
//			// 
//			// menuItem7
//			// 
//			this.menuItem7.Index = 5;
//			this.menuItem7.Text = "삭제";
//			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
//			// 
//			// menuItem8
//			// 
//			this.menuItem8.Index = 6;
//			this.menuItem8.Text = "-";
//			// 
//			// menuItem9
//			// 
//			this.menuItem9.Index = 7;
//			this.menuItem9.Text = "모두선택";
//			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
//			// 
//			// textBox1
//			// 
//			this.textBox1.Location = new System.Drawing.Point(24, 40);
//			this.textBox1.Name = "textBox1";
//			this.textBox1.Size = new System.Drawing.Size(224, 21);
//			this.textBox1.TabIndex = 0;
//			this.textBox1.Text = "";
//			// 
//			// textBox2
//			// 
//			this.textBox2.Location = new System.Drawing.Point(24, 144);
//			this.textBox2.Name = "textBox2";
//			this.textBox2.Size = new System.Drawing.Size(224, 21);
//			this.textBox2.TabIndex = 1;
//			this.textBox2.Text = "";
//			// 
//			// FrmEditMenu
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(292, 273);
//			this.Controls.AddRange(new System.Windows.Forms.Control[] {
//																																	this.textBox2,
//																																	this.textBox1});
//			this.Menu = this.mmFrmEditMenu;
//			this.Name = "FrmEditMenu";
//			this.Text = "편집 메뉴 작성하기";
//			this.ResumeLayout(false);

//		}
//		#endregion

//		//취소 버튼 구현
//		private void menuItem2_Click(object sender, System.EventArgs e)
//		{
//			//TextBox 객체를 하나 생성하고, 이를 ActiveControl로 지정한다.
//			TextBox objTextBox = new TextBox();
//			//현재 프로그램에서 ActiceControl(활성화된 컨트롤:텍스트 박스) 지정
//			objTextBox = (TextBox)this.ActiveControl;
//			//활성화된 텍스트 박스의 내용을 취소
//			objTextBox.Undo();
//		}
//		//잘라내기
//		private void menuItem4_Click(object sender, System.EventArgs e){
//			TextBox objTextBox = new TextBox();
//			objTextBox = (TextBox)this.ActiveControl;
//			objTextBox.Cut();
//		}
//		//복사
//		private void menuItem5_Click(object sender, System.EventArgs e){
//			TextBox objTextBox = new TextBox();
//			objTextBox = (TextBox)this.ActiveControl;
//			objTextBox.Copy();
//		}
//		//붙여넣기
//		private void menuItem6_Click(object sender, System.EventArgs e){
//			TextBox objTextBox = new TextBox();
//			objTextBox = (TextBox)this.ActiveControl;
//			objTextBox.Paste();
//		}
//		//삭제
//		private void menuItem7_Click(object sender, System.EventArgs e){
//			TextBox objTextBox = new TextBox();
//			objTextBox = (TextBox)this.ActiveControl;
//			objTextBox.Cut();
//		}
//		//모두선택
//		private void menuItem9_Click(object sender, System.EventArgs e){
//			TextBox objTextBox = new TextBox();
//			objTextBox = (TextBox)this.ActiveControl;
//			objTextBox.SelectAll();
//		}
//	}
//}
