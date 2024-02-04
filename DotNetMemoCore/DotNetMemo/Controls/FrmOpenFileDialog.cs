using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;//���ڵ� ��� ����
using System.IO;//��Ʈ�� ��ü

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmOpenFileDialog�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmOpenFileDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		#region +
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmOpenFileDialog()
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
		#endregion 
		#region Windows Form �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(8, 8);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(216, 120);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(232, 16);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.TabIndex = 1;
			this.btnOpen.Text = "����";
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// FrmOpenFileDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(312, 133);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.richTextBox1);
			this.Name = "FrmOpenFileDialog";
			this.Text = "FrmOpenFileDialog";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOpen_Click(object sender, System.EventArgs e)
		{
			// ���� ��ȭ ����
			this.openFileDialog1.Filter = 
				"�ؽ�Ʈ ����(*.txt)|*.txt|�������|*.*";
			this.openFileDialog1.FilterIndex = 1;
			this.openFileDialog1.InitialDirectory = 
				@"C:\CSharp_Windows\CSharp_Windows\";
			this.openFileDialog1.Title = "�ؽ�Ʈ ���� ����";
			// ���� ó��
			DialogResult objDr = 
				this.openFileDialog1.ShowDialog();
			if(objDr == DialogResult.OK)
			{
				string strFileName = 
					this.openFileDialog1.FileName;//������ü���
				// ��Ʈ�� Ŭ���� �ν��Ͻ� ����
				StreamReader objSr = 
					new StreamReader(strFileName, 
						Encoding.Default);
				this.richTextBox1.Text = 
					objSr.ReadToEnd();//��ü ���
				objSr.Close();//��Ʈ�� ��ü �ݱ�
			}

		}
	}
}
