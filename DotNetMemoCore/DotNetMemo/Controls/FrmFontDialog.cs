using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyWinForms.Controls
{
    public partial class FrmFontDialog : Form
    {
        public FrmFontDialog()
        {
            InitializeComponent();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            // 폰트창을 열고,
            DialogResult dr =
                this.fdFont.ShowDialog();
            // 확인 버튼 누르면, 변경
            if (dr == DialogResult.OK)
	        {
                txtFont.Font = fdFont.Font; 
	        }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            // 색상창 열고,
            if (cdColor.ShowDialog() != DialogResult.Cancel)
            {
                txtFont.ForeColor = cdColor.Color; // 글꼴색 변경
            }
        }
    }
}
