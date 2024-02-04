//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace CSharp_Windows.도구모음
//{
//	/// <summary>
//	/// FrmToolBar에 대한 요약 설명입니다.
//	/// </summary>
//	public class FrmToolBar : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.ToolBar toolBar1;
//		private System.Windows.Forms.ToolBarButton toolBarButton1;
//		private System.Windows.Forms.ToolBarButton toolBarButton2;
//		private System.Windows.Forms.ToolBarButton toolBarButton3;
//		private System.Windows.Forms.ToolBarButton toolBarButton4;
//		private System.Windows.Forms.ToolBarButton toolBarButton5;
//		private System.Windows.Forms.ToolBarButton toolBarButton6;
//		private System.Windows.Forms.ToolBarButton toolBarButton7;
//		private System.Windows.Forms.ImageList imageList1;
//		private System.Windows.Forms.TextBox textBox1;
//		private System.ComponentModel.IContainer components;

//		public FrmToolBar()
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
//			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmToolBar));
//			this.toolBar1 = new System.Windows.Forms.ToolBar();
//			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
//			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
//			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
//			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
//			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
//			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
//			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
//			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
//			this.textBox1 = new System.Windows.Forms.TextBox();
//			this.SuspendLayout();
//			// 
//			// toolBar1
//			// 
//			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
//																						this.toolBarButton1,
//																						this.toolBarButton2,
//																						this.toolBarButton3,
//																						this.toolBarButton4,
//																						this.toolBarButton5,
//																						this.toolBarButton6,
//																						this.toolBarButton7});
//			this.toolBar1.DropDownArrows = true;
//			this.toolBar1.ImageList = this.imageList1;
//			this.toolBar1.Location = new System.Drawing.Point(0, 0);
//			this.toolBar1.Name = "toolBar1";
//			this.toolBar1.ShowToolTips = true;
//			this.toolBar1.Size = new System.Drawing.Size(384, 41);
//			this.toolBar1.TabIndex = 0;
//			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
//			// 
//			// toolBarButton1
//			// 
//			this.toolBarButton1.ImageIndex = 0;
//			this.toolBarButton1.Text = "삭제";
//			this.toolBarButton1.ToolTipText = "텍스트 박스를 삭제";
//			// 
//			// toolBarButton2
//			// 
//			this.toolBarButton2.ImageIndex = 1;
//			this.toolBarButton2.Text = "빨강";
//			this.toolBarButton2.ToolTipText = "텍스트 색상을 빨간색으로";
//			// 
//			// toolBarButton3
//			// 
//			this.toolBarButton3.ImageIndex = 2;
//			this.toolBarButton3.Text = "파랑";
//			this.toolBarButton3.ToolTipText = "텍스트 색상을 파란색으로";
//			// 
//			// toolBarButton4
//			// 
//			this.toolBarButton4.ImageIndex = 3;
//			this.toolBarButton4.Text = "대문자";
//			this.toolBarButton4.ToolTipText = "대문자로...";
//			// 
//			// toolBarButton5
//			// 
//			this.toolBarButton5.ImageIndex = 4;
//			this.toolBarButton5.Text = "소문자";
//			this.toolBarButton5.ToolTipText = "소문자로...";
//			// 
//			// toolBarButton6
//			// 
//			this.toolBarButton6.ImageIndex = 5;
//			this.toolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
//			// 
//			// toolBarButton7
//			// 
//			this.toolBarButton7.ImageIndex = 5;
//			this.toolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
//			this.toolBarButton7.Text = "ㅅㄷㄴㅅ";
//			this.toolBarButton7.ToolTipText = "ㅅㄷㄴㅅ";
//			// 
//			// imageList1
//			// 
//			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
//			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
//			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
//			// 
//			// textBox1
//			// 
//			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
//			this.textBox1.Location = new System.Drawing.Point(0, 41);
//			this.textBox1.Multiline = true;
//			this.textBox1.Name = "textBox1";
//			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
//			this.textBox1.Size = new System.Drawing.Size(384, 157);
//			this.textBox1.TabIndex = 1;
//			this.textBox1.Text = "";
//			// 
//			// FrmToolBar
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(384, 198);
//			this.Controls.Add(this.textBox1);
//			this.Controls.Add(this.toolBar1);
//			this.Name = "FrmToolBar";
//			this.Text = "FrmToolBar";
//			this.ResumeLayout(false);

//		}
//		#endregion

//		private void toolBar1_ButtonClick(
//			object sender, 
//			System.Windows.Forms.ToolBarButtonClickEventArgs e)
//		{
//			if(e.Button == this.toolBarButton1)
//			{
//				this.textBox1.ForeColor = Color.Black;
//			}
//			else if(e.Button == this.toolBarButton2)
//			{
//				this.textBox1.ForeColor = Color.Red;
//			}
//		}
//	}
//}
