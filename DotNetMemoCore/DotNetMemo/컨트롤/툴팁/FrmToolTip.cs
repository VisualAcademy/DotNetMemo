using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.툴팁
{
	/// <summary>
	/// FrmToolTip : 컨트롤에 풍선 도움말 기능 제공
	/// </summary>
	public class FrmToolTip : System.Windows.Forms.Form
	{
		#region Controls
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.ComponentModel.IContainer components;
		#endregion

		#region Constructors
		public FrmToolTip()
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

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 56);
			this.button1.TabIndex = 0;
			this.button1.Text = "마우스 커서를 올려보세요.";
			this.toolTip1.SetToolTip(this.button1, "툴팁 컨트롤 사용법입니다.");
			// 
			// FrmToolTip
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(216, 77);
			this.Controls.Add(this.button1);
			this.Name = "FrmToolTip";
			this.Text = "FrmToolTip";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
