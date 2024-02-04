using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetMemo.Practices.Chapter04
{
    public partial class FrmDialogs : Form
    {
        public FrmDialogs()
        {
            InitializeComponent();
        }

        private void FrmDialogs_Load(object sender, EventArgs e)
        {

        }

        private void FrmDialogs_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = 
                MessageBox.Show("정말로 닫으시겠습니까?", "폼 닫기", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // 이벤트 취소
            }
        }
    }
}
