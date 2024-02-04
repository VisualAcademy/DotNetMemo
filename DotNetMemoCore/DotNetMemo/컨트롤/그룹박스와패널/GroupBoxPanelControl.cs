using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.그룹박스와패널
{
	public class GroupBoxPanelControl : System.Windows.Forms.Form
	{
		#region Controls
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Button cmdHi;
		private System.Windows.Forms.Button cmdBye;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button btnRight;
		private System.ComponentModel.Container components = null;
		#endregion

		public GroupBoxPanelControl()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}


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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmdHi = new System.Windows.Forms.Button();
			this.cmdBye = new System.Windows.Forms.Button();
			this.btnLeft = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.cmdBye,
																																						this.cmdHi});
			this.groupBox1.Location = new System.Drawing.Point(104, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox1.Size = new System.Drawing.Size(224, 144);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "버튼을 누르세요.";
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																				 this.btnRight,
																																				 this.btnLeft});
			this.panel1.Location = new System.Drawing.Point(104, 224);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(224, 136);
			this.panel1.TabIndex = 0;
			// 
			// cmdHi
			// 
			this.cmdHi.Location = new System.Drawing.Point(24, 64);
			this.cmdHi.Name = "cmdHi";
			this.cmdHi.TabIndex = 0;
			this.cmdHi.Text = "안녕";
			this.cmdHi.Click += new System.EventHandler(this.cmdHi_Click);
			// 
			// cmdBye
			// 
			this.cmdBye.Location = new System.Drawing.Point(128, 56);
			this.cmdBye.Name = "cmdBye";
			this.cmdBye.Size = new System.Drawing.Size(88, 40);
			this.cmdBye.TabIndex = 1;
			this.cmdBye.Text = "잘가";
			this.cmdBye.Click += new System.EventHandler(this.cmdBye_Click);
			// 
			// btnLeft
			// 
			this.btnLeft.Location = new System.Drawing.Point(16, 56);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.TabIndex = 0;
			this.btnLeft.Text = "왼쪽";
			this.btnLeft.Click += new System.EventHandler(this.Panel1_Click);
			// 
			// btnRight
			// 
			this.btnRight.Location = new System.Drawing.Point(200, 56);
			this.btnRight.Name = "btnRight";
			this.btnRight.TabIndex = 1;
			this.btnRight.Text = "오른쪽";
			this.btnRight.Click += new System.EventHandler(this.Panel1_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Location = new System.Drawing.Point(112, 176);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(216, 23);
			this.lblDisplay.TabIndex = 2;
			// 
			// GroupBoxPanelControl
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(424, 397);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.groupBox1,
																																	this.panel1,
																																	this.lblDisplay});
			this.Name = "GroupBoxPanelControl";
			this.Text = "GroupBoxPanelControl";
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void cmdHi_Click(object sender, System.EventArgs e)
		{
			this.lblDisplay.Text = 
				this.cmdHi.Text + "이 선택됨";
		}

		private void cmdBye_Click(object sender, System.EventArgs e)
		{
			this.lblDisplay.Text = 
				this.cmdBye.Text + "이 선택됨";
		}

		private void Panel1_Click(
			object sender, System.EventArgs e){
			if(sender == btnLeft){
				this.lblDisplay.Text = "왼쪽 버튼 클릭";
			}
			else{
				this.lblDisplay.Text = "오른쪽 버튼 클릭";
			}
		}
	}
}
