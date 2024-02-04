namespace MyWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuControl = new System.Windows.Forms.ToolStripMenuItem();
            this.miCommonControl = new System.Windows.Forms.ToolStripMenuItem();
            this.miButton = new System.Windows.Forms.ToolStripMenuItem();
            this.miLable = new System.Windows.Forms.ToolStripMenuItem();
            this.miCheckBoxRadioButton = new System.Windows.Forms.ToolStripMenuItem();
            this.miTextBox = new System.Windows.Forms.ToolStripMenuItem();
            this.miComboListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.miCheckedListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.miToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.miContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.miGroupBox = new System.Windows.Forms.ToolStripMenuItem();
            this.miTabControl = new System.Windows.Forms.ToolStripMenuItem();
            this.miData = new System.Windows.Forms.ToolStripMenuItem();
            this.대화상자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miFont = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.miMessageBox = new System.Windows.Forms.ToolStripMenuItem();
            this.miDialogResult = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.miNotepad = new System.Windows.Forms.ToolStripMenuItem();
            this.miExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.miImageViewer = new System.Windows.Forms.ToolStripMenuItem();
            this.wcfSumServiceTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindowClose = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindowHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindowVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuControl,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.mnuWindow,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.miExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(57, 20);
            this.mnuFile.Text = "파일(&F)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(125, 22);
            this.miExit.Text = "끝내기(&X)";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(57, 20);
            this.mnuEdit.Text = "편집(&E)";
            // 
            // mnuView
            // 
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(59, 20);
            this.mnuView.Text = "보기(&V)";
            // 
            // mnuControl
            // 
            this.mnuControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCommonControl,
            this.miContainer,
            this.miData,
            this.대화상자ToolStripMenuItem});
            this.mnuControl.Name = "mnuControl";
            this.mnuControl.Size = new System.Drawing.Size(71, 20);
            this.mnuControl.Text = "컨트롤(&C)";
            // 
            // miCommonControl
            // 
            this.miCommonControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miButton,
            this.miLable,
            this.miCheckBoxRadioButton,
            this.miTextBox,
            this.miComboListBox,
            this.miCheckedListBox,
            this.miToolTip});
            this.miCommonControl.Name = "miCommonControl";
            this.miCommonControl.Size = new System.Drawing.Size(138, 22);
            this.miCommonControl.Text = "공용 컨트롤";
            // 
            // miButton
            // 
            this.miButton.Name = "miButton";
            this.miButton.Size = new System.Drawing.Size(194, 22);
            this.miButton.Text = "버튼";
            this.miButton.Click += new System.EventHandler(this.miButton_Click);
            // 
            // miLable
            // 
            this.miLable.Name = "miLable";
            this.miLable.Size = new System.Drawing.Size(194, 22);
            this.miLable.Text = "버튼레이블텍스트박스";
            this.miLable.Click += new System.EventHandler(this.miLable_Click);
            // 
            // miCheckBoxRadioButton
            // 
            this.miCheckBoxRadioButton.Name = "miCheckBoxRadioButton";
            this.miCheckBoxRadioButton.Size = new System.Drawing.Size(194, 22);
            this.miCheckBoxRadioButton.Text = "체크박스라다오버튼";
            this.miCheckBoxRadioButton.Click += new System.EventHandler(this.miCheckBoxRadioButton_Click);
            // 
            // miTextBox
            // 
            this.miTextBox.Name = "miTextBox";
            this.miTextBox.Size = new System.Drawing.Size(194, 22);
            this.miTextBox.Text = "텍스트박스";
            this.miTextBox.Click += new System.EventHandler(this.miTextBox_Click);
            // 
            // miComboListBox
            // 
            this.miComboListBox.Name = "miComboListBox";
            this.miComboListBox.Size = new System.Drawing.Size(194, 22);
            this.miComboListBox.Text = "콤보박스리스트박스";
            this.miComboListBox.Click += new System.EventHandler(this.miComboListBox_Click);
            // 
            // miCheckedListBox
            // 
            this.miCheckedListBox.Name = "miCheckedListBox";
            this.miCheckedListBox.Size = new System.Drawing.Size(194, 22);
            this.miCheckedListBox.Text = "체크리스트박스";
            this.miCheckedListBox.Click += new System.EventHandler(this.miCheckedListBox_Click);
            // 
            // miToolTip
            // 
            this.miToolTip.Name = "miToolTip";
            this.miToolTip.Size = new System.Drawing.Size(194, 22);
            this.miToolTip.Text = "툴팁";
            this.miToolTip.Click += new System.EventHandler(this.miToolTip_Click);
            // 
            // miContainer
            // 
            this.miContainer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGroupBox,
            this.miTabControl});
            this.miContainer.Name = "miContainer";
            this.miContainer.Size = new System.Drawing.Size(138, 22);
            this.miContainer.Text = "컨테이너";
            // 
            // miGroupBox
            // 
            this.miGroupBox.Name = "miGroupBox";
            this.miGroupBox.Size = new System.Drawing.Size(122, 22);
            this.miGroupBox.Text = "그룹박스";
            this.miGroupBox.Click += new System.EventHandler(this.miGroupBox_Click);
            // 
            // miTabControl
            // 
            this.miTabControl.Name = "miTabControl";
            this.miTabControl.Size = new System.Drawing.Size(122, 22);
            this.miTabControl.Text = "탭컨트롤";
            this.miTabControl.Click += new System.EventHandler(this.miTabControl_Click);
            // 
            // miData
            // 
            this.miData.Name = "miData";
            this.miData.Size = new System.Drawing.Size(138, 22);
            this.miData.Text = "데이터";
            // 
            // 대화상자ToolStripMenuItem
            // 
            this.대화상자ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFont,
            this.miFileFolder});
            this.대화상자ToolStripMenuItem.Name = "대화상자ToolStripMenuItem";
            this.대화상자ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.대화상자ToolStripMenuItem.Text = "대화상자";
            // 
            // miFont
            // 
            this.miFont.Name = "miFont";
            this.miFont.Size = new System.Drawing.Size(146, 22);
            this.miFont.Text = "폰트";
            this.miFont.Click += new System.EventHandler(this.miFont_Click);
            // 
            // miFileFolder
            // 
            this.miFileFolder.Name = "miFileFolder";
            this.miFileFolder.Size = new System.Drawing.Size(146, 22);
            this.miFileFolder.Text = " 파일 및 폴더";
            this.miFileFolder.Click += new System.EventHandler(this.miFileFolder_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMessageBox,
            this.miDialogResult});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem3.Text = "클래스(&U)";
            // 
            // miMessageBox
            // 
            this.miMessageBox.Name = "miMessageBox";
            this.miMessageBox.Size = new System.Drawing.Size(134, 22);
            this.miMessageBox.Text = "메시지박스";
            this.miMessageBox.Click += new System.EventHandler(this.miMessageBox_Click);
            // 
            // miDialogResult
            // 
            this.miDialogResult.Name = "miDialogResult";
            this.miDialogResult.Size = new System.Drawing.Size(134, 22);
            this.miDialogResult.Text = "대화상자";
            this.miDialogResult.Click += new System.EventHandler(this.miDialogResult_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNotepad,
            this.miExplorer,
            this.miImageViewer,
            this.wcfSumServiceTestToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(58, 20);
            this.toolStripMenuItem4.Text = "샘플(&S)";
            // 
            // miNotepad
            // 
            this.miNotepad.Name = "miNotepad";
            this.miNotepad.Size = new System.Drawing.Size(179, 22);
            this.miNotepad.Text = "초단간노트패드";
            this.miNotepad.Click += new System.EventHandler(this.miNotepad_Click);
            // 
            // miExplorer
            // 
            this.miExplorer.Name = "miExplorer";
            this.miExplorer.Size = new System.Drawing.Size(179, 22);
            this.miExplorer.Text = "초간단웹브라우저";
            this.miExplorer.Click += new System.EventHandler(this.miExplorer_Click);
            // 
            // miImageViewer
            // 
            this.miImageViewer.Name = "miImageViewer";
            this.miImageViewer.Size = new System.Drawing.Size(179, 22);
            this.miImageViewer.Text = "초간단이미지뷰어";
            this.miImageViewer.Click += new System.EventHandler(this.miImageViewer_Click);
            // 
            // wcfSumServiceTestToolStripMenuItem
            // 
            this.wcfSumServiceTestToolStripMenuItem.Name = "wcfSumServiceTestToolStripMenuItem";
            this.wcfSumServiceTestToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.wcfSumServiceTestToolStripMenuItem.Text = "WcfSumServiceTest";
            this.wcfSumServiceTestToolStripMenuItem.Click += new System.EventHandler(this.wcfSumServiceTestToolStripMenuItem_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miWindowClose,
            this.miWindowCascade,
            this.miWindowHorizontal,
            this.miWindowVertical});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(50, 20);
            this.mnuWindow.Text = "창(&W)";
            // 
            // miWindowClose
            // 
            this.miWindowClose.Name = "miWindowClose";
            this.miWindowClose.Size = new System.Drawing.Size(166, 22);
            this.miWindowClose.Text = "창 닫기";
            this.miWindowClose.Click += new System.EventHandler(this.miWindowClose_Click);
            // 
            // miWindowCascade
            // 
            this.miWindowCascade.Name = "miWindowCascade";
            this.miWindowCascade.Size = new System.Drawing.Size(166, 22);
            this.miWindowCascade.Text = "계단식 정렬";
            this.miWindowCascade.Click += new System.EventHandler(this.miWindowCascade_Click);
            // 
            // miWindowHorizontal
            // 
            this.miWindowHorizontal.Name = "miWindowHorizontal";
            this.miWindowHorizontal.Size = new System.Drawing.Size(166, 22);
            this.miWindowHorizontal.Text = "수평 바둑판 정렬";
            this.miWindowHorizontal.Click += new System.EventHandler(this.miWindowHorizontal_Click);
            // 
            // miWindowVertical
            // 
            this.miWindowVertical.Name = "miWindowVertical";
            this.miWindowVertical.Size = new System.Drawing.Size(166, 22);
            this.miWindowVertical.Text = "수직 바둑판 정렬";
            this.miWindowVertical.Click += new System.EventHandler(this.miWindowVertical_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(72, 20);
            this.mnuHelp.Text = "도움말(&H)";
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.miAbout.Size = new System.Drawing.Size(186, 22);
            this.miAbout.Text = "프로그램 정보(&A)";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.sslTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 329);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(527, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel1.Text = "작성자 : 박용준";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(422, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // sslTime
            // 
            this.sslTime.Name = "sslTime";
            this.sslTime.Size = new System.Drawing.Size(0, 17);
            this.sslTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAbout,
            this.toolStripMenuItem2,
            this.cmsExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 54);
            // 
            // cmsAbout
            // 
            this.cmsAbout.Name = "cmsAbout";
            this.cmsAbout.Size = new System.Drawing.Size(150, 22);
            this.cmsAbout.Text = "프로그램 정보";
            this.cmsAbout.Click += new System.EventHandler(this.cmsAbout_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 6);
            // 
            // cmsExit
            // 
            this.cmsExit.Name = "cmsExit";
            this.cmsExit.Size = new System.Drawing.Size(150, 22);
            this.cmsExit.Text = "끝내기";
            this.cmsExit.Click += new System.EventHandler(this.cmsExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "마이윈폼";
            this.notifyIcon1.BalloonTipTitle = "마이윈폼";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "마이윈폼";
            this.notifyIcon1.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 351);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuControl;
        private System.Windows.Forms.ToolStripMenuItem miCommonControl;
        private System.Windows.Forms.ToolStripMenuItem miButton;
        private System.Windows.Forms.ToolStripMenuItem miContainer;
        private System.Windows.Forms.ToolStripMenuItem miData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cmsExit;
        private System.Windows.Forms.ToolStripMenuItem miLable;
        private System.Windows.Forms.ToolStripMenuItem miCheckBoxRadioButton;
        private System.Windows.Forms.ToolStripMenuItem miTextBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem miMessageBox;
        private System.Windows.Forms.ToolStripMenuItem miComboListBox;
        private System.Windows.Forms.ToolStripMenuItem miGroupBox;
        private System.Windows.Forms.ToolStripMenuItem miDialogResult;
        private System.Windows.Forms.ToolStripMenuItem 대화상자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miFont;
        private System.Windows.Forms.ToolStripMenuItem miFileFolder;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem miNotepad;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel sslTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem miExplorer;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem miWindowClose;
        private System.Windows.Forms.ToolStripMenuItem miWindowCascade;
        private System.Windows.Forms.ToolStripMenuItem miWindowHorizontal;
        private System.Windows.Forms.ToolStripMenuItem miWindowVertical;
        private System.Windows.Forms.ToolStripMenuItem miCheckedListBox;
        private System.Windows.Forms.ToolStripMenuItem miImageViewer;
        private System.Windows.Forms.ToolStripMenuItem miTabControl;
        private System.Windows.Forms.ToolStripMenuItem miToolTip;
        private System.Windows.Forms.ToolStripMenuItem wcfSumServiceTestToolStripMenuItem;
    }
}