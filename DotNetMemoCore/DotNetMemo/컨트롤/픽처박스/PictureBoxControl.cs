using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.��ó�ڽ�
{
	public class PictureBoxControl : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;

		private System.ComponentModel.Container components = null;

		public PictureBoxControl()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
		}


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PictureBoxControl));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(432, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "�Ʒ� �׸��� Ŭ���� ������.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(104, 72);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(222, 218);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// PictureBoxControl
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(432, 357);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.pictureBox1,
																																	this.label1});
			this.Name = "PictureBoxControl";
			this.Text = "PictureBoxControl";
			this.ResumeLayout(false);

		}
		#endregion

		//���� : Ŭ���� ������ 3�� �̹��� ������Ʈ...
		private int imageNumber = -1;//�ʱ�ȭ
		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
			imageNumber = (imageNumber + 1) % 3 + 1;//����
			this.pictureBox1.Image =
				Image.FromFile(
					System.IO.Directory.GetCurrentDirectory()
					+ "\\images\\image" + imageNumber + ".bmp");
		}
	}
}
