using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmGroupBox에 대한 요약 설명입니다.
	/// </summary>
	public class FrmGroupBoxClick : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnHi;
		private System.Windows.Forms.Button cmdBye;
		private System.Windows.Forms.Label lblDisplay;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmGroupBoxClick()
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnHi = new System.Windows.Forms.Button();
			this.cmdBye = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmdBye);
			this.groupBox1.Controls.Add(this.btnHi);
			this.groupBox1.Location = new System.Drawing.Point(24, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 96);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "클릭하세요";
			// 
			// btnHi
			// 
			this.btnHi.Location = new System.Drawing.Point(16, 40);
			this.btnHi.Name = "btnHi";
			this.btnHi.TabIndex = 0;
			this.btnHi.Text = "안녕";
			this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
			// 
			// cmdBye
			// 
			this.cmdBye.Location = new System.Drawing.Point(112, 40);
			this.cmdBye.Name = "cmdBye";
			this.cmdBye.TabIndex = 1;
			this.cmdBye.Text = "잘가";
			this.cmdBye.Click += new System.EventHandler(this.cmdBye_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblDisplay.Location = new System.Drawing.Point(0, 134);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(248, 23);
			this.lblDisplay.TabIndex = 1;
			this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmGroupBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(248, 157);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmGroupBox";
			this.Text = "그룹박스 : 여러 컨트롤을 묶는 컨테이너 역할";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnHi_Click(object sender, System.EventArgs e)
		{
			lblDisplay.Text = btnHi.Text;	
		}

		private void cmdBye_Click(object sender, System.EventArgs e)
		{
			lblDisplay.Text = cmdBye.Text;
		}
	}
}
