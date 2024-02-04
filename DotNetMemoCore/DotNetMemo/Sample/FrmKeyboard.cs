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
    public partial class FrmKeyboard : Form
    {
        public FrmKeyboard()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 엔터키를 타이핑했을 때 다음 텍스트박스로 이동
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Focus(); 
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            // 엔터키 입력시 확인 버튼으로 포커스
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus(); 
            }
        }
    }
}
