using System;
using System.Windows.Forms;

namespace MyWinForms.Class
{
    public partial class FrmDialogResultChild : Form
    {
        public FrmDialogResultChild()
        {
            InitializeComponent();
        }

        // 속성
        public string SendValue { get; set; }

        private void FrmDialogResultChild_Load(object sender, EventArgs e)
        {
            // 폼 로드시 SendValue 속성에 담긴 값 저장
            this.txtChild.Text = SendValue; 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FrmDialogResult fdr = (FrmDialogResult)Owner;
            fdr.Value = txtReturn.Text; // 텍스트 전송
            this.Close(); // 현재 폼 닫기
        }
    }
}
