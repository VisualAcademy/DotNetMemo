using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Ʈ����
{
	/// <summary>
	/// FrmTracBar : ��ũ�ѹ�ó�� ������ ���� ������ �� �ִ� ��Ʈ��
	/// </summary>
	public class FrmTrackBar : System.Windows.Forms.Form
	{
		#region Controls
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TrackBar trackBar2;
		#endregion

		#region Private Members
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		#region Constructors
		public FrmTrackBar()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
		}
		#endregion

		#region Protected Methods
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

		#region Windows Form Designer generated code
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmTrackBar));
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			this.SuspendLayout();
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(40, 176);
			this.trackBar1.Maximum = 250;
			this.trackBar1.Minimum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(168, 45);
			this.trackBar1.TabIndex = 0;
			this.trackBar1.Value = 100;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(48, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 140);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(40, 232);
			this.trackBar2.Maximum = 300;
			this.trackBar2.Minimum = 30;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(168, 45);
			this.trackBar2.TabIndex = 2;
			this.trackBar2.Value = 30;
			this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
			// 
			// FrmTrackBar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(232, 286);
			this.Controls.Add(this.trackBar2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.trackBar1);
			this.Name = "FrmTrackBar";
			this.Text = "Ʈ���� ��Ʈ��";
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void trackBar1_Scroll(object sender, System.EventArgs e)
		{
			int x = trackBar1.Value;
			int y = this.pictureBox1.Size.Height;
			this.pictureBox1.Size = new Size(x, y);
		}

		private void trackBar2_Scroll(object sender, System.EventArgs e)
		{
			int x = this.pictureBox1.Size.Width;
			int y = trackBar2.Value;
			this.pictureBox1.Size = new Size(x, y);
		}
		#endregion
	}
}
