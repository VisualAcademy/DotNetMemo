//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace CSharp_Windows.���θ޴�
//{
//	/// <summary>
//	/// UsingMDI�� ���� ��� �����Դϴ�.
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
//		private System.Windows.Forms.MenuItem mi����;
//		private System.Windows.Forms.MenuItem mi����;
//		private System.Windows.Forms.MenuItem miChild1;
//		private System.Windows.Forms.MenuItem miChild2;
//		private System.Windows.Forms.MenuItem miChild3;
//		/// <summary>
//		/// �ʼ� �����̳� �����Դϴ�.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public UsingMDI()
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

//		#region Windows Form Designer generated code
//		/// <summary>
//		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
//		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
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
//			this.mi���� = new System.Windows.Forms.MenuItem();
//			this.mi���� = new System.Windows.Forms.MenuItem();
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
//			this.miFile.Text = "����(&F)";
//			// 
//			// miWindow
//			// 
//			this.miWindow.Index = 1;
//			this.miWindow.MdiList = true;
//			this.miWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																						 this.miCascading,
//																																						 this.mi����,
//																																						 this.mi����});
//			this.miWindow.Text = "â(&W)";
//			// 
//			// miNew
//			// 
//			this.miNew.Index = 0;
//			this.miNew.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																					this.miChild1,
//																																					this.miChild2,
//																																					this.miChild3});
//			this.miNew.Text = "���� �����(&N)";
//			// 
//			// menuItem4
//			// 
//			this.menuItem4.Index = 1;
//			this.menuItem4.Text = "-";
//			// 
//			// miExit
//			// 
//			this.miExit.Index = 2;
//			this.miExit.Text = "������(&X)";
//			this.miExit.Click += new System.EventHandler(this.miExit_Click);
//			// 
//			// miChild1
//			// 
//			this.miChild1.Index = 0;
//			this.miChild1.Text = "�ڽ� â1";
//			this.miChild1.Click += new System.EventHandler(this.miChild1_Click);
//			// 
//			// miChild2
//			// 
//			this.miChild2.Index = 1;
//			this.miChild2.Text = "�ڽ� â2";
//			this.miChild2.Click += new System.EventHandler(this.miChild2_Click);
//			// 
//			// miChild3
//			// 
//			this.miChild3.Index = 2;
//			this.miChild3.Text = "�ڽ� â3";
//			this.miChild3.Click += new System.EventHandler(this.miChild3_Click);
//			// 
//			// miCascading
//			// 
//			this.miCascading.Index = 0;
//			this.miCascading.Text = "��ܽ� ����";
//			this.miCascading.Click += new System.EventHandler(this.miCascading_Click);
//			// 
//			// mi����
//			// 
//			this.mi����.Index = 1;
//			this.mi����.Text = "���� �ٵ��ǽ�";
//			this.mi����.Click += new System.EventHandler(this.mi����_Click);
//			// 
//			// mi����
//			// 
//			this.mi����.Index = 2;
//			this.mi����.Text = "���� �ٵ��ǽ�";
//			this.mi����.Click += new System.EventHandler(this.mi����_Click);
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
//			Application.Exit();//���α׷� ����
//		}

//		private void miChild1_Click(object sender, System.EventArgs e)
//		{
//			FrmChild fc1 = new FrmChild("�ڽ�1");
//			fc1.MdiParent = this;
//			fc1.Show();//�� â
//		}

//		private void miChild2_Click(object sender, System.EventArgs e)
//		{
//			FrmChild fc2 = new FrmChild("�ڽ�2");
//			fc2.MdiParent = this;//�θ� ����
//			fc2.Show();//���� MDI ���� ���
//		}

//		private void miChild3_Click(object sender, System.EventArgs e)
//		{
//			FrmChild fc3 = new FrmChild("�ڽ�3");
//			fc3.MdiParent = this;
//			fc3.Show();
//		}

//		private void miCascading_Click(object sender, System.EventArgs e)
//		{
//			this.LayoutMdi(MdiLayout.Cascade);//��ܽ� �迭
//		}

//		private void mi����_Click(object sender, System.EventArgs e)
//		{
//			this.LayoutMdi(MdiLayout.TileHorizontal);//���� �迭
//		}

//		private void mi����_Click(object sender, System.EventArgs e)
//		{
//			this.LayoutMdi(MdiLayout.TileVertical);//���� �迭
//		}
//	}
//}
