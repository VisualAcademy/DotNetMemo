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
    public partial class FrmTreeView : Form
    {
        public FrmTreeView()
        {
            InitializeComponent();
        }

        private void FrmTreeView_Load(object sender, EventArgs e)
        {
            this.treeView1.Nodes[0].Nodes[1].Nodes.Add("Program");
            this.treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("SQL"); 
        }
    }
}
