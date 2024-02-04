using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyWinForms.Sample
{
    public partial class FrmExplorer : Form
    {
        public FrmExplorer()
        {
            InitializeComponent();
        }

        // 뒤로, 앞으로, 이동, 멈춤을 클릭시 모두 현재 이벤트핸들러로
        private void cmdCommon(object sender, EventArgs e)
        {
            ToolStripButton btn1 = (ToolStripButton)sender; //[1]
            if (btn1 == btnBack)
            {
                webBrowser1.GoBack(); // 뒤로
            }
            ToolStripButton btn2 = sender as ToolStripButton; //[2]
            if (btn2 == btnForward)
            {
                webBrowser1.GoForward(); // 앞으로
            }
            else if (btn2 == btnGo)
            {
                webBrowser1.Navigate(txtUrl.Text); // URL받아서 이동
            }
            else
            {
                webBrowser1.Stop(); // 멈춤
            }
        }
    }
}
