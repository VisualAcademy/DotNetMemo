//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace CSharp_Windows.Controls
//{
//	/// <summary>
//	/// FrmNotifyIcon�� ���� ��� �����Դϴ�.
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
//			this.menuItem1.Text = "���α׷� ����";
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
//			MessageBox.Show("���� Ŭ����.");
//		}
//	}
//}
