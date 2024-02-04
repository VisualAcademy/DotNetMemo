using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	public class FrmFontDialogControl : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnFont;
		private System.Windows.Forms.FontDialog fontDialog1;
		#region +
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmFontDialogControl()
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
			this.btnFont = new System.Windows.Forms.Button();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(16, 16);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(224, 96);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// btnFont
			// 
			this.btnFont.Location = new System.Drawing.Point(248, 16);
			this.btnFont.Name = "btnFont";
			this.btnFont.TabIndex = 1;
			this.btnFont.Text = "�۲�";
			this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
			// 
			// FrmFontDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(328, 125);
			this.Controls.Add(this.btnFont);
			this.Controls.Add(this.richTextBox1);
			this.Name = "FrmFontDialog";
			this.Text = "FrmFontDialog";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void btnFont_Click(object sender, System.EventArgs e)
		{
			// �۲� ���� ����
			this.fontDialog1.ShowColor = true;
			// �۲� ���� â
			if(this.fontDialog1.ShowDialog() ==
				DialogResult.OK)
			{
				this.richTextBox1.Font =
					this.fontDialog1.Font;//��Ʈ ����
				this.richTextBox1.ForeColor = 
					this.fontDialog1.Color;//�۲� ���� ����
			}
		}
	}
}
