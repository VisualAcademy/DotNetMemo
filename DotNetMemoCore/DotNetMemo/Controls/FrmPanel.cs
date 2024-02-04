using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmPanel�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmPanel : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Panel pnlTest;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmPanel()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
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

		#region Windows Form �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlTest = new System.Windows.Forms.Panel();
			this.btnLeft = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.pnlTest.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTest
			// 
			this.pnlTest.AutoScroll = true;
			this.pnlTest.Controls.Add(this.btnRight);
			this.pnlTest.Controls.Add(this.btnLeft);
			this.pnlTest.Location = new System.Drawing.Point(32, 16);
			this.pnlTest.Name = "pnlTest";
			this.pnlTest.Size = new System.Drawing.Size(248, 120);
			this.pnlTest.TabIndex = 0;
			// 
			// btnLeft
			// 
			this.btnLeft.Location = new System.Drawing.Point(16, 48);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.TabIndex = 0;
			this.btnLeft.Text = "���ʹ�ư";
			this.btnLeft.Click += new System.EventHandler(this.pnlTest_Click);
			// 
			// btnRight
			// 
			this.btnRight.Location = new System.Drawing.Point(192, 48);
			this.btnRight.Name = "btnRight";
			this.btnRight.TabIndex = 1;
			this.btnRight.Text = "�����ʹ�ư";
			this.btnRight.Click += new System.EventHandler(this.pnlTest_Click);
			// 
			// FrmPanel
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(320, 157);
			this.Controls.Add(this.pnlTest);
			this.Name = "FrmPanel";
			this.Text = "�г� : ��Ʈ�� �׷�ȭ �� ��ũ�Ѹ� ����";
			this.pnlTest.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		// btnLeft�� btnRight Ŭ���� �߻�
		private void pnlTest_Click(
			object sender, System.EventArgs e)
		{
			if(sender == btnLeft){
				MessageBox.Show(
					btnLeft.Text + " ���õ�.");	
			}
			else{
				MessageBox.Show(
					btnRight.Text + " ���õ�.");	
			}
		}

	}
}
