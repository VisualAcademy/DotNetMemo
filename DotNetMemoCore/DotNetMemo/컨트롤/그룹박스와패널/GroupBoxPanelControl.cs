using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.�׷�ڽ����г�
{
	public class GroupBoxPanelControl : System.Windows.Forms.Form
	{
		#region Controls
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Button cmdHi;
		private System.Windows.Forms.Button cmdBye;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button btnRight;
		private System.ComponentModel.Container components = null;
		#endregion

		public GroupBoxPanelControl()
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmdHi = new System.Windows.Forms.Button();
			this.cmdBye = new System.Windows.Forms.Button();
			this.btnLeft = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.cmdBye,
																																						this.cmdHi});
			this.groupBox1.Location = new System.Drawing.Point(104, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox1.Size = new System.Drawing.Size(224, 144);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "��ư�� ��������.";
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																				 this.btnRight,
																																				 this.btnLeft});
			this.panel1.Location = new System.Drawing.Point(104, 224);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(224, 136);
			this.panel1.TabIndex = 0;
			// 
			// cmdHi
			// 
			this.cmdHi.Location = new System.Drawing.Point(24, 64);
			this.cmdHi.Name = "cmdHi";
			this.cmdHi.TabIndex = 0;
			this.cmdHi.Text = "�ȳ�";
			this.cmdHi.Click += new System.EventHandler(this.cmdHi_Click);
			// 
			// cmdBye
			// 
			this.cmdBye.Location = new System.Drawing.Point(128, 56);
			this.cmdBye.Name = "cmdBye";
			this.cmdBye.Size = new System.Drawing.Size(88, 40);
			this.cmdBye.TabIndex = 1;
			this.cmdBye.Text = "�߰�";
			this.cmdBye.Click += new System.EventHandler(this.cmdBye_Click);
			// 
			// btnLeft
			// 
			this.btnLeft.Location = new System.Drawing.Point(16, 56);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.TabIndex = 0;
			this.btnLeft.Text = "����";
			this.btnLeft.Click += new System.EventHandler(this.Panel1_Click);
			// 
			// btnRight
			// 
			this.btnRight.Location = new System.Drawing.Point(200, 56);
			this.btnRight.Name = "btnRight";
			this.btnRight.TabIndex = 1;
			this.btnRight.Text = "������";
			this.btnRight.Click += new System.EventHandler(this.Panel1_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Location = new System.Drawing.Point(112, 176);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(216, 23);
			this.lblDisplay.TabIndex = 2;
			// 
			// GroupBoxPanelControl
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(424, 397);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.groupBox1,
																																	this.panel1,
																																	this.lblDisplay});
			this.Name = "GroupBoxPanelControl";
			this.Text = "GroupBoxPanelControl";
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void cmdHi_Click(object sender, System.EventArgs e)
		{
			this.lblDisplay.Text = 
				this.cmdHi.Text + "�� ���õ�";
		}

		private void cmdBye_Click(object sender, System.EventArgs e)
		{
			this.lblDisplay.Text = 
				this.cmdBye.Text + "�� ���õ�";
		}

		private void Panel1_Click(
			object sender, System.EventArgs e){
			if(sender == btnLeft){
				this.lblDisplay.Text = "���� ��ư Ŭ��";
			}
			else{
				this.lblDisplay.Text = "������ ��ư Ŭ��";
			}
		}
	}
}
