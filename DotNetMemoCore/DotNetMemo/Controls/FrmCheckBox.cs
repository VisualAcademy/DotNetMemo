using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmCheckBox�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmCheckBox : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkSoccer;
		private System.Windows.Forms.CheckBox chkBasketball;
		private System.Windows.Forms.Label lblDisplay;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmCheckBox()
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
			this.chkSoccer = new System.Windows.Forms.CheckBox();
			this.chkBasketball = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// chkSoccer
			// 
			this.chkSoccer.Location = new System.Drawing.Point(40, 56);
			this.chkSoccer.Name = "chkSoccer";
			this.chkSoccer.TabIndex = 0;
			this.chkSoccer.Text = "�౸";
			this.chkSoccer.CheckedChanged += new System.EventHandler(this.chkSoccer_CheckedChanged);
			// 
			// chkBasketball
			// 
			this.chkBasketball.Location = new System.Drawing.Point(168, 56);
			this.chkBasketball.Name = "chkBasketball";
			this.chkBasketball.TabIndex = 1;
			this.chkBasketball.Text = "��";
			this.chkBasketball.CheckedChanged += new System.EventHandler(this.chkBasketball_CheckedChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(296, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "����� ��̴�?";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 118);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(296, 23);
			this.lblDisplay.TabIndex = 3;
			// 
			// FrmCheckBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(296, 141);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chkBasketball);
			this.Controls.Add(this.chkSoccer);
			this.Name = "FrmCheckBox";
			this.Text = "üũ�ڽ� : �׸� ����(���� ���� ����)";
			this.ResumeLayout(false);

		}
		#endregion

		private void chkSoccer_CheckedChanged(object sender, System.EventArgs e){
			if(chkSoccer.Checked == true){
				this.lblDisplay.Text = 
					this.chkSoccer.Text;//�౸
			}
			else{
				this.lblDisplay.Text = "";
			}
		}
		private void chkBasketball_CheckedChanged(object sender, System.EventArgs e){
			if(this.chkBasketball.Checked){
				this.lblDisplay.Text = 
					this.chkBasketball.Text;
			}
			else{
				lblDisplay.Text = String.Empty;	
			}
		}
	}
}
