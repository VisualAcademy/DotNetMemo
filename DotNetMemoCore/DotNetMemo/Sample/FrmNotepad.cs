using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; // 파일 처리

namespace MyWinForms.Sample
{
    public partial class FrmNotepad : Form
    {
        public FrmNotepad()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "텍스트파일|*.txt"; // 코드레벨 설정
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                // 텍스트 파일 열기
                StreamReader sr = new StreamReader(
                    openFileDialog1.FileName, Encoding.Default);
                // 데이터 읽어오기
                txtNote.Text = sr.ReadToEnd(); // 텍스트 모두 열기
                // 파일 닫기
                sr.Close(); 
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "텍스트파일|*.txt";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel) {
                StreamWriter sw = new StreamWriter(
                    saveFileDialog1.FileName, false, Encoding.Default);
                sw.Write(txtNote.Text);
                sw.Close(); 
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == btnCopy) // 복사 버튼이라면
            {
                // 클립보드에 선택된 텍스트를 복사(저장)
                //Clipboard.SetText(this.txtNote.SelectedText); 
                // 객체형으로 저장
                Clipboard.SetDataObject(txtNote.SelectedText, true); 
            }
            else
            {
                // 현재 클립보드의 텍스트를 붙여넣기
                //this.txtNote.Text = Clipboard.GetText(); 
                IDataObject ido = Clipboard.GetDataObject();
                if (ido.GetDataPresent(typeof(string)))
                {
                    txtNote.Text = (string)ido.GetData(typeof(string)); 
                }
            }
        }
    }
}
