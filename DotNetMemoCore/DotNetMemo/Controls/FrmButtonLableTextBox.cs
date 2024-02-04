using System;
using System.Windows.Forms;

namespace MyWinForms.Controls
{
    public partial class FrmButtonLableTextBox : Form
    {
        public FrmButtonLableTextBox()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int kor = Convert.ToInt32(txtKor.Text);
            int eng = Int32.Parse(txtEng.Text);

            int tot = kor + eng;

            // mbox
            MessageBox.Show(String.Format("{0} + {1} = {2}", kor, eng, tot));

            btnCancel_Click(null, null); // 재 호출
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtKor.Text = "";
            this.txtEng.Text = String.Empty;
            txtKor.Focus(); 
        }

        private void txtKor_KeyDown(object sender, KeyEventArgs e)
        {
            // 두번째 매개변수 e.KeyCode로 키보드값을 반환
            if (e.KeyCode == Keys.Enter)
            {
                this.txtEng.Focus(); // 포커스 부여
            }
        }

        private void txtEng_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnOK_Click(null, null); // 확인 버튼 클릭
            }
        }
    }
}
