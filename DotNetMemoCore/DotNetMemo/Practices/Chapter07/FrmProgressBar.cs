using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
    /// <summary>
    /// FrmProgressBar에 대한 요약 설명입니다.
    /// </summary>
    public class FrmProgressBar : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button btnCommand;
		private System.Windows.Forms.Label lblDisplay;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmProgressBar()
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
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnCommand = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(48, 32);
			this.progressBar1.Maximum = 1000000;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(216, 23);
			this.progressBar1.TabIndex = 0;
			// 
			// btnCommand
			// 
			this.btnCommand.Location = new System.Drawing.Point(40, 80);
			this.btnCommand.Name = "btnCommand";
			this.btnCommand.Size = new System.Drawing.Size(224, 23);
			this.btnCommand.TabIndex = 1;
			this.btnCommand.Text = "오래 걸리는 작업 수행";
			this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 126);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(292, 23);
			this.lblDisplay.TabIndex = 2;
			// 
			// FrmProgressBar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 149);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.btnCommand);
			this.Controls.Add(this.progressBar1);
			this.Name = "FrmProgressBar";
			this.Text = "FrmProgressBar";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnCommand_Click(object sender, System.EventArgs e)
		{
			for (int i = 0;i < 10000;i++)
			{
				this.progressBar1.Increment(1);
				this.lblDisplay.Text = 
					this.progressBar1.Value.ToString();
			}
			MessageBox.Show("진행완료");
		}
	}
}
