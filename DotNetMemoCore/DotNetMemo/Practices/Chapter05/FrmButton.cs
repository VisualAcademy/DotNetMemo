using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
    /// <summary>
    /// FrmButton에 대한 요약 설명입니다.
    /// </summary>
    public class FrmButton : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Button cmdBye;
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FrmButton()
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
            this.btnHi = new System.Windows.Forms.Button();
            this.cmdBye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHi
            // 
            this.btnHi.Location = new System.Drawing.Point(96, 24);
            this.btnHi.Name = "btnHi";
            this.btnHi.TabIndex = 0;
            this.btnHi.Text = "안녕";
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // cmdBye
            // 
            this.cmdBye.Location = new System.Drawing.Point(96, 80);
            this.cmdBye.Name = "cmdBye";
            this.cmdBye.TabIndex = 1;
            this.cmdBye.Text = "잘가";
            this.cmdBye.Click += new System.EventHandler(this.cmdBye_Click);
            // 
            // FrmButton
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(280, 149);
            this.Controls.Add(this.cmdBye);
            this.Controls.Add(this.btnHi);
            this.Name = "FrmButton";
            this.Text = "버튼 컨트롤 : 명령어 실행";
            this.ResumeLayout(false);

        }
        #endregion

        private void btnHi_Click(object sender, System.EventArgs e)
        {
            //MessageBox.Show("안녕하세요.", "안녕");
            MessagePrint("안녕하세요.", "안녕");
        }

        private void cmdBye_Click(object sender, System.EventArgs e)
        {
            //MessageBox.Show("또 만나요.", "잘가");
            MessagePrint("또 만나요.", "잘가");
        }

        // 공통 메서드
        private void MessagePrint(string s1, string s2)
        {
            MessageBox.Show(s1, s2);
        }
    }
}
