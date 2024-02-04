using System;
using System.Windows.Forms;

namespace MyWinForms.Class
{
    public partial class FrmDialogResult : Form
    {
        public FrmDialogResult()
        {
            InitializeComponent();
        }

        // 속성
        public string Value { get; set; } 

        private void btnSend_Click(object sender, EventArgs e)
        {
            // 자식 폼으로 데이터 전송
            MyWinForms.Class.FrmDialogResultChild c = new FrmDialogResultChild();
            c.Owner = this; // 자식 폼의 주인 FrmDialogResult 
            c.SendValue = txtParent.Text; // 속성으로 값을 전달
            //DialogResult dr = c.ShowDialog(); // 폼 로드되면서 전송된 텍스트가 자식 폼에 출력
            if (c.ShowDialog() == DialogResult.OK)
            {
                this.txtResult.Text = Value; 
            }
        }
    }
}
