using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Ű�����̺�Ʈó��
{
	/// <summary>
	/// FrmKeyboardHelper�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmKeyboardHelper : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label keyInfoLabel;
		private System.Windows.Forms.Label charLabel;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmKeyboardHelper()
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
			this.keyInfoLabel = new System.Windows.Forms.Label();
			this.charLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// keyInfoLabel
			// 
			this.keyInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.keyInfoLabel.Location = new System.Drawing.Point(62, 92);
			this.keyInfoLabel.Name = "keyInfoLabel";
			this.keyInfoLabel.Size = new System.Drawing.Size(168, 136);
			this.keyInfoLabel.TabIndex = 2;
			// 
			// charLabel
			// 
			this.charLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.charLabel.Location = new System.Drawing.Point(62, 44);
			this.charLabel.Name = "charLabel";
			this.charLabel.Size = new System.Drawing.Size(168, 32);
			this.charLabel.TabIndex = 1;
			// 
			// FrmKeyboardHelper
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.keyInfoLabel);
			this.Controls.Add(this.charLabel);
			this.Name = "FrmKeyboardHelper";
			this.Text = "FrmKeyboardHelper";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKeyboardHelper_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmKeyboardHelper_KeyPress);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmKeyboardHelper_KeyUp);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmKeyboardHelper_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			keyInfoLabel.Text = "";
			charLabel.Text = "";
		}

		private void FrmKeyboardHelper_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			charLabel.Text = e.KeyChar + "Ű ����";
		}

		private void FrmKeyboardHelper_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			keyInfoLabel.Text = 
				"Alt: " + (e.Alt ? "Yes" : "No") + '\n' +
				"Shift: " + (e.Shift ? "Yes" : "No" ) + '\n' +
				"Ctrl: " + (e.Control ? "Yes" : "No" ) + '\n' + 
				"KeyCode: " + e.KeyCode + '\n' +
				"KeyData: " + e.KeyData + '\n' +
				"KeyValue: " + e.KeyValue;    
		}
	}
}
