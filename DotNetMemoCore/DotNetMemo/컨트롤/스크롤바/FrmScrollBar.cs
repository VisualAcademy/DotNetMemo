using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.스크롤바
{
	/// <summary>
	/// FrmScrollBar : 가로, 세로 스크롤바 설정
	/// </summary>
	public class FrmScrollBar : System.Windows.Forms.Form
	{
		#region Controls
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.HScrollBar hScrollBar2;
		private System.Windows.Forms.HScrollBar hScrollBar3;
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		#endregion

		#region Private Members
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		#region Constructors
		public FrmScrollBar()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}
		#endregion

		#region Protected Methods
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
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
			this.hScrollBar3 = new System.Windows.Forms.HScrollBar();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(32, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(288, 80);
			this.label1.TabIndex = 0;
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.LargeChange = 1;
			this.hScrollBar1.Location = new System.Drawing.Point(64, 136);
			this.hScrollBar1.Maximum = 255;
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(256, 16);
			this.hScrollBar1.TabIndex = 1;
			this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
			// 
			// hScrollBar2
			// 
			this.hScrollBar2.Location = new System.Drawing.Point(64, 168);
			this.hScrollBar2.Maximum = 255;
			this.hScrollBar2.Name = "hScrollBar2";
			this.hScrollBar2.Size = new System.Drawing.Size(256, 16);
			this.hScrollBar2.TabIndex = 2;
			this.hScrollBar2.ValueChanged += new System.EventHandler(this.hScrollBar2_ValueChanged);
			// 
			// hScrollBar3
			// 
			this.hScrollBar3.Location = new System.Drawing.Point(64, 200);
			this.hScrollBar3.Maximum = 255;
			this.hScrollBar3.Name = "hScrollBar3";
			this.hScrollBar3.Size = new System.Drawing.Size(256, 16);
			this.hScrollBar3.TabIndex = 3;
			this.hScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar3_Scroll);
			// 
			// lblDisplay
			// 
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 250);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(352, 23);
			this.lblDisplay.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 136);
			this.label2.Name = "label2";
			this.label2.TabIndex = 5;
			this.label2.Text = "Red";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 168);
			this.label3.Name = "label3";
			this.label3.TabIndex = 6;
			this.label3.Text = "Green";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "Blue";
			// 
			// FrmScrollBar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(352, 273);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.hScrollBar3);
			this.Controls.Add(this.hScrollBar2);
			this.Controls.Add(this.hScrollBar1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "FrmScrollBar";
			this.Text = "FrmScrollBar : 스크롤바";
			this.Load += new System.EventHandler(this.FrmScrollBar_Load);
			this.ResumeLayout(false);

		}
		#endregion

		#region Private Methods
		//[0] 레이블 색상 변경 메서드
		private void ChangeColor()
		{
			int r = this.hScrollBar1.Value;//
			int g = this.hScrollBar2.Value;//
			int b = this.hScrollBar3.Value;//

			this.label1.BackColor = Color.FromArgb(r, g, b);//색상 조합		
			this.lblDisplay.Text = String.Format("RGB 색상값 : RGB({0},{1},{2})"
				, r, g, b);
		}
		#endregion

		#region Event Handlers
		private void FrmScrollBar_Load(object sender, System.EventArgs e)
		{
			//폼 로드
			this.label1.BackColor = Color.Yellow;
		}

		//[1] 스크롤바 스크롤 될 때마다...
		private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			ChangeColor();
		}

		//[2] 스크롤바의 값이 변경될 때마다...
		private void hScrollBar2_ValueChanged(object sender, System.EventArgs e)
		{
			ChangeColor();
		}

		//[3] 
		private void hScrollBar3_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			ChangeColor();
		}
		#endregion
	}
}








