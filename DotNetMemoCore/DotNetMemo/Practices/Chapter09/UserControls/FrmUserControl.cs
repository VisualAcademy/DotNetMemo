using System;
using System.Windows.Forms;

namespace UserControls
{
    public partial class FrmUserControl : Form
    {
        public FrmUserControl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person p = new Person
            {
                FirstName = "용준",
                LastName = "박",
                Age = 21
            };

            personControl1.Person = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personControl1.Person.LastName, this.Text);
        }
    }
}
