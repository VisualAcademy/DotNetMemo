using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	public class FrmSaveFileDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button btnSave;
		#region +
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmSaveFileDialog()
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(8, 8);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(264, 128);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(288, 8);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(56, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "����";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// FrmSaveFileDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(352, 157);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.richTextBox1);
			this.Name = "FrmSaveFileDialog";
			this.Text = "FrmSaveFileDialog";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void btnSave_Click(object sender, System.EventArgs e)
		{
			// SaveFileDialog ��Ʈ���� �ֿ� �Ӽ� ����
			this.saveFileDialog1.Filter = 
				"�ؽ�Ʈ ����(*.txt)|*.txt|��� ����|*.*";
			this.saveFileDialog1.OverwritePrompt = true;
			// ���� ���� ����
			if(this.saveFileDialog1.ShowDialog() ==
				DialogResult.OK)
			{
				string strFileName = 
					this.saveFileDialog1.FileName;
				// ��Ʈ�� Ŭ����
				System.IO.StreamWriter objSw = 
					new System.IO.StreamWriter(
					strFileName, 
					false, // �߰� ����
					System.Text.Encoding.Default);
				// ����
				objSw.Write(this.richTextBox1.Text);
				// �ݱ�
				objSw.Flush(); // ���� ����
				objSw.Close(); // ��Ʈ�� Ŭ���� �ݱ�
			}
		}
	}
}
