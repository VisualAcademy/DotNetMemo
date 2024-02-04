using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.탭{
	public class FrmTabControl : System.Windows.Forms.Form{
		#region Controls
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tbpColor;
		private System.Windows.Forms.RadioButton radRed;
		private System.Windows.Forms.RadioButton radBlack;
		private System.Windows.Forms.RadioButton radGreen;
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.TabPage tbpSize;
		private System.Windows.Forms.TabPage tbpMessage;
		private System.Windows.Forms.TabPage tbpAbout;
		private System.Windows.Forms.RadioButton radSize12;
		private System.Windows.Forms.RadioButton radSize16;
		private System.Windows.Forms.RadioButton radSize20;
		private System.Windows.Forms.RadioButton radHello;
		private System.Windows.Forms.RadioButton radGoodbye;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabStyle;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkBold;
		private System.Windows.Forms.CheckBox chkItalic;
		#endregion

		#region Code Hiding
		private System.ComponentModel.Container components = null;

		public FrmTabControl()
		{
			InitializeComponent();
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

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tbpColor = new System.Windows.Forms.TabPage();
			this.radGreen = new System.Windows.Forms.RadioButton();
			this.radBlack = new System.Windows.Forms.RadioButton();
			this.radRed = new System.Windows.Forms.RadioButton();
			this.tbpSize = new System.Windows.Forms.TabPage();
			this.radSize20 = new System.Windows.Forms.RadioButton();
			this.radSize16 = new System.Windows.Forms.RadioButton();
			this.radSize12 = new System.Windows.Forms.RadioButton();
			this.tbpMessage = new System.Windows.Forms.TabPage();
			this.radGoodbye = new System.Windows.Forms.RadioButton();
			this.radHello = new System.Windows.Forms.RadioButton();
			this.tabStyle = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkItalic = new System.Windows.Forms.CheckBox();
			this.chkBold = new System.Windows.Forms.CheckBox();
			this.tbpAbout = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tbpColor.SuspendLayout();
			this.tbpSize.SuspendLayout();
			this.tbpMessage.SuspendLayout();
			this.tabStyle.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tbpAbout.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tbpColor);
			this.tabControl1.Controls.Add(this.tbpSize);
			this.tabControl1.Controls.Add(this.tbpMessage);
			this.tabControl1.Controls.Add(this.tabStyle);
			this.tabControl1.Controls.Add(this.tbpAbout);
			this.tabControl1.Location = new System.Drawing.Point(16, 16);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.ShowToolTips = true;
			this.tabControl1.Size = new System.Drawing.Size(264, 168);
			this.tabControl1.TabIndex = 0;
			// 
			// tbpColor
			// 
			this.tbpColor.Controls.Add(this.radGreen);
			this.tbpColor.Controls.Add(this.radBlack);
			this.tbpColor.Controls.Add(this.radRed);
			this.tbpColor.Location = new System.Drawing.Point(4, 21);
			this.tbpColor.Name = "tbpColor";
			this.tbpColor.Size = new System.Drawing.Size(256, 143);
			this.tbpColor.TabIndex = 0;
			this.tbpColor.Text = "색상";
			// 
			// radGreen
			// 
			this.radGreen.Location = new System.Drawing.Point(72, 88);
			this.radGreen.Name = "radGreen";
			this.radGreen.TabIndex = 2;
			this.radGreen.Text = "Green";
			this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
			// 
			// radBlack
			// 
			this.radBlack.Location = new System.Drawing.Point(72, 56);
			this.radBlack.Name = "radBlack";
			this.radBlack.TabIndex = 1;
			this.radBlack.Text = "Black";
			this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
			// 
			// radRed
			// 
			this.radRed.Location = new System.Drawing.Point(72, 24);
			this.radRed.Name = "radRed";
			this.radRed.TabIndex = 0;
			this.radRed.Text = "Red";
			this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
			// 
			// tbpSize
			// 
			this.tbpSize.Controls.Add(this.radSize20);
			this.tbpSize.Controls.Add(this.radSize16);
			this.tbpSize.Controls.Add(this.radSize12);
			this.tbpSize.Location = new System.Drawing.Point(4, 21);
			this.tbpSize.Name = "tbpSize";
			this.tbpSize.Size = new System.Drawing.Size(256, 143);
			this.tbpSize.TabIndex = 1;
			this.tbpSize.Text = "크기";
			// 
			// radSize20
			// 
			this.radSize20.Location = new System.Drawing.Point(72, 88);
			this.radSize20.Name = "radSize20";
			this.radSize20.TabIndex = 2;
			this.radSize20.Text = "20포인트";
			this.radSize20.CheckedChanged += new System.EventHandler(this.radSize20_CheckedChanged);
			// 
			// radSize16
			// 
			this.radSize16.Location = new System.Drawing.Point(72, 56);
			this.radSize16.Name = "radSize16";
			this.radSize16.TabIndex = 1;
			this.radSize16.Text = "16포인트";
			this.radSize16.CheckedChanged += new System.EventHandler(this.radSize16_CheckedChanged);
			// 
			// radSize12
			// 
			this.radSize12.Location = new System.Drawing.Point(72, 24);
			this.radSize12.Name = "radSize12";
			this.radSize12.TabIndex = 0;
			this.radSize12.Text = "12포인트";
			this.radSize12.CheckedChanged += new System.EventHandler(this.radSize12_CheckedChanged);
			// 
			// tbpMessage
			// 
			this.tbpMessage.Controls.Add(this.radGoodbye);
			this.tbpMessage.Controls.Add(this.radHello);
			this.tbpMessage.Location = new System.Drawing.Point(4, 21);
			this.tbpMessage.Name = "tbpMessage";
			this.tbpMessage.Size = new System.Drawing.Size(256, 143);
			this.tbpMessage.TabIndex = 2;
			this.tbpMessage.Text = "텍스트";
			// 
			// radGoodbye
			// 
			this.radGoodbye.Location = new System.Drawing.Point(72, 72);
			this.radGoodbye.Name = "radGoodbye";
			this.radGoodbye.TabIndex = 1;
			this.radGoodbye.Text = "잘가세요.";
			this.radGoodbye.CheckedChanged += new System.EventHandler(this.radGoodbye_CheckedChanged);
			// 
			// radHello
			// 
			this.radHello.Location = new System.Drawing.Point(72, 32);
			this.radHello.Name = "radHello";
			this.radHello.TabIndex = 0;
			this.radHello.Text = "안녕하세요.";
			this.radHello.CheckedChanged += new System.EventHandler(this.radHello_CheckedChanged);
			// 
			// tabStyle
			// 
			this.tabStyle.Controls.Add(this.groupBox1);
			this.tabStyle.Location = new System.Drawing.Point(4, 21);
			this.tabStyle.Name = "tabStyle";
			this.tabStyle.Size = new System.Drawing.Size(256, 143);
			this.tabStyle.TabIndex = 4;
			this.tabStyle.Text = "스타일";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkItalic);
			this.groupBox1.Controls.Add(this.chkBold);
			this.groupBox1.Location = new System.Drawing.Point(32, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 88);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "스타일 설정";
			// 
			// chkItalic
			// 
			this.chkItalic.Location = new System.Drawing.Point(48, 56);
			this.chkItalic.Name = "chkItalic";
			this.chkItalic.TabIndex = 1;
			this.chkItalic.Text = "이탤릭";
			this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
			// 
			// chkBold
			// 
			this.chkBold.Location = new System.Drawing.Point(48, 24);
			this.chkBold.Name = "chkBold";
			this.chkBold.TabIndex = 0;
			this.chkBold.Text = "굵게";
			this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
			// 
			// tbpAbout
			// 
			this.tbpAbout.Controls.Add(this.label1);
			this.tbpAbout.Location = new System.Drawing.Point(4, 21);
			this.tbpAbout.Name = "tbpAbout";
			this.tbpAbout.Size = new System.Drawing.Size(256, 143);
			this.tbpAbout.TabIndex = 3;
			this.tbpAbout.Text = "기타";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(56, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 56);
			this.label1.TabIndex = 0;
			this.label1.Text = "탭컨트롤은 일정한 공간을 나누어서 관리하고자할 때 사용되는 컨트롤이다.";
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 190);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(296, 96);
			this.lblDisplay.TabIndex = 3;
			// 
			// FrmTabControl
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(296, 286);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.lblDisplay);
			this.Name = "FrmTabControl";
			this.Text = "탭 컨트롤";
			this.Load += new System.EventHandler(this.FrmTabControl_Load);
			this.tabControl1.ResumeLayout(false);
			this.tbpColor.ResumeLayout(false);
			this.tbpSize.ResumeLayout(false);
			this.tbpMessage.ResumeLayout(false);
			this.tabStyle.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tbpAbout.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		#endregion

		#region Event Handlers
		private void radRed_CheckedChanged(object sender, System.EventArgs e){
			this.lblDisplay.ForeColor = Color.Red;
		}

		private void radBlack_CheckedChanged(object sender, System.EventArgs e){
			this.lblDisplay.ForeColor = Color.Black;
		}

		private void radGreen_CheckedChanged(object sender, System.EventArgs e){
			this.lblDisplay.ForeColor = Color.Green;
		}

		private void radSize12_CheckedChanged(object sender, System.EventArgs e){
			this.lblDisplay.Font = new Font(lblDisplay.Font.Name, 12);
		}

		private void radSize16_CheckedChanged(object sender, System.EventArgs e){
			this.lblDisplay.Font = new Font(lblDisplay.Font.Name, 16);
		}

		private void radSize20_CheckedChanged(object sender, System.EventArgs e){
			this.lblDisplay.Font = new Font(lblDisplay.Font.Name, 20);
		}

		private void radHello_CheckedChanged(object sender, System.EventArgs e){
			this.lblDisplay.Text = "안녕하세요.";
		}
		private void radGoodbye_CheckedChanged(object sender, System.EventArgs e){
			this.lblDisplay.Text = "잘가세요.";
		}
		private void FrmTabControl_Load(object sender, System.EventArgs e){
			this.lblDisplay.Text = "위 탭을 클릭해서 글씨를 변경해 보세요.";
		}
		private void chkBold_CheckedChanged(object sender, System.EventArgs e){
			this.lblDisplay.Font = new Font(lblDisplay.Font.Name
				, lblDisplay.Font.Size
				, lblDisplay.Font.Style ^ FontStyle.Bold);
		}
		private void chkItalic_CheckedChanged(object sender, System.EventArgs e){
			this.lblDisplay.Font = new Font(lblDisplay.Font.Name
				, lblDisplay.Font.Size
				, lblDisplay.Font.Style ^ FontStyle.Italic);
		}
		#endregion
	}
}
