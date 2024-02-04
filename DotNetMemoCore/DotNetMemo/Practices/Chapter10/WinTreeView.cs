using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinTreeView
{
    public partial class WinTreeView : Form
    {
        public WinTreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // 현재 선택된 노드의 텍스트를 텍스트박스에 출력
            if (treeView1.SelectedNode != null)
            {
                textBox1.Text = treeView1.SelectedNode.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼 로드시 treeView2에 데이터 바인딩
            treeView2.Nodes.Add("iPhone");
            treeView2.Nodes[0].Nodes.Add("Object C");
            treeView2.Nodes.Add("Android");
            treeView2.Nodes[1].Nodes.Add("Java");
        }

        //[1] 
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // 첫번째 텍스트박스에 대하여 Text 속성을 복사할 수 있도록 설정
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
        }
        //[2] 
        private void textBox2_DragEnter(object sender, DragEventArgs e)
        {
            // 드래그하는 마우스 커서가 두번째 텍스트박스에 위치했을 때
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        //[3] 
        private void textBox2_DragDrop(object sender, DragEventArgs e)
        {
            textBox2.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        //[1]
        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        //[2]
        private void treeView2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode"))
            {
                e.Effect = DragDropEffects.Move; // 이동
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //[3]
        private void treeView2_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode newNode; // 원본
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                Point pt;
                TreeNode destinationNode; // 대상

                pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y)); // 현재 포인터 위치
                destinationNode = ((TreeView)sender).GetNodeAt(pt);
                newNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode"); // 원본

                if (!(destinationNode.TreeView == newNode.TreeView))
                {
                    destinationNode.Nodes.Add((TreeNode)newNode.Clone()); // 복사
                    destinationNode.Expand(); // 노드 확장

                    newNode.Remove(); // 원본 노드 삭제
                }
            }
        }

    }
}
