//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace CSharp_Windows.���ؽ�Ʈ�޴�
//{
//	/// <summary>
//	/// FrmContextMenu�� ���� ��� �����Դϴ�.
//	/// </summary>
//	public class FrmContextMenu : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.ContextMenu contextMenu1;
//		private System.Windows.Forms.MenuItem menuItem1;
//		private System.Windows.Forms.MenuItem menuItem2;
//		private System.Windows.Forms.Panel panel1;
//		/// <summary>
//		/// �ʼ� �����̳� �����Դϴ�.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmContextMenu()
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
//			this.Text = "���ؽ�Ʈ�޴� ��Ʈ��";
//			this.ResumeLayout(false);

//		}
//		#endregion

//		private void menuItem1_Click(object sender, System.EventArgs e)
//		{
//			MessageBox.Show("Message �޴��� Ŭ���Ǿ����ϴ�.");
//		}

//		private void menuItem2_Click(object sender, System.EventArgs e)
//		{
//			this.Close();
//		}
//	}
//}
