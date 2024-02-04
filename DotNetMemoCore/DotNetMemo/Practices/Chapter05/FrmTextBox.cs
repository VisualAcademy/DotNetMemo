using System;
using System.Text;
using System.Windows.Forms;

namespace MyWinForms.Controls
{
    public partial class FrmTextBox : Form
    {
        public FrmTextBox()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("싱글라인 : " + txtSingleLine.Text);
            sb.AppendFormat("멀티라인 : {0}", txtMultiLine.Text);
            sb.Append(String.Format("패스워드 : {0}", txtPassword.Text));
            sb.Append("마스크 : " + txtMaskedText.Text);
            sb.AppendFormat("리치 : {0}", txtRichTextBox.Text);

            MessageBox.Show(sb.ToString());
        }
    }
}
