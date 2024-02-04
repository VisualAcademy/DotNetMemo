using System;
using System.Windows.Forms;
using DotNetMemo;
using MyWinForms.Sample;

namespace MyWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            // 현재 프로그램 종료
            Application.Exit();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            // 모달 폼 : 현재 창을 닫아야지만, 메인으로 이동 가능
            FrmAbout fa = new FrmAbout();
            fa.ShowDialog();
        }

        private void miButton_Click(object sender, EventArgs e)
        {
            //// 모달리스 폼 : 독립적인 하나의 폼
            //MyWinForms.Controls.FrmButton fb = 
            //    new MyWinForms.Controls.FrmButton();
            //fb.MdiParent = this; // MDI 컨테이너를 현재 폼(메인)으로 설정
            //fb.Show(); 
        }


        #region 컨텍스트메뉴
        private void cmsAbout_Click(object sender, EventArgs e)
        {
            //FrmAbout fa = new FrmAbout();
            //fa.ShowDialog(); 
            miAbout_Click(null, null); // 재 사용
        }

        private void cmsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void miLable_Click(object sender, EventArgs e)
        {
            MyWinForms.Controls.FrmButtonLableTextBox blt = new MyWinForms.Controls.FrmButtonLableTextBox();
            blt.MdiParent = this;
            blt.Show();
        }

        private void miCheckBoxRadioButton_Click(object sender, EventArgs e)
        {
            MyWinForms.Controls.FrmCheckBoxRadioButton cbrb = new MyWinForms.Controls.FrmCheckBoxRadioButton();
            cbrb.MdiParent = this;
            cbrb.Show();
        }

        private void miTextBox_Click(object sender, EventArgs e)
        {
            MyWinForms.Controls.FrmTextBox ftb = new MyWinForms.Controls.FrmTextBox();
            ftb.MdiParent = this;
            ftb.Show();
        }

        private void miMessageBox_Click(object sender, EventArgs e)
        {
            // 메시지 박스의 주요 모양
            // MSDN 온라인 적극 활용
            // 코드조각 : mbox
            MessageBox.Show("기본");
            MessageBox.Show("캡션", "제목");
            MessageBox.Show("버튼의 종류", "버튼", MessageBoxButtons.OKCancel);
            MessageBox.Show("아이콘의 종류", "아이콘"
                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void miComboListBox_Click(object sender, EventArgs e)
        {
            MyWinForms.Controls.FrmComboListBox clb = new MyWinForms.Controls.FrmComboListBox();
            clb.MdiParent = this;
            clb.Show();
        }

        private void miGroupBox_Click(object sender, EventArgs e)
        {
            MyWinForms.Controls.FrmGroupBox gb = new MyWinForms.Controls.FrmGroupBox();
            gb.MdiParent = this;
            gb.Show();
        }

        private void miDialogResult_Click(object sender, EventArgs e)
        {
            MyWinForms.Class.FrmDialogResult fdr = new MyWinForms.Class.FrmDialogResult();
            fdr.Show();
        }

        // 컨트롤 - 대화상자 - 폰트
        private void miFont_Click(object sender, EventArgs e)
        {
            MyWinForms.Controls.FrmFontDialog ffd = new MyWinForms.Controls.FrmFontDialog();
            ffd.MdiParent = this;
            ffd.Show();
        }

        // 컨트롤 - 대화상자 - 파일 및 폴더
        private void miFileFolder_Click(object sender, EventArgs e)
        {
            MyWinForms.Controls.FrmFileFolder fff = new MyWinForms.Controls.FrmFileFolder();
            fff.MdiParent = this;
            fff.Show();
        }

        // 초간단 노트패드
        private void miNotepad_Click(object sender, EventArgs e)
        {
            FrmNotepad fn = new FrmNotepad();
            fn.MdiParent = this;
            fn.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 스테이터스바의 3번째 레이블에 현재 시간 출력
            sslTime.Text =
                String.Format("{0}시 {1:0#}분 {2}초",
                    DateTime.Now.Hour
                    , DateTime.Now.Minute
                        , DateTime.Now.Second.ToString().PadLeft(2, '0'));
        }

        private void miExplorer_Click(object sender, EventArgs e)
        {
            FrmExplorer ie = new FrmExplorer();
            ie.Show();
        }

        #region 창 메뉴 관련
        private void miWindowClose_Click(object sender, EventArgs e)
        {
            Form frm = ActiveMdiChild; // 현재 열려있는 폼 가져오기
            if (frm != null)
            {
                frm.Close(); // 닫기
            }
        }
        private void miWindowCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade); // 계단식
        }
        private void miWindowHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal); // 수평 바둑판
        }
        private void miWindowVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical); // 수직 바둑판
        }
        #endregion

        private void miCheckedListBox_Click(object sender, EventArgs e)
        {
            // 생성과 동시에 오픈
            (new MyWinForms.Controls.FrmCheckedListBoxFavorite()).Show();
        }

        private void miImageViewer_Click(object sender, EventArgs e)
        {
            (new FrmImageViewer()).Show();
        }

        private void miTabControl_Click(object sender, EventArgs e)
        {
            //(new MyWinForms.Controls.FrmTabControl()).Show();
        }

        private void miToolTip_Click(object sender, EventArgs e)
        {
            (new MyWinForms.Controls.FrmToolTip()).Show();
        }

        private void MainForm_FormClosing(object sender,
            FormClosingEventArgs e)
        {
            // 폼을 닫을건지 취소할건지 결정
            DialogResult dr =
                MessageBox.Show(
                    "종료하시겠습니까?"
                    , "종료확인"
                    , MessageBoxButtons.YesNo
                    , MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                e.Cancel = true; // 취소
            }
        }

        private void wcfSumServiceTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmSumServiceTest test = new FrmSumServiceTest();
            //test.Show(); 
        }
    }
}
