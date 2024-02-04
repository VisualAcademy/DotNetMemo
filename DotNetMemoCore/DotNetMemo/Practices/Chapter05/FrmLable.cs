using System.Drawing;

namespace CSharp_Windows.Controls
{
    /// <summary>
    /// FrmLable�� ���� ��� �����Դϴ�.
    /// </summary>
    public class FrmLable : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label lblFirstLabel;
        private System.Windows.Forms.Label lblSecondLable;
        /// <summary>
        /// �ʼ� �����̳� �����Դϴ�.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FrmLable()
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
            this.lblFirstLabel.Text = "�ȳ��ϼ���.";
            this.lblFirstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondLable
            // 
            this.lblSecondLable.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(192)));
            this.lblSecondLable.Location = new System.Drawing.Point(64, 72);
            this.lblSecondLable.Name = "lblSecondLable";
            this.lblSecondLable.Size = new System.Drawing.Size(160, 32);
            this.lblSecondLable.TabIndex = 1;
            this.lblSecondLable.Text = "�ݰ����ϴ�.";
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
            this.Text = "���̺� ��Ʈ�� : ���� �ؽ�Ʈ ǥ��";
            this.Load += new System.EventHandler(this.FrmLable_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void FrmLable_Load(object sender, System.EventArgs e)
        {
            this.lblFirstLabel.Text =
                "���� �ε�Ǿ����ϴ�.";
            this.lblFirstLabel.BackColor =
                Color.Red;
        }

        private bool blnFalg = true;
        private void lblSecondLable_Click(object sender, System.EventArgs e)
        {
            #region +
            //			if(lblSecondLable.Text == 
            //				"�ݰ����ϴ�.")
            //			{
            //				this.lblSecondLable.Text = 
            //					"�� ������.";
            //			}
            //			else
            //			{
            //				this.lblSecondLable.Text = 
            //					"�ݰ����ϴ�.";
            //			}
            #endregion
            if (blnFalg)
            {
                this.lblSecondLable.Text =
                    "�ݰ����ϴ�.";
                blnFalg = false;
            }
            else
            {
                this.lblSecondLable.Text =
                    "�� ������.";
                blnFalg = true;
            }
        }
    }
}
