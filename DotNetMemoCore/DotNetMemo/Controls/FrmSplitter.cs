//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace CSharp_Windows.Controls
//{
//	/// <summary>
//	/// FrmSplitter�� ���� ��� �����Դϴ�.
//	/// </summary>
//	public class FrmSplitter : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.MainMenu mainMenu1;
//		private System.Windows.Forms.MenuItem menuItem1;
//		private System.Windows.Forms.MenuItem menuItem2;
//		private System.Windows.Forms.ToolBar toolBar1;
//		private System.Windows.Forms.ToolBarButton toolBarButton1;
//		private System.Windows.Forms.ContextMenu contextMenu1;
//		private System.Windows.Forms.MenuItem menuItem3;
//		private System.Windows.Forms.MenuItem menuItem4;
//		private System.Windows.Forms.MenuItem menuItem5;
//		private System.Windows.Forms.MenuItem menuItem6;
//		private System.Windows.Forms.StatusBar statusBar1;
//		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
//		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
//		private System.Windows.Forms.StatusBarPanel statusBarPanel3;
//		private System.Windows.Forms.Panel panel1;
//		private System.Windows.Forms.Splitter splitter1;
//		private System.Windows.Forms.ListView listView1;
//		private System.Windows.Forms.Label label1;
//		private System.Windows.Forms.Button button1;
//		private System.Windows.Forms.TreeView treeView1;
//		private System.Windows.Forms.ColumnHeader columnHeader1;
//		private System.Windows.Forms.ColumnHeader columnHeader2;
//		/// <summary>
//		/// �ʼ� �����̳� �����Դϴ�.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmSplitter()
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
//			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmSplitter));
//			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
//																																																						 "C:",
//																																																						 "���� ��ũ"}, -1);
//			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
//																																																						 "D:",
//																																																						 "���� ��ũ"}, -1);
//			this.mainMenu1 = new System.Windows.Forms.MainMenu();
//			this.menuItem1 = new System.Windows.Forms.MenuItem();
//			this.menuItem2 = new System.Windows.Forms.MenuItem();
//			this.toolBar1 = new System.Windows.Forms.ToolBar();
//			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
//			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
//			this.menuItem3 = new System.Windows.Forms.MenuItem();
//			this.menuItem4 = new System.Windows.Forms.MenuItem();
//			this.menuItem5 = new System.Windows.Forms.MenuItem();
//			this.menuItem6 = new System.Windows.Forms.MenuItem();
//			this.statusBar1 = new System.Windows.Forms.StatusBar();
//			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
//			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
//			this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
//			this.panel1 = new System.Windows.Forms.Panel();
//			this.splitter1 = new System.Windows.Forms.Splitter();
//			this.listView1 = new System.Windows.Forms.ListView();
//			this.label1 = new System.Windows.Forms.Label();
//			this.button1 = new System.Windows.Forms.Button();
//			this.treeView1 = new System.Windows.Forms.TreeView();
//			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
//			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
//			this.panel1.SuspendLayout();
//			this.SuspendLayout();
//			// 
//			// mainMenu1
//			// 
//			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																							this.menuItem1});
//			// 
//			// menuItem1
//			// 
//			this.menuItem1.Index = 0;
//			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																							this.menuItem2});
//			this.menuItem1.Text = "����(&F)";
//			// 
//			// menuItem2
//			// 
//			this.menuItem2.Index = 0;
//			this.menuItem2.Text = "�ݱ�(&C)";
//			// 
//			// toolBar1
//			// 
//			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
//																																								this.toolBarButton1});
//			this.toolBar1.DropDownArrows = true;
//			this.toolBar1.Location = new System.Drawing.Point(0, 0);
//			this.toolBar1.Name = "toolBar1";
//			this.toolBar1.ShowToolTips = true;
//			this.toolBar1.Size = new System.Drawing.Size(400, 41);
//			this.toolBar1.TabIndex = 0;
//			// 
//			// toolBarButton1
//			// 
//			this.toolBarButton1.DropDownMenu = this.contextMenu1;
//			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
//			this.toolBarButton1.Text = "����";
//			// 
//			// contextMenu1
//			// 
//			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																								 this.menuItem3,
//																																								 this.menuItem4,
//																																								 this.menuItem5,
//																																								 this.menuItem6});
//			// 
//			// menuItem3
//			// 
//			this.menuItem3.Index = 0;
//			this.menuItem3.Text = "ū ������";
//			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
//			// 
//			// menuItem4
//			// 
//			this.menuItem4.Index = 1;
//			this.menuItem4.Text = "���� ������";
//			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
//			// 
//			// menuItem5
//			// 
//			this.menuItem5.Index = 2;
//			this.menuItem5.Text = "������";
//			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
//			// 
//			// menuItem6
//			// 
//			this.menuItem6.Index = 3;
//			this.menuItem6.Text = "�ڼ���";
//			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
//			// 
//			// statusBar1
//			// 
//			this.statusBar1.Location = new System.Drawing.Point(0, 139);
//			this.statusBar1.Name = "statusBar1";
//			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
//																																									this.statusBarPanel1,
//																																									this.statusBarPanel2,
//																																									this.statusBarPanel3});
//			this.statusBar1.ShowPanels = true;
//			this.statusBar1.Size = new System.Drawing.Size(400, 22);
//			this.statusBar1.TabIndex = 1;
//			this.statusBar1.Text = "statusBar1";
//			// 
//			// statusBarPanel1
//			// 
//			this.statusBarPanel1.Text = "4 ��ü";
//			// 
//			// statusBarPanel3
//			// 
//			this.statusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
//			this.statusBarPanel3.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanel3.Icon")));
//			this.statusBarPanel3.Text = "�� ��ǻ��";
//			this.statusBarPanel3.Width = 184;
//			// 
//			// panel1
//			// 
//			this.panel1.Controls.Add(this.treeView1);
//			this.panel1.Controls.Add(this.button1);
//			this.panel1.Controls.Add(this.label1);
//			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
//			this.panel1.Location = new System.Drawing.Point(0, 41);
//			this.panel1.Name = "panel1";
//			this.panel1.Size = new System.Drawing.Size(192, 98);
//			this.panel1.TabIndex = 2;
//			// 
//			// splitter1
//			// 
//			this.splitter1.Location = new System.Drawing.Point(192, 41);
//			this.splitter1.Name = "splitter1";
//			this.splitter1.Size = new System.Drawing.Size(8, 98);
//			this.splitter1.TabIndex = 3;
//			this.splitter1.TabStop = false;
//			// 
//			// listView1
//			// 
//			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
//																																								this.columnHeader1,
//																																								this.columnHeader2});
//			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
//			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
//																																							listViewItem1,
//																																							listViewItem2});
//			this.listView1.Location = new System.Drawing.Point(200, 41);
//			this.listView1.Name = "listView1";
//			this.listView1.Size = new System.Drawing.Size(200, 98);
//			this.listView1.TabIndex = 4;
//			// 
//			// label1
//			// 
//			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
//			this.label1.Location = new System.Drawing.Point(0, 0);
//			this.label1.Name = "label1";
//			this.label1.Size = new System.Drawing.Size(192, 23);
//			this.label1.TabIndex = 0;
//			this.label1.Text = "����";
//			// 
//			// button1
//			// 
//			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
//			this.button1.Location = new System.Drawing.Point(144, 0);
//			this.button1.Name = "button1";
//			this.button1.Size = new System.Drawing.Size(48, 24);
//			this.button1.TabIndex = 1;
//			this.button1.Text = "x";
//			// 
//			// treeView1
//			// 
//			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
//			this.treeView1.ImageIndex = -1;
//			this.treeView1.Location = new System.Drawing.Point(0, 23);
//			this.treeView1.Name = "treeView1";
//			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
//																																					new System.Windows.Forms.TreeNode("�� ��ǻ��", new System.Windows.Forms.TreeNode[] {
//																																																																													 new System.Windows.Forms.TreeNode("���� ��ũ(C:)"),
//																																																																													 new System.Windows.Forms.TreeNode("���� ��ũ(D:)")})});
//			this.treeView1.SelectedImageIndex = -1;
//			this.treeView1.Size = new System.Drawing.Size(192, 75);
//			this.treeView1.TabIndex = 2;
//			// 
//			// columnHeader1
//			// 
//			this.columnHeader1.Text = "�̸�";
//			// 
//			// columnHeader2
//			// 
//			this.columnHeader2.Text = "����";
//			// 
//			// FrmSplitter
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(400, 161);
//			this.Controls.Add(this.listView1);
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
//			this.ResumeLayout(false);

//		}
//		#endregion

//		private void menuItem3_Click(object sender, System.EventArgs e)
//		{
//			// ū ������
//			listView1.View = View.LargeIcon;
//		}
//		private void menuItem4_Click(object sender, System.EventArgs e)
//		{
//			// ���� ������
//			listView1.View = View.SmallIcon;
//		}
//		private void menuItem5_Click(object sender, System.EventArgs e)
//		{
//			// ������
//			listView1.View = View.List;
//		}
//		private void menuItem6_Click(object sender, System.EventArgs e)
//		{
//			// �ڼ���
//			listView1.View = View.Details;
//		}

//	}
//}
