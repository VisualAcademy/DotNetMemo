using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;//

namespace CSharp_Windows.�������ϴ��̾�α�
{
	public class FrmOpenFileDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.TextBox textBox1;
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

		#region Windows Form �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnOpen = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(232, 24);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.TabIndex = 1;
			this.btnOpen.Text = "���� ����";
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(224, 112);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			// 
			// FrmOpenFileDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(320, 69);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnOpen);
			this.Name = "FrmOpenFileDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmOpenFileDialog";
			this.ResumeLayout(false);

		}
		#endregion
#endregion 
		private void btnOpen_Click(object sender, System.EventArgs e)
		{
			string strFileName = 
				@"C:\CSharp_Windows\CSharp_Windows\�������ϴ��̾�α�\Hello.txt";		

			// ���� ��ȭ ���� ����� ����
			this.openFileDialog1.Filter = 
				"Text files (*.txt)|*.txt|All files (*.*)|*.*";
			this.openFileDialog1.FilterIndex = 1;
			this.openFileDialog1.InitialDirectory = @"C:\CSharp_Windows\";
			this.openFileDialog1.Title = "�ؽ�Ʈ ���� ����";

			// Ȯ�� ��ư�� Ŭ���Ѵٸ�,
			if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				strFileName = this.openFileDialog1.FileName;
				StreamReader objSr = new StreamReader(strFileName
					, System.Text.Encoding.Default);//���ڵ� ��� ����
				this.textBox1.Text = objSr.ReadToEnd();
				objSr.Close();
			}
		}
	}
}
