using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmTextBox�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmTextBoxAll : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSingleLine;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtMultiLine;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtReadOnly;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmTextBoxAll()
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
			this.txtSingleLine = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtMultiLine = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtReadOnly = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtSingleLine
			// 
			this.txtSingleLine.Location = new System.Drawing.Point(136, 16);
			this.txtSingleLine.Name = "txtSingleLine";
			this.txtSingleLine.Size = new System.Drawing.Size(104, 21);
			this.txtSingleLine.TabIndex = 0;
			this.txtSingleLine.Text = "";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(136, 56);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(104, 21);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.Text = "";
			// 
			// txtMultiLine
			// 
			this.txtMultiLine.Location = new System.Drawing.Point(136, 88);
			this.txtMultiLine.Multiline = true;
			this.txtMultiLine.Name = "txtMultiLine";
			this.txtMultiLine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMultiLine.Size = new System.Drawing.Size(104, 96);
			this.txtMultiLine.TabIndex = 2;
			this.txtMultiLine.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 3;
			this.label1.Text = "�̱۶���";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.TabIndex = 4;
			this.label2.Text = "�н�����";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 96);
			this.label3.Name = "label3";
			this.label3.TabIndex = 5;
			this.label3.Text = "��Ƽ����";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 192);
			this.label4.Name = "label4";
			this.label4.TabIndex = 6;
			this.label4.Text = "�б�����";
			// 
			// txtReadOnly
			// 
			this.txtReadOnly.Location = new System.Drawing.Point(136, 192);
			this.txtReadOnly.Name = "txtReadOnly";
			this.txtReadOnly.ReadOnly = true;
			this.txtReadOnly.Size = new System.Drawing.Size(104, 21);
			this.txtReadOnly.TabIndex = 7;
			this.txtReadOnly.Text = "�ȳ�";
			// 
			// FrmTextBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(272, 221);
			this.Controls.Add(this.txtReadOnly);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtMultiLine);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtSingleLine);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmTextBox";
			this.Text = "FrmTextBox";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
