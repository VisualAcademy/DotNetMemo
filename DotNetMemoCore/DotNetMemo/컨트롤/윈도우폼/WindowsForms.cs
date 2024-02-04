using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.��������
{
	/// <summary>
	/// WindowsForms�� ���� ��� �����Դϴ�.
	/// </summary>
	public class WindowsForms : System.Windows.Forms.Form
	{
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public WindowsForms()
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

		#region Windows Form Designer generated code
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// WindowsForms
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.ClientSize = new System.Drawing.Size(392, 373);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "WindowsForms";
			this.Text = "�̺�Ʈ ����ϱ�";
			this.Click += new System.EventHandler(this.WindowsForms_Click);
			this.Load += new System.EventHandler(this.WindowsForms_Load);
			this.MouseHover += new System.EventHandler(this.WindowsForms_MouseHover);
			this.MouseLeave += new System.EventHandler(this.WindowsForms_MouseLeave);

		}
		#endregion

		private void WindowsForms_Load(object sender, System.EventArgs e)
		{
			MessageBox.Show("������ ���� �ε�Ǿ����ϴ�.");
		}

		private void WindowsForms_Click(object sender, System.EventArgs e)
		{
			string strMsg = "������ ���� Ŭ���Ǿ����ϴ�.";
			MessageBox.Show(strMsg);
		}

		private void WindowsForms_MouseHover(object sender, System.EventArgs e)
		{
			this.BackColor = Color.Red;
		}

		private void WindowsForms_MouseLeave(object sender, System.EventArgs e)
		{
			this.BackColor = Color.Aqua;
		}
	}
}
