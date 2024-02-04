//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace CSharp_Windows.컨텍스트메뉴
//{
//	/// <summary>
//	/// FrmContextMenu에 대한 요약 설명입니다.
//	/// </summary>
//	public class FrmContextMenu : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.ContextMenu contextMenu1;
//		private System.Windows.Forms.MenuItem menuItem1;
//		private System.Windows.Forms.MenuItem menuItem2;
//		private System.Windows.Forms.Panel panel1;
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
//			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
//			this.menuItem1 = new System.Windows.Forms.MenuItem();
//			this.menuItem2 = new System.Windows.Forms.MenuItem();
//			this.panel1 = new System.Windows.Forms.Panel();
//			this.SuspendLayout();
//			// 
//			// contextMenu1
//			// 
//			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																						 this.menuItem1,
//																						 this.menuItem2});
//			// 
//			// menuItem1
//			// 
//			this.menuItem1.Index = 0;
//			this.menuItem1.Text = "&Message";
//			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
//			// 
//			// menuItem2
//			// 
//			this.menuItem2.Index = 1;
//			this.menuItem2.Text = "&Exit";
//			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
//			// 
//			// panel1
//			// 
//			this.panel1.ContextMenu = this.contextMenu1;
//			this.panel1.Location = new System.Drawing.Point(48, 64);
//			this.panel1.Name = "panel1";
//			this.panel1.TabIndex = 0;
//			// 
//			// FrmContextMenu
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(292, 273);
//			this.Controls.Add(this.panel1);
//			this.Name = "FrmContextMenu";
//			this.Text = "컨텍스트메뉴 컨트롤";
//			this.ResumeLayout(false);

//		}
//		#endregion

//		private void menuItem1_Click(object sender, System.EventArgs e)
//		{
//			MessageBox.Show("Message 메뉴가 클릭되었습니다.");
//		}

//		private void menuItem2_Click(object sender, System.EventArgs e)
//		{
//			this.Close();
//		}
//	}
//}
