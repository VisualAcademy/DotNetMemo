using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmGroupBox�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmGroupBoxClick : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnHi;
		private System.Windows.Forms.Button cmdBye;
		private System.Windows.Forms.Label lblDisplay;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmGroupBoxClick()
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnHi = new System.Windows.Forms.Button();
			this.cmdBye = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmdBye);
			this.groupBox1.Controls.Add(this.btnHi);
			this.groupBox1.Location = new System.Drawing.Point(24, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 96);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ŭ���ϼ���";
			// 
			// btnHi
			// 
			this.btnHi.Location = new System.Drawing.Point(16, 40);
			this.btnHi.Name = "btnHi";
			this.btnHi.TabIndex = 0;
			this.btnHi.Text = "�ȳ�";
			this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
			// 
			// cmdBye
			// 
			this.cmdBye.Location = new System.Drawing.Point(112, 40);
			this.cmdBye.Name = "cmdBye";
			this.cmdBye.TabIndex = 1;
			this.cmdBye.Text = "�߰�";
			this.cmdBye.Click += new System.EventHandler(this.cmdBye_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblDisplay.Location = new System.Drawing.Point(0, 134);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(248, 23);
			this.lblDisplay.TabIndex = 1;
			this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmGroupBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(248, 157);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmGroupBox";
			this.Text = "�׷�ڽ� : ���� ��Ʈ���� ���� �����̳� ����";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnHi_Click(object sender, System.EventArgs e)
		{
			lblDisplay.Text = btnHi.Text;	
		}

		private void cmdBye_Click(object sender, System.EventArgs e)
		{
			lblDisplay.Text = cmdBye.Text;
		}
	}
}
