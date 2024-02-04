using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.���θ޴�
{
	/// <summary>
	/// FrmChild�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmChild : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmdClose;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmChild(string strText)
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();
			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
			this.Text = strText;//������ �������� ����
		}

		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmdClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmdClose
			// 
			this.cmdClose.Location = new System.Drawing.Point(112, 112);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.TabIndex = 0;
			this.cmdClose.Text = "�ݱ�";
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// FrmChild
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.cmdClose});
			this.Name = "FrmChild";
			this.ResumeLayout(false);

		}
		#endregion

		private void cmdClose_Click(object sender, System.EventArgs e)
		{
			this.Close();//â �ݱ�
		}
	}
}
