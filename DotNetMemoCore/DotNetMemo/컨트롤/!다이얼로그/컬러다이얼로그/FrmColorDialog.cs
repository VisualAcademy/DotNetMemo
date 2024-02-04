using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.컬러다이얼로그
{
	/// <summary>
	/// FrmColorDialog 클래스 : 컨트롤의 색상 설정
	/// </summary>
	public class FrmColorDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		#region +
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmColorDialog()
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
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(16, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "textBox1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(128, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "색상 변경";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FrmColorDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 61);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "FrmColorDialog";
			this.Text = "FrmColorDialog";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void button1_Click(object sender, System.EventArgs e)
		{
			if(this.colorDialog1.ShowDialog() == DialogResult.OK)
			{
				this.textBox1.ForeColor = this.colorDialog1.Color;
				this.button1.ForeColor = this.colorDialog1.Color;
			}
		}
	}
}
