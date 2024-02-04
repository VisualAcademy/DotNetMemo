using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace DotNetNote
{
    public partial class DotNetNote : Form
    {
        #region Constructors
        public DotNetNote()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Member Variables
        private bool _IsTextChanged; // 텍스트 변경 여부
        #endregion

        #region Private Methods
        /// <summary>
        /// 파일을 저장할지 결정 메서드
        /// </summary>
        private void SaveText()
        {
            if (this.Text == "제목 없음 - 메모장")
            {
                DialogResult objDr = sfdDotNetNote.ShowDialog();
                if (objDr != DialogResult.Cancel)
                {
                    string strFileName = sfdDotNetNote.FileName;
                    SaveFile(strFileName);
                }
            }
            else
            {
                string strFileName = this.Text; // 파일 전체 이름
                SaveFile(strFileName);
            }
        }

        /// <summary>
        /// 실제 파일을 저장하는 메서드
        /// </summary>
        /// <param name="strFileName">저장될 파일의 전체 경로</param>
        private void SaveFile(string strFileName)
        {
            StreamWriter objSw = new StreamWriter(strFileName, false, System.Text.Encoding.Default);
            objSw.Write(this.txtMain.Text);
            objSw.Flush();
            objSw.Close();

            _IsTextChanged = false;
            this.Text = strFileName; // 제목에 파일명 출력
        }

        /// <summary>
        /// 텍스트 박스의 내용 비우기
        /// </summary>
        private void ClearText()
        {
            this.txtMain.ResetText(); // 텍스트박스 리셋    
            this.Text = "제목 없음 - 메모장";
            _IsTextChanged = false;
        }

        // 저장 또는 텍스트박스 클리어 또는 취소 기능 메서드
        private void SaveOrClearOrCancel(string strFlag)
        {
            DialogResult objDr = MessageBox.Show(
                this.Text + " " +
                " 파일의 내용이 변경되었습니다.\r\n" +
                "변경된 내용을 저장하시겠습니까?",
                "메모장",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation);
            switch (objDr)
            {
                case DialogResult.Yes:
                    SaveText(); // 텍스트 저장
                    if (strFlag == "New")
                        ClearText(); // 텍스트 클리어(리셋)
                    else
                        OpenText(); // 열기
                    break;
                case DialogResult.No:
                    if (strFlag == "New")
                        ClearText(); // 텍스트 클리어(리셋)
                    else
                        OpenText(); // 열기
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        // 열기 기능 메서드
        private void OpenText()
        {
            DialogResult objDr = ofdDotNetNote.ShowDialog();
            if (objDr != DialogResult.Cancel)
            {
                string strFileName = ofdDotNetNote.FileName;
                StreamReader objSr = new StreamReader(strFileName, System.Text.Encoding.Default);
                this.txtMain.Text = objSr.ReadToEnd();
                objSr.Close();

                _IsTextChanged = false;
                this.Text = strFileName; // 제목에 파일명 출력
            }
        }
        #endregion

        #region Event Handlers
        // 폼 로드 이벤트
        private void DotNetNote_Load(object sender, EventArgs e)
        {
            this.Width = 600;
            this.Height = 400;

            //if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\Hawaso\DotNetNote\", "Font-Family", "") != null)
            //{
            //    // 레지스트리에 저장된 폰트 정보 가져오기
            //    Font fnt = new Font(
            //      Convert.ToString(
            //        Registry.GetValue(@"HKEY_CURRENT_USER\Software\Hawaso\DotNetNote\", "Font-Family", ""))
            //      , Convert.ToSingle(Registry.GetValue(@"HKEY_CURRENT_USER\Software\Hawaso\DotNetNote\", "Font-Size", "")));
            //    this.txtMain.Font = fnt;
            //}
        }

        // 새로 만들기 메뉴
        private void miNew_Click(object sender, EventArgs e)
        {
            if (_IsTextChanged)
            {
                SaveOrClearOrCancel("New");
            }
            else
            {
                ClearText();
            }
        }

        // 텍스트 내용 변경시 발생
        private void txtMain_TextChanged(object sender, EventArgs e)
        {
            _IsTextChanged = true; // 텍스트 변경 적용
            miUndo.Enabled = true; // 취소 메뉴 활성화
            miCut.Enabled = true; // 잘라내기 메뉴 활성화
            miCopy.Enabled = true; // 복사 메뉴 활성화  
            miDel.Enabled = true; // 삭제 메뉴 활성화
            miFind.Enabled = true; // 찾기 메뉴 활성화
            miFindNext.Enabled = true; // 다음 찾기 메뉴 활성화
            miGo.Enabled = true; // 이동 메뉴 활성화
            if (txtMain.Text.Length == 0)
            {
              _IsTextChanged = false;  
            }
        }

        // 열기 메뉴
        private void miOpen_Click(object sender, EventArgs e)
        {
            if (_IsTextChanged)
            {
                SaveOrClearOrCancel("Open");
            }
            else
            {
                OpenText();
            }
        }

        // 저장 메뉴
        private void miSave_Click(object sender, EventArgs e)
        {
            SaveText(); // 저장 메서드 호출
        }

        // 다른 이름으로 저장
        private void miSaveAs_Click(object sender, EventArgs e)
        {
            DialogResult objDr = sfdDotNetNote.ShowDialog();
            if (objDr != DialogResult.Cancel)
            {
                string strFileName = sfdDotNetNote.FileName;
                SaveFile(strFileName);
            }
        }

        // 페이지 설정 메뉴
        private void miPageSetup_Click(object sender, EventArgs e)
        {
            //[1] PrintDocument.DocumentName = 문서 지정
            dnnPrintDocument.DocumentName = txtMain.Text;
            //[2] PageSetupDialog.Document = PrintDocument
            psdDotNetNote.Document = this.dnnPrintDocument;
            //[3] 페이지 설정 창 띄우기
            psdDotNetNote.ShowDialog();
        }

        // 인쇄 메뉴
        private void miPrint_Click(object sender, EventArgs e)
        {
            dnnPrintDocument.DocumentName = txtMain.Text;
            if (pdDotNetNote.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dnnPrintDocument.Print();
                }
                catch
                {
                    MessageBox.Show(
                        "인쇄하는 도중에 에러가 발생했습니다.", 
                        "인쇄 오류", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
        }

        // 페이지 인쇄 이벤트 핸들러
        private void dnnPrintDocument_PrintPage(
            object sender, 
            System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringReader objSr = new StringReader(this.txtMain.Text);

            // 현재 문서의 글꼴과 사이즈
            Font printFont = 
                new Font(txtMain.Font.Name, txtMain.Font.Size);
            float linesPerPage = 0; // 페이지의 라인 수
            float yPos = 0; // 페이지 상단에서 떨어진 위치(문자열 출력)
            int count = 0; // 페이지 줄 번호

            float leftMargin = e.MarginBounds.Left; // 왼쪽 여백
            float topMargin = e.MarginBounds.Top; // 오른쪽 여백

            string line = null; // 각 행의 데이터 저장
            linesPerPage = // 페이지 당 라인 수 계산
                e.MarginBounds.Height /
                    printFont.GetHeight(e.Graphics);

            while (count < linesPerPage &&
                ((line = objSr.ReadLine()) != null))
            { 
                yPos = topMargin +
                    (count * printFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(
                    line,
                    printFont, 
                    Brushes.Black, 
                    leftMargin, yPos, 
                    new StringFormat());
                count++;
            }

            if (line != null)
            {
                e.HasMorePages = true;
            }
            else 
            {
                e.HasMorePages = false; 
            }
            objSr.Close();
        }

        // 끝내기 메뉴
        private void miExit_Click(object sender, EventArgs e)
        {
            if (_IsTextChanged)
            {
                DialogResult objDr = MessageBox.Show(
                    this.Text + " " + 
                    "파일의 내용이 변경되었습니다.\r\n" +
                    "변경된 내용을 저장하시겠습니까?",
                    "메모장",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation);
                switch (objDr)
                {
                    case DialogResult.Yes:
                        SaveText(); // 텍스트 저장
                        this.Close(); // 종료
                        break;
                    case DialogResult.No:
                        this.Close(); // 종료
                        break;
                    case DialogResult.Cancel:
                        break;
                }    
            }
            else
            {
                Application.Exit(); // this.Close();
            }
        }

        // 실행 취소 메뉴
        private void miUndo_Click(object sender, EventArgs e)
        {
            if (this.txtMain.CanUndo)
            {
                this.txtMain.Undo();
            }
        }

        // 잘라내기 메뉴 구현
        private void miCut_Click(object sender, EventArgs e)
        {
            this.txtMain.Cut();
            //Clipboard.SetDataObject(txtMain.SelectedText);
            //txtMain.SelectedText = String.Empty;
        }

        // 복사 메뉴 구현
        private void miCopy_Click(object sender, EventArgs e)
        {
            this.txtMain.Copy();
            //Clipboard.SetDataObject(txtMain.SelectedText); // 복사
        }

        // 붙여넣기 메뉴 구현
        private void miPaste_Click(object sender, EventArgs e)
        {
            this.txtMain.Paste(); // 붙여넣기
            //[!] 클립보드의 내용이 텍스트 형식인지 검사 후 붙여넣기
            //if (Clipboard.GetDataObject().GetDataPresent(
            //    DataFormats.Text))
            //{
            //    // 클립보드의 내용을 텍스트 형식으로 변환 후 반환
            //    this.txtMain.SelectedText =
            //        Clipboard.GetDataObject().GetData(
            //        DataFormats.Text, true).ToString();
            //}
        }

        // 삭제 메뉴 구현
        private void miDel_Click(object sender, EventArgs e)
        {
            this.txtMain.SelectedText = String.Empty;
        }

        // 찾기 메뉴 구현
        private void miFind_Click(object sender, EventArgs e)
        {
            FrmFind f = new FrmFind(this);
            f.Show();
        }

        // 다음 찾기 메뉴 구현
        private void miFindNext_Click(object sender, EventArgs e)
        {
            miFind_Click(null, null);
        }

        // 바꾸기 메뉴 구현
        private void miReplace_Click(object sender, EventArgs e)
        {
            (new FrmReplace(this)).Show();
            //FrmReplace r = new FrmReplace(this);
            //r.Show();
        }

        // 이동 메뉴
        private void miGo_Click(object sender, EventArgs e)
        {
            int intLineLength = //전체 라인수
                this.txtMain.Lines.Length;
            int intCurrentLine = //현재 라인수
                Library.GetLineAndColumn(this.txtMain).Line;

            FrmGo go = new FrmGo(intLineLength, intCurrentLine);
            if (go.ShowDialog() == DialogResult.OK)
            {
                int intLineNum = 0;
                if (go.GetLine() != 1)
                {
                    for (int i = 0; i < go.GetLine() - 1; i++)
                    {
                        intLineNum +=
                            txtMain.Lines[i].Length + 2;
                    }
                }
                txtMain.SelectionStart = intLineNum;
                txtMain.ScrollToCaret();
            }
        }

        // 전체 선택 메뉴
        private void miSelectAll_Click(object sender, EventArgs e)
        {
            this.txtMain.SelectAll();
        }

        // 시간/날짜 메뉴 구현
        private void miTimeDate_Click(object sender, EventArgs e)
        {
          // 마우스 커서(캐럿) 자리에 시간/날짜 출력
          txtMain.SelectedText =
            String.Format("{0} {1}"
              , DateTime.Now.ToShortTimeString()
              , DateTime.Now.ToShortDateString());
        }

        // 자동 줄 바꿈 메뉴
        private void miWordWrap_Click(object sender, EventArgs e)
        {

            this.txtMain.WordWrap = !(this.txtMain.WordWrap);
            this.miWordWrap.Checked = !(this.miWordWrap.Checked);
            // 자동 줄 바꿈 체크 : 상태 표시줄 비활성화
            if (miWordWrap.Checked)
            {
              miStatus.Enabled = false;
            }
            else
            {
              miStatus.Enabled = true;
            }
        }
        
        // 글꼴 메뉴 
        private void miFont_Click(object sender, EventArgs e)
        {
          fdDotNetNote.Font = txtMain.Font; // 폰트 다이얼로그 컨트롤에 현재 텍스트박스 글꼴 선택
          if (fdDotNetNote.ShowDialog() != DialogResult.Cancel)
          {
            txtMain.Font = fdDotNetNote.Font;
            //// 윈도우 레지스트리에 현재 설정된 글꼴 저장
            //Registry.SetValue(@"HKEY_CURRENT_USER\Software\Hawaso\DotNetNote\", "Font-Size", fdDotNetNote.Font.Size);
            //Registry.SetValue(@"HKEY_CURRENT_USER\Software\Hawaso\DOtNetNOte\", "Font-Family", fdDotNetNote.Font.FontFamily.Name);
          }
        }

        // 상태 표시줄 메뉴
        private void miStatus_Click(object sender, EventArgs e)
        {
            if (this.dnnStatusStrip.Visible)
            {
                this.dnnStatusStrip.Visible = false;
                this.miStatus.Checked = false;
                this.txtMain.Height = this.Height - 55;
            }
            else
            {
                this.dnnStatusStrip.Visible = true;
                this.miStatus.Checked = true;
                int intLine =
                    Library.GetLineAndColumn(txtMain).Line;
                int intColumn =
                    Library.GetLineAndColumn(txtMain).Column;

                string strMsg = String.Format(
                    "Ln {0}, Col {1}", intLine, intColumn);

                this.toolStripStatusLabel2.Text = strMsg;
                this.txtMain.Height = this.txtMain.Height - 25;
            }
        }

        // 키보드 키 누른 후에 발생
        private void txtMain_KeyUp(object sender, KeyEventArgs e)
        {
            int intLine =
                Library.GetLineAndColumn(txtMain).Line;
            int intColumn =
                Library.GetLineAndColumn(txtMain).Column;

            string strMsg = String.Format(
                "Ln {0}, Col {1}", intLine, intColumn);

            this.toolStripStatusLabel2.Text = strMsg;
        }

        //[!] 도움말 항목 메뉴
        private void miHelp_Click(object sender, EventArgs e)
        {
            // 시스템(Windows) 디렉터리 경로
            string strDirectory =
                System.Environment.SystemDirectory;
            // Help 폴더 안의 Notepad.chm 파일 경로 : Parent
            strDirectory = // 한 단계 상위 경로 폴더 뽑아내기
                strDirectory.Substring(
                    0, strDirectory.LastIndexOf("\\"));
            strDirectory += @"\Help\Notepad.chm"; // Combine()
            // 파일이 있는지 확인 후 도움말 띄우기
            if (System.IO.File.Exists(strDirectory))
            {
                Help.ShowHelp(this, strDirectory);
            }
            else
            {
                MessageBox.Show(strDirectory +
                    "도움말 파일이 없습니다.",
                    "메모장",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
 
        //[!] 메모장 정보 메뉴
        private void miAbout_Click(object sender, EventArgs e)
        {
          // FrmAbout 윈폼의 인스턴스 생성
          FrmAbout about = new FrmAbout();
          // 윈폼 개체의 showDialog() 메서드로 윈폼 띄우기
          about.ShowDialog(); // 모달(Modal) 폼
        }

        // 파일 드롭 지원 : txtMain.AllowDrop = true로 설정해야 함.
        private void txtMain_DragOver(object sender, DragEventArgs e)
        {
          if (e.Data.GetDataPresent(DataFormats.FileDrop))
          {
            e.Effect = DragDropEffects.Copy;
          }
        }

        private void txtMain_DragDrop(object sender, DragEventArgs e)
        {
          if (e.Data.GetDataPresent(DataFormats.FileDrop))
          {
            string[] strFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            StreamReader objSr = new StreamReader(strFiles[0], Encoding.Default);
            this.txtMain.Clear();
            this.txtMain.Text = objSr.ReadToEnd();
            objSr.Close();
          }
        }

        private void txtMain_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            if (e.EscapePressed)
            {
                e.Action = DragAction.Cancel; 
            }
        }
        #endregion

        // 인쇄 미리 보기
        private void miPreview_Click(object sender, EventArgs e)
        {
            dnnPrintPreviewDialog.Document = dnnPrintDocument;
            dnnPrintPreviewDialog.ShowDialog(); 
        }
    }
}