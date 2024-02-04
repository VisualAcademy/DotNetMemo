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
    public partial class FrmKeyDown : Form
    {
        private Point p; 
        public FrmKeyDown() {
            InitializeComponent();
            p.X = 10; p.Y = 10; 
        }
        // 폼이 그려질 때 발생하는 이벤트
        private void FrmKeyDown_Paint(object sender, PaintEventArgs e) {
            // 원 그리기
            e.Graphics.FillEllipse(Brushes.Black, p.X - 8, p.Y - 8, 16, 16); 
        }
        // 폼에서 키보드가 타이핑될 때
        private void FrmKeyDown_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Left: p.X -= 10; Invalidate(); break;
                case Keys.Right: p.X += 10; Invalidate(); break;
                case Keys.Up: p.Y -= 10; Invalidate(); break;
                case Keys.Down: p.Y += 10; Invalidate(); break;
                default: break; 
            }    
        }
        // 폼 로드
        private void FrmKeyDown_Load(object sender, EventArgs e)
        {

        }
    }
}
