using System.Windows.Forms;

namespace WinShareData
{
    public partial class WinShareData2 : Form
    {
        public WinShareData2()
        {
            InitializeComponent();
        }

        // 문자열 매개변수를 갖는 생성자
        public WinShareData2(string str)
        {
            InitializeComponent();

            textBox1.Text = str;
        }

        // 폼 개체 매개변수를 갖는 생성자
        public WinShareData2(WinShareData1 form1)
        {
            InitializeComponent();

            textBox2.Text = form1.ShareData; 
        }

    }
}
