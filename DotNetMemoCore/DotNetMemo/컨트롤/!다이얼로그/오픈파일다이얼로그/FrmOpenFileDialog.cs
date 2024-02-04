using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;//

namespace CSharp_Windows.오픈파일다이얼로그
{
	public class FrmOpenFileDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.TextBox textBox1;
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

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnOpen = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(232, 24);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.TabIndex = 1;
			this.btnOpen.Text = "파일 열기";
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(224, 112);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			// 
			// FrmOpenFileDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(320, 69);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnOpen);
			this.Name = "FrmOpenFileDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmOpenFileDialog";
			this.ResumeLayout(false);

		}
		#endregion
#endregion 
		private void btnOpen_Click(object sender, System.EventArgs e)
		{
			string strFileName = 
				@"C:\CSharp_Windows\CSharp_Windows\오픈파일다이얼로그\Hello.txt";		

			// 열기 대화 상자 사용자 정의
			this.openFileDialog1.Filter = 
				"Text files (*.txt)|*.txt|All files (*.*)|*.*";
			this.openFileDialog1.FilterIndex = 1;
			this.openFileDialog1.InitialDirectory = @"C:\CSharp_Windows\";
			this.openFileDialog1.Title = "텍스트 파일 열기";

			// 확인 버튼을 클릭한다면,
			if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				strFileName = this.openFileDialog1.FileName;
				StreamReader objSr = new StreamReader(strFileName
					, System.Text.Encoding.Default);//인코딩 방식 지정
				this.textBox1.Text = objSr.ReadToEnd();
				objSr.Close();
			}
		}
	}
}
