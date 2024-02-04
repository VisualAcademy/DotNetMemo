using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.헬프프로바이더
{
	/// <summary>
	/// FrmHelpProvider에 대한 요약 설명입니다.
	/// </summary>
	public class FrmHelpProvider : System.Windows.Forms.Form
	{
		private System.Windows.Forms.HelpProvider helpProvider1;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmHelpProvider()
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
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// helpProvider1
			// 
			this.helpProvider1.HelpNamespace = "C:\\CSharp_Windows\\CSharp_Windows.htm";
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "F1 키를 눌러보세요.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FrmHelpProvider
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 21);
			this.Controls.Add(this.label1);
			this.helpProvider1.SetHelpKeyword(this, "C# 윈도우 프로그래밍");
			this.helpProvider1.SetHelpString(this, "C#");
			this.KeyPreview = true;
			this.Name = "FrmHelpProvider";
			this.helpProvider1.SetShowHelp(this, true);
			this.Text = "FrmHelpProvider";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
