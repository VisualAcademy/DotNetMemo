using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmDomainUpDown�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmDomainUpDown : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DomainUpDown domainUpDown1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmDomainUpDown()
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
			this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// domainUpDown1
			// 
			this.domainUpDown1.Items.Add("Windows Server");
			this.domainUpDown1.Items.Add("SQL Server");
			this.domainUpDown1.Items.Add("Visual Studio");
			this.domainUpDown1.Location = new System.Drawing.Point(72, 16);
			this.domainUpDown1.Name = "domainUpDown1";
			this.domainUpDown1.TabIndex = 0;
			this.domainUpDown1.Text = "domainUpDown1";
			this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(80, 56);
			this.label1.Name = "label1";
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(80, 96);
			this.label2.Name = "label2";
			this.label2.TabIndex = 2;
			this.label2.Text = "label2";
			// 
			// FrmDomainUpDown
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(256, 133);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.domainUpDown1);
			this.Name = "FrmDomainUpDown";
			this.Text = "FrmDomainUpDown";
			this.Load += new System.EventHandler(this.FrmDomainUpDown_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void domainUpDown1_SelectedItemChanged(object sender, System.EventArgs e)
		{
			// ù��° ���̺� �ε��� ǥ��
			this.label1.Text = 
				this.domainUpDown1.SelectedIndex.ToString();
			// �ι�° ���̺� ���� ���õ� ���� ǥ��
      this.label2.Text = 
				//this.domainUpDown1.SelectedItem.ToString();
				this.domainUpDown1.Items[
					this.domainUpDown1.SelectedIndex].ToString();
		}

		private void FrmDomainUpDown_Load(object sender, System.EventArgs e)
		{
			// ù��° �������� ��������
			this.domainUpDown1.SelectedIndex = 0;
		}
	}
}
