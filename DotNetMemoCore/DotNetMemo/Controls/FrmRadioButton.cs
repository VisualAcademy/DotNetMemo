using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmRadioButton에 대한 요약 설명입니다.
	/// </summary>
	public class FrmRadioButton : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdoMan;
		private System.Windows.Forms.RadioButton rdoWomen;
		private System.Windows.Forms.Button btnOK;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmRadioButton()
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
			this.rdoMan = new System.Windows.Forms.RadioButton();
			this.rdoWomen = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rdoMan
			// 
			this.rdoMan.Checked = true;
			this.rdoMan.Location = new System.Drawing.Point(72, 48);
			this.rdoMan.Name = "rdoMan";
			this.rdoMan.TabIndex = 0;
			this.rdoMan.TabStop = true;
			this.rdoMan.Text = "남자";
			// 
			// rdoWomen
			// 
			this.rdoWomen.Location = new System.Drawing.Point(72, 80);
			this.rdoWomen.Name = "rdoWomen";
			this.rdoWomen.TabIndex = 1;
			this.rdoWomen.Text = "여자";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "당신의 성별은?";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(152, 128);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "확인";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// FrmRadioButton
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(232, 157);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rdoWomen);
			this.Controls.Add(this.rdoMan);
			this.Name = "FrmRadioButton";
			this.Text = "라디오 버튼 : 단일 선택";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			string strMsg = String.Empty;
			strMsg += String.Format(
				"당신의 성별은 {0}입니다.",
					(rdoMan.Checked) 
					?  
					this.rdoMan.Text
					: 
					this.rdoWomen.Text
				);
			MessageBox.Show(strMsg);
		}
	}
}
