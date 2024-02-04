using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace CSharp_Network.���ǻ���
{
	/// <summary>
	/// ��_������Ʈ����������α׷��� ���� ��� �����Դϴ�.
	/// </summary>
	public class ��_������Ʈ����������α׷� : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtWebsite;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox txtDisplay;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ��_������Ʈ����������α׷�()
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
			this.txtWebsite = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.txtDisplay = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "������ ����� ������Ʈ : ";
			// 
			// txtWebsite
			// 
			this.txtWebsite.Location = new System.Drawing.Point(8, 24);
			this.txtWebsite.Name = "txtWebsite";
			this.txtWebsite.Size = new System.Drawing.Size(424, 21);
			this.txtWebsite.TabIndex = 1;
			this.txtWebsite.Text = "";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(352, 0);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(80, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "Ȯ��";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// txtDisplay
			// 
			this.txtDisplay.Location = new System.Drawing.Point(8, 48);
			this.txtDisplay.Multiline = true;
			this.txtDisplay.Name = "txtDisplay";
			this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtDisplay.Size = new System.Drawing.Size(424, 224);
			this.txtDisplay.TabIndex = 3;
			this.txtDisplay.Text = "";
			// 
			// ��_������Ʈ����������α׷�
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(440, 285);
			this.Controls.Add(this.txtDisplay);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtWebsite);
			this.Controls.Add(this.label1);
			this.Name = "��_������Ʈ����������α׷�";
			this.Text = "��_������Ʈ����������α׷�";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient();
			try
			{
				client.Connect(this.txtWebsite.Text.Trim(), 80);	
			}
			catch
			{
				MessageBox.Show("������ ������ �� �����ϴ�.");
			}

			Stream stream = client.GetStream();

			string msg = "GET /default.asp HTTP/1.0\r\n\n";
			Byte [] byteSend = System.Text.Encoding.Default.GetBytes(msg.ToCharArray());

			stream.Write(byteSend, 0, byteSend.Length);

			stream.Flush();

			byte [] response = new byte[256];
			int size = stream.Read(response, 0, response.Length);

			this.txtDisplay.AppendText("���� ����Ʈ �� : " + size + "Byte \r\n");
			this.txtDisplay.AppendText("�������� ������ �޽��� : \r\n");
			this.txtDisplay.AppendText(System.Text.Encoding.Default.GetString(response));
		}
	}
}
