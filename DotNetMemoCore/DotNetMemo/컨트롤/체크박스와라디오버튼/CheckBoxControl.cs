using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.체크박스와라디오버튼
{
	/// <summary>
	/// CheckBoxControl에 대한 요약 설명입니다.
	/// </summary>
	public class CheckBoxControl : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkConsole;
		private System.Windows.Forms.CheckBox chkWeb;
		private System.Windows.Forms.CheckBox chkWindows;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblDisplay;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CheckBoxControl()
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
			this.label1 = new System.Windows.Forms.Label();
			this.chkConsole = new System.Windows.Forms.CheckBox();
			this.chkWeb = new System.Windows.Forms.CheckBox();
			this.chkWindows = new System.Windows.Forms.CheckBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(376, 48);
			this.label1.TabIndex = 0;
			this.label1.Text = "C#에서 본인이 잘하는 분야는?";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chkConsole
			// 
			this.chkConsole.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.chkConsole.Location = new System.Drawing.Point(32, 72);
			this.chkConsole.Name = "chkConsole";
			this.chkConsole.Size = new System.Drawing.Size(304, 48);
			this.chkConsole.TabIndex = 1;
			this.chkConsole.Text = "콘솔 응용프로그램";
			this.chkConsole.CheckedChanged += new System.EventHandler(this.chkConsole_CheckedChanged);
			// 
			// chkWeb
			// 
			this.chkWeb.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.chkWeb.Location = new System.Drawing.Point(32, 186);
			this.chkWeb.Name = "chkWeb";
			this.chkWeb.Size = new System.Drawing.Size(304, 48);
			this.chkWeb.TabIndex = 2;
			this.chkWeb.Text = "웹 응용프로그램";
			this.chkWeb.CheckedChanged += new System.EventHandler(this.chkWeb_CheckedChanged);
			// 
			// chkWindows
			// 
			this.chkWindows.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.chkWindows.Location = new System.Drawing.Point(32, 129);
			this.chkWindows.Name = "chkWindows";
			this.chkWindows.Size = new System.Drawing.Size(304, 48);
			this.chkWindows.TabIndex = 2;
			this.chkWindows.Text = "윈도우 응용프로그램";
			this.chkWindows.CheckedChanged += new System.EventHandler(this.chkWindows_CheckedChanged);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnOK.Location = new System.Drawing.Point(280, 272);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "확인";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lblDisplay.Location = new System.Drawing.Point(16, 272);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(216, 23);
			this.lblDisplay.TabIndex = 5;
			this.lblDisplay.Text = "선택된 값 : ";
			// 
			// CheckBoxControl
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(376, 309);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.lblDisplay,
																																	this.btnOK,
																																	this.chkWeb,
																																	this.chkConsole,
																																	this.label1,
																																	this.chkWindows});
			this.Name = "CheckBoxControl";
			this.Text = "CheckBoxControl";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			string strMsg = String.Empty;
			if(this.chkConsole.Checked == true)//[1]
			{
				strMsg += this.chkConsole.Text + "\n";
			}
			if(this.chkWindows.Checked)//[2] 주로 사용
			{
				strMsg += this.chkWindows.Text + "\n";
			}
			if(this.chkWeb.Checked != false)//[3]
			{
				strMsg += this.chkWeb.Text;
			}
			MessageBox.Show(strMsg);//출력
		}

		private void chkConsole_CheckedChanged(object sender, System.EventArgs e)
		{
			this.lblDisplay.Text = 
				"선택된 값 : " + this.chkConsole.Text;
		}

		private void chkWindows_CheckedChanged(object sender, System.EventArgs e)
		{
			this.lblDisplay.Text =
				"선택된 값 : " + this.chkWindows.Text;
		}

		private void chkWeb_CheckedChanged(object sender, System.EventArgs e)
		{
			this.lblDisplay.Text =
				"선택된 값 : " + this.chkWeb.Text;
		}
	}
}
