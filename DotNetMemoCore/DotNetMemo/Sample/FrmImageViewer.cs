using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyWinForms.Sample
{
    public partial class FrmImageViewer : Form
    {
        public FrmImageViewer()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() != DialogResult.Cancel)
            {
                this.picImage.ImageLocation = ofdImage.FileName; 
            }
        }

        private void FrmImageViewer_Load(object sender, EventArgs e)
        {
            // 픽처박스의 기본 크기는 50*50
            p.X = hScrollBar1.Value; 
            p.Y = vScrollBar1.Value; 
            this.picImage.Size = new Size(p); 
        }
        Point p; // 포인터형 변수 : X, Y값을 보관
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            p.X = hScrollBar1.Value * 2; 
            this.picImage.Size = new Size(p); 
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            p.Y = vScrollBar1.Value * 2;
            this.picImage.Size = new Size(p); 
        }
    }
}
