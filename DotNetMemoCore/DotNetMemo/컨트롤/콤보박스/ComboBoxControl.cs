using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.�޺��ڽ�
{
	public class ComboBoxControl : System.Windows.Forms.Form
	{
		#region Controls
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button cmdOK;
		private System.Windows.Forms.ComboBox comYear;
		private System.Windows.Forms.ComboBox comMonth;
		private System.Windows.Forms.ComboBox comDay;
		#endregion

		private System.ComponentModel.Container components = null;

		public ComboBoxControl()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
		}

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
			this.comYear = new System.Windows.Forms.ComboBox();
			this.comMonth = new System.Windows.Forms.ComboBox();
			this.comDay = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmdOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("����", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "����� ���������?";
			// 
			// comYear
			// 
			this.comYear.Location = new System.Drawing.Point(16, 56);
			this.comYear.Name = "comYear";
			this.comYear.Size = new System.Drawing.Size(121, 20);
			this.comYear.TabIndex = 1;
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
			this.comMonth.Location = new System.Drawing.Point(16, 88);
			this.comMonth.Name = "comMonth";
			this.comMonth.Size = new System.Drawing.Size(121, 20);
			this.comMonth.TabIndex = 2;
			this.comMonth.Text = "1";
			this.comMonth.SelectedIndexChanged += new System.EventHandler(this.comMonth_SelectedIndexChanged);
			// 
			// comDay
			// 
			this.comDay.Location = new System.Drawing.Point(16, 120);
			this.comDay.Name = "comDay";
			this.comDay.Size = new System.Drawing.Size(121, 20);
			this.comDay.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(144, 56);
			this.label2.Name = "label2";
			this.label2.TabIndex = 4;
			this.label2.Text = "��";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(144, 88);
			this.label3.Name = "label3";
			this.label3.TabIndex = 5;
			this.label3.Text = "��";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(144, 120);
			this.label4.Name = "label4";
			this.label4.TabIndex = 6;
			this.label4.Text = "��";
			// 
			// cmdOK
			// 
			this.cmdOK.Location = new System.Drawing.Point(200, 176);
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.TabIndex = 7;
			this.cmdOK.Text = "Ȯ��";
			this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
			// 
			// ComboBoxControl
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 221);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.cmdOK,
																																	this.label4,
																																	this.label3,
																																	this.label2,
																																	this.comDay,
																																	this.comMonth,
																																	this.comYear,
																																	this.label1});
			this.Name = "ComboBoxControl";
			this.Text = "�޺��ڽ� ��Ʈ��";
			this.Load += new System.EventHandler(this.ComboBoxControl_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void ComboBoxControl_Load(object sender, System.EventArgs e)
		{
			for(int i = 2005;i > 1950;i--)
			{
				this.comYear.Items.Add(i.ToString());
			}
			for(int i = 1;i <= 31;i++)
			{
				this.comDay.Items.Add(i.ToString());
			}
		}

		private void comMonth_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.comDay.Items.Clear();
			int intYear = 
				Convert.ToInt32(this.comYear.SelectedItem);//���õ� �⵵
			int intMonth =
				Convert.ToInt32(this.comMonth.SelectedItem);//���õ� ��
			int intDay = DateTime.DaysInMonth(intYear, intMonth);
			for(int i = 1;i <= intDay;i++)
			{
				this.comDay.Items.Add(i.ToString());
			}
		}

		private void cmdOK_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
