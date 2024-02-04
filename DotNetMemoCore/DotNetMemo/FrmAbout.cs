using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyWinForms
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // 현재 폼 닫기
            this.Close(); 
        }

        private void lnkAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "http://www.dotnetkorea.com/";
            System.Diagnostics.Process.Start(url); // 위 경로 띄우기
            Process.Start("notepad.exe"); // 실행 창에서 여는 명령어
            //Process.Start("mspaint"); // 그림판
            //Process.Start("inetmgr"); // IIS 웹 서버
        }
    }
}
