using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	public class FrmSaveFileDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button btnSave;
		#region +
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmSaveFileDialog()
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(8, 8);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(264, 128);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(288, 8);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(56, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "저장";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// FrmSaveFileDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(352, 157);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.richTextBox1);
			this.Name = "FrmSaveFileDialog";
			this.Text = "FrmSaveFileDialog";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void btnSave_Click(object sender, System.EventArgs e)
		{
			// SaveFileDialog 컨트롤의 주요 속성 지정
			this.saveFileDialog1.Filter = 
				"텍스트 파일(*.txt)|*.txt|모든 파일|*.*";
			this.saveFileDialog1.OverwritePrompt = true;
			// 저장 로직 구현
			if(this.saveFileDialog1.ShowDialog() ==
				DialogResult.OK)
			{
				string strFileName = 
					this.saveFileDialog1.FileName;
				// 스트림 클래스
				System.IO.StreamWriter objSw = 
					new System.IO.StreamWriter(
					strFileName, 
					false, // 추가 유무
					System.Text.Encoding.Default);
				// 저장
				objSw.Write(this.richTextBox1.Text);
				// 닫기
				objSw.Flush(); // 버퍼 비우기
				objSw.Close(); // 스트림 클래스 닫기
			}
		}
	}
}
