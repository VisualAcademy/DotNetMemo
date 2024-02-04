using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;//StringBuilder

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmTimer�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmTimer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox txtDisplay;
		private System.ComponentModel.IContainer components;

		public FrmTimer()
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
			this.components = new System.ComponentModel.Container();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.txtDisplay = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Location = new System.Drawing.Point(24, 8);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(248, 23);
			this.lblDisplay.TabIndex = 0;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// txtDisplay
			// 
			this.txtDisplay.Location = new System.Drawing.Point(24, 48);
			this.txtDisplay.Multiline = true;
			this.txtDisplay.Name = "txtDisplay";
			this.txtDisplay.Size = new System.Drawing.Size(248, 128);
			this.txtDisplay.TabIndex = 1;
			this.txtDisplay.Text = "";
			// 
			// FrmTimer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 205);
			this.Controls.Add(this.txtDisplay);
			this.Controls.Add(this.lblDisplay);
			this.Name = "FrmTimer";
			this.Text = "FrmTimer";
			this.Load += new System.EventHandler(this.FrmTimer_Load);
			this.ResumeLayout(false);

		}
		#endregion

		// Interval(1��)���� �̺�Ʈ �߻�
		private void timer1_Tick(object sender, System.EventArgs e)
		{
			this.lblDisplay.Text = 
				"���� �Ͻ�: " + 
				DateTime.Now.ToString();
			//
			this.FrmTimer_Load(null, null);
		}

		private void FrmTimer_Load(object sender, System.EventArgs e)
		{
			// ��, ��, ��, ��, ��, �� ������
			string strMsg = String.Empty;
			strMsg = String.Format(
				"{0}��\r\n{1}��\r\n{2}��\r\n" + 
				"{3}��\r\n{4}��\r\n{5}��\r\n",
				DateTime.Now.Year,
				DateTime.Now.Month,
				DateTime.Now.Day,
				DateTime.Now.Hour,
				DateTime.Now.Minute,
				DateTime.Now.Second);
			this.txtDisplay.Text = strMsg;
			// StringBuilder Ŭ���� ��� 
			StringBuilder sb = new StringBuilder();
			sb.Append("����ð�\r\n");
			sb.Append(
				DateTime.Now.Year.ToString() + "��");
      sb.AppendFormat(
				"\r\n{0}��", DateTime.Now.Month);
			sb.AppendFormat(
				"{0}{1}��{2}", "\r\n", 
				DateTime.Now.Day, "\r\n");
			this.txtDisplay.Text += sb.ToString();
		}
	}
}
