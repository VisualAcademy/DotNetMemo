using System;
using System.Windows.Forms;

namespace DotNetMemo
{
    public partial class SdiMainForm : Form
    {
        private static int _counter = 0;

        public SdiMainForm()
        {
            InitializeComponent();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Main 메서드에 args 주고 아래와 같이 호출
            // SdiApplication.Instance.Run(args);

            // 작업 관리자를 열고 몇개의 인스턴스가 만들어지고
            // 전체 창 닫았을 때 프로세스가 소멸되는지 확인 
            CreateForm();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Rich text files|*.rtf";
            var result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.documentTextBox.LoadFile(dialog.FileName);
                this.Text = dialog.FileName;
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Rich text files|*.rtf";
            dialog.AddExtension = true;
            var result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.documentTextBox.SaveFile(dialog.FileName);
                this.Text = dialog.FileName;
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.documentTextBox.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.documentTextBox.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.documentTextBox.Paste();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.documentTextBox.SelectAll();
        }

        public static SdiMainForm CreateForm()
        {
            var form = new SdiMainForm();
            form.Text = "새 문서 " + ++_counter;
            SdiApplication.Instance.ApplicationContext.MainForm = form;
            form.Show();

            return form;
        }
    }
}
