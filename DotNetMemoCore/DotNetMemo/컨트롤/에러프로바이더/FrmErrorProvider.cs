using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.�������ι��̴�
{
	public class FrmErrorProvider : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Button btnOK;
		#region +
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmErrorProvider()
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
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(56, 8);
			this.txtInput.Name = "txtInput";
			this.txtInput.TabIndex = 0;
			this.txtInput.Text = "";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(64, 40);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(80, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "Ȯ��";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// FrmErrorProvider
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(208, 69);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtInput);
			this.Name = "FrmErrorProvider";
			this.Text = "FrmErrorProvider";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		// �ؽ�Ʈ �ڽ� ��ȿ�� �˻�
		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if(this.txtInput.Text.Length < 3)
			{
				this.errorProvider1.SetError(this.txtInput, "3�� �̻� �־��ּ���.");
			}
			else
			{
				this.errorProvider1.SetError(this.txtInput, "");
			}
		}
	}
}
