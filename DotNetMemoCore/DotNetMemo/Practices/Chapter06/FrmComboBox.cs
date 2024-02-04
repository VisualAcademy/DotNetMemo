using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmComboBox�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmComboBox : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comYear;
		private System.Windows.Forms.ComboBox comMonth;
		private System.Windows.Forms.ComboBox comDay;
		private System.Windows.Forms.Button btnSubmit;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmComboBox()
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
			this.comYear = new System.Windows.Forms.ComboBox();
			this.comMonth = new System.Windows.Forms.ComboBox();
			this.comDay = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comYear
			// 
			this.comYear.Location = new System.Drawing.Point(104, 40);
			this.comYear.Name = "comYear";
			this.comYear.Size = new System.Drawing.Size(121, 20);
			this.comYear.TabIndex = 0;
			this.comYear.Text = "2006";
			// 
			// comMonth
			// 
			this.comMonth.Items.AddRange(new object[] {
																									"1",
																									"2",
																									"3",
																									"4",
																									"5",
																									"6",
																									"7",
																									"8",
																									"9",
																									"10",
																									"11",
																									"12"});
			this.comMonth.Location = new System.Drawing.Point(104, 68);
			this.comMonth.Name = "comMonth";
			this.comMonth.Size = new System.Drawing.Size(121, 20);
			this.comMonth.TabIndex = 1;
			this.comMonth.Text = "1";
			this.comMonth.SelectedIndexChanged += new System.EventHandler(this.comMonth_SelectedIndexChanged);
			// 
			// comDay
			// 
			this.comDay.Location = new System.Drawing.Point(104, 96);
			this.comDay.Name = "comDay";
			this.comDay.Size = new System.Drawing.Size(121, 20);
			this.comDay.TabIndex = 2;
			this.comDay.Text = "1";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(328, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "����� ��������� �����Ͻÿ�.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(64, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "��:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(64, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "��:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(64, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "��:";
			// 
			// btnSubmit
			// 
			this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSubmit.Location = new System.Drawing.Point(248, 136);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.TabIndex = 7;
			this.btnSubmit.Text = "Ȯ��";
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// FrmComboBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(328, 165);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comDay);
			this.Controls.Add(this.comMonth);
			this.Controls.Add(this.comYear);
			this.Name = "FrmComboBox";
			this.Text = "FrmComboBox";
			this.Load += new System.EventHandler(this.FrmComboBox_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmComboBox_Load(object sender, System.EventArgs e)
		{
			for(int i = DateTime.Now.Year;
				i > (DateTime.Now.Year - 50);i--)
			{
				this.comYear.Items.Add(i);
			}
			for(int i = 1;i <= 31;i++){
				this.comDay.Items.Add(i);
			}
		}

		private void comMonth_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// ��Ʈ�� �ʱ�ȭ
			this.comDay.Items.Clear();
			int intYear = 
				Convert.ToInt32(
					this.comYear.SelectedItem);
			int intMonth = 
				Convert.ToInt32(
					comMonth.SelectedItem);
			int intDay = 
				DateTime.DaysInMonth(
					intYear, intMonth);
			for(int i = 1;i <= intDay;i++){
				this.comDay.Items.Add(i);
			}
		}

		private void btnSubmit_Click(object sender, System.EventArgs e)
		{
			string strMsg = String.Format(
				"����� ��������� {0}�� {1}��"
				+ " {2}�� �Դϴ�."
				, this.comYear.SelectedItem
				, this.comMonth.SelectedItem
				, this.comDay.SelectedItem);

      MessageBox.Show(strMsg);
		}
	}
}
