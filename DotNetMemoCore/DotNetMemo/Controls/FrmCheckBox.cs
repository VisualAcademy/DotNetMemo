using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmCheckBox에 대한 요약 설명입니다.
	/// </summary>
	public class FrmCheckBox : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkSoccer;
		private System.Windows.Forms.CheckBox chkBasketball;
		private System.Windows.Forms.Label lblDisplay;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmCheckBox()
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
			this.chkSoccer = new System.Windows.Forms.CheckBox();
			this.chkBasketball = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// chkSoccer
			// 
			this.chkSoccer.Location = new System.Drawing.Point(40, 56);
			this.chkSoccer.Name = "chkSoccer";
			this.chkSoccer.TabIndex = 0;
			this.chkSoccer.Text = "축구";
			this.chkSoccer.CheckedChanged += new System.EventHandler(this.chkSoccer_CheckedChanged);
			// 
			// chkBasketball
			// 
			this.chkBasketball.Location = new System.Drawing.Point(168, 56);
			this.chkBasketball.Name = "chkBasketball";
			this.chkBasketball.TabIndex = 1;
			this.chkBasketball.Text = "농구";
			this.chkBasketball.CheckedChanged += new System.EventHandler(this.chkBasketball_CheckedChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(296, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "당신의 취미는?";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 118);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(296, 23);
			this.lblDisplay.TabIndex = 3;
			// 
			// FrmCheckBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(296, 141);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chkBasketball);
			this.Controls.Add(this.chkSoccer);
			this.Name = "FrmCheckBox";
			this.Text = "체크박스 : 항목 선택(다중 선택 가능)";
			this.ResumeLayout(false);

		}
		#endregion

		private void chkSoccer_CheckedChanged(object sender, System.EventArgs e){
			if(chkSoccer.Checked == true){
				this.lblDisplay.Text = 
					this.chkSoccer.Text;//축구
			}
			else{
				this.lblDisplay.Text = "";
			}
		}
		private void chkBasketball_CheckedChanged(object sender, System.EventArgs e){
			if(this.chkBasketball.Checked){
				this.lblDisplay.Text = 
					this.chkBasketball.Text;
			}
			else{
				lblDisplay.Text = String.Empty;	
			}
		}
	}
}
