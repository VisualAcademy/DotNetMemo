using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.윈도우폼
{
	/// <summary>
	/// WindowsForms에 대한 요약 설명입니다.
	/// </summary>
	public class WindowsForms : System.Windows.Forms.Form
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public WindowsForms()
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
			// 
			// WindowsForms
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.ClientSize = new System.Drawing.Size(392, 373);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "WindowsForms";
			this.Text = "이벤트 사용하기";
			this.Click += new System.EventHandler(this.WindowsForms_Click);
			this.Load += new System.EventHandler(this.WindowsForms_Load);
			this.MouseHover += new System.EventHandler(this.WindowsForms_MouseHover);
			this.MouseLeave += new System.EventHandler(this.WindowsForms_MouseLeave);

		}
		#endregion

		private void WindowsForms_Load(object sender, System.EventArgs e)
		{
			MessageBox.Show("윈도우 폼이 로드되었습니다.");
		}

		private void WindowsForms_Click(object sender, System.EventArgs e)
		{
			string strMsg = "윈도우 폼이 클릭되었습니다.";
			MessageBox.Show(strMsg);
		}

		private void WindowsForms_MouseHover(object sender, System.EventArgs e)
		{
			this.BackColor = Color.Red;
		}

		private void WindowsForms_MouseLeave(object sender, System.EventArgs e)
		{
			this.BackColor = Color.Aqua;
		}
	}
}
