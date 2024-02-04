using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.���콺�̺�Ʈó��
{
	/// <summary>
	/// FrmPainter�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmPainter : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDisplay;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmPainter()
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "���콺�� Ŭ���� ������.";
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 250);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(292, 23);
			this.lblDisplay.TabIndex = 1;
			// 
			// FrmPainter
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.lblDisplay,
																																	this.label1});
			this.Name = "FrmPainter";
			this.Text = "���콺 �̺�Ʈ ó��";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPainter_MouseDown);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmPainter_MouseUp);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPainter_MouseMove);
			this.ResumeLayout(false);

		}
		#endregion

		//[0] �ʵ�
		private bool blnFlag = false;//
		//[1] ���콺 �ٿ�
		private void FrmPainter_MouseDown(
			object sender, 
			System.Windows.Forms.MouseEventArgs e){
			blnFlag = true;//�׸� �׸��� ����
			this.lblDisplay.Text = e.Button.ToString();
			this.lblDisplay.Text += "(" + e.X.ToString()
				+ ", " + e.Y.ToString() + ")";
		}
		//[2] ���콺 ��
		private void FrmPainter_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e){
			blnFlag = false;//�׸� �׸��� ���
		}
		//[3] ���콺 ������ ������ �׸� �׸��� : GDI+
		private void FrmPainter_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e){
			if(blnFlag){ //���콺 �ٿ� �̺�Ʈ �߻���
				Graphics g = CreateGraphics();
				g.FillEllipse(
					new SolidBrush(Color.Red), e.X, e.Y, 5, 5);
			}
		}
	}
}
