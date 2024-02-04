using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.키보드이벤트처리
{
	/// <summary>
	/// FrmKeyboardHelper에 대한 요약 설명입니다.
	/// </summary>
	public class FrmKeyboardHelper : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label keyInfoLabel;
		private System.Windows.Forms.Label charLabel;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmKeyboardHelper()
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
			this.keyInfoLabel = new System.Windows.Forms.Label();
			this.charLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// keyInfoLabel
			// 
			this.keyInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.keyInfoLabel.Location = new System.Drawing.Point(62, 92);
			this.keyInfoLabel.Name = "keyInfoLabel";
			this.keyInfoLabel.Size = new System.Drawing.Size(168, 136);
			this.keyInfoLabel.TabIndex = 2;
			// 
			// charLabel
			// 
			this.charLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.charLabel.Location = new System.Drawing.Point(62, 44);
			this.charLabel.Name = "charLabel";
			this.charLabel.Size = new System.Drawing.Size(168, 32);
			this.charLabel.TabIndex = 1;
			// 
			// FrmKeyboardHelper
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.keyInfoLabel);
			this.Controls.Add(this.charLabel);
			this.Name = "FrmKeyboardHelper";
			this.Text = "FrmKeyboardHelper";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKeyboardHelper_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmKeyboardHelper_KeyPress);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmKeyboardHelper_KeyUp);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmKeyboardHelper_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			keyInfoLabel.Text = "";
			charLabel.Text = "";
		}

		private void FrmKeyboardHelper_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			charLabel.Text = e.KeyChar + "키 눌림";
		}

		private void FrmKeyboardHelper_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			keyInfoLabel.Text = 
				"Alt: " + (e.Alt ? "Yes" : "No") + '\n' +
				"Shift: " + (e.Shift ? "Yes" : "No" ) + '\n' +
				"Ctrl: " + (e.Control ? "Yes" : "No" ) + '\n' + 
				"KeyCode: " + e.KeyCode + '\n' +
				"KeyData: " + e.KeyData + '\n' +
				"KeyValue: " + e.KeyValue;    
		}
	}
}
