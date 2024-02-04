using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CSharp_Windows
{
    /// <summary>
    /// FrmMain에 대한 요약 설명입니다.
    /// </summary>
    public class FrmMain : System.Windows.Forms.Form
    {
        private System.Windows.Forms.MenuStrip myMainMenu;
        private System.Windows.Forms.MenuStrip miFile;
        private System.Windows.Forms.MenuStrip miWindow;
        private System.Windows.Forms.MenuStrip miExit;
        private System.Windows.Forms.MenuStrip miControl;
        private System.Windows.Forms.MenuStrip miPictureBoxContorl;
        private System.Windows.Forms.MenuStrip miMainMenuControl;
        private System.Windows.Forms.MenuStrip miBasicControl;
        private System.Windows.Forms.MenuStrip miInformation;
        private System.Windows.Forms.MenuStrip miCascade;
        private System.Windows.Forms.MenuStrip miHorizontal;
        private System.Windows.Forms.MenuStrip miVertical;
        private System.Windows.Forms.MenuStrip miIcon;
        private System.Windows.Forms.MenuStrip menuItem4;
        private System.Windows.Forms.MenuStrip menuItem9;
        private System.Windows.Forms.MenuStrip miHelp;
        private System.Windows.Forms.MenuStrip miEdit;
        private System.Windows.Forms.MenuStrip miEditUndo;
        private System.Windows.Forms.MenuStrip miEditCut;
        private System.Windows.Forms.MenuStrip miEditCopy;
        private System.Windows.Forms.MenuStrip miEditPaste;
        private System.Windows.Forms.MenuStrip miEditDelete;
        private System.Windows.Forms.MenuStrip miEditSelectAll;
        private System.Windows.Forms.MenuStrip miContorlFrmEditMemu;
        private System.Windows.Forms.MenuStrip miControlFrmListBox;
        private System.Windows.Forms.MenuStrip menuItem1;
        private System.Windows.Forms.MenuStrip menuItem2;
        private System.Windows.Forms.ToolStripStatusLabel statusBar1;
        private System.Windows.Forms.StatusStrip statusBarPanel1;
        private System.Windows.Forms.StatusStrip statusBarPanel2;
        private System.Windows.Forms.StatusStrip statusBarPanel3;
        private System.Windows.Forms.MenuStrip menuItem3;
        private System.Windows.Forms.ToolStrip toolBar1;
        private System.Windows.Forms.ToolStripButton toolBarButton1;
        private System.Windows.Forms.ToolStripButton toolBarButton2;
        private System.Windows.Forms.ToolStripButton toolBarButton3;
        private System.Windows.Forms.ToolStripButton toolBarButton4;
        private System.Windows.Forms.ToolStripButton toolBarButton5;
        private System.Windows.Forms.ToolStripButton toolBarButton6;
        private System.Windows.Forms.MenuStrip menuItem5;
        private System.Windows.Forms.MenuStrip menuItem6;
        private System.Windows.Forms.MenuStrip menuItem7;
        private System.Windows.Forms.MenuStrip menuItem8;
        private System.Windows.Forms.MenuStrip menuItem10;
        private System.Windows.Forms.ContextMenuStrip myContextMenu;
        private System.Windows.Forms.MenuStrip menuItem11;
        private System.Windows.Forms.MenuStrip menuItem12;
        private System.Windows.Forms.MenuStrip menuItem13;
        private System.Windows.Forms.NotifyIcon myNotifyIcon;
        private System.Windows.Forms.MenuStrip menuItem14;
        private System.Windows.Forms.MenuStrip menuItem15;
        private System.Windows.Forms.MenuStrip menuItem16;
        private System.Windows.Forms.MenuStrip menuItem17;
        private System.Windows.Forms.MenuStrip menuItem18;
        private System.Windows.Forms.MenuStrip menuItem19;
        private System.Windows.Forms.MenuStrip menuItem20;
        private System.Windows.Forms.MenuStrip menuItem21;
        private System.Windows.Forms.MenuStrip menuItem22;
        private System.Windows.Forms.MenuStrip menuItem23;
        private System.Windows.Forms.MenuStrip menuItem24;
        private System.Windows.Forms.MenuStrip menuItem25;
        private System.Windows.Forms.MenuStrip menuItem26;
        private System.Windows.Forms.MenuStrip menuItem27;
        private System.Windows.Forms.MenuStrip menuItem28;
        private System.Windows.Forms.MenuStrip menuItem29;
        private System.Windows.Forms.MenuStrip menuItem30;
        private System.Windows.Forms.MenuStrip menuItem31;
        private System.Windows.Forms.MenuStrip menuItem32;
        private System.Windows.Forms.MenuStrip menuItem33;
        private System.Windows.Forms.MenuStrip menuItem34;
        private System.Windows.Forms.MenuStrip menuItem35;
        private System.Windows.Forms.MenuStrip menuItem36;
        private System.Windows.Forms.MenuStrip menuItem37;
        private System.Windows.Forms.MenuStrip menuItem38;
        private System.Windows.Forms.MenuStrip miBasic;
        private System.Windows.Forms.MenuStrip miBasicWrite;
        private System.Windows.Forms.MenuStrip miBasicList;
        private System.Windows.Forms.MenuStrip miBasicView;
        private System.Windows.Forms.MenuStrip miBasicModify;
        private System.Windows.Forms.MenuStrip miBasicDelete;
        private System.Windows.Forms.MenuStrip miBasicSearch;
        private System.Windows.Forms.MenuStrip menuItem39;
        private System.Windows.Forms.MenuStrip miMessageBoxCreater;
        private System.ComponentModel.IContainer components;

        public FrmMain()
        {
            //
            // Windows Form 디자이너 지원에 필요합니다.
            //
            InitializeComponent();
            //
            // TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
            //
        }

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.myMainMenu = new System.Windows.Forms.MenuStrip(); 
            this.miFile = new System.Windows.Forms.MenuStrip();
            this.miExit = new System.Windows.Forms.MenuStrip();
            this.miEdit = new System.Windows.Forms.MenuStrip();
            this.miEditUndo = new System.Windows.Forms.MenuStrip();
            this.menuItem4 = new System.Windows.Forms.MenuStrip();
            this.miEditCut = new System.Windows.Forms.MenuStrip();
            this.miEditCopy = new System.Windows.Forms.MenuStrip();
            this.miEditPaste = new System.Windows.Forms.MenuStrip();
            this.miEditDelete = new System.Windows.Forms.MenuStrip();
            this.menuItem9 = new System.Windows.Forms.MenuStrip();
            this.miEditSelectAll = new System.Windows.Forms.MenuStrip();
            this.miControl = new System.Windows.Forms.MenuStrip();
            this.miBasicControl = new System.Windows.Forms.MenuStrip();
            this.miPictureBoxContorl = new System.Windows.Forms.MenuStrip();
            this.miMainMenuControl = new System.Windows.Forms.MenuStrip();
            this.miContorlFrmEditMemu = new System.Windows.Forms.MenuStrip();
            this.miControlFrmListBox = new System.Windows.Forms.MenuStrip();
            this.menuItem1 = new System.Windows.Forms.MenuStrip();
            this.menuItem2 = new System.Windows.Forms.MenuStrip();
            this.menuItem3 = new System.Windows.Forms.MenuStrip();
            this.menuItem5 = new System.Windows.Forms.MenuStrip();
            this.menuItem6 = new System.Windows.Forms.MenuStrip();
            this.menuItem7 = new System.Windows.Forms.MenuStrip();
            this.menuItem8 = new System.Windows.Forms.MenuStrip();
            this.menuItem10 = new System.Windows.Forms.MenuStrip();
            this.menuItem14 = new System.Windows.Forms.MenuStrip();
            this.menuItem15 = new System.Windows.Forms.MenuStrip();
            this.menuItem16 = new System.Windows.Forms.MenuStrip();
            this.menuItem17 = new System.Windows.Forms.MenuStrip();
            this.menuItem18 = new System.Windows.Forms.MenuStrip();
            this.menuItem19 = new System.Windows.Forms.MenuStrip();
            this.menuItem20 = new System.Windows.Forms.MenuStrip();
            this.menuItem21 = new System.Windows.Forms.MenuStrip();
            this.menuItem22 = new System.Windows.Forms.MenuStrip();
            this.menuItem23 = new System.Windows.Forms.MenuStrip();
            this.menuItem24 = new System.Windows.Forms.MenuStrip();
            this.menuItem25 = new System.Windows.Forms.MenuStrip();
            this.menuItem26 = new System.Windows.Forms.MenuStrip();
            this.menuItem27 = new System.Windows.Forms.MenuStrip();
            this.menuItem28 = new System.Windows.Forms.MenuStrip();
            this.menuItem29 = new System.Windows.Forms.MenuStrip();
            this.menuItem30 = new System.Windows.Forms.MenuStrip();
            this.menuItem31 = new System.Windows.Forms.MenuStrip();
            this.menuItem32 = new System.Windows.Forms.MenuStrip();
            this.menuItem34 = new System.Windows.Forms.MenuStrip();
            this.menuItem35 = new System.Windows.Forms.MenuStrip();
            this.menuItem33 = new System.Windows.Forms.MenuStrip();
            this.menuItem39 = new System.Windows.Forms.MenuStrip();
            this.miMessageBoxCreater = new System.Windows.Forms.MenuStrip();
            this.menuItem36 = new System.Windows.Forms.MenuStrip();
            this.menuItem37 = new System.Windows.Forms.MenuStrip();
            this.menuItem38 = new System.Windows.Forms.MenuStrip();
            this.miBasic = new System.Windows.Forms.MenuStrip();
            this.miBasicWrite = new System.Windows.Forms.MenuStrip();
            this.miBasicList = new System.Windows.Forms.MenuStrip();
            this.miBasicView = new System.Windows.Forms.MenuStrip();
            this.miBasicModify = new System.Windows.Forms.MenuStrip();
            this.miBasicDelete = new System.Windows.Forms.MenuStrip();
            this.miBasicSearch = new System.Windows.Forms.MenuStrip();
            this.miWindow = new System.Windows.Forms.MenuStrip();
            this.miCascade = new System.Windows.Forms.MenuStrip();
            this.miHorizontal = new System.Windows.Forms.MenuStrip();
            this.miVertical = new System.Windows.Forms.MenuStrip();
            this.miIcon = new System.Windows.Forms.MenuStrip();
            this.miHelp = new System.Windows.Forms.MenuStrip();
            this.miInformation = new System.Windows.Forms.MenuStrip();
            this.statusBar1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarPanel1 = new System.Windows.Forms.StatusStrip();
            this.statusBarPanel2 = new System.Windows.Forms.StatusStrip();
            this.statusBarPanel3 = new System.Windows.Forms.StatusStrip();
            this.toolBar1 = new System.Windows.Forms.ToolStrip();
            this.toolBarButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolBarButton6 = new System.Windows.Forms.ToolStripButton();
            this.myContextMenu = new System.Windows.Forms.ContextMenuStrip();
            this.menuItem11 = new System.Windows.Forms.MenuStrip();
            this.menuItem12 = new System.Windows.Forms.MenuStrip();
            this.menuItem13 = new System.Windows.Forms.MenuStrip();
            this.myNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
            this.SuspendLayout();
            //// 
            //// myMainMenu
            //// 
            //this.myMainMenu.MenuStrips.AddRange(new System.Windows.Forms.MenuStrip[] {
            //this.miFile,
            //this.miEdit,
            //this.miControl,
            //this.menuItem39,
            //this.menuItem36,
            //this.miWindow,
            //this.miHelp});
            //// 
            //// miFile
            //// 
            //this.miFile.Index = 0;
            //this.miFile.MenuStrips.AddRange(new System.Windows.Forms.MenuStrip[] {
            //this.miExit});
            //this.miFile.Text = "파일(&F)";
            //// 
            //// miExit
            //// 
            //this.miExit.Index = 0;
            //this.miExit.Text = "끝내기(&X)";
            //this.miExit.Click += new System.EventHandler(this.miExit_Click);
            //// 
            //// miEdit
            //// 
            //this.miEdit.Index = 1;
            //this.miEdit.MenuStrips.AddRange(new System.Windows.Forms.MenuStrip[] {
            //this.miEditUndo,
            //this.menuItem4,
            //this.miEditCut,
            //this.miEditCopy,
            //this.miEditPaste,
            //this.miEditDelete,
            //this.menuItem9,
            //this.miEditSelectAll});
            //this.miEdit.Text = "편집(&E)";
            //// 
            //// miEditUndo
            //// 
            //this.miEditUndo.Enabled = false;
            //this.miEditUndo.Index = 0;
            //this.miEditUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            //this.miEditUndo.Text = "실행 취소(&U)";
            //this.miEditUndo.Click += new System.EventHandler(this.miEditUndo_Click);
            //// 
            //// menuItem4
            //// 
            //this.menuItem4.Index = 1;
            //this.menuItem4.Text = "-";
            //// 
            //// miEditCut
            //// 
            //this.miEditCut.Enabled = false;
            //this.miEditCut.Index = 2;
            //this.miEditCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            //this.miEditCut.Text = "잘라내기(&T)";
            //this.miEditCut.Click += new System.EventHandler(this.miEditCut_Click);
            //// 
            //// miEditCopy
            //// 
            //this.miEditCopy.Enabled = false;
            //this.miEditCopy.Index = 3;
            //this.miEditCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            //this.miEditCopy.Text = "복사(&C)";
            //this.miEditCopy.Click += new System.EventHandler(this.miEditCopy_Click);
            //// 
            //// miEditPaste
            //// 
            //this.miEditPaste.Enabled = false;
            //this.miEditPaste.Index = 4;
            //this.miEditPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            //this.miEditPaste.Text = "붙여넣기(&P)";
            //this.miEditPaste.Click += new System.EventHandler(this.miEditPaste_Click);
            //// 
            //// miEditDelete
            //// 
            //this.miEditDelete.Enabled = false;
            //this.miEditDelete.Index = 5;
            //this.miEditDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
            //this.miEditDelete.Text = "삭제(&L)";
            //this.miEditDelete.Click += new System.EventHandler(this.miEditDelete_Click);
            //// 
            //// menuItem9
            //// 
            //this.menuItem9.Index = 6;
            //this.menuItem9.Text = "-";
            //// 
            //// miEditSelectAll
            //// 
            //this.miEditSelectAll.Enabled = false;
            //this.miEditSelectAll.Index = 7;
            //this.miEditSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            //this.miEditSelectAll.Text = "모두 선택(&A)";
            //this.miEditSelectAll.Click += new System.EventHandler(this.miEditSelectAll_Click);
            //// 
            //// miControl
            //// 
            //this.miControl.Index = 2;
            //this.miControl.MenuStrips.AddRange(new System.Windows.Forms.MenuStrip[] {
            //this.miBasicControl,
            //this.miPictureBoxContorl,
            //this.miMainMenuControl,
            //this.miContorlFrmEditMemu,
            //this.miControlFrmListBox,
            //this.menuItem1,
            //this.menuItem2,
            //this.menuItem3,
            //this.menuItem5,
            //this.menuItem6,
            //this.menuItem7,
            //this.menuItem8,
            //this.menuItem10,
            //this.menuItem14,
            //this.menuItem15,
            //this.menuItem16,
            //this.menuItem17,
            //this.menuItem18,
            //this.menuItem19,
            //this.menuItem20,
            //this.menuItem21,
            //this.menuItem22,
            //this.menuItem23,
            //this.menuItem24,
            //this.menuItem25,
            //this.menuItem26,
            //this.menuItem27,
            //this.menuItem33});
            //this.miControl.Text = "컨트롤(&C)";
            //// 
            //// miBasicControl
            //// 
            //this.miBasicControl.Index = 0;
            //this.miBasicControl.Text = "기본컨트롤";
            //this.miBasicControl.Click += new System.EventHandler(this.miBasicControl_Click);
            //// 
            //// miPictureBoxContorl
            //// 
            //this.miPictureBoxContorl.Index = 1;
            //this.miPictureBoxContorl.Text = "픽처박스 컨트롤";
            //this.miPictureBoxContorl.Click += new System.EventHandler(this.miPictureBoxContorl_Click);
            //// 
            //// miMainMenuControl
            //// 
            //this.miMainMenuControl.Index = 2;
            //this.miMainMenuControl.Text = "메인메뉴 컨트롤";
            //// 
            //// miContorlFrmEditMemu
            //// 
            //this.miContorlFrmEditMemu.Index = 3;
            //this.miContorlFrmEditMemu.Text = "편집메뉴 처리";
            //this.miContorlFrmEditMemu.Click += new System.EventHandler(this.miContorlFrmEditMemu_Click);
            //// 
            //// miControlFrmListBox
            //// 
            //this.miControlFrmListBox.Index = 4;
            //this.miControlFrmListBox.Text = "리스트박스 컨트롤";
            //this.miControlFrmListBox.Click += new System.EventHandler(this.miControlFrmListBox_Click);
            //// 
            //// menuItem1
            //// 
            //this.menuItem1.Index = 5;
            //this.menuItem1.Text = "체크드리스트박스 컨트롤";
            //this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            //// 
            //// menuItem2
            //// 
            //this.menuItem2.Index = 6;
            //this.menuItem2.Text = "상태표시줄";
            //this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            //// 
            //// menuItem3
            //// 
            //this.menuItem3.Index = 7;
            //this.menuItem3.Text = "도구모음 컨트롤";
            //this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            //// 
            //// menuItem5
            //// 
            //this.menuItem5.Index = 8;
            //this.menuItem5.Text = "뉴머릭업다운 컨트롤";
            //this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            //// 
            //// menuItem6
            //// 
            //this.menuItem6.Index = 9;
            //this.menuItem6.Text = "스크롤바 컨트롤";
            //this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            //// 
            //// menuItem7
            //// 
            //this.menuItem7.Index = 10;
            //this.menuItem7.Text = "트랙바 컨트롤";
            //this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            //// 
            //// menuItem8
            //// 
            //this.menuItem8.Index = 11;
            //this.menuItem8.Text = "컨텍스트메뉴 컨트롤";
            //this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            //// 
            //// menuItem10
            //// 
            //this.menuItem10.Index = 12;
            //this.menuItem10.Text = "노우터파이아이콘 컨트롤";
            //this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            //// 
            //// menuItem14
            //// 
            //this.menuItem14.Index = 13;
            //this.menuItem14.Text = "탭 컨트롤";
            //this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            //// 
            //// menuItem15
            //// 
            //this.menuItem15.Index = 14;
            //this.menuItem15.Text = "트리뷰 컨트롤";
            //this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
            //// 
            //// menuItem16
            //// 
            //this.menuItem16.Index = 15;
            //this.menuItem16.Text = "리스트뷰 컨트롤";
            //this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
            //// 
            //// menuItem17
            //// 
            //this.menuItem17.Index = 16;
            //this.menuItem17.Text = "도구모음 컨트롤(이벤트)";
            //this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
            //// 
            //// menuItem18
            //// 
            //this.menuItem18.Index = 17;
            //this.menuItem18.Text = "타이머 컨트롤";
            //this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
            //// 
            //// menuItem19
            //// 
            //this.menuItem19.Index = 18;
            //this.menuItem19.Text = "헬프프로바이더 컨트롤";
            //this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
            //// 
            //// menuItem20
            //// 
            //this.menuItem20.Index = 19;
            //this.menuItem20.Text = "툴팁 컨트롤";
            //this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
            //// 
            //// menuItem21
            //// 
            //this.menuItem21.Index = 20;
            //this.menuItem21.Text = "리치텍스트박스 컨트롤";
            //this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
            //// 
            //// menuItem22
            //// 
            //this.menuItem22.Index = 21;
            //this.menuItem22.Text = "프로그레스바 컨트롤";
            //this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
            //// 
            //// menuItem23
            //// 
            //this.menuItem23.Index = 22;
            //this.menuItem23.Text = "에러프로바이더 컨트롤";
            //this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
            //// 
            //// menuItem24
            //// 
            //this.menuItem24.Index = 23;
            //this.menuItem24.Text = "데이트타임픽커 컨트롤";
            //this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
            //// 
            //// menuItem25
            //// 
            //this.menuItem25.Index = 24;
            //this.menuItem25.Text = "크리스탈레포트뷰어 컨트롤";
            //this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
            //// 
            //// menuItem26
            //// 
            //this.menuItem26.Index = 25;
            //this.menuItem26.Text = "먼쓰캘린더 컨트롤";
            //this.menuItem26.Click += new System.EventHandler(this.menuItem26_Click);
            //// 
            //// menuItem27
            //// 
            //this.menuItem27.Index = 26;
            //this.menuItem27.MenuStrips.AddRange(new System.Windows.Forms.MenuStrip[] {
            //this.menuItem28,
            //this.menuItem29,
            //this.menuItem30,
            //this.menuItem31,
            //this.menuItem32,
            //this.menuItem34,
            //this.menuItem35});
            //this.menuItem27.Text = "다이얼로그 컨트롤";
            //// 
            //// menuItem28
            //// 
            //this.menuItem28.Index = 0;
            //this.menuItem28.Text = "오픈파일다이얼로그";
            //this.menuItem28.Click += new System.EventHandler(this.menuItem28_Click);
            //// 
            //// menuItem29
            //// 
            //this.menuItem29.Index = 1;
            //this.menuItem29.Text = "세이브파일다이얼로그";
            //this.menuItem29.Click += new System.EventHandler(this.menuItem29_Click);
            //// 
            //// menuItem30
            //// 
            //this.menuItem30.Index = 2;
            //this.menuItem30.Text = "폰트다이얼로그";
            //this.menuItem30.Click += new System.EventHandler(this.menuItem30_Click);
            //// 
            //// menuItem31
            //// 
            //this.menuItem31.Index = 3;
            //this.menuItem31.Text = "컬러다이얼로그";
            //this.menuItem31.Click += new System.EventHandler(this.menuItem31_Click);
            //// 
            //// menuItem32
            //// 
            //this.menuItem32.Index = 4;
            //this.menuItem32.Text = "프린트다이얼로그";
            //this.menuItem32.Click += new System.EventHandler(this.menuItem32_Click);
            //// 
            //// menuItem34
            //// 
            //this.menuItem34.Index = 5;
            //this.menuItem34.Text = "페이지셋업다이얼로그";
            //this.menuItem34.Click += new System.EventHandler(this.menuItem34_Click);
            //// 
            //// menuItem35
            //// 
            //this.menuItem35.Index = 6;
            //this.menuItem35.Text = "폴더브라우저다이얼로그";
            //this.menuItem35.Click += new System.EventHandler(this.menuItem35_Click);
            //// 
            //// menuItem33
            //// 
            //this.menuItem33.Index = 27;
            //this.menuItem33.Text = "데이터그리드 컨트롤";
            //this.menuItem33.Click += new System.EventHandler(this.menuItem33_Click);
            //// 
            //// menuItem39
            //// 
            //this.menuItem39.Index = 3;
            //this.menuItem39.MenuStrips.AddRange(new System.Windows.Forms.MenuStrip[] {
            //this.miMessageBoxCreater});
            //this.menuItem39.Text = "응용프로그램(&A)";
            //// 
            //// miMessageBoxCreater
            //// 
            //this.miMessageBoxCreater.Index = 0;
            //this.miMessageBoxCreater.Text = "메시지박스 생성기";
            //this.miMessageBoxCreater.Click += new System.EventHandler(this.miMessageBoxCreater_Click);
            //// 
            //// menuItem36
            //// 
            //this.menuItem36.Index = 4;
            //this.menuItem36.MenuStrips.AddRange(new System.Windows.Forms.MenuStrip[] {
            //this.menuItem37,
            //this.menuItem38,
            //this.miBasic});
            //this.menuItem36.Text = "데이터베이스(&D)";
            // 
            // menuItem37
            // 
            //this.menuItem37.Index = 0;
            this.menuItem37.Text = "데이터베이스연결 및 종료";
            this.menuItem37.Click += new System.EventHandler(this.menuItem37_Click);
            // 
            // menuItem38
            // 
            //this.menuItem38.Index = 1;
            this.menuItem38.Text = "컨트롤 바인딩";
            this.menuItem38.Click += new System.EventHandler(this.menuItem38_Click);
            // 
            // miBasic
            // 
            //this.miBasic.Index = 2;
            //this.miBasic.MenuStrips.AddRange(new System.Windows.Forms.MenuStrip[] {
            //this.miBasicWrite,
            //this.miBasicList,
            //this.miBasicView,
            //this.miBasicModify,
            //this.miBasicDelete,
            //this.miBasicSearch});
            this.miBasic.Text = "기본형게시판";
            // 
            // miBasicWrite
            // 
            //this.miBasicWrite.Index = 0;
            this.miBasicWrite.Text = "입력";
            // 
            // miBasicList
            // 
            //this.miBasicList.Index = 1;
            this.miBasicList.Text = "출력";
            // 
            // miBasicView
            // 
            //this.miBasicView.Index = 2;
            this.miBasicView.Text = "상세";
            // 
            // miBasicModify
            // 
            //this.miBasicModify.Index = 3;
            this.miBasicModify.Text = "수정";
            //// 
            //// miBasicDelete
            //// 
            //this.miBasicDelete.Index = 4;
            //this.miBasicDelete.Text = "삭제";
            //// 
            //// miBasicSearch
            //// 
            //this.miBasicSearch.Index = 5;
            //this.miBasicSearch.Text = "검색";
            //// 
            //// miWindow
            //// 
            //this.miWindow.Index = 5;
            //this.miWindow.MdiList = true;
            //this.miWindow.MenuStrips.AddRange(new System.Windows.Forms.MenuStrip[] {
            //this.miCascade,
            //this.miHorizontal,
            //this.miVertical,
            //this.miIcon});
            //this.miWindow.Text = "창(&W)";
            //// 
            //// miCascade
            //// 
            //this.miCascade.Index = 0;
            //this.miCascade.Text = "계단식";
            //this.miCascade.Click += new System.EventHandler(this.miCascade_Click);
            //// 
            //// miHorizontal
            //// 
            //this.miHorizontal.Index = 1;
            //this.miHorizontal.Text = "수평 배열";
            //this.miHorizontal.Click += new System.EventHandler(this.miHorizontal_Click);
            //// 
            //// miVertical
            //// 
            //this.miVertical.Index = 2;
            //this.miVertical.Text = "수직 배열";
            //this.miVertical.Click += new System.EventHandler(this.miVertical_Click);
            //// 
            //// miIcon
            //// 
            //this.miIcon.Index = 3;
            //this.miIcon.Text = "아이콘 정렬";
            //this.miIcon.Click += new System.EventHandler(this.miIcon_Click);
            //// 
            //// miHelp
            //// 
            //this.miHelp.Index = 6;
            //this.miHelp.MenuStrips.AddRange(new System.Windows.Forms.MenuStrip[] {
            //this.miInformation});
            //this.miHelp.Text = "도움말(&H)";
            //// 
            //// miInformation
            //// 
            //this.miInformation.Index = 0;
            //this.miInformation.Text = "프로그램 정보(&A)...";
            //this.miInformation.Click += new System.EventHandler(this.miInformation_Click);
            //// 
            //// statusBar1
            //// 
            //this.statusBar1.Location = new System.Drawing.Point(0, 529);
            //this.statusBar1.Name = "statusBar1";
            //this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusStrip[] {
            //this.statusBarPanel1,
            //this.statusBarPanel2,
            //this.statusBarPanel3});
            //this.statusBar1.ShowPanels = true;
            //this.statusBar1.Size = new System.Drawing.Size(686, 22);
            //this.statusBar1.SizingGrip = false;
            //this.statusBar1.TabIndex = 1;
            //this.statusBar1.Text = "statusBar1";
            //// 
            //// statusBarPanel1
            //// 
            //this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusStripAutoSize.Spring;
            //this.statusBarPanel1.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanel1.Icon")));
            //this.statusBarPanel1.Name = "statusBarPanel1";
            //this.statusBarPanel1.Width = 486;
            //// 
            //// statusBarPanel2
            //// 
            //this.statusBarPanel2.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanel2.Icon")));
            //this.statusBarPanel2.Name = "statusBarPanel2";
            //// 
            //// statusBarPanel3
            //// 
            //this.statusBarPanel3.Icon = ((System.Drawing.Icon)(resources.GetObject("statusBarPanel3.Icon")));
            //this.statusBarPanel3.Name = "statusBarPanel3";
            //// 
            //// toolBar1
            //// 
            //this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolStripButton[] {
            //this.toolBarButton1,
            //this.toolBarButton2,
            //this.toolBarButton3,
            //this.toolBarButton4,
            //this.toolBarButton5,
            //this.toolBarButton6});
            //this.toolBar1.DropDownArrows = true;
            //this.toolBar1.Location = new System.Drawing.Point(0, 0);
            //this.toolBar1.Name = "toolBar1";
            //this.toolBar1.ShowToolTips = true;
            //this.toolBar1.Size = new System.Drawing.Size(686, 41);
            //this.toolBar1.TabIndex = 3;
            //this.toolBar1.ButtonClick += new System.Windows.Forms.ToolStripButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Text = "끝내기";
            this.toolBarButton1.ToolTipText = "끝내기";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.Name = "toolBarButton3";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.Name = "toolBarButton4";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.Name = "toolBarButton5";
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.Name = "toolBarButton6";
            this.toolBarButton6.Text = "프로그램 정보";
            this.toolBarButton6.ToolTipText = "프로그램 정보";
            //// 
            //// myContextMenu
            //// 
            //this.myContextMenu.MenuStrips.AddRange(new System.Windows.Forms.MenuStrip[] {
            //this.menuItem11,
            //this.menuItem12,
            //this.menuItem13});
            //// 
            //// menuItem11
            //// 
            //this.menuItem11.Index = 0;
            //this.menuItem11.Text = "프로그램 정보(&A)";
            //this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            //// 
            //// menuItem12
            //// 
            //this.menuItem12.Index = 1;
            //this.menuItem12.Text = "-";
            //// 
            //// menuItem13
            //// 
            //this.menuItem13.Index = 2;
            //this.menuItem13.Text = "프로그램 종료(&X)";
            //this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            //// 
            //// myNotifyIcon
            //// 
            //this.myNotifyIcon.ContextMenu = this.myContextMenu;
            //this.myNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("myNotifyIcon.Icon")));
            //this.myNotifyIcon.Text = "C# 윈도우 프로그래밍";
            //this.myNotifyIcon.Visible = true;
            //this.myNotifyIcon.DoubleClick += new System.EventHandler(this.myNotifyIcon_DoubleClick);
            // 
            // FrmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 551);
            this.Controls.Add(this.toolBar1);
            ///this.Controls.Add(this.statusBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(300, 300);
            this.MainMenuStrip = this.myMainMenu;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Forms 예제 프로그램";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private void miExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();//끝내기
        }

        private void miPictureBoxContorl_Click(object sender, System.EventArgs e)
        {
            픽처박스.PictureBoxControl pb =
                new 픽처박스.PictureBoxControl();
            pb.MdiParent = this;
            pb.Show();
        }

        private void miBasicControl_Click(object sender, System.EventArgs e)
        {
            레이블과버튼과텍스트박스.LabelButtonTextBox lbt =
                new 레이블과버튼과텍스트박스.LabelButtonTextBox();
            lbt.MdiParent = this;
            lbt.Show();//모달리스 폼
        }

        private void miInformation_Click(object sender, System.EventArgs e)
        {
            링크레이블.FrmLinkLabel fl =
                new 링크레이블.FrmLinkLabel();
            //fl.MdiParent = this;
            fl.ShowDialog();//모달 폼
            fl.Dispose();//리소스 해제
        }

        private void miCascade_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);//계단식 배열
        }

        private void miHorizontal_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);//수평 배열
        }

        private void miVertical_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);//수직 배열
        }

        private void miIcon_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);//아이콘 정렬
        }

        private void miContorlFrmEditMemu_Click(object sender, System.EventArgs e)
        {
            //편집메뉴처리.FrmEditMenu fem = new 편집메뉴처리.FrmEditMenu();
            ////fem.MdiParent = this;
            //fem.ShowDialog();
            //fem.Dispose();
        }

        private void miEditUndo_Click(object sender, System.EventArgs e)
        {
            //TextBox 객체를 하나 생성하고, 이를 ActiveControl로 지정한다.
            TextBox objTextBox = new TextBox();
            //현재 프로그램에서 ActiceControl(활성화된 컨트롤:텍스트 박스) 지정
            objTextBox = (TextBox)this.ActiveControl;
            //활성화된 텍스트 박스의 내용을 취소
            objTextBox.Undo();
        }

        private void miEditCut_Click(object sender, System.EventArgs e)
        {
            TextBox objTextBox = new TextBox();
            objTextBox = (TextBox)this.ActiveControl;
            objTextBox.Cut();
        }

        private void miEditCopy_Click(object sender, System.EventArgs e)
        {
            TextBox objTextBox = new TextBox();
            objTextBox = (TextBox)this.ActiveControl;
            objTextBox.Copy();
        }

        private void miEditPaste_Click(object sender, System.EventArgs e)
        {
            TextBox objTextBox = new TextBox();
            objTextBox = (TextBox)this.ActiveControl;
            objTextBox.Paste();
        }

        private void miEditDelete_Click(object sender, System.EventArgs e)
        {
            TextBox objTextBox = new TextBox();
            objTextBox = (TextBox)this.ActiveControl;
            objTextBox.Cut();
        }

        private void miEditSelectAll_Click(object sender, System.EventArgs e)
        {
            TextBox objTextBox = new TextBox();
            objTextBox = (TextBox)this.ActiveControl;
            objTextBox.SelectAll();
        }

        private void miControlFrmListBox_Click(object sender, System.EventArgs e)
        {
            리스트박스.FrmListBox lb = new 리스트박스.FrmListBox();
            lb.MdiParent = this;
            lb.Show();
        }

        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            체크드리스트박스.FrmCheckedListBox clb =
                new 체크드리스트박스.FrmCheckedListBox();
            clb.MdiParent = this;
            clb.Show();
        }

        private void menuItem2_Click(object sender, System.EventArgs e)
        {
            //상태표시줄.FrmStatusBar sb = new 상태표시줄.FrmStatusBar();
            //sb.MdiParent = this;
            //sb.Show();
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.statusBarPanel1.Text = "완료";
            this.statusBarPanel2.Text = DateTime.Now.ToShortDateString();
            this.statusBarPanel3.Text = DateTime.Now.ToShortTimeString();
            this.Cursor = Cursors.Default;
        }

        //도구 모음
        private void menuItem3_Click(object sender, System.EventArgs e)
        {
            //도구모음.FrmToolBar tb = new 도구모음.FrmToolBar();
            //tb.MdiParent = this;
            //tb.Show();
        }

        ////끝내기 버튼
        //private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolStripButtonClickEventArgs e)
        //{
        //    if (e.Button == this.toolBarButton1)
        //    {
        //        //Application.Exit();	
        //        miExit_Click(null, null);//이미 구현된 이벤트 핸들러 호출
        //    }
        //    else if (e.Button == this.toolBarButton6)
        //    {
        //        this.miInformation_Click(null, null);
        //    }
        //}

        private void menuItem5_Click(object sender, System.EventArgs e)
        {
            뉴머릭업다운.FrmNumericUpDown nud =
                new 뉴머릭업다운.FrmNumericUpDown();
            nud.MdiParent = this;
            nud.Show();
        }

        private void menuItem6_Click(object sender, System.EventArgs e)
        {
            스크롤바.FrmScrollBar sc = new 스크롤바.FrmScrollBar();
            sc.MdiParent = this;
            sc.Show();
        }

        private void menuItem7_Click(object sender, System.EventArgs e)
        {
            트랙바.FrmTrackBar tb = new 트랙바.FrmTrackBar();
            tb.MdiParent = this;
            tb.Show();
        }

        //private void menuItem8_Click(object sender, System.EventArgs e)
        //{
        //    컨텍스트메뉴.FrmContextMenu cm = new 컨텍스트메뉴.FrmContextMenu();
        //    cm.MdiParent = this;
        //    cm.Show();
        //}

        //private void menuItem10_Click(object sender, System.EventArgs e)
        //{
        //    노우터파이아이콘.FrmNotifyIcon ni = new 노우터파이아이콘.FrmNotifyIcon();
        //    ni.MdiParent = this;
        //    ni.Show();
        //}
        //상황 메뉴 : 프로그램 정보
        private void menuItem11_Click(object sender, System.EventArgs e)
        {
            this.miInformation_Click(null, null);
        }
        //상황 메뉴 : 프로그램 종료
        private void menuItem13_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        //트레이 아이콘을 더블클릭했을 때
        private void myNotifyIcon_DoubleClick(object sender, System.EventArgs e)
        {
            MessageBox.Show("예제로 배워보는 컨트롤입니다."
                , "윈도우 폼"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }
        //탭 컨트롤
        private void menuItem14_Click(object sender, System.EventArgs e)
        {
            탭.FrmTabControl t = new 탭.FrmTabControl();
            t.MdiParent = this;
            t.Show();
        }
        //트리뷰 컨트롤
        private void menuItem15_Click(object sender, System.EventArgs e)
        {
            트리뷰.FrmTreeView tv = new 트리뷰.FrmTreeView();
            tv.MdiParent = this;
            tv.Show();
        }
        //리스트뷰 컨트롤
        private void menuItem16_Click(object sender, System.EventArgs e)
        {
            리스트뷰.FrmListView lv = new 리스트뷰.FrmListView();
            lv.MdiParent = this;
            lv.Show();
        }

        //private void menuItem17_Click(object sender, System.EventArgs e)
        //{
        //    도구모음.FrmToolBarEvent tbe = new CSharp_Windows.도구모음.FrmToolBarEvent();
        //    tbe.MdiParent = this;
        //    tbe.Show();
        //}

        private void menuItem18_Click(object sender, System.EventArgs e)
        {
            타이머.FrmTimer t = new CSharp_Windows.타이머.FrmTimer();
            t.MdiParent = this;
            t.Show();
        }

        private void menuItem19_Click(object sender, System.EventArgs e)
        {
            헬프프로바이더.FrmHelpProvider hp = new CSharp_Windows.헬프프로바이더.FrmHelpProvider();
            hp.MdiParent = this;
            hp.Show();
        }

        private void menuItem20_Click(object sender, System.EventArgs e)
        {
            툴팁.FrmToolTip tt = new CSharp_Windows.툴팁.FrmToolTip();
            tt.MdiParent = this;
            tt.Show();
        }

        private void menuItem21_Click(object sender, System.EventArgs e)
        {
            리치텍스트박스.FrmRichTextBox rtb = new CSharp_Windows.리치텍스트박스.FrmRichTextBox();
            rtb.MdiParent = this;
            rtb.Show();
        }

        private void menuItem22_Click(object sender, System.EventArgs e)
        {
            프로그레스바.FrmProgressBar pb = new CSharp_Windows.프로그레스바.FrmProgressBar();
            pb.MdiParent = this;
            pb.Show();
        }

        private void menuItem23_Click(object sender, System.EventArgs e)
        {
            에러프로바이더.FrmErrorProvider ep = new CSharp_Windows.에러프로바이더.FrmErrorProvider();
            ep.MdiParent = this;
            ep.Show();
        }

        private void menuItem24_Click(object sender, System.EventArgs e)
        {
            데이트타임픽커.FrmDateTimePicker dtp = new CSharp_Windows.데이트타임픽커.FrmDateTimePicker();
            dtp.MdiParent = this;
            dtp.Show();
        }

        private void menuItem25_Click(object sender, System.EventArgs e)
        {
        }

        private void menuItem26_Click(object sender, System.EventArgs e)
        {
            먼쓰캘린더.FrmMonthCalendar mc = new CSharp_Windows.먼쓰캘린더.FrmMonthCalendar();
            mc.MdiParent = this;
            mc.Show();
        }

        private void menuItem28_Click(object sender, System.EventArgs e)
        {
            오픈파일다이얼로그.FrmOpenFileDialog ofd = new CSharp_Windows.오픈파일다이얼로그.FrmOpenFileDialog();
            ofd.MdiParent = this;
            ofd.Show();
        }

        private void menuItem29_Click(object sender, System.EventArgs e)
        {
            세이브파일다이얼로그.FrmSaveFileDialog sfd = new CSharp_Windows.세이브파일다이얼로그.FrmSaveFileDialog();
            sfd.MdiParent = this;
            sfd.Show();
        }

        private void menuItem30_Click(object sender, System.EventArgs e)
        {
            폰트다이얼로그.FrmFontDialog fd = new CSharp_Windows.폰트다이얼로그.FrmFontDialog();
            fd.MdiParent = this;
            fd.Show();
        }

        private void menuItem31_Click(object sender, System.EventArgs e)
        {
            컬러다이얼로그.FrmColorDialog cd = new CSharp_Windows.컬러다이얼로그.FrmColorDialog();
            cd.MdiParent = this;
            cd.Show();
        }

        private void menuItem32_Click(object sender, System.EventArgs e)
        {
            프린트다이얼로그.FrmPrintDialog pd = new CSharp_Windows.프린트다이얼로그.FrmPrintDialog();
            pd.MdiParent = this;
            pd.Show();
        }

        //private void menuItem33_Click(object sender, System.EventArgs e)
        //{
        //    데이터그리드.FrmDataGrid dg = new CSharp_Windows.데이터그리드.FrmDataGrid();
        //    dg.MdiParent = this;
        //    dg.Show();
        //}

        private void menuItem34_Click(object sender, System.EventArgs e)
        {
            페이지셋업다이얼로그.FrmPageSetupDialog psd = new CSharp_Windows.페이지셋업다이얼로그.FrmPageSetupDialog();
            psd.MdiParent = this;
            psd.Show();
        }

        private void menuItem35_Click(object sender, System.EventArgs e)
        {
            폴더브라우저다이얼로그.FrmFolderBrowserDialog fbd = new CSharp_Windows.폴더브라우저다이얼로그.FrmFolderBrowserDialog();
            fbd.MdiParent = this;
            fbd.Show();
        }

        private void menuItem37_Click(object sender, System.EventArgs e)
        {
            데이터베이스연결및종료 dbcc = new 데이터베이스연결및종료();
            dbcc.MdiParent = this;
            dbcc.Show();
        }

        private void menuItem38_Click(object sender, System.EventArgs e)
        {
        }

        private void miMessageBoxCreater_Click(object sender, System.EventArgs e)
        {
            메시지박스생성기.MessageBoxCreater mbc = new 메시지박스생성기.MessageBoxCreater();
            mbc.MdiParent = this;
            mbc.Show();
        }
    }
}












