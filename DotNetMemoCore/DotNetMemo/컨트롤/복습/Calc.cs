using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.복습
{
	/// <summary>
	/// Calc에 대한 요약 설명입니다.
	/// </summary>
	public class Calc : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdCalc;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Calc()
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

		#region Windows Form Designer generated code
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblDisplay = new System.Windows.Forms.Label();
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdCalc = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblDisplay
			// 
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(292, 23);
			this.lblDisplay.TabIndex = 0;
			this.lblDisplay.Text = "계산할 내용을 입력하세요.";
			this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(96, 48);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.TabIndex = 1;
			this.txtNum1.Text = "";
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(96, 104);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.TabIndex = 2;
			this.txtNum2.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(136, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 14);
			this.label1.TabIndex = 3;
			this.label1.Text = "+";
			// 
			// cmdCalc
			// 
			this.cmdCalc.Location = new System.Drawing.Point(112, 152);
			this.cmdCalc.Name = "cmdCalc";
			this.cmdCalc.TabIndex = 4;
			this.cmdCalc.Text = "계산하기";
			this.cmdCalc.Click += new System.EventHandler(this.cmdCalc_Click);
			// 
			// Calc
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.ClientSize = new System.Drawing.Size(292, 203);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.cmdCalc,
																																	this.label1,
																																	this.txtNum2,
																																	this.txtNum1,
																																	this.lblDisplay});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Calc";
			this.Text = "간단한 계산기";
			this.ResumeLayout(false);

		}
		#endregion

		private void cmdCalc_Click(object sender, System.EventArgs e)
		{
			int firstNumber = 0;
			int lastNumber = 0;
			if(this.txtNum1.Text.Length > 0 &&
				this.txtNum2.Text.Length > 0)
			{
				firstNumber = Convert.ToInt32(
					this.txtNum1.Text);
				lastNumber = Convert.ToInt32(
					this.txtNum2.Text);
			}

			string strMsg = String.Format("{0} + {1} = {2}"
				, firstNumber, lastNumber
				, (firstNumber + lastNumber));

			MessageBox.Show(strMsg);
		}
	}
}
