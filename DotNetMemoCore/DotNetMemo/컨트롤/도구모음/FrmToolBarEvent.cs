//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace CSharp_Windows.��������
//{
//	/// <summary>
//	/// FrmToolBarEvent�� ���� ��� �����Դϴ�.
//	/// </summary>
//	public class FrmToolBarEvent : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.ToolBar toolBar1;
//		private System.Windows.Forms.ToolBarButton toolBarButton1;
//		private System.Windows.Forms.ToolBarButton toolBarButton2;
//		private System.Windows.Forms.ToolBarButton toolBarButton3;
//		private System.Windows.Forms.ToolBarButton toolBarButton4;
//		private System.Windows.Forms.ToolBarButton toolBarButton5;
//		/// <summary>
//		/// �ʼ� �����̳� �����Դϴ�.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmToolBarEvent()
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
//			this.toolBar1 = new System.Windows.Forms.ToolBar();
//			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
//			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
//			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
//			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
//			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
//			this.SuspendLayout();
//			// 
//			// toolBar1
//			// 
//			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
//																						this.toolBarButton1,
//																						this.toolBarButton2,
//																						this.toolBarButton3,
//																						this.toolBarButton4,
//																						this.toolBarButton5});
//			this.toolBar1.DropDownArrows = true;
//			this.toolBar1.Location = new System.Drawing.Point(0, 0);
//			this.toolBar1.Name = "toolBar1";
//			this.toolBar1.ShowToolTips = true;
//			this.toolBar1.Size = new System.Drawing.Size(208, 41);
//			this.toolBar1.TabIndex = 0;
//			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
//			// 
//			// toolBarButton1
//			// 
//			this.toolBarButton1.Text = "1";
//			// 
//			// toolBarButton2
//			// 
//			this.toolBarButton2.Text = "2";
//			// 
//			// toolBarButton3
//			// 
//			this.toolBarButton3.Text = "3";
//			// 
//			// toolBarButton4
//			// 
//			this.toolBarButton4.Text = "4";
//			// 
//			// toolBarButton5
//			// 
//			this.toolBarButton5.Text = "5";
//			// 
//			// FrmToolBarEvent
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(208, 69);
//			this.Controls.Add(this.toolBar1);
//			this.Name = "FrmToolBarEvent";
//			this.Text = "FrmToolBarEvent";
//			this.ResumeLayout(false);

//		}
//		#endregion

//		private void toolBar1_ButtonClick(
//			object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
//		{
//			switch(this.toolBar1.Buttons.IndexOf(e.Button))
//			{
//				case 0:
//					MessageBox.Show("ù��° ��ư");
//					break;
//				case 1:
//					MessageBox.Show("�ι�° ��ư");
//					break;
//				case 2:
//					MessageBox.Show("����° ��ư");
//					break;
//				case 3:
//					MessageBox.Show("�׹�° ��ư");
//					break;
//				case 4:
//					MessageBox.Show("�ټ���° ��ư");
//					break;              
//			}
//		}
//	}
//}
