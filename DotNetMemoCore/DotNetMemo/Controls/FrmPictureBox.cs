using System.Drawing;

namespace CSharp_Windows.Controls
{
    /// <summary>
    /// FrmPictureBox�� ���� ��� �����Դϴ�.
    /// </summary>
    public class FrmPictureBox : System.Windows.Forms.Form
    {
        private System.Windows.Forms.PictureBox pictureBox1;
        /// <summary>
        /// �ʼ� �����̳� �����Դϴ�.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FrmPictureBox()
        {
            //
            // Windows Form �����̳� ������ �ʿ��մϴ�.
            //
            InitializeComponent();

            //
            // TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
            //
        }

        /// <summary>
        /// ��� ���� ��� ���ҽ��� �����մϴ�.
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

        #region Windows Form �����̳ʿ��� ������ �ڵ�
        /// <summary>
        /// �����̳� ������ �ʿ��� �޼����Դϴ�.
        /// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
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
            this.Text = "��ó�ڽ� : �� ���� �̹��� ���";
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
