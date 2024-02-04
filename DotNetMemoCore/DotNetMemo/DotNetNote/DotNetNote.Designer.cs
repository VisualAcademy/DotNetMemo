namespace DotNetNote
{
    partial class DotNetNote
    {
        #region Private Members
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #endregion

        #region Protected Methods
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
        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DotNetNote));
            this.mmDotNetNote = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.miSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.miPageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.miSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.miSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.miCut = new System.Windows.Forms.ToolStripMenuItem();
            this.miCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.miPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.miDel = new System.Windows.Forms.ToolStripMenuItem();
            this.miSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.miFind = new System.Windows.Forms.ToolStripMenuItem();
            this.miFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.miReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.miGo = new System.Windows.Forms.ToolStripMenuItem();
            this.miSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.miSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miTimeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.miWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.miFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.miStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.ofdDotNetNote = new System.Windows.Forms.OpenFileDialog();
            this.sfdDotNetNote = new System.Windows.Forms.SaveFileDialog();
            this.fdDotNetNote = new System.Windows.Forms.FontDialog();
            this.pdDotNetNote = new System.Windows.Forms.PrintDialog();
            this.dnnPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.psdDotNetNote = new System.Windows.Forms.PageSetupDialog();
            this.dnnStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dnnPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.mmDotNetNote.SuspendLayout();
            this.dnnStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mmDotNetNote
            // 
            this.mmDotNetNote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuFont,
            this.mnuView,
            this.mnuHelp});
            this.mmDotNetNote.Location = new System.Drawing.Point(0, 0);
            this.mmDotNetNote.Name = "mmDotNetNote";
            this.mmDotNetNote.Size = new System.Drawing.Size(392, 24);
            this.mmDotNetNote.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.miSaveAs,
            this.miSeparator1,
            this.miPreview,
            this.miPageSetup,
            this.miPrint,
            this.miSeparator2,
            this.miExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(57, 20);
            this.mnuFile.Text = "파일(&F)";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miNew.Size = new System.Drawing.Size(203, 22);
            this.miNew.Text = "새로 만들기(&N)";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miOpen.Size = new System.Drawing.Size(203, 22);
            this.miOpen.Text = "열기(&O)...";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSave.Size = new System.Drawing.Size(203, 22);
            this.miSave.Text = "저장(&S)";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miSaveAs
            // 
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.Size = new System.Drawing.Size(203, 22);
            this.miSaveAs.Text = "다른 이름으로 저장(&A)...";
            this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
            // 
            // miSeparator1
            // 
            this.miSeparator1.Name = "miSeparator1";
            this.miSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // miPreview
            // 
            this.miPreview.Name = "miPreview";
            this.miPreview.Size = new System.Drawing.Size(203, 22);
            this.miPreview.Text = "인쇄 미리 보기(&V)";
            this.miPreview.Click += new System.EventHandler(this.miPreview_Click);
            // 
            // miPageSetup
            // 
            this.miPageSetup.Name = "miPageSetup";
            this.miPageSetup.Size = new System.Drawing.Size(203, 22);
            this.miPageSetup.Text = "페이지 설정(&U)...";
            this.miPageSetup.Click += new System.EventHandler(this.miPageSetup_Click);
            // 
            // miPrint
            // 
            this.miPrint.Name = "miPrint";
            this.miPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.miPrint.Size = new System.Drawing.Size(203, 22);
            this.miPrint.Text = "인쇄(&P)...";
            this.miPrint.Click += new System.EventHandler(this.miPrint_Click);
            // 
            // miSeparator2
            // 
            this.miSeparator2.Name = "miSeparator2";
            this.miSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(203, 22);
            this.miExit.Text = "끝내기(&X)";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUndo,
            this.miSeparator3,
            this.miCut,
            this.miCopy,
            this.miPaste,
            this.miDel,
            this.miSeparator4,
            this.miFind,
            this.miFindNext,
            this.miReplace,
            this.miGo,
            this.miSeparator5,
            this.miSelectAll,
            this.miTimeDate});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuEdit.Size = new System.Drawing.Size(57, 20);
            this.mnuEdit.Text = "편집(&E)";
            // 
            // miUndo
            // 
            this.miUndo.Enabled = false;
            this.miUndo.Name = "miUndo";
            this.miUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.miUndo.Size = new System.Drawing.Size(184, 22);
            this.miUndo.Text = "실행 취소(&U)";
            this.miUndo.Click += new System.EventHandler(this.miUndo_Click);
            // 
            // miSeparator3
            // 
            this.miSeparator3.Name = "miSeparator3";
            this.miSeparator3.Size = new System.Drawing.Size(181, 6);
            // 
            // miCut
            // 
            this.miCut.Enabled = false;
            this.miCut.Name = "miCut";
            this.miCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.miCut.Size = new System.Drawing.Size(184, 22);
            this.miCut.Text = "잘라내기(&T)";
            this.miCut.Click += new System.EventHandler(this.miCut_Click);
            // 
            // miCopy
            // 
            this.miCopy.Enabled = false;
            this.miCopy.Name = "miCopy";
            this.miCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.miCopy.Size = new System.Drawing.Size(184, 22);
            this.miCopy.Text = "복사(&C)";
            this.miCopy.Click += new System.EventHandler(this.miCopy_Click);
            // 
            // miPaste
            // 
            this.miPaste.Name = "miPaste";
            this.miPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.miPaste.Size = new System.Drawing.Size(184, 22);
            this.miPaste.Text = "붙여넣기(&P)";
            this.miPaste.Click += new System.EventHandler(this.miPaste_Click);
            // 
            // miDel
            // 
            this.miDel.Enabled = false;
            this.miDel.Name = "miDel";
            this.miDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.miDel.Size = new System.Drawing.Size(184, 22);
            this.miDel.Text = "삭제(&L)";
            this.miDel.Click += new System.EventHandler(this.miDel_Click);
            // 
            // miSeparator4
            // 
            this.miSeparator4.Name = "miSeparator4";
            this.miSeparator4.Size = new System.Drawing.Size(181, 6);
            // 
            // miFind
            // 
            this.miFind.Enabled = false;
            this.miFind.Name = "miFind";
            this.miFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.miFind.Size = new System.Drawing.Size(184, 22);
            this.miFind.Text = "찾기(&F)...";
            this.miFind.Click += new System.EventHandler(this.miFind_Click);
            // 
            // miFindNext
            // 
            this.miFindNext.Enabled = false;
            this.miFindNext.Name = "miFindNext";
            this.miFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.miFindNext.Size = new System.Drawing.Size(184, 22);
            this.miFindNext.Text = "다음 찾기(&N)";
            this.miFindNext.Click += new System.EventHandler(this.miFindNext_Click);
            // 
            // miReplace
            // 
            this.miReplace.Name = "miReplace";
            this.miReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.miReplace.Size = new System.Drawing.Size(184, 22);
            this.miReplace.Text = "바꾸기(&R)...";
            this.miReplace.Click += new System.EventHandler(this.miReplace_Click);
            // 
            // miGo
            // 
            this.miGo.Enabled = false;
            this.miGo.Name = "miGo";
            this.miGo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.miGo.Size = new System.Drawing.Size(184, 22);
            this.miGo.Text = "이동(&G)...";
            this.miGo.Click += new System.EventHandler(this.miGo_Click);
            // 
            // miSeparator5
            // 
            this.miSeparator5.Name = "miSeparator5";
            this.miSeparator5.Size = new System.Drawing.Size(181, 6);
            // 
            // miSelectAll
            // 
            this.miSelectAll.Name = "miSelectAll";
            this.miSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.miSelectAll.Size = new System.Drawing.Size(184, 22);
            this.miSelectAll.Text = "모두 선택(&A)";
            this.miSelectAll.Click += new System.EventHandler(this.miSelectAll_Click);
            // 
            // miTimeDate
            // 
            this.miTimeDate.Name = "miTimeDate";
            this.miTimeDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.miTimeDate.Size = new System.Drawing.Size(184, 22);
            this.miTimeDate.Text = "시간/날짜(&D)";
            this.miTimeDate.Click += new System.EventHandler(this.miTimeDate_Click);
            // 
            // mnuFont
            // 
            this.mnuFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miWordWrap,
            this.miFont});
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.Size = new System.Drawing.Size(60, 20);
            this.mnuFont.Text = "서식(&O)";
            // 
            // miWordWrap
            // 
            this.miWordWrap.Checked = true;
            this.miWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miWordWrap.Name = "miWordWrap";
            this.miWordWrap.Size = new System.Drawing.Size(161, 22);
            this.miWordWrap.Text = "자동 줄 바꿈(&W)";
            this.miWordWrap.Click += new System.EventHandler(this.miWordWrap_Click);
            // 
            // miFont
            // 
            this.miFont.Name = "miFont";
            this.miFont.Size = new System.Drawing.Size(161, 22);
            this.miFont.Text = "글꼴(&F)...";
            this.miFont.Click += new System.EventHandler(this.miFont_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miStatus});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(59, 20);
            this.mnuView.Text = "보기(&V)";
            // 
            // miStatus
            // 
            this.miStatus.Name = "miStatus";
            this.miStatus.Size = new System.Drawing.Size(153, 22);
            this.miStatus.Text = "상태 표시줄(&S)";
            this.miStatus.Click += new System.EventHandler(this.miStatus_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelp,
            this.miSeparator6,
            this.miAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(72, 20);
            this.mnuHelp.Text = "도움말(&H)";
            // 
            // miHelp
            // 
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(155, 22);
            this.miHelp.Text = "도움말 항목(&H)";
            this.miHelp.Click += new System.EventHandler(this.miHelp_Click);
            // 
            // miSeparator6
            // 
            this.miSeparator6.Name = "miSeparator6";
            this.miSeparator6.Size = new System.Drawing.Size(152, 6);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(155, 22);
            this.miAbout.Text = "메모장 정보(&A)";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // txtMain
            // 
            this.txtMain.AllowDrop = true;
            this.txtMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMain.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMain.Location = new System.Drawing.Point(0, 21);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMain.Size = new System.Drawing.Size(392, 220);
            this.txtMain.TabIndex = 1;
            this.txtMain.TextChanged += new System.EventHandler(this.txtMain_TextChanged);
            this.txtMain.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.txtMain_QueryContinueDrag);
            this.txtMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtMain_DragDrop);
            this.txtMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMain_KeyUp);
            this.txtMain.DragOver += new System.Windows.Forms.DragEventHandler(this.txtMain_DragOver);
            // 
            // ofdDotNetNote
            // 
            this.ofdDotNetNote.FileName = "*.txt";
            this.ofdDotNetNote.Filter = "텍스트 문서(.txt)|*.txt|모든 파일|*.*";
            // 
            // sfdDotNetNote
            // 
            this.sfdDotNetNote.FileName = "*.txt";
            this.sfdDotNetNote.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일|*.*";
            // 
            // pdDotNetNote
            // 
            this.pdDotNetNote.Document = this.dnnPrintDocument;
            this.pdDotNetNote.UseEXDialog = true;
            // 
            // dnnPrintDocument
            // 
            this.dnnPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.dnnPrintDocument_PrintPage);
            // 
            // dnnStatusStrip
            // 
            this.dnnStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.dnnStatusStrip.Location = new System.Drawing.Point(0, 244);
            this.dnnStatusStrip.Name = "dnnStatusStrip";
            this.dnnStatusStrip.Size = new System.Drawing.Size(392, 22);
            this.dnnStatusStrip.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(310, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel2.Text = "Ln 1, Col 1";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dnnPrintPreviewDialog
            // 
            this.dnnPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dnnPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dnnPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.dnnPrintPreviewDialog.Enabled = true;
            this.dnnPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("dnnPrintPreviewDialog.Icon")));
            this.dnnPrintPreviewDialog.Name = "printPreviewDialog1";
            this.dnnPrintPreviewDialog.Visible = false;
            // 
            // DotNetNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 266);
            this.Controls.Add(this.dnnStatusStrip);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.mmDotNetNote);
            this.MainMenuStrip = this.mmDotNetNote;
            this.Name = "DotNetNote";
            this.Text = "제목 없음 - 메모장";
            this.Load += new System.EventHandler(this.DotNetNote_Load);
            this.mmDotNetNote.ResumeLayout(false);
            this.mmDotNetNote.PerformLayout();
            this.dnnStatusStrip.ResumeLayout(false);
            this.dnnStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Controls
        private System.Windows.Forms.MenuStrip mmDotNetNote;          // 메인 메뉴(mmMainMenu)
        public System.Windows.Forms.TextBox txtMain;                  // 메인 텍스트박스
        private System.Windows.Forms.ToolStripMenuItem mnuFile;       // 파일
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;       // 편집
        private System.Windows.Forms.ToolStripMenuItem mnuFont;       // 서식
        private System.Windows.Forms.ToolStripMenuItem mnuView;       // 보기
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;       // 도움말

        private System.Windows.Forms.ToolStripMenuItem miNew;         // 새로 만들기 
        private System.Windows.Forms.ToolStripMenuItem miOpen;        // 열기
        private System.Windows.Forms.ToolStripMenuItem miSave;        // 저장
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;      // 다른 이름으로 저장
        private System.Windows.Forms.ToolStripSeparator miSeparator1; // 구분선(이름X)
        private System.Windows.Forms.ToolStripMenuItem miPageSetup;   // 페이지 설정
        private System.Windows.Forms.ToolStripMenuItem miPrint;       // 인쇄
        private System.Windows.Forms.ToolStripSeparator miSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miExit;        // 끝내기
        private System.Windows.Forms.ToolStripMenuItem miUndo;        // 실행 취소
        private System.Windows.Forms.ToolStripSeparator miSeparator3;
        private System.Windows.Forms.ToolStripMenuItem miCut;         // 잘라내기
        private System.Windows.Forms.ToolStripMenuItem miCopy;        // 복사
        private System.Windows.Forms.ToolStripMenuItem miPaste;       // 붙여넣기
        private System.Windows.Forms.ToolStripMenuItem miDel;         // 삭제
        private System.Windows.Forms.ToolStripSeparator miSeparator4;
        private System.Windows.Forms.ToolStripMenuItem miFind;        // 찾기
        private System.Windows.Forms.ToolStripMenuItem miFindNext;    // 다음 찾기
        private System.Windows.Forms.ToolStripMenuItem miReplace;     // 바꾸기
        private System.Windows.Forms.ToolStripMenuItem miGo;          // 이동
        private System.Windows.Forms.ToolStripSeparator miSeparator5;
        private System.Windows.Forms.ToolStripMenuItem miSelectAll;   // 모두 선택
        private System.Windows.Forms.ToolStripMenuItem miTimeDate;    // 시간/날짜
        private System.Windows.Forms.ToolStripMenuItem miWordWrap;    // 자동 줄 바꿈
        private System.Windows.Forms.ToolStripMenuItem miFont;        // 글꼴
        private System.Windows.Forms.ToolStripMenuItem miStatus;      // 상태 표시줄
        private System.Windows.Forms.ToolStripMenuItem miHelp;        // 도움말 보기
        private System.Windows.Forms.ToolStripSeparator miSeparator6;
        private System.Windows.Forms.ToolStripMenuItem miAbout;       // 메모장 정보

        private System.Windows.Forms.OpenFileDialog ofdDotNetNote;
        private System.Windows.Forms.SaveFileDialog sfdDotNetNote;
        private System.Windows.Forms.FontDialog fdDotNetNote;
        private System.Windows.Forms.PrintDialog pdDotNetNote;
        private System.Windows.Forms.PageSetupDialog psdDotNetNote;
        private System.Drawing.Printing.PrintDocument dnnPrintDocument;
        private System.Windows.Forms.StatusStrip dnnStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        #endregion
        private System.Windows.Forms.ToolStripMenuItem miPreview;
        private System.Windows.Forms.PrintPreviewDialog dnnPrintPreviewDialog;
      }
}

