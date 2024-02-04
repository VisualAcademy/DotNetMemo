using System;
using System.Windows.Forms;

namespace WinShareData
{
    public partial class WinShareData1 : Form
    {
        // Form2에서 공유해서 사용할 목적으로 public 속성 정의
        public string ShareData { get; set; }

        public WinShareData1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 단순 문자열만 전송하고자할 때
            WinShareData2 form2 = new WinShareData2(textBox1.Text);
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 속성 등을 사용하여 개체(폼) 값을 전송하고자할 때
            ShareData = textBox1.Text;

            WinShareData2 form2 = new WinShareData2(this);
            form2.Show();
        }
    }
}
