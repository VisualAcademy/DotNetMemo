using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmListBox에 대한 요약 설명입니다.
	/// </summary>
	public class FrmListBox : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lstCountry;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Button btnUp;		//위로
		private System.Windows.Forms.Button btnDown;	//아래로
		private System.Windows.Forms.Button btnInput;	//입력
		private System.Windows.Forms.Button btnDelete;//선택삭제
		private System.Windows.Forms.Button btnClear;	//모두삭제
		private System.Windows.Forms.Button btnClose;	//닫기
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmListBox()
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
			this.label1 = new System.Windows.Forms.Label();
			this.lstCountry = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnInput = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(360, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "나라 이름을 입력하세요.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lstCountry
			// 
			this.lstCountry.ItemHeight = 12;
			this.lstCountry.Location = new System.Drawing.Point(16, 64);
			this.lstCountry.Name = "lstCountry";
			this.lstCountry.Size = new System.Drawing.Size(120, 88);
			this.lstCountry.TabIndex = 1;
			this.lstCountry.SelectedIndexChanged += new System.EventHandler(this.lstCountry_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(160, 32);
			this.label2.Name = "label2";
			this.label2.TabIndex = 2;
			this.label2.Text = "나라 이름:";
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(248, 32);
			this.txtInput.Name = "txtInput";
			this.txtInput.TabIndex = 3;
			this.txtInput.Text = "";
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(144, 72);
			this.btnUp.Name = "btnUp";
			this.btnUp.TabIndex = 4;
			this.btnUp.Text = "위로";
			this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(144, 112);
			this.btnDown.Name = "btnDown";
			this.btnDown.TabIndex = 5;
			this.btnDown.Text = "아래로";
			this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
			// 
			// btnInput
			// 
			this.btnInput.Location = new System.Drawing.Point(256, 64);
			this.btnInput.Name = "btnInput";
			this.btnInput.TabIndex = 6;
			this.btnInput.Text = "입력";
			this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(256, 96);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "선택 삭제";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(256, 128);
			this.btnClear.Name = "btnClear";
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "모두 삭제";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(256, 160);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 9;
			this.btnClose.Text = "종료";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 206);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(360, 23);
			this.lblDisplay.TabIndex = 10;
			this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FrmListBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(360, 229);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnInput);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lstCountry);
			this.Controls.Add(this.label1);
			this.Name = "FrmListBox";
			this.Text = "리스트박스 : 여러 항목 중 하나 선택";
			this.ResumeLayout(false);

		}
		#endregion

		// 리스트박스의 항목 선택시
		private void lstCountry_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		// 입력
		private void btnInput_Click(object sender, System.EventArgs e)
		{
			
		}

		// 선택삭제
		private void btnDelete_Click(object sender, System.EventArgs e)
		{
		
		}

		// 모두삭제
		private void btnClear_Click(object sender, System.EventArgs e)
		{
		
		}
		// 닫기
		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		// 위로(과제)
		private void btnUp_Click(object sender, System.EventArgs e)
		{
		
		}
		// 아래로(과제)
		private void btnDown_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
