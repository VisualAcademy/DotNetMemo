using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinTabControl
{
    public partial class WinTabControl : Form
    {
        public WinTabControl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 시스템 환경 변수 출력
            txtMachineName.Text = System.Environment.MachineName;
            txtUserName.Text = System.Environment.UserName;
            txtOSVersion.Text = System.Environment.OSVersion.VersionString;
        }
    }
}
