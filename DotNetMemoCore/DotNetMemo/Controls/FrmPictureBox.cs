using System.Drawing;

namespace CSharp_Windows.Controls
{
    /// <summary>
    /// FrmPictureBox에 대한 요약 설명입니다.
    /// </summary>
    public class FrmPictureBox : System.Windows.Forms.Form
    {
        private System.Windows.Forms.PictureBox pictureBox1;
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FrmPictureBox()
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmPictureBox));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmPictureBox
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(256, 165);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmPictureBox";
            this.Text = "픽처박스 : 윈 폼에 이미지 출력";
            this.ResumeLayout(false);

        }
        #endregion

        private int imageNumber = -1;
        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            imageNumber =
                (imageNumber + 1) % 3 + 1;
            this.pictureBox1.Image =
                Image.FromFile(
                "image" + imageNumber + ".bmp");
        }
    }
}
