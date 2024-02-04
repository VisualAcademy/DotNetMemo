//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace CSharp_Windows.스플리터
//{
//	/// <summary>
//	/// FrmSplitter에 대한 요약 설명입니다.
//	/// </summary>
//	public class FrmSplitter : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.MainMenu mainMenu1;
//		private System.Windows.Forms.MenuItem menuItem1;
//		private System.Windows.Forms.ToolBar toolBar1;
//		private System.Windows.Forms.ToolBarButton toolBarButton1;
//		private System.Windows.Forms.ToolBarButton toolBarButton2;
//		private System.Windows.Forms.ToolBarButton toolBarButton3;
//		private System.Windows.Forms.StatusBar statusBar1;
//		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
//		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
//		private System.Windows.Forms.StatusBarPanel statusBarPanel3;
//		private System.Windows.Forms.Panel panel1;
//		private System.Windows.Forms.Splitter splitter1;
//		private System.Windows.Forms.Panel panel2;
//		private System.Windows.Forms.Label label1;
//		private System.Windows.Forms.TreeView treeView1;
//		private System.Windows.Forms.ListView listView1;
//		private System.Windows.Forms.ColumnHeader columnHeader1;
//		private System.Windows.Forms.ColumnHeader columnHeader2;
//		/// <summary>
//		/// 필수 디자이너 변수입니다.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmSplitter()
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
//			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
//																													 "C:",
//																													 "로컬 디스크"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129))));
//			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
//																													 "D:",
//																													 "로컬 디스크"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129))));
//			this.mainMenu1 = new System.Windows.Forms.MainMenu();
//			this.menuItem1 = new System.Windows.Forms.MenuItem();
//			this.toolBar1 = new System.Windows.Forms.ToolBar();
//			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
//			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
//			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
//			this.statusBar1 = new System.Windows.Forms.StatusBar();
//			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
//			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
//			this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
//			this.panel1 = new System.Windows.Forms.Panel();
//			this.treeView1 = new System.Windows.Forms.TreeView();
//			this.label1 = new System.Windows.Forms.Label();
//			this.splitter1 = new System.Windows.Forms.Splitter();
//			this.panel2 = new System.Windows.Forms.Panel();
//			this.listView1 = new System.Windows.Forms.ListView();
//			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
//			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
//			this.panel1.SuspendLayout();
//			this.panel2.SuspendLayout();
//			this.SuspendLayout();
//			// 
//			// mainMenu1
//			// 
//			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																					  this.menuItem1});
//			// 
//			// menuItem1
//			// 
//			this.menuItem1.Index = 0;
//			this.menuItem1.Text = "파일(&F)";
//			// 
//			// toolBar1
//			// 
//			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
//																						this.toolBarButton1,
//																						this.toolBarButton2,
//																						this.toolBarButton3});
//			this.toolBar1.DropDownArrows = true;
//			this.toolBar1.Location = new System.Drawing.Point(0, 0);
//			this.toolBar1.Name = "toolBar1";
//			this.toolBar1.ShowToolTips = true;
//			this.toolBar1.Size = new System.Drawing.Size(392, 41);
//			this.toolBar1.TabIndex = 0;
//			// 
//			// toolBarButton1
//			// 
//			this.toolBarButton1.Text = "뒤로";
//			// 
//			// statusBar1
//			// 
//			this.statusBar1.Location = new System.Drawing.Point(0, 147);
//			this.statusBar1.Name = "statusBar1";
//			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
//																						  this.statusBarPanel1,
//																						  this.statusBarPanel2,
//																						  this.statusBarPanel3});
//			this.statusBar1.ShowPanels = true;
//			this.statusBar1.Size = new System.Drawing.Size(392, 22);
//			this.statusBar1.TabIndex = 1;
//			this.statusBar1.Text = "statusBar1";
//			// 
//			// statusBarPanel1
//			// 
//			this.statusBarPanel1.Text = "statusBarPanel1";
//			// 
//			// statusBarPanel2
//			// 
//			this.statusBarPanel2.Text = "statusBarPanel2";
//			// 
//			// statusBarPanel3
//			// 
//			this.statusBarPanel3.Text = "statusBarPanel3";
//			// 
//			// panel1
//			// 
//			this.panel1.Controls.Add(this.treeView1);
//			this.panel1.Controls.Add(this.label1);
//			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
//			this.panel1.Location = new System.Drawing.Point(0, 41);
//			this.panel1.Name = "panel1";
//			this.panel1.Size = new System.Drawing.Size(184, 106);
//			this.panel1.TabIndex = 2;
//			// 
//			// treeView1
//			// 
//			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
//			this.treeView1.ImageIndex = -1;
//			this.treeView1.Location = new System.Drawing.Point(0, 23);
//			this.treeView1.Name = "treeView1";
//			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
//																				  new System.Windows.Forms.TreeNode("내 컴퓨터", new System.Windows.Forms.TreeNode[] {
//																																									 new System.Windows.Forms.TreeNode("C:"),
//																																									 new System.Windows.Forms.TreeNode("D:")})});
//			this.treeView1.SelectedImageIndex = -1;
//			this.treeView1.Size = new System.Drawing.Size(184, 83);
//			this.treeView1.TabIndex = 1;
//			// 
//			// label1
//			// 
//			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
//			this.label1.Location = new System.Drawing.Point(0, 0);
//			this.label1.Name = "label1";
//			this.label1.Size = new System.Drawing.Size(184, 23);
//			this.label1.TabIndex = 0;
//			this.label1.Text = "폴더";
//			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//			// 
//			// splitter1
//			// 
//			this.splitter1.Location = new System.Drawing.Point(184, 41);
//			this.splitter1.Name = "splitter1";
//			this.splitter1.Size = new System.Drawing.Size(8, 106);
//			this.splitter1.TabIndex = 3;
//			this.splitter1.TabStop = false;
//			// 
//			// panel2
//			// 
//			this.panel2.Controls.Add(this.listView1);
//			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
//			this.panel2.Location = new System.Drawing.Point(192, 41);
//			this.panel2.Name = "panel2";
//			this.panel2.Size = new System.Drawing.Size(200, 106);
//			this.panel2.TabIndex = 4;
//			// 
//			// listView1
//			// 
//			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
//																						this.columnHeader1,
//																						this.columnHeader2});
//			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
//			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
//																					  listViewItem1,
//																					  listViewItem2});
//			this.listView1.Location = new System.Drawing.Point(0, 0);
//			this.listView1.Name = "listView1";
//			this.listView1.Size = new System.Drawing.Size(200, 106);
//			this.listView1.TabIndex = 0;
//			this.listView1.View = System.Windows.Forms.View.Details;
//			// 
//			// columnHeader1
//			// 
//			this.columnHeader1.Text = "이름";
//			// 
//			// columnHeader2
//			// 
//			this.columnHeader2.Text = "종류";
//			this.columnHeader2.Width = 117;
//			// 
//			// FrmSplitter
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(392, 169);
//			this.Controls.Add(this.panel2);
//			this.Controls.Add(this.splitter1);
//			this.Controls.Add(this.panel1);
//			this.Controls.Add(this.statusBar1);
//			this.Controls.Add(this.toolBar1);
//			this.Menu = this.mainMenu1;
//			this.Name = "FrmSplitter";
//			this.Text = "FrmSplitter";
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
//			this.panel1.ResumeLayout(false);
//			this.panel2.ResumeLayout(false);
//			this.ResumeLayout(false);

//		}
//		#endregion
//	}
//}
