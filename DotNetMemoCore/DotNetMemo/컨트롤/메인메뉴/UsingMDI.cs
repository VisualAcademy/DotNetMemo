//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace CSharp_Windows.메인메뉴
//{
//	/// <summary>
//	/// UsingMDI에 대한 요약 설명입니다.
//	/// </summary>
//	public class UsingMDI : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.MenuItem menuItem4;
//		private System.Windows.Forms.MainMenu mmMainMenu;
//		private System.Windows.Forms.MenuItem miFile;
//		private System.Windows.Forms.MenuItem miWindow;
//		private System.Windows.Forms.MenuItem miNew;
//		private System.Windows.Forms.MenuItem miExit;
//		private System.Windows.Forms.MenuItem miCascading;
//		private System.Windows.Forms.MenuItem mi가로;
//		private System.Windows.Forms.MenuItem mi세로;
//		private System.Windows.Forms.MenuItem miChild1;
//		private System.Windows.Forms.MenuItem miChild2;
//		private System.Windows.Forms.MenuItem miChild3;
//		/// <summary>
//		/// 필수 디자이너 변수입니다.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public UsingMDI()
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
//			this.mmMainMenu = new System.Windows.Forms.MainMenu();
//			this.miFile = new System.Windows.Forms.MenuItem();
//			this.miWindow = new System.Windows.Forms.MenuItem();
//			this.miNew = new System.Windows.Forms.MenuItem();
//			this.menuItem4 = new System.Windows.Forms.MenuItem();
//			this.miExit = new System.Windows.Forms.MenuItem();
//			this.miChild1 = new System.Windows.Forms.MenuItem();
//			this.miChild2 = new System.Windows.Forms.MenuItem();
//			this.miChild3 = new System.Windows.Forms.MenuItem();
//			this.miCascading = new System.Windows.Forms.MenuItem();
//			this.mi가로 = new System.Windows.Forms.MenuItem();
//			this.mi세로 = new System.Windows.Forms.MenuItem();
//			// 
//			// mmMainMenu
//			// 
//			this.mmMainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																							 this.miFile,
//																																							 this.miWindow});
//			// 
//			// miFile
//			// 
//			this.miFile.Index = 0;
//			this.miFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																					 this.miNew,
//																																					 this.menuItem4,
//																																					 this.miExit});
//			this.miFile.Text = "파일(&F)";
//			// 
//			// miWindow
//			// 
//			this.miWindow.Index = 1;
//			this.miWindow.MdiList = true;
//			this.miWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																						 this.miCascading,
//																																						 this.mi가로,
//																																						 this.mi세로});
//			this.miWindow.Text = "창(&W)";
//			// 
//			// miNew
//			// 
//			this.miNew.Index = 0;
//			this.miNew.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																					this.miChild1,
//																																					this.miChild2,
//																																					this.miChild3});
//			this.miNew.Text = "새로 만들기(&N)";
//			// 
//			// menuItem4
//			// 
//			this.menuItem4.Index = 1;
//			this.menuItem4.Text = "-";
//			// 
//			// miExit
//			// 
//			this.miExit.Index = 2;
//			this.miExit.Text = "끝내기(&X)";
//			this.miExit.Click += new System.EventHandler(this.miExit_Click);
//			// 
//			// miChild1
//			// 
//			this.miChild1.Index = 0;
//			this.miChild1.Text = "자식 창1";
//			this.miChild1.Click += new System.EventHandler(this.miChild1_Click);
//			// 
//			// miChild2
//			// 
//			this.miChild2.Index = 1;
//			this.miChild2.Text = "자식 창2";
//			this.miChild2.Click += new System.EventHandler(this.miChild2_Click);
//			// 
//			// miChild3
//			// 
//			this.miChild3.Index = 2;
//			this.miChild3.Text = "자식 창3";
//			this.miChild3.Click += new System.EventHandler(this.miChild3_Click);
//			// 
//			// miCascading
//			// 
//			this.miCascading.Index = 0;
//			this.miCascading.Text = "계단식 정렬";
//			this.miCascading.Click += new System.EventHandler(this.miCascading_Click);
//			// 
//			// mi가로
//			// 
//			this.mi가로.Index = 1;
//			this.mi가로.Text = "가로 바둑판식";
//			this.mi가로.Click += new System.EventHandler(this.mi가로_Click);
//			// 
//			// mi세로
//			// 
//			this.mi세로.Index = 2;
//			this.mi세로.Text = "세로 바둑판식";
//			this.mi세로.Click += new System.EventHandler(this.mi세로_Click);
//			// 
//			// UsingMDI
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(432, 337);
//			this.IsMdiContainer = true;
//			this.Menu = this.mmMainMenu;
//			this.Name = "UsingMDI";
//			this.Text = "UsingMDI";

//		}
//		#endregion

//		private void miExit_Click(object sender, System.EventArgs e)
//		{
//			Application.Exit();//프로그램 종료
//		}

//		private void miChild1_Click(object sender, System.EventArgs e)
//		{
//			FrmChild fc1 = new FrmChild("자식1");
//			fc1.MdiParent = this;
//			fc1.Show();//새 창
//		}

//		private void miChild2_Click(object sender, System.EventArgs e)
//		{
//			FrmChild fc2 = new FrmChild("자식2");
//			fc2.MdiParent = this;//부모 지정
//			fc2.Show();//현재 MDI 폼에 출력
//		}

//		private void miChild3_Click(object sender, System.EventArgs e)
//		{
//			FrmChild fc3 = new FrmChild("자식3");
//			fc3.MdiParent = this;
//			fc3.Show();
//		}

//		private void miCascading_Click(object sender, System.EventArgs e)
//		{
//			this.LayoutMdi(MdiLayout.Cascade);//계단식 배열
//		}

//		private void mi가로_Click(object sender, System.EventArgs e)
//		{
//			this.LayoutMdi(MdiLayout.TileHorizontal);//가로 배열
//		}

//		private void mi세로_Click(object sender, System.EventArgs e)
//		{
//			this.LayoutMdi(MdiLayout.TileVertical);//세로 배열
//		}
//	}
//}
