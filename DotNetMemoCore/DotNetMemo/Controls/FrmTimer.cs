using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;//StringBuilder

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmTimer에 대한 요약 설명입니다.
	/// </summary>
	public class FrmTimer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox txtDisplay;
		private System.ComponentModel.IContainer components;

		public FrmTimer()
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
			this.components = new System.ComponentModel.Container();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.txtDisplay = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Location = new System.Drawing.Point(24, 8);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(248, 23);
			this.lblDisplay.TabIndex = 0;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// txtDisplay
			// 
			this.txtDisplay.Location = new System.Drawing.Point(24, 48);
			this.txtDisplay.Multiline = true;
			this.txtDisplay.Name = "txtDisplay";
			this.txtDisplay.Size = new System.Drawing.Size(248, 128);
			this.txtDisplay.TabIndex = 1;
			this.txtDisplay.Text = "";
			// 
			// FrmTimer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 205);
			this.Controls.Add(this.txtDisplay);
			this.Controls.Add(this.lblDisplay);
			this.Name = "FrmTimer";
			this.Text = "FrmTimer";
			this.Load += new System.EventHandler(this.FrmTimer_Load);
			this.ResumeLayout(false);

		}
		#endregion

		// Interval(1초)마다 이벤트 발생
		private void timer1_Tick(object sender, System.EventArgs e)
		{
			this.lblDisplay.Text = 
				"현재 일시: " + 
				DateTime.Now.ToString();
			//
			this.FrmTimer_Load(null, null);
		}

		private void FrmTimer_Load(object sender, System.EventArgs e)
		{
			// 년, 월, 일, 시, 분, 초 나누기
			string strMsg = String.Empty;
			strMsg = String.Format(
				"{0}년\r\n{1}월\r\n{2}일\r\n" + 
				"{3}시\r\n{4}분\r\n{5}초\r\n",
				DateTime.Now.Year,
				DateTime.Now.Month,
				DateTime.Now.Day,
				DateTime.Now.Hour,
				DateTime.Now.Minute,
				DateTime.Now.Second);
			this.txtDisplay.Text = strMsg;
			// StringBuilder 클래스 사용 
			StringBuilder sb = new StringBuilder();
			sb.Append("현재시간\r\n");
			sb.Append(
				DateTime.Now.Year.ToString() + "년");
      sb.AppendFormat(
				"\r\n{0}월", DateTime.Now.Month);
			sb.AppendFormat(
				"{0}{1}일{2}", "\r\n", 
				DateTime.Now.Day, "\r\n");
			this.txtDisplay.Text += sb.ToString();
		}
	}
}
