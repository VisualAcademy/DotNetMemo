using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmNumericUpDown�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmNumericUpDown : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Button btnAdd;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmNumericUpDown()
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
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "�ֹ�����:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(112, 16);
			this.numericUpDown1.Maximum = new System.Decimal(new int[] {
																																	 50,
																																	 0,
																																	 0,
																																	 0});
			this.numericUpDown1.Minimum = new System.Decimal(new int[] {
																																	 1,
																																	 0,
																																	 0,
																																	 0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																																 1,
																																 0,
																																 0,
																																 0});
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(80, 56);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "��ٱ��� ���";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 94);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(240, 23);
			this.lblDisplay.TabIndex = 3;
			// 
			// FrmNumericUpDown
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(240, 117);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label1);
			this.Name = "FrmNumericUpDown";
			this.Text = "FrmNumericUpDown";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			string strMsg = String.Empty;
			strMsg = String.Format(
				"��ٱ��Ͽ� {0}���� ��ǰ�� �ֹ��Ǿ���.",
				this.numericUpDown1.Value);
			MessageBox.Show(
				strMsg, 
				"��ٱ��� Ȯ��", 
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}
	}
}
