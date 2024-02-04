//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace CSharp_Windows.Controls
//{
//	/// <summary>
//	/// FrmContextMenu에 대한 요약 설명입니다.
//	/// </summary>
//	public class FrmContextMenu : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.Button btnClick;
//		private System.Windows.Forms.Panel pnlClick;
//		private System.Windows.Forms.ContextMenu cmFrmContextMenu;
//		private System.Windows.Forms.ContextMenu cmBtnClick;
//		private System.Windows.Forms.ContextMenu cmPnlClick;
//		private System.Windows.Forms.MenuItem menuItem1;
//		private System.Windows.Forms.MenuItem menuItem2;
//		private System.Windows.Forms.MenuItem menuItem3;
//		/// <summary>
//		/// 필수 디자이너 변수입니다.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmContextMenu()
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
//      this.cmFrmContextMenu = new System.Windows.Forms.ContextMenu();
//      this.menuItem1 = new System.Windows.Forms.MenuItem();
//      this.cmBtnClick = new System.Windows.Forms.ContextMenu();
//      this.menuItem2 = new System.Windows.Forms.MenuItem();
//      this.cmPnlClick = new System.Windows.Forms.ContextMenu();
//      this.menuItem3 = new System.Windows.Forms.MenuItem();
//      this.btnClick = new System.Windows.Forms.Button();
//      this.pnlClick = new System.Windows.Forms.Panel();
//      this.SuspendLayout();
//      // 
//      // cmFrmContextMenu
//      // 
//      this.cmFrmContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//            this.menuItem1});
//      // 
//      // menuItem1
//      // 
//      this.menuItem1.Index = 0;
//      this.menuItem1.Text = "프로그램 종료";
//      this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
//      // 
//      // cmBtnClick
//      // 
//      this.cmBtnClick.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//            this.menuItem2});
//      // 
//      // menuItem2
//      // 
//      this.menuItem2.Index = 0;
//      this.menuItem2.Text = "메시지 출력";
//      this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
//      // 
//      // cmPnlClick
//      // 
//      this.cmPnlClick.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//            this.menuItem3});
//      // 
//      // menuItem3
//      // 
//      this.menuItem3.Index = 0;
//      this.menuItem3.Text = "패널 배경 색상 변경";
//      this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
//      // 
//      // btnClick
//      // 
//      this.btnClick.ContextMenu = this.cmBtnClick;
//      this.btnClick.Location = new System.Drawing.Point(32, 48);
//      this.btnClick.Name = "btnClick";
//      this.btnClick.Size = new System.Drawing.Size(75, 23);
//      this.btnClick.TabIndex = 0;
//      this.btnClick.Text = "클릭하세요";
//      // 
//      // pnlClick
//      // 
//      this.pnlClick.ContextMenu = this.cmPnlClick;
//      this.pnlClick.Location = new System.Drawing.Point(128, 16);
//      this.pnlClick.Name = "pnlClick";
//      this.pnlClick.Size = new System.Drawing.Size(200, 100);
//      this.pnlClick.TabIndex = 1;
//      // 
//      // FrmContextMenu
//      // 
//      this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//      this.ClientSize = new System.Drawing.Size(352, 141);
//      this.ContextMenu = this.cmFrmContextMenu;
//      this.Controls.Add(this.pnlClick);
//      this.Controls.Add(this.btnClick);
//      this.Name = "FrmContextMenu";
//      this.Text = "FrmContextMenu";
//      this.ResumeLayout(false);

//		}
//		#endregion

//		private void menuItem1_Click(object sender, System.EventArgs e)
//		{
//			//Application.Exit();
//			this.Close();
//		}

//		private void menuItem2_Click(object sender, System.EventArgs e)
//		{
//			MessageBox.Show("버튼 클릭");
//		}

//		private void menuItem3_Click(object sender, System.EventArgs e)
//		{
//			this.pnlClick.BackColor = 
//				Color.Yellow;
//		}
//	}
//}
