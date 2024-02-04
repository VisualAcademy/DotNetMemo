using System;
using System.Windows.Forms;

namespace MyWinForms.Controls
{
    public partial class FrmCheckBoxRadioButton : Form
    {
        public FrmCheckBoxRadioButton()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string msg = "";
            // 관심사항
            if (this.chkSeeSharp.Checked)               //[1] 체크되었다면
            {
                msg += this.chkSeeSharp.Text + "\r\n"; 
            }
            if (this.chkAspNet.Checked == true)         //[2] 체크 true면
            {
                msg += this.chkAspNet.Text + "\r\n"; 
            }
            if (!chkSilverlight.Checked)                //[3] 체크가 되지 않았다면,
            {
                // Empty
            }
            else
            {
                msg += this.chkSilverlight.Text + "\r\n";
            }
            // 성별
            if (this.rdoMan.Checked)
            {
                msg += String.Format("{0}{1}{0}", "\r\n", rdoMan.Text); 
            }
            else
            {
                msg += String.Format("{0}{1}{0}", "\r\n", optWomen.Text); 
            }
            this.txtResult.Text = msg; 
        }

        private void FrmCheckBoxRadioButton_Load(object sender, EventArgs e)
        {
            // 폼 로드시 동적으로 라디오버튼 체크
            this.rdoMan.Checked = true; 
        }
    }
}
