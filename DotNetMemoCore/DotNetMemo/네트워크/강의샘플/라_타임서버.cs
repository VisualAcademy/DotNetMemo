//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;
////
//using System.Net;
//using System.Net.Sockets;
//using System.IO;
//using System.Threading;

//namespace CSharp_Network.���ǻ���
//{
//	/// <summary>
//	/// ��_Ÿ�Ӽ����� ���� ��� �����Դϴ�.
//	/// </summary>
//	public class ��_Ÿ�Ӽ��� : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.Button btnStart;
//		private System.Windows.Forms.Button btnEnd;
//		private System.Windows.Forms.Button btnTimeClient;
//		#region +
//		/// <summary>
//		/// �ʼ� �����̳� �����Դϴ�.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public ��_Ÿ�Ӽ���()
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
//			this.btnStart = new System.Windows.Forms.Button();
//			this.btnEnd = new System.Windows.Forms.Button();
//			this.btnTimeClient = new System.Windows.Forms.Button();
//			this.SuspendLayout();
//			// 
//			// btnStart
//			// 
//			this.btnStart.Location = new System.Drawing.Point(24, 16);
//			this.btnStart.Name = "btnStart";
//			this.btnStart.Size = new System.Drawing.Size(136, 23);
//			this.btnStart.TabIndex = 0;
//			this.btnStart.Text = "Ÿ�� ���� ����";
//			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
//			// 
//			// btnEnd
//			// 
//			this.btnEnd.Location = new System.Drawing.Point(24, 56);
//			this.btnEnd.Name = "btnEnd";
//			this.btnEnd.Size = new System.Drawing.Size(136, 23);
//			this.btnEnd.TabIndex = 1;
//			this.btnEnd.Text = "Ÿ�� ���� ����";
//			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
//			// 
//			// btnTimeClient
//			// 
//			this.btnTimeClient.Location = new System.Drawing.Point(24, 96);
//			this.btnTimeClient.Name = "btnTimeClient";
//			this.btnTimeClient.Size = new System.Drawing.Size(136, 23);
//			this.btnTimeClient.TabIndex = 2;
//			this.btnTimeClient.Text = "Ÿ�� Ŭ���̾�Ʈ ����";
//			this.btnTimeClient.Click += new System.EventHandler(this.btnTimeClient_Click);
//			// 
//			// ��_Ÿ�Ӽ���
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(184, 133);
//			this.Controls.Add(this.btnTimeClient);
//			this.Controls.Add(this.btnEnd);
//			this.Controls.Add(this.btnStart);
//			this.Name = "��_Ÿ�Ӽ���";
//			this.Text = "��_Ÿ�Ӽ���";
//			this.ResumeLayout(false);

//		}
//		#endregion
//		#endregion
//		public NetworkStream stream;//��Ʈ��ũ ��Ʈ��
//		public const int port = 7007;//Ÿ�� ���� ��Ʈ

//		System.Net.Sockets.TcpListener listener = null;//TCP ������

//		StreamWriter write = null; // ���� ��Ʈ��

//		Thread th = null;//������

//		private void Accept()
//		{
//			try
//			{
//				//listener = new System.Net.Sockets.TcpListener(port);
//				listener.Start();
//			}
//			catch(Exception ex)
//			{
//				MessageBox.Show("�����޽��� : " + ex.StackTrace);
//			}
//			btnStart.Enabled = false;
//			btnEnd.Enabled = true;

//			System.Net.Sockets.Socket client = listener.AcceptSocket();

//			if(client.Connected)
//			{
//				stream = new NetworkStream(client);
//				write = new StreamWriter(stream);
//				write.WriteLine(DateTime.Now);//���� �ð� ����
//				write.Flush();
//			}
//		}

//		private void Stop()
//		{
//			try
//			{
//				listener.Stop();
//			}
//			catch(Exception ex)
//			{
//				MessageBox.Show("���� �޽��� : " + ex.StackTrace);
//			}
//			btnStart.Enabled = true;
//			btnEnd.Enabled = false;
//		}

//		private void btnStart_Click(object sender, System.EventArgs e)
//		{
//			th = new Thread(new ThreadStart(Accept));
//			th.Start();
//		}

//		private void btnEnd_Click(object sender, System.EventArgs e)
//		{
//			this.Stop();
//			try
//			{
//				th.Abort();
//			}
//			catch
//			{
			
//			}
//		}

//		private void btnTimeClient_Click(object sender, System.EventArgs e)
//		{
//			��_Ÿ��Ŭ���̾�Ʈ client = new ��_Ÿ��Ŭ���̾�Ʈ();
//			client.Show();
//		}
//	}
//}
