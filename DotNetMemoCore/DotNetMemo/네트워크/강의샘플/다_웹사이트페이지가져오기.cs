using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//
using System.Net;
using System.Text;
using System.IO;

namespace CSharp_Network.���ǻ���
{
	/// <summary>
	/// ��_������Ʈ�������������⿡ ���� ��� �����Դϴ�.
	/// </summary>
	public class ��_������Ʈ�������������� : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Button btnGet;
		private System.Windows.Forms.TextBox txtSource;
		#region +
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ��_������Ʈ��������������()
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
			this.btnGet = new System.Windows.Forms.Button();
			this.txtSource = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("����", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(496, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "�� ������ �о����";
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(0, 32);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(408, 21);
			this.txtUrl.TabIndex = 1;
			this.txtUrl.Text = "";
			// 
			// btnGet
			// 
			this.btnGet.Location = new System.Drawing.Point(416, 32);
			this.btnGet.Name = "btnGet";
			this.btnGet.TabIndex = 2;
			this.btnGet.Text = "��������";
			this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
			// 
			// txtSource
			// 
			this.txtSource.Location = new System.Drawing.Point(0, 56);
			this.txtSource.Multiline = true;
			this.txtSource.Name = "txtSource";
			this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtSource.Size = new System.Drawing.Size(488, 456);
			this.txtSource.TabIndex = 3;
			this.txtSource.Text = "";
			// 
			// ��_������Ʈ��������������
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(496, 525);
			this.Controls.Add(this.txtSource);
			this.Controls.Add(this.btnGet);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.label1);
			this.Name = "��_������Ʈ��������������";
			this.Text = "��_������Ʈ��������������";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void btnGet_Click(object sender, System.EventArgs e)
		{
			//�� ������ ����
			System.Net.WebRequest request = WebRequest.Create(this.txtUrl.Text.Trim());

			//������ ������ ��Ʈ�� ����
			System.Net.WebResponse response = request.GetResponse();
			System.IO.Stream stream = response.GetResponseStream();

			//��Ʈ������ ������ �б�
			StreamReader read = new StreamReader(stream, System.Text.Encoding.Default);
			
			//���ڿ��� ȿ�������� ó���ϱ� ���� StringBuilder Ŭ���� ����
			StringBuilder strData = new StringBuilder();

			//���� ������ ������ �о����
			while(read.ReadLine() != null)
			{
				strData.Append(read.ReadLine() + "\r\n");
			}

			//��Ʈ�� �ݱ�
			read.Close();

			//ȭ�鿡 ���
			this.txtSource.Text = strData.ToString();
		}
	}
}
