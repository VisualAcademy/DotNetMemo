using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.에러프로바이더
{
	public class FrmErrorProvider : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Button btnOK;
		#region +
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmErrorProvider()
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
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(56, 8);
			this.txtInput.Name = "txtInput";
			this.txtInput.TabIndex = 0;
			this.txtInput.Text = "";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(64, 40);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(80, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "확인";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// FrmErrorProvider
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(208, 69);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtInput);
			this.Name = "FrmErrorProvider";
			this.Text = "FrmErrorProvider";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		// 텍스트 박스 유효성 검사
		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if(this.txtInput.Text.Length < 3)
			{
				this.errorProvider1.SetError(this.txtInput, "3자 이상 넣어주세요.");
			}
			else
			{
				this.errorProvider1.SetError(this.txtInput, "");
			}
		}
	}
}
