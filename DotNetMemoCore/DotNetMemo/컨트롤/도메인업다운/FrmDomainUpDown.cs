using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.�����ξ��ٿ�
{
	public class FrmDomainUpDown : System.Windows.Forms.Form
	{
		#region Controls
		private System.Windows.Forms.DomainUpDown domainUpDown1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		#endregion
		
		#region Private Members
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		#region Constructors
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
		#endregion

		#region Protected Methods
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
		#endregion

		#region Windows Form Designer generated code
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
			this.domainUpDown1.Items.Add("Item1");
			this.domainUpDown1.Items.Add("Item2");
			this.domainUpDown1.Items.Add("Item3");
			this.domainUpDown1.Location = new System.Drawing.Point(56, 16);
			this.domainUpDown1.Name = "domainUpDown1";
			this.domainUpDown1.TabIndex = 0;
			this.domainUpDown1.Text = "domainUpDown1";
			this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(64, 48);
			this.label1.Name = "label1";
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(64, 80);
			this.label2.Name = "label2";
			this.label2.TabIndex = 2;
			this.label2.Text = "label2";
			// 
			// FrmDomainUpDown
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(216, 117);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.domainUpDown1);
			this.Name = "FrmDomainUpDown";
			this.Text = "FrmDomainUpDown";
			this.ResumeLayout(false);

		}
		#endregion
		
		#region Event Handlers
		private void domainUpDown1_SelectedItemChanged(
			object sender, System.EventArgs e)
		{
			this.label1.Text = this.domainUpDown1.SelectedIndex.ToString();
			this.label2.Text = this.domainUpDown1.Items[
				this.domainUpDown1.SelectedIndex].ToString();
		}
		#endregion
	}
}
