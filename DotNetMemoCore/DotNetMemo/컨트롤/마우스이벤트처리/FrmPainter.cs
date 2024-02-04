using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.마우스이벤트처리
{
	/// <summary>
	/// FrmPainter에 대한 요약 설명입니다.
	/// </summary>
	public class FrmPainter : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDisplay;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmPainter()
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
			this.lblDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "마우스를 클릭해 보세요.";
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 250);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(292, 23);
			this.lblDisplay.TabIndex = 1;
			// 
			// FrmPainter
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.lblDisplay,
																																	this.label1});
			this.Name = "FrmPainter";
			this.Text = "마우스 이벤트 처리";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPainter_MouseDown);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmPainter_MouseUp);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPainter_MouseMove);
			this.ResumeLayout(false);

		}
		#endregion

		//[0] 필드
		private bool blnFlag = false;//
		//[1] 마우스 다운
		private void FrmPainter_MouseDown(
			object sender, 
			System.Windows.Forms.MouseEventArgs e){
			blnFlag = true;//그림 그리기 가능
			this.lblDisplay.Text = e.Button.ToString();
			this.lblDisplay.Text += "(" + e.X.ToString()
				+ ", " + e.Y.ToString() + ")";
		}
		//[2] 마우스 업
		private void FrmPainter_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e){
			blnFlag = false;//그림 그리기 취소
		}
		//[3] 마우스 움직일 때마다 그림 그리기 : GDI+
		private void FrmPainter_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e){
			if(blnFlag){ //마우스 다운 이벤트 발생시
				Graphics g = CreateGraphics();
				g.FillEllipse(
					new SolidBrush(Color.Red), e.X, e.Y, 5, 5);
			}
		}
	}
}
