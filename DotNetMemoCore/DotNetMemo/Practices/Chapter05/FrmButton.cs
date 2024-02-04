using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
    /// <summary>
    /// FrmButton�� ���� ��� �����Դϴ�.
    /// </summary>
    public class FrmButton : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Button cmdBye;
        /// <summary>
        /// �ʼ� �����̳� �����Դϴ�.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FrmButton()
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
            this.btnHi = new System.Windows.Forms.Button();
            this.cmdBye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHi
            // 
            this.btnHi.Location = new System.Drawing.Point(96, 24);
            this.btnHi.Name = "btnHi";
            this.btnHi.TabIndex = 0;
            this.btnHi.Text = "�ȳ�";
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // cmdBye
            // 
            this.cmdBye.Location = new System.Drawing.Point(96, 80);
            this.cmdBye.Name = "cmdBye";
            this.cmdBye.TabIndex = 1;
            this.cmdBye.Text = "�߰�";
            this.cmdBye.Click += new System.EventHandler(this.cmdBye_Click);
            // 
            // FrmButton
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(280, 149);
            this.Controls.Add(this.cmdBye);
            this.Controls.Add(this.btnHi);
            this.Name = "FrmButton";
            this.Text = "��ư ��Ʈ�� : ��ɾ� ����";
            this.ResumeLayout(false);

        }
        #endregion

        private void btnHi_Click(object sender, System.EventArgs e)
        {
            //MessageBox.Show("�ȳ��ϼ���.", "�ȳ�");
            MessagePrint("�ȳ��ϼ���.", "�ȳ�");
        }

        private void cmdBye_Click(object sender, System.EventArgs e)
        {
            //MessageBox.Show("�� ������.", "�߰�");
            MessagePrint("�� ������.", "�߰�");
        }

        // ���� �޼���
        private void MessagePrint(string s1, string s2)
        {
            MessageBox.Show(s1, s2);
        }
    }
}
