using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.��Ʈ�ѷ��̾ƿ�
{
	/// <summary>
	/// ControlLayout�� ���� ��� �����Դϴ�.
	/// </summary>
	public class ControlLayout : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Button btnCheck;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ControlLayout()
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
			this.lblDisplay = new System.Windows.Forms.Label();
			this.btnCheck = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(296, 23);
			this.lblDisplay.TabIndex = 0;
			this.lblDisplay.Text = "��ܿ� ����";
			this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCheck
			// 
			this.btnCheck.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnCheck.Location = new System.Drawing.Point(136, 96);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(144, 23);
			this.btnCheck.TabIndex = 1;
			this.btnCheck.Text = "������ �ؿ� ����";
			// 
			// ControlLayout
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(296, 141);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.btnCheck,
																																	this.lblDisplay});
			this.Name = "ControlLayout";
			this.Text = "��Ʈ�� ���̾ƿ�";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
