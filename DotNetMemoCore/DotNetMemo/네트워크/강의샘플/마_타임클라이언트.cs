using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace CSharp_Network.���ǻ���
{
	/// <summary>
	/// ��_Ÿ��Ŭ���̾�Ʈ�� ���� ��� �����Դϴ�.
	/// </summary>
	public class ��_Ÿ��Ŭ���̾�Ʈ : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDisplay;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Button btnConnect;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ��_Ÿ��Ŭ���̾�Ʈ()
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtDisplay = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "����ð� : ";
			// 
			// txtDisplay
			// 
			this.txtDisplay.Location = new System.Drawing.Point(72, 0);
			this.txtDisplay.Name = "txtDisplay";
			this.txtDisplay.Size = new System.Drawing.Size(216, 21);
			this.txtDisplay.TabIndex = 1;
			this.txtDisplay.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 2;
			this.label2.Text = "Ÿ�� ���� IP :";
			// 
			// txtIP
			// 
			this.txtIP.Location = new System.Drawing.Point(88, 48);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(200, 21);
			this.txtIP.TabIndex = 3;
			this.txtIP.Text = "";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(104, 88);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.TabIndex = 4;
			this.btnConnect.Text = "����";
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// ��_Ÿ��Ŭ���̾�Ʈ
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 125);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.txtIP);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtDisplay);
			this.Controls.Add(this.label1);
			this.Name = "��_Ÿ��Ŭ���̾�Ʈ";
			this.Text = "��_Ÿ��Ŭ���̾�Ʈ";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			System.Net.Sockets.TcpClient client = new TcpClient(this.txtIP.Text.Trim(), 7007);
			System.Net.Sockets.NetworkStream stream = client.GetStream();
			StreamReader read = new StreamReader(stream);
			DateTime data = DateTime.Parse(read.ReadLine());
			this.txtDisplay.Text = data.ToLongTimeString().ToString();
		}
	}
}
