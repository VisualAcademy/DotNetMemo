using System;
using System.Windows.Forms;

namespace WinListView
{
    public partial class WinListView : Form
    {
        public WinListView()
        {
            InitializeComponent();
            // 컬럼 제목 등록
            lvwEmailListByCode.Columns.Add("이름", 80, HorizontalAlignment.Center);
            lvwEmailListByCode.Columns.Add("이메일", 120, HorizontalAlignment.Center);
            lvwEmailListByCode.FullRowSelect = true; // 추가 속성은 MSDN 온라인 참조
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 코드 기반으로 ListView 컨트롤에 항목 추가하기
            lvwEmailListByCode.Items.Add(
                new ListViewItem(new string[] { txtName.Text, txtEmail.Text }));
            txtName.Text = txtEmail.Text = String.Empty;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // 리스트뷰에서 선택된 값을 가져오기
            if (lvwEmailListByCode.SelectedItems.Count > 0)
            {
                MessageBox.Show(String.Format("{0}, {1}", 
                    lvwEmailListByCode.SelectedItems[0].Text,
                    lvwEmailListByCode.SelectedItems[0].SubItems[1].Text));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 리스트뷰 항목 전체 삭제
            lvwEmailListByCode.Items.Clear();
        }
    }
}
