using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.�������ι��̴�
{
	/// <summary>
	/// FrmHelpProvider�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmHelpProvider : System.Windows.Forms.Form
	{
		private System.Windows.Forms.HelpProvider helpProvider1;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmHelpProvider()
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
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// helpProvider1
			// 
			this.helpProvider1.HelpNamespace = "C:\\CSharp_Windows\\CSharp_Windows.htm";
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "F1 Ű�� ����������.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmHelpProvider
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 21);
			this.Controls.Add(this.label1);
			this.helpProvider1.SetHelpKeyword(this, "C# ������ ���α׷���");
			this.helpProvider1.SetHelpString(this, "C#");
			this.KeyPreview = true;
			this.Name = "FrmHelpProvider";
			this.helpProvider1.SetShowHelp(this, true);
			this.Text = "FrmHelpProvider";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
