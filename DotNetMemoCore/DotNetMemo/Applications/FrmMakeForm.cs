using System.Windows.Forms;

namespace CSharp_Windows.Applications
{
    /// <summary>
    /// FrmMakeForm�� ���� ��� �����Դϴ�.
    /// </summary>
    public class FrmMakeForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbPos;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.Button btnCreate;
        /// <summary>
        /// �ʼ� �����̳� �����Դϴ�.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FrmMakeForm()
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbPos = new System.Windows.Forms.ComboBox();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.TabIndex = 0;
            this.label1.Text = "�� �Ӽ�:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 56);
            this.label2.Name = "label2";
            this.label2.TabIndex = 1;
            this.label2.Text = "�� ��ġ:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 88);
            this.label3.Name = "label3";
            this.label3.TabIndex = 2;
            this.label3.Text = "�� ����:";
            // 
            // cmbType
            // 
            this.cmbType.Location = new System.Drawing.Point(160, 24);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 20);
            this.cmbType.TabIndex = 3;
            // 
            // cmbPos
            // 
            this.cmbPos.Location = new System.Drawing.Point(160, 52);
            this.cmbPos.Name = "cmbPos";
            this.cmbPos.Size = new System.Drawing.Size(121, 20);
            this.cmbPos.TabIndex = 4;
            // 
            // cmbMode
            // 
            this.cmbMode.Location = new System.Drawing.Point(160, 80);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(121, 20);
            this.cmbMode.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(112, 136);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "�� ����";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FrmMakeForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(304, 173);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmbMode);
            this.Controls.Add(this.cmbPos);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMakeForm";
            this.Text = "FrmMakeForm : �� ���� �׽�Ʈ";
            this.Load += new System.EventHandler(this.FrmMakeForm_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void FrmMakeForm_Load(object sender, System.EventArgs e)
        {
            // FormBorderStyle 
            this.cmbType.Items.Add("None");
            this.cmbType.Items.Add("FixedSingle");
            this.cmbType.Items.Add("Fixed3D");
            this.cmbType.Items.Add("FixedDialog");
            this.cmbType.Items.Add("Sizable");
            this.cmbType.Items.Add("FixedToolWindow");
            this.cmbType.Items.Add("SizableToolWindow");

            // FormStartPosition
            this.cmbPos.Items.Add("Manual");
            this.cmbPos.Items.Add("CenterScreen");
            this.cmbPos.Items.Add("WindowsDefaultLocation");
            this.cmbPos.Items.Add("WindowsDefaultBounds");
            this.cmbPos.Items.Add("CenterParent");

            // Modal Or Modaless
            this.cmbMode.Items.Add("���");
            this.cmbMode.Items.Add("��޸���");

            // �ʱⰪ ����
            this.cmbType.SelectedIndex = 0;
            this.cmbPos.SelectedIndex = 0;
            this.cmbMode.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            // FrmUserDefinedForm �ν��Ͻ� ����
            FrmUserDefinedForm udf = new
                FrmUserDefinedForm();
            // �ɼ� ����
            //[a] �׵θ� ����
            udf.FormBorderStyle =
                FormBorderStyle.Fixed3D;
            //[b] ������ġ ����
            udf.StartPosition =
                      FormStartPosition.CenterScreen;
            // ���� ���� ���� ��Ʈ�� ���� : �Ӽ�����
            udf.lblType.Text =
                this.cmbType.SelectedItem.ToString(); ;
            udf.LblPos =
                this.cmbPos.SelectedItem.ToString();
            udf.LblMode =
                this.cmbMode.SelectedItem.ToString();
            // �⺻������ �� ����
            if (this.cmbMode.SelectedIndex != 0)
                udf.Show();//��޸��� �� : �θ� ����
            else
                udf.ShowDialog(this);//��� ��
        }
    }
}
