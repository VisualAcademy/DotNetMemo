using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmScrollBar : ��ũ�ѹ�
	/// </summary>
	public class FrmScrollBar : System.Windows.Forms.Form
	{
		#region Controls
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.HScrollBar hScrollBar2;
		private System.Windows.Forms.HScrollBar hScrollBar3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDisplay;
		#endregion

		#region Private Members
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		#region Constructors
		public FrmScrollBar()
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

		#region Windows Form �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
			this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.Location = new System.Drawing.Point(40, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 128);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(40, 160);
			this.hScrollBar1.Maximum = 256;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(208, 16);
			this.hScrollBar1.TabIndex = 1;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// hScrollBar2
			// 
			this.hScrollBar2.Location = new System.Drawing.Point(40, 184);
			this.hScrollBar2.Maximum = 256;
			this.hScrollBar2.Name = "hScrollBar2";
			this.hScrollBar2.Size = new System.Drawing.Size(208, 16);
			this.hScrollBar2.TabIndex = 2;
			this.hScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar2_Scroll);
			// 
			// hScrollBar3
			// 
			this.hScrollBar3.Location = new System.Drawing.Point(40, 208);
			this.hScrollBar3.Maximum = 256;
			this.hScrollBar3.Name = "hScrollBar3";
			this.hScrollBar3.Size = new System.Drawing.Size(208, 16);
			this.hScrollBar3.TabIndex = 3;
			this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 254);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(292, 23);
			this.lblDisplay.TabIndex = 4;
			// 
			// FrmScrollBar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 277);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.hScrollBar3);
			this.Controls.Add(this.hScrollBar2);
			this.Controls.Add(this.hScrollBar1);
			this.Controls.Add(this.label1);
			this.Name = "FrmScrollBar";
			this.Text = "FrmScrollBar";
			this.Load += new System.EventHandler(this.FrmScrollBar_Load);
			this.ResumeLayout(false);

		}
		#endregion

		#region Private Methods
		private void ChangeColor()
		{
			int r = this.hScrollBar1.Value;
			int g = this.hScrollBar2.Value;
			int b = this.hScrollBar3.Value;

			this.label1.BackColor = 
				Color.FromArgb(r, g, b);
			this.lblDisplay.Text = String.Format(
				"RGB ���� : RGB({0},{1},{2}"
				, r, g, b);		
		}
		#endregion

		#region Event Handlers
		private void FrmScrollBar_Load(object sender, System.EventArgs e)
		{
			this.label1.BackColor = Color.Red;
		}
		private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			this.ChangeColor();
		}
		private void hScrollBar2_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			ChangeColor();
		}
		private void hScrollBar3_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			hScrollBar1_Scroll(null, null);
		}
		#endregion
	}
}
