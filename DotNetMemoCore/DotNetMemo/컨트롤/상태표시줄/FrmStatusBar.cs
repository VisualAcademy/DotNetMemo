//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace CSharp_Windows.����ǥ����
//{
//	/// <summary>
//	/// StatusBar Ŭ���� : ���� ǥ���� 
//	/// </summary>
//	public class FrmStatusBar : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.StatusBar statusBar1;
//		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
//		private System.Windows.Forms.StatusBarPanel statusBarPanel2;

//		#region Code Hiding
//		/// <summary>
//		/// �ʼ� �����̳� �����Դϴ�.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmStatusBar()
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
//			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmStatusBar));
//			this.statusBar1 = new System.Windows.Forms.StatusBar();
//			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
//			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
//			this.SuspendLayout();
//			// 
//			// statusBar1
//			// 
//			this.statusBar1.Location = new System.Drawing.Point(0, 64);
//			this.statusBar1.Name = "statusBar1";
//			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
//																						  this.statusBarPanel1,
//																						  this.statusBarPanel2});
//			this.statusBar1.ShowPanels = true;
//			this.statusBar1.Size = new System.Drawing.Size(292, 22);
//			this.statusBar1.TabIndex = 0;
//			// 
//			// statusBarPanel1
//			// 
//			this.statusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
//			this.statusBarPanel1.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanel1.Icon")));
//			this.statusBarPanel1.Text = "�ȳ��ϼ���.";
//			this.statusBarPanel1.ToolTipText = "�ȳ��ϼ���.";
//			// 
//			// statusBarPanel2
//			// 
//			this.statusBarPanel2.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised;
//			this.statusBarPanel2.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanel2.Icon")));
//			this.statusBarPanel2.Text = "�ݰ�����";
//			this.statusBarPanel2.ToolTipText = "�ݰ�����";
//			// 
//			// FrmStatusBar
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(292, 86);
//			this.Controls.Add(this.statusBar1);
//			this.Name = "FrmStatusBar";
//			this.Text = "FrmStatusBar";
//			this.Load += new System.EventHandler(this.FrmStatusBar_Load);
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
//			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
//			this.ResumeLayout(false);

//		}
//		#endregion
//		#endregion

//		//���� ǥ���� �ֿ� �Ӽ� ����
//		private void FrmStatusBar_Load(object sender, System.EventArgs e)
//		{
//			this.statusBar1.ShowPanels = true;//�׵θ� ���̱�
//			this.statusBar1.SizingGrip = false;//ũ�� ���� �Ұ���
//			this.statusBarPanel1.Text = "�ȳ��ϼ���";
//			this.statusBarPanel2.Text = "�ݰ����ϴ�.";
//		}
//	}
//}
