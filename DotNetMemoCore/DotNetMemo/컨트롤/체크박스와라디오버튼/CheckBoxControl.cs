using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.üũ�ڽ��Ͷ�����ư
{
	/// <summary>
	/// CheckBoxControl�� ���� ��� �����Դϴ�.
	/// </summary>
	public class CheckBoxControl : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkConsole;
		private System.Windows.Forms.CheckBox chkWeb;
		private System.Windows.Forms.CheckBox chkWindows;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblDisplay;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CheckBoxControl()
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
			this.chkConsole = new System.Windows.Forms.CheckBox();
			this.chkWeb = new System.Windows.Forms.CheckBox();
			this.chkWindows = new System.Windows.Forms.CheckBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("����", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(376, 48);
			this.label1.TabIndex = 0;
			this.label1.Text = "C#���� ������ ���ϴ� �оߴ�?";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chkConsole
			// 
			this.chkConsole.Font = new System.Drawing.Font("����", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.chkConsole.Location = new System.Drawing.Point(32, 72);
			this.chkConsole.Name = "chkConsole";
			this.chkConsole.Size = new System.Drawing.Size(304, 48);
			this.chkConsole.TabIndex = 1;
			this.chkConsole.Text = "�ܼ� �������α׷�";
			this.chkConsole.CheckedChanged += new System.EventHandler(this.chkConsole_CheckedChanged);
			// 
			// chkWeb
			// 
			this.chkWeb.Font = new System.Drawing.Font("����", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.chkWeb.Location = new System.Drawing.Point(32, 186);
			this.chkWeb.Name = "chkWeb";
			this.chkWeb.Size = new System.Drawing.Size(304, 48);
			this.chkWeb.TabIndex = 2;
			this.chkWeb.Text = "�� �������α׷�";
			this.chkWeb.CheckedChanged += new System.EventHandler(this.chkWeb_CheckedChanged);
			// 
			// chkWindows
			// 
			this.chkWindows.Font = new System.Drawing.Font("����", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.chkWindows.Location = new System.Drawing.Point(32, 129);
			this.chkWindows.Name = "chkWindows";
			this.chkWindows.Size = new System.Drawing.Size(304, 48);
			this.chkWindows.TabIndex = 2;
			this.chkWindows.Text = "������ �������α׷�";
			this.chkWindows.CheckedChanged += new System.EventHandler(this.chkWindows_CheckedChanged);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnOK.Location = new System.Drawing.Point(280, 272);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "Ȯ��";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.Font = new System.Drawing.Font("����", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lblDisplay.Location = new System.Drawing.Point(16, 272);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(216, 23);
			this.lblDisplay.TabIndex = 5;
			this.lblDisplay.Text = "���õ� �� : ";
			// 
			// CheckBoxControl
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(376, 309);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.lblDisplay,
																																	this.btnOK,
																																	this.chkWeb,
																																	this.chkConsole,
																																	this.label1,
																																	this.chkWindows});
			this.Name = "CheckBoxControl";
			this.Text = "CheckBoxControl";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			string strMsg = String.Empty;
			if(this.chkConsole.Checked == true)//[1]
			{
				strMsg += this.chkConsole.Text + "\n";
			}
			if(this.chkWindows.Checked)//[2] �ַ� ���
			{
				strMsg += this.chkWindows.Text + "\n";
			}
			if(this.chkWeb.Checked != false)//[3]
			{
				strMsg += this.chkWeb.Text;
			}
			MessageBox.Show(strMsg);//���
		}

		private void chkConsole_CheckedChanged(object sender, System.EventArgs e)
		{
			this.lblDisplay.Text = 
				"���õ� �� : " + this.chkConsole.Text;
		}

		private void chkWindows_CheckedChanged(object sender, System.EventArgs e)
		{
			this.lblDisplay.Text =
				"���õ� �� : " + this.chkWindows.Text;
		}

		private void chkWeb_CheckedChanged(object sender, System.EventArgs e)
		{
			this.lblDisplay.Text =
				"���õ� �� : " + this.chkWeb.Text;
		}
	}
}
