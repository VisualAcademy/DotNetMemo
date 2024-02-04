using System.Drawing;

namespace CSharp_Windows.Controls
{
    /// <summary>
    /// FrmLable에 대한 요약 설명입니다.
    /// </summary>
    public class FrmLable : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label lblFirstLabel;
        private System.Windows.Forms.Label lblSecondLable;
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FrmLable()
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드
        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirstLabel = new System.Windows.Forms.Label();
            this.lblSecondLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstLabel
            // 
            this.lblFirstLabel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
            this.lblFirstLabel.Location = new System.Drawing.Point(64, 24);
            this.lblFirstLabel.Name = "lblFirstLabel";
            this.lblFirstLabel.Size = new System.Drawing.Size(160, 32);
            this.lblFirstLabel.TabIndex = 0;
            this.lblFirstLabel.Text = "안녕하세요.";
            this.lblFirstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondLable
            // 
            this.lblSecondLable.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
            this.lblSecondLable.Location = new System.Drawing.Point(64, 72);
            this.lblSecondLable.Name = "lblSecondLable";
            this.lblSecondLable.Size = new System.Drawing.Size(160, 32);
            this.lblSecondLable.TabIndex = 1;
            this.lblSecondLable.Text = "반갑습니다.";
            this.lblSecondLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSecondLable.Click += new System.EventHandler(this.lblSecondLable_Click);
            // 
            // FrmLable
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(280, 141);
            this.Controls.Add(this.lblSecondLable);
            this.Controls.Add(this.lblFirstLabel);
            this.Name = "FrmLable";
            this.Text = "레이블 컨트롤 : 폼에 텍스트 표시";
            this.Load += new System.EventHandler(this.FrmLable_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void FrmLable_Load(object sender, System.EventArgs e)
        {
            this.lblFirstLabel.Text =
                "폼이 로드되었습니다.";
            this.lblFirstLabel.BackColor =
                Color.Red;
        }

        private bool blnFalg = true;
        private void lblSecondLable_Click(object sender, System.EventArgs e)
        {
            #region +
            //			if(lblSecondLable.Text == 
            //				"반갑습니다.")
            //			{
            //				this.lblSecondLable.Text = 
            //					"또 만나요.";
            //			}
            //			else
            //			{
            //				this.lblSecondLable.Text = 
            //					"반갑습니다.";
            //			}
            #endregion
            if (blnFalg)
            {
                this.lblSecondLable.Text =
                    "반갑습니다.";
                blnFalg = false;
            }
            else
            {
                this.lblSecondLable.Text =
                    "또 만나요.";
                blnFalg = true;
            }
        }
    }
}
