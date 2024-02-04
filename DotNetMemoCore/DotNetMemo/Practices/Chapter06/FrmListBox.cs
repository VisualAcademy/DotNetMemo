using System;
using System.Windows.Forms;

namespace DotNetMemo.Practices.Chapter06
{
    public partial class FrmListBox : Form
    {
        public FrmListBox()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string strMsg = String.Empty;
            // 리스트박스 항목 중 선택한 항목들 가져오기 
            foreach (var item in lstHobby.SelectedItems)
            {
                strMsg += (strMsg == "" ? "" : ", ") + item.ToString();
            }

            lblDisplay.Text = strMsg;
        }

        private void FrmListBox_Load(object sender, EventArgs e)
        {
            // 동적으로 항목 추가
            this.lstHobby.Items.Add("축구");
            this.lstHobby.Items.Add("농구");
            this.lstHobby.Items.Add("배구");
        }
    }
}
