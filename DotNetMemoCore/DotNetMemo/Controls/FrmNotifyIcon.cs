//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace CSharp_Windows.Controls
//{
//	/// <summary>
//	/// FrmNotifyIcon에 대한 요약 설명입니다.
//	/// </summary>
//	public class FrmNotifyIcon : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.NotifyIcon notifyIcon1;
//		private System.Windows.Forms.ContextMenu contextMenu1;
//		private System.Windows.Forms.MenuItem menuItem1;
//		private System.ComponentModel.IContainer components;

//		public FrmNotifyIcon()
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
//			this.components = new System.ComponentModel.Container();
//			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmNotifyIcon));
//			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
//			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
//			this.menuItem1 = new System.Windows.Forms.MenuItem();
//			// 
//			// notifyIcon1
//			// 
//			this.notifyIcon1.ContextMenu = this.contextMenu1;
//			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
//			this.notifyIcon1.Text = "notifyIcon1";
//			this.notifyIcon1.Visible = true;
//			this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
//			// 
//			// contextMenu1
//			// 
//			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																								 this.menuItem1});
//			// 
//			// menuItem1
//			// 
//			this.menuItem1.Index = 0;
//			this.menuItem1.Text = "프로그램 종료";
//			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
//			// 
//			// FrmNotifyIcon
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(292, 21);
//			this.Name = "FrmNotifyIcon";
//			this.Text = "FrmNotifyIcon";

//		}
//		#endregion

//		private void menuItem1_Click(object sender, System.EventArgs e)
//		{
//			Application.Exit();
//		}

//		private void notifyIcon1_DoubleClick(object sender, System.EventArgs e)
//		{
//			MessageBox.Show("더블 클릭됨.");
//		}
//	}
//}
