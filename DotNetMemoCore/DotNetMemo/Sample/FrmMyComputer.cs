//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;
//using System.Management;
//using System.IO;

//namespace MyWinForms.Sample
//{
//    public partial class FrmMyComputer : Form
//    {
//        public FrmMyComputer()
//        {
//            InitializeComponent();
//        }

//        private void FrmMyComputer_Load(object sender, EventArgs e)
//        {
//            DisplayData(); 
//        }
//        // 전체 폴더 목록을 왼쪽 트리뷰에 출력
//        private void DisplayData()
//        {
//            this.treeView1.Nodes.Add(new TreeNode("니 컴퓨터"));

//            var q = 
//                new ManagementObjectSearcher(
//                    "SELECT * From Win32_LogicalDisk");
//            var arr = q.Get(); // 목록 받아오기

//            foreach (var item in arr)
//            {
//                this.treeView1.Nodes[0].Nodes.Add(
//                    new TreeNode(item["Name"].ToString())); // 자식 노드로 추가
//            }
//        }

//        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
//        {
//            if (this.treeView1.SelectedNode.Text != "니 컴퓨터")
//            {
//                DisplayList(treeView1.SelectedNode.Text + @"\"); 
//            }
//        }
//        // 왼쪽 트리뷰에서 C, D 선택시 오른쪽에 해당 폴더 내용출력
//        private void DisplayList(string dir) {
//            this.listView1.Items.Clear(); // 클리어
//            if (!Directory.Exists(dir)) {
//                MessageBox.Show("드라이가 없거나 로드 불가");
//            }
//            else {
//                DirectoryInfo di = new DirectoryInfo(dir);
//                foreach (var item in di.GetDirectories()) // 폴더목록
//                {
//                    listView1.Items.Add(
//                        new ListViewItem(new string[]{item.Name, ""})); 
//                }
//                foreach (var item in di.GetFiles()) // 파일목록
//                {
//                    listView1.Items.Add(
//                        new ListViewItem(new string[] { 
//                            item.Name, item.Length.ToString() }));
//                }
//            }
//        }
//    }
//}
