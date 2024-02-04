using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	public class FrmFontDialogControl : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnFont;
		private System.Windows.Forms.FontDialog fontDialog1;
		#region +
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmFontDialogControl()
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnFont = new System.Windows.Forms.Button();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(16, 16);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(224, 96);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// btnFont
			// 
			this.btnFont.Location = new System.Drawing.Point(248, 16);
			this.btnFont.Name = "btnFont";
			this.btnFont.TabIndex = 1;
			this.btnFont.Text = "글꼴";
			this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
			// 
			// FrmFontDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(328, 125);
			this.Controls.Add(this.btnFont);
			this.Controls.Add(this.richTextBox1);
			this.Name = "FrmFontDialog";
			this.Text = "FrmFontDialog";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void btnFont_Click(object sender, System.EventArgs e)
		{
			// 글꼴 색상 지정
			this.fontDialog1.ShowColor = true;
			// 글꼴 설정 창
			if(this.fontDialog1.ShowDialog() ==
				DialogResult.OK)
			{
				this.richTextBox1.Font =
					this.fontDialog1.Font;//폰트 설정
				this.richTextBox1.ForeColor = 
					this.fontDialog1.Color;//글꼴 색상 설정
			}
		}
	}
}
