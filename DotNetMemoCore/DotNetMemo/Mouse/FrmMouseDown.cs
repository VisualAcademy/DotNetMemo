using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace MyWinForms.Mouse
{
    public partial class FrmMouseDown : Form {
        private ArrayList al; 
        public FrmMouseDown() {
            InitializeComponent();
            al = new ArrayList(); 
        }
        private void FrmMouseDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                // 그래픽 객체 생성
                Graphics g = CreateGraphics();
                // 원 그리기
                g.DrawEllipse(Pens.Red, e.X, e.Y, 10, 10);
                // 객체 해제 
                g.Dispose(); 
            }
            p.X = e.X; p.Y = e.Y; 
        }
        private Point p; // 좌표
        private void FrmMouseDown_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                Graphics g = this.CreateGraphics();
                g.DrawLine(Pens.Blue, p.X, p.Y, e.X, e.Y);
                // 좌표값 보관
                al.Add(Rectangle.FromLTRB(p.X, p.Y, e.X, e.Y)); 
                p.X = e.X; p.Y = e.Y; // 재설정
                g.Dispose(); 
            }
        }
        private void FrmMouseDown_Paint(object sender, PaintEventArgs e) {
            // 저장된 좌표값 다시 그리기
            foreach (Rectangle r in al) {
                e.Graphics.DrawLine(
                    Pens.Blue, r.Left, r.Top, r.Right, r.Bottom);    
            }
        }
    }
}
