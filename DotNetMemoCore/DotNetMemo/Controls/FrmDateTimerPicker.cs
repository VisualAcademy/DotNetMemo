using System;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
    /// <summary>
    /// FrmDateTimerPicker에 대한 요약 설명입니다.
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
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FrmDateTimerPicker()
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
            this.label1.Text = "현재 일시:";
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
            this.label2.Text = "배송 예정일:";
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
            this.btnOK.Text = "확인";
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
            // 현재 일시
            this.lblDisplay.Text =
                DateTime.Now.ToString();
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            string strMsg = String.Format(
                "배송 예정일은 {0}입니다."
                , this.dateTimePicker1.Value.ToShortDateString());
            MessageBox.Show(strMsg, "배송 예정일",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void dateTimePickerFormat_CheckedChanged(object sender, System.EventArgs e)
        {
            if (sender == this.customButton)
            {
                // 사용자 정의 모양
                this.dateTimePicker1.Format =
                    DateTimePickerFormat.Custom;
                // 형식 지정 : 06년 02월 03일(금)
                this.dateTimePicker1.CustomFormat = "yy년 MM월 dd일(ddd)";
            }
        }
    }
}
