using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;//인코딩 방식 지정
using System.IO;//스트림 객체

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmOpenFileDialog에 대한 요약 설명입니다.
	/// </summary>
	public class FrmOpenFileDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		#region +
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmOpenFileDialog()
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
		#endregion 
		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(8, 8);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(216, 120);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(232, 16);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.TabIndex = 1;
			this.btnOpen.Text = "열기";
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// FrmOpenFileDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(312, 133);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.richTextBox1);
			this.Name = "FrmOpenFileDialog";
			this.Text = "FrmOpenFileDialog";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOpen_Click(object sender, System.EventArgs e)
		{
			// 열기 대화 상자
			this.openFileDialog1.Filter = 
				"텍스트 문서(*.txt)|*.txt|모든파일|*.*";
			this.openFileDialog1.FilterIndex = 1;
			this.openFileDialog1.InitialDirectory = 
				@"C:\CSharp_Windows\CSharp_Windows\";
			this.openFileDialog1.Title = "텍스트 파일 열기";
			// 열기 처리
			DialogResult objDr = 
				this.openFileDialog1.ShowDialog();
			if(objDr == DialogResult.OK)
			{
				string strFileName = 
					this.openFileDialog1.FileName;//파일전체경로
				// 스트림 클래스 인스턴스 생성
				StreamReader objSr = 
					new StreamReader(strFileName, 
						Encoding.Default);
				this.richTextBox1.Text = 
					objSr.ReadToEnd();//전체 출력
				objSr.Close();//스트림 객체 닫기
			}

		}
	}
}
