using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[0]
using System.Net;

namespace CSharp_Network.���ǻ���
{
	/// <summary>
	/// ��_�������ּ�������α׷��� ���� ��� �����Դϴ�.
	/// </summary>
	public class ��_�������ּ�������α׷� : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.ListBox listBox1;
		#region +
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ��_�������ּ�������α׷�()
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
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "�ּ��Է� : ";
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(80, 24);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(200, 21);
			this.txtUrl.TabIndex = 1;
			this.txtUrl.Text = "";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(88, 232);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(136, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "Ȯ��";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// listBox1
			// 
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(8, 56);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(272, 160);
			this.listBox1.TabIndex = 3;
			// 
			// ��_�������ּ�������α׷�
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.label1);
			this.Name = "��_�������ּ�������α׷�";
			this.Text = "��_�������ּ�������α׷�";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void btnOK_Click(object sender, System.EventArgs e)
		{
			////IPHostEntry : ȣ��Ʈ �� ���� ���� Ŭ����
			//System.Net.IPHostEntry host = 
			//	//Dns : ȣ��Ʈ �̸��� IP �ּҷ� ��ȯ
			//	System.Net.Dns.Resolve(this.txtUrl.Text);

   //         this.listBox1.Items.Add("ȣ��Ʈ �̸� : " + host.HostName);
			//this.listBox1.Items.Add("������ �ּ� ����Ʈ : ");
			//for(int i = 0;i < host.AddressList.Length;i++)
			//{
			//	//IPAddress : IP �ּ� ����
			//	System.Net.IPAddress ip = host.AddressList[i];
			//	this.listBox1.Items.Add(String.Format("[{0}]", ip));
			//}
		}
	}
}
