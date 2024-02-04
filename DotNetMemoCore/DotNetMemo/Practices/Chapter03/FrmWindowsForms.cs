using System;
using System.Windows.Forms;

namespace DotNetMemo.Practices.Chapter03
{
    public partial class FrmWindowsForms : Form
    {
        public FrmWindowsForms()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼 로드 이벤트 처리기: 이벤트 핸드러
        /// </summary>
        private void FrmWindowsForms_Load(object sender, EventArgs e)
        {
            // 선언적으로 Text 속성을 설정한 것을
            // 프로그래밍적으로 폼 로드할 때 변경
            this.Text = "Windows Forms의 세계에 오신 것을 환영합니다.";
        }

        /// <summary>
        /// 폼을 두번 클릭했을 때 어떤 일을 할건지?
        /// </summary>
        private void FrmWindowsForms_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("더블 클릭하셨군요."); 
            MessageBox.Show("더블 클릭하셨군요.", "FrmWindowsForms", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
