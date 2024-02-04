using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmFolderBrowserDialog에 대한 요약 설명입니다.
	/// </summary>
	public class FrmFolderBrowserDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button btnFind;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmFolderBrowserDialog()
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
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.btnFind = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(104, 40);
			this.btnFind.Name = "btnFind";
			this.btnFind.TabIndex = 0;
			this.btnFind.Text = "찾아보기...";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// FrmFolderBrowserDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(280, 109);
			this.Controls.Add(this.btnFind);
			this.Name = "FrmFolderBrowserDialog";
			this.Text = "FrmFolderBrowserDialog";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnFind_Click(object sender, System.EventArgs e)
		{
			
			if(this.folderBrowserDialog1.ShowDialog() ==
				DialogResult.OK)
			{
				// 선택된 경로 출력
				MessageBox.Show(
					this.folderBrowserDialog1.SelectedPath);
			}
		}
	}
}
