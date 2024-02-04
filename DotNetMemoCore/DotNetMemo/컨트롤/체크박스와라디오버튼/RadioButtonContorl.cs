using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.체크박스와라디오버튼
{
	/// <summary>
	/// RadioButtonContorl에 대한 요약 설명입니다.
	/// </summary>
	public class RadioButtonContorl : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdoWomen;
		private System.Windows.Forms.Button cmdOK;
		private System.Windows.Forms.RadioButton rdoMan;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RadioButtonContorl()
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
			this.rdoMan = new System.Windows.Forms.RadioButton();
			this.rdoWomen = new System.Windows.Forms.RadioButton();
			this.cmdOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(400, 48);
			this.label1.TabIndex = 0;
			this.label1.Text = "당신의 성별은?";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// rdoMan
			// 
			this.rdoMan.Location = new System.Drawing.Point(32, 56);
			this.rdoMan.Name = "rdoMan";
			this.rdoMan.Size = new System.Drawing.Size(160, 24);
			this.rdoMan.TabIndex = 1;
			this.rdoMan.Text = "남자";
			// 
			// rdoWomen
			// 
			this.rdoWomen.Location = new System.Drawing.Point(32, 104);
			this.rdoWomen.Name = "rdoWomen";
			this.rdoWomen.Size = new System.Drawing.Size(160, 24);
			this.rdoWomen.TabIndex = 2;
			this.rdoWomen.Text = "여자";
			// 
			// cmdOK
			// 
			this.cmdOK.Location = new System.Drawing.Point(240, 72);
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.TabIndex = 3;
			this.cmdOK.Text = "확인";
			this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
			// 
			// RadioButtonContorl
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(400, 285);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.cmdOK,
																																	this.rdoWomen,
																																	this.rdoMan,
																																	this.label1});
			this.Name = "RadioButtonContorl";
			this.Text = "라디오버튼 컨트롤";
			this.ResumeLayout(false);

		}
		#endregion

		//확인
		private void cmdOK_Click(object sender, System.EventArgs e)
		{
			string strMsg = "";
			if(this.rdoMan.Checked)
			{
				strMsg = this.rdoMan.Text;	
			}
			else
			{
				strMsg = this.rdoWomen.Text;
			}
			MessageBox.Show(strMsg);
		}
	}
}
