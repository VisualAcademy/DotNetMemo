using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.레이블과버튼과텍스트박스
{
	/// <summary>
	/// LabelButtonTextBox에 대한 요약 설명입니다.
	/// </summary>
	public class LabelButtonTextBox : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtMulti;
		private System.Windows.Forms.Button btnOK;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LabelButtonTextBox()
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
			this.lblDisplay = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtMulti = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDisplay.Location = new System.Drawing.Point(152, 24);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(304, 48);
			this.lblDisplay.TabIndex = 0;
			this.lblDisplay.Text = "레이블 컨트롤은 읽기전용 텍스트를 표시합니다.";
			this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "레이블 컨트롤";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "텍스트박스";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "패스워드박스";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "멀티라인텍스트박스";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 248);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "버튼 컨트롤";
			// 
			// txtInput
			// 
			this.txtInput.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtInput.Location = new System.Drawing.Point(152, 88);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(304, 21);
			this.txtInput.TabIndex = 6;
			this.txtInput.Text = "";
			this.txtInput.MouseHover += new System.EventHandler(this.txtInput_MouseHover);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(152, 144);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(304, 21);
			this.txtPassword.TabIndex = 7;
			this.txtPassword.Text = "";
			// 
			// txtMulti
			// 
			this.txtMulti.Location = new System.Drawing.Point(152, 192);
			this.txtMulti.Multiline = true;
			this.txtMulti.Name = "txtMulti";
			this.txtMulti.Size = new System.Drawing.Size(304, 40);
			this.txtMulti.TabIndex = 8;
			this.txtMulti.Text = "";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(152, 248);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(304, 23);
			this.btnOK.TabIndex = 9;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// LabelButtonTextBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(480, 301);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.btnOK,
																																	this.txtMulti,
																																	this.txtPassword,
																																	this.txtInput,
																																	this.label5,
																																	this.label4,
																																	this.label3,
																																	this.label2,
																																	this.label1,
																																	this.lblDisplay});
			this.Name = "LabelButtonTextBox";
			this.Text = "LabelButtonTextBox";
			this.ResumeLayout(false);

		}
		#endregion

		private int intNum = 0;//필드
		private void lblDisplay_Click(object sender, System.EventArgs e)
		{
			intNum++;//1증가
			if(intNum % 2 == 0)
			{
				this.lblDisplay.BackColor = Color.Beige;
			}
			else
			{
				this.lblDisplay.BackColor = Color.Yellow;
			}
		}

		private void txtInput_MouseHover(object sender, System.EventArgs e)
		{
			this.txtInput.BackColor = Color.White;
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			string strMsg = 
				String.Format("{0}\n{1}\n{2}"
					, this.txtInput.Text
					, this.txtPassword.Text
					, this.txtMulti.Text);
			MessageBox.Show(strMsg);//출력
		}
	}
}
