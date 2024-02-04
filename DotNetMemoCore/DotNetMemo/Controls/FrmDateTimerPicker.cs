using System;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
    /// <summary>
    /// FrmDateTimerPicker�� ���� ��� �����Դϴ�.
    /// </summary>
    public class FrmDateTimerPicker : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton customButton;
        private System.Windows.Forms.RadioButton timeButton;
        private System.Windows.Forms.RadioButton longButton;
        private System.Windows.Forms.RadioButton shortButton;
        /// <summary>
        /// �ʼ� �����̳� �����Դϴ�.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FrmDateTimerPicker()
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customButton = new System.Windows.Forms.RadioButton();
            this.timeButton = new System.Windows.Forms.RadioButton();
            this.longButton = new System.Windows.Forms.RadioButton();
            this.shortButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.TabIndex = 0;
            this.label1.Text = "���� �Ͻ�:";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(224)), ((System.Byte)(192)));
            this.lblDisplay.Location = new System.Drawing.Point(104, 16);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(160, 23);
            this.lblDisplay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.TabIndex = 2;
            this.label2.Text = "��� ������:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(120, 96);
            this.btnOK.Name = "btnOK";
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Ȯ��";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customButton);
            this.groupBox1.Controls.Add(this.timeButton);
            this.groupBox1.Controls.Add(this.longButton);
            this.groupBox1.Controls.Add(this.shortButton);
            this.groupBox1.Location = new System.Drawing.Point(56, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 120);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DateTimePickerFormat";
            // 
            // customButton
            // 
            this.customButton.Location = new System.Drawing.Point(40, 88);
            this.customButton.Name = "customButton";
            this.customButton.TabIndex = 3;
            this.customButton.Text = "Custom";
            this.customButton.CheckedChanged += new System.EventHandler(this.dateTimePickerFormat_CheckedChanged);
            // 
            // timeButton
            // 
            this.timeButton.Location = new System.Drawing.Point(40, 64);
            this.timeButton.Name = "timeButton";
            this.timeButton.TabIndex = 2;
            this.timeButton.Text = "Time";
            this.timeButton.CheckedChanged += new System.EventHandler(this.dateTimePickerFormat_CheckedChanged);
            // 
            // longButton
            // 
            this.longButton.Location = new System.Drawing.Point(40, 16);
            this.longButton.Name = "longButton";
            this.longButton.TabIndex = 1;
            this.longButton.Text = "Long";
            this.longButton.CheckedChanged += new System.EventHandler(this.dateTimePickerFormat_CheckedChanged);
            // 
            // shortButton
            // 
            this.shortButton.Location = new System.Drawing.Point(40, 40);
            this.shortButton.Name = "shortButton";
            this.shortButton.TabIndex = 0;
            this.shortButton.Text = "Short";
            this.shortButton.CheckedChanged += new System.EventHandler(this.dateTimePickerFormat_CheckedChanged);
            // 
            // FrmDateTimerPicker
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(304, 293);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.label1);
            this.Name = "FrmDateTimerPicker";
            this.Text = "FrmDateTimerPicker";
            this.Load += new System.EventHandler(this.FrmDateTimerPicker_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void FrmDateTimerPicker_Load(object sender, System.EventArgs e)
        {
            // ���� �Ͻ�
            this.lblDisplay.Text =
                DateTime.Now.ToString();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            string strMsg = String.Format(
                "��� �������� {0}�Դϴ�."
                , this.dateTimePicker1.Value.ToShortDateString());
            MessageBox.Show(strMsg, "��� ������",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void dateTimePickerFormat_CheckedChanged(object sender, System.EventArgs e)
        {
            if (sender == this.customButton)
            {
                // ����� ���� ���
                this.dateTimePicker1.Format =
                    DateTimePickerFormat.Custom;
                // ���� ���� : 06�� 02�� 03��(��)
                this.dateTimePicker1.CustomFormat = "yy�� MM�� dd��(ddd)";
            }
        }
    }
}
