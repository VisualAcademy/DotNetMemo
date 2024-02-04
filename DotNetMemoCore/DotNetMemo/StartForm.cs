using System;
using System.Windows.Forms;

namespace DotNetMemo
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 프로그램 종료
            Application.Exit(); 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 새로운 폼 띄우기
            (new AboutForm()).Show(); 
        }

        private void mainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new MyWinForms.MainForm()).Show(); 
        }

        private void frmMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //(new CSharp_Windows.FrmMain()).Show();
        }

        private void 메모장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new DotNetNote.DotNetNote()).Show();
        }

        private void 계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new DotNetCalc.DotNetCalc()).Show(); 
        }
    }
}
