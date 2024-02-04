using System;
using System.Windows.Forms;

namespace CustomDialogs
{
    public partial class FrmCustomDialogs : Form
    {
        public FrmCustomDialogs()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialog = new ConfirmDialog();

            if (dialog.ShowDialog() == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListBox1.Items.Add("Oranges");
            ListBox1.Items.Add("Grapes");
            ListBox1.Items.Add("Bananas");
            ListBox1.Items.Add("Peaches");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex == -1)
            {
                var msg = "Please select an item from the list box";
                MessageBox.Show(msg, this.Text);
                return;
            }

            Label1.Text = ListBox1.Text;
        }
    }
}
