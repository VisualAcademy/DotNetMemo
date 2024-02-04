//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace CSharp_Windows.Controls
//{
//	/// <summary>
//	/// FrmStatusBar에 대한 요약 설명입니다.
//	/// </summary>
//	public class FrmStatusBar : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.StatusBar statusBar1;
//		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
//		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
//		private System.Windows.Forms.StatusBarPanel statusBarPanel3;
//		private System.Windows.Forms.Timer timer1;
//		private System.ComponentModel.IContainer components;

//		public FrmStatusBar()
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
//			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmStatusBar));
//			this.statusBar1 = new System.Windows.Forms.StatusBar();
//			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
//			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
//			this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
//			this.timer1 = new System.Windows.Forms.Timer(this.components);
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
//			this.SuspendLayout();
//			// 
//			// statusBar1
//			// 
//			this.statusBar1.Location = new System.Drawing.Point(0, 71);
//			this.statusBar1.Name = "statusBar1";
//			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
//																																									this.statusBarPanel1,
//																																									this.statusBarPanel2,
//																																									this.statusBarPanel3});
//			this.statusBar1.ShowPanels = true;
//			this.statusBar1.Size = new System.Drawing.Size(368, 22);
//			this.statusBar1.TabIndex = 0;
//			this.statusBar1.Text = "완료.";
//			// 
//			// statusBarPanel1
//			// 
//			this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
//			this.statusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised;
//			this.statusBarPanel1.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanel1.Icon")));
//			this.statusBarPanel1.Text = "안녕하세요.";
//			this.statusBarPanel1.Width = 126;
//			// 
//			// statusBarPanel2
//			// 
//			this.statusBarPanel2.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanel2.Icon")));
//			this.statusBarPanel2.Text = "반갑습니다.";
//			// 
//			// statusBarPanel3
//			// 
//			this.statusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
//			this.statusBarPanel3.Width = 126;
//			// 
//			// timer1
//			// 
//			this.timer1.Enabled = true;
//			this.timer1.Interval = 1000;
//			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
//			// 
//			// FrmStatusBar
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(368, 93);
//			this.Controls.Add(this.statusBar1);
//			this.Name = "FrmStatusBar";
//			this.Text = "FrmStatusBar";
//			this.Load += new System.EventHandler(this.FrmStatusBar_Load);
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
//			this.ResumeLayout(false);

//		}
//		#endregion

//		private void FrmStatusBar_Load(object sender, System.EventArgs e)
//		{
//			this.statusBarPanel3.Text = 
//				DateTime.Now.ToLongTimeString();
//		}

//		private void timer1_Tick(object sender, System.EventArgs e)
//		{
//			this.statusBarPanel3.Text = 
//				DateTime.Now.ToLongTimeString();
//		}
//	}
//}
