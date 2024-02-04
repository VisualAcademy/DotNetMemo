using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;//

namespace CSharp_Windows.��Ʈ���̾�α�
{
	public class FrmFontDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button btnFont;
		private System.Windows.Forms.FontDialog fontDialog1;
		#region +
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmFontDialog()
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.btnFont = new System.Windows.Forms.Button();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
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
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(224, 160);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "richTextBox1";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(232, 56);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "���� ����";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnFont
			// 
			this.btnFont.Location = new System.Drawing.Point(232, 88);
			this.btnFont.Name = "btnFont";
			this.btnFont.TabIndex = 4;
			this.btnFont.Text = "�۲�";
			this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
			// 
			// FrmFontDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(312, 141);
			this.Controls.Add(this.btnFont);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnOpen);
			this.Name = "FrmFontDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmFontDialog";
			this.ResumeLayout(false);

		}
		#endregion
#endregion 

		private string strFileName = 
			@"C:\CSharp_Windows\CSharp_Windows\�������ϴ��̾�α�\Hello.txt";		

		private void btnOpen_Click(object sender, System.EventArgs e)
		{
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
				this.richTextBox1.Text = objSr.ReadToEnd();
				objSr.Close();
			}
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			// ���� ��ȭ ���� ����� ����
			this.saveFileDialog1.DefaultExt = "txt";
			this.saveFileDialog1.FileName = strFileName;
			this.saveFileDialog1.Filter = "Text files (*.txt)|.txt|All files (*.*)|*.*";
			this.saveFileDialog1.FilterIndex = 0;
			this.saveFileDialog1.InitialDirectory = @"C:\CSharp_Windows\";
			this.saveFileDialog1.OverwritePrompt = true;
			this.saveFileDialog1.Title = "�ؽ�Ʈ ���� ����";

			// ���� ��ȭ ���ڷ� ���� ����
			if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				strFileName = this.saveFileDialog1.FileName;
				StreamWriter objSw = new StreamWriter(strFileName, false, System.Text.Encoding.Default);
                objSw.Write(this.richTextBox1.Text);
				objSw.Close();
			}
		}

		private void btnFont_Click(object sender, System.EventArgs e)
		{
			this.fontDialog1.ShowColor = true;

			if(this.fontDialog1.ShowDialog() == DialogResult.OK)
			{
				this.richTextBox1.Font = this.fontDialog1.Font;
				this.richTextBox1.ForeColor = this.fontDialog1.Color;
			}
		}
	}
}
