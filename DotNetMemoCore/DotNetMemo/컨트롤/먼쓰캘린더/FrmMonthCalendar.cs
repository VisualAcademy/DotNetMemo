using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.�վ�Ķ����
{
	/// <summary>
	/// FrmMonthCalendar�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmMonthCalendar : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmMonthCalendar()
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
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(8, 8);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 0;
			this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(160, 64);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "���� ���";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FrmMonthCalendar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(240, 165);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.monthCalendar1);
			this.Name = "FrmMonthCalendar";
			this.Text = "FrmMonthCalendar";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this.monthCalendar1.TodayDate.ToShortDateString());
		}

		private void monthCalendar1_DateSelected(
			object sender, System.Windows.Forms.DateRangeEventArgs e)
		{
			MessageBox.Show(
				"������ : " + e.Start.ToShortDateString() 
				+ ", ������ : " + e.End.ToShortDateString());		
		}
	}
}
