//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace CSharp_Windows.Controls
//{
//	/// <summary>
//	/// FrmToolBar�� ���� ��� �����Դϴ�.
//	/// </summary>
//	public class FrmToolBar : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.ToolBar toolBar1;
//		private System.Windows.Forms.ToolBarButton toolBarButton1;
//		private System.Windows.Forms.ToolBarButton toolBarButton2;
//		private System.Windows.Forms.ToolBarButton toolBarButton3;
//		private System.Windows.Forms.ToolBarButton toolBarButton4;
//		private System.Windows.Forms.ToolBarButton toolBarButton5;
//		private System.Windows.Forms.ImageList imageList1;
//		private System.Windows.Forms.ToolBarButton toolBarButton6;
//		private System.Windows.Forms.ContextMenu contextMenu1;
//		private System.Windows.Forms.MenuItem menuItem1;
//		private System.ComponentModel.IContainer components;

//		public FrmToolBar()
//		{
//			//
//			// Windows Form �����̳� ������ �ʿ��մϴ�.
//			//
//			InitializeComponent();

//			//
//			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
//			//
//		}

//		/// <summary>
//		/// ��� ���� ��� ���ҽ��� �����մϴ�.
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

//		#region Windows Form �����̳ʿ��� ������ �ڵ�
//		/// <summary>
//		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
//		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
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
//			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
//			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
//			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
//			this.menuItem1 = new System.Windows.Forms.MenuItem();
//			this.SuspendLayout();
//			// 
//			// toolBar1
//			// 
//			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
//																																								this.toolBarButton1,
//																																								this.toolBarButton2,
//																																								this.toolBarButton6,
//																																								this.toolBarButton3,
//																																								this.toolBarButton4,
//																																								this.toolBarButton5});
//			this.toolBar1.DropDownArrows = true;
//			this.toolBar1.ImageList = this.imageList1;
//			this.toolBar1.Location = new System.Drawing.Point(0, 0);
//			this.toolBar1.Name = "toolBar1";
//			this.toolBar1.ShowToolTips = true;
//			this.toolBar1.Size = new System.Drawing.Size(272, 41);
//			this.toolBar1.TabIndex = 0;
//			// 
//			// toolBarButton1
//			// 
//			this.toolBarButton1.ImageIndex = 0;
//			this.toolBarButton1.Text = "����";
//			// 
//			// toolBarButton2
//			// 
//			this.toolBarButton2.ImageIndex = 1;
//			this.toolBarButton2.Text = "����";
//			// 
//			// toolBarButton3
//			// 
//			this.toolBarButton3.ImageIndex = 2;
//			this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
//			this.toolBarButton3.Text = "�Ķ�";
//			// 
//			// toolBarButton4
//			// 
//			this.toolBarButton4.DropDownMenu = this.contextMenu1;
//			this.toolBarButton4.ImageIndex = 3;
//			this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
//			this.toolBarButton4.Text = "�빮��";
//			// 
//			// toolBarButton5
//			// 
//			this.toolBarButton5.ImageIndex = 4;
//			this.toolBarButton5.Text = "�ҹ���";
//			// 
//			// imageList1
//			// 
//			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
//			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
//			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
//			// 
//			// toolBarButton6
//			// 
//			this.toolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
//			// 
//			// contextMenu1
//			// 
//			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																								 this.menuItem1});
//			// 
//			// menuItem1
//			// 
//			this.menuItem1.Index = 0;
//			this.menuItem1.Text = "�׽�Ʈ";
//			// 
//			// FrmToolBar
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(272, 85);
//			this.Controls.Add(this.toolBar1);
//			this.Name = "FrmToolBar";
//			this.Text = "FrmToolBar";
//			this.ResumeLayout(false);

//		}
//		#endregion
//	}
//}
