using System;
using System.Windows.Forms;

namespace MyWinForms.Controls
{
    public partial class FrmComboListBox : Form
    {
        public FrmComboListBox()
        {
            InitializeComponent();
        }

        private void FrmComboListBox_Load(object sender, EventArgs e)
        {
            // 동적으로 아이콘의 종류를 리스트박스에 초기화
            lstIcon.Items.Add(MessageBoxIcon.Error.ToString());
            lstIcon.Items.Add(MessageBoxIcon.Information.ToString());
            lstIcon.Items.Add(MessageBoxIcon.Question.ToString());
            lstIcon.Items.Add(MessageBoxIcon.Warning.ToString());    
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lstButton.SelectedIndex != -1 && lstIcon.SelectedIndex != -1)
            {
                string btn = lstButton.Items[lstButton.SelectedIndex].ToString();
                string icon = lstIcon.Items[lstIcon.SelectedIndex].ToString();

                // Process

                MessageBox.Show(
                    String.Format("버튼 : {0}, 아이콘 : {1}", btn, icon)); 
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "콤보박스와 리스트박스를 선택하시오."
                    ,"제목"
                    , MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    lblResult.Text = "확인 클릭";
                }
                else if (result == DialogResult.Cancel)
                {
                    lblResult.Text = "취소 클릭"; 
                }
            }
        }
    }
}
