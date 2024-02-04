using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmPanel에 대한 요약 설명입니다.
	/// </summary>
	public class FrmPanel : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Panel pnlTest;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmPanel()
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
			this.pnlTest = new System.Windows.Forms.Panel();
			this.btnLeft = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.pnlTest.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTest
			// 
			this.pnlTest.AutoScroll = true;
			this.pnlTest.Controls.Add(this.btnRight);
			this.pnlTest.Controls.Add(this.btnLeft);
			this.pnlTest.Location = new System.Drawing.Point(32, 16);
			this.pnlTest.Name = "pnlTest";
			this.pnlTest.Size = new System.Drawing.Size(248, 120);
			this.pnlTest.TabIndex = 0;
			// 
			// btnLeft
			// 
			this.btnLeft.Location = new System.Drawing.Point(16, 48);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.TabIndex = 0;
			this.btnLeft.Text = "왼쪽버튼";
			this.btnLeft.Click += new System.EventHandler(this.pnlTest_Click);
			// 
			// btnRight
			// 
			this.btnRight.Location = new System.Drawing.Point(192, 48);
			this.btnRight.Name = "btnRight";
			this.btnRight.TabIndex = 1;
			this.btnRight.Text = "오른쪽버튼";
			this.btnRight.Click += new System.EventHandler(this.pnlTest_Click);
			// 
			// FrmPanel
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(320, 157);
			this.Controls.Add(this.pnlTest);
			this.Name = "FrmPanel";
			this.Text = "패널 : 컨트롤 그룹화 및 스크롤링 가능";
			this.pnlTest.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		// btnLeft와 btnRight 클릭시 발생
		private void pnlTest_Click(
			object sender, System.EventArgs e)
		{
			if(sender == btnLeft){
				MessageBox.Show(
					btnLeft.Text + " 선택됨.");	
			}
			else{
				MessageBox.Show(
					btnRight.Text + " 선택됨.");	
			}
		}

	}
}
