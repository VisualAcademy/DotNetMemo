using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmComboBox에 대한 요약 설명입니다.
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
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmComboBox()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
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

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
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
			this.label1.Text = "당신의 생년월일을 선택하시오.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(64, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "년:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(64, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "월:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(64, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "일:";
			// 
			// btnSubmit
			// 
			this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSubmit.Location = new System.Drawing.Point(248, 136);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.TabIndex = 7;
			this.btnSubmit.Text = "확인";
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
			// 컨트롤 초기화
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
				"당신의 생년월일은 {0}년 {1}월"
				+ " {2}일 입니다."
				, this.comYear.SelectedItem
				, this.comMonth.SelectedItem
				, this.comDay.SelectedItem);

      MessageBox.Show(strMsg);
		}
	}
}
