using System;
using System.Windows.Forms;

namespace DotNetMemo.Practices.Chapter02
{
    public partial class FrmHelloWorld : Form
    {
        public FrmHelloWorld()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "안녕하세요.";
        }
    }
}
