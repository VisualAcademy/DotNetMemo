using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyWinForms.Controls
{
    public partial class FrmListView : Form
    {
        public FrmListView()
        {
            InitializeComponent();
        }

        private void FrmListView_Load(object sender, EventArgs e)
        {
            // 국어/영어/총점을 리스트뷰에 출력
            // 3개의 레코드를 리스트뷰에 출력
            string[] arr1 = new string[] { "100", "100", "200" };
            string[] arr2 = new string[] { "90", "90", "180" };
            string[] arr3 = new string[] { "80", "80", "160" };

            // 입력
            this.lstScore.Items.Add(new ListViewItem(arr1)); //[1]

            ListViewItem lvi = new ListViewItem(arr2); //[2]
            this.lstScore.Items.Add(lvi);

            this.lstScore.Items.Add(
                new ListViewItem(new string[] { "80", "80", "160" })); //[3]
        }
    }
}
