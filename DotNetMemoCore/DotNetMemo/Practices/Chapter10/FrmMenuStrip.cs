using System;
using System.Windows.Forms;

namespace DotNetMemo.Practices.Chapter10
{
    public partial class FrmMenuStrip : Form
    {
        public FrmMenuStrip()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
