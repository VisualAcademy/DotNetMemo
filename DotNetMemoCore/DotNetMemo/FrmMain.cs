using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CSharp_Windows
{
    /// <summary>
    /// FrmMain�� ���� ��� �����Դϴ�.
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
            // Windows Form �����̳� ������ �ʿ��մϴ�.
            //
            InitializeComponent();
            //
            // TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
            //
        }

        /// <summary>
        /// ��� ���� ��� ���ҽ��� �����մϴ�.
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
        /// �����̳� ������ �ʿ��� �޼����Դϴ�.
        /// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
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
            //this.miFile.Text = "����(&F)";
            //// 
            //// miExit
            //// 
            //this.miExit.Index = 0;
            //this.miExit.Text = "������(&X)";
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
            //this.miEdit.Text = "����(&E)";
            //// 
            //// miEditUndo
            //// 
            //this.miEditUndo.Enabled = false;
            //this.miEditUndo.Index = 0;
            //this.miEditUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            //this.miEditUndo.Text = "���� ���(&U)";
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
            //this.miEditCut.Text = "�߶󳻱�(&T)";
            //this.miEditCut.Click += new System.EventHandler(this.miEditCut_Click);
            //// 
            //// miEditCopy
            //// 
            //this.miEditCopy.Enabled = false;
            //this.miEditCopy.Index = 3;
            //this.miEditCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            //this.miEditCopy.Text = "����(&C)";
            //this.miEditCopy.Click += new System.EventHandler(this.miEditCopy_Click);
            //// 
            //// miEditPaste
            //// 
            //this.miEditPaste.Enabled = false;
            //this.miEditPaste.Index = 4;
            //this.miEditPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            //this.miEditPaste.Text = "�ٿ��ֱ�(&P)";
            //this.miEditPaste.Click += new System.EventHandler(this.miEditPaste_Click);
            //// 
            //// miEditDelete
            //// 
            //this.miEditDelete.Enabled = false;
            //this.miEditDelete.Index = 5;
            //this.miEditDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
            //this.miEditDelete.Text = "����(&L)";
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
            //this.miEditSelectAll.Text = "��� ����(&A)";
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
            //this.miControl.Text = "��Ʈ��(&C)";
            //// 
            //// miBasicControl
            //// 
            //this.miBasicControl.Index = 0;
            //this.miBasicControl.Text = "�⺻��Ʈ��";
            //this.miBasicControl.Click += new System.EventHandler(this.miBasicControl_Click);
            //// 
            //// miPictureBoxContorl
            //// 
            //this.miPictureBoxContorl.Index = 1;
            //this.miPictureBoxContorl.Text = "��ó�ڽ� ��Ʈ��";
            //this.miPictureBoxContorl.Click += new System.EventHandler(this.miPictureBoxContorl_Click);
            //// 
            //// miMainMenuControl
            //// 
            //this.miMainMenuControl.Index = 2;
            //this.miMainMenuControl.Text = "���θ޴� ��Ʈ��";
            //// 
            //// miContorlFrmEditMemu
            //// 
            //this.miContorlFrmEditMemu.Index = 3;
            //this.miContorlFrmEditMemu.Text = "�����޴� ó��";
            //this.miContorlFrmEditMemu.Click += new System.EventHandler(this.miContorlFrmEditMemu_Click);
            //// 
            //// miControlFrmListBox
            //// 
            //this.miControlFrmListBox.Index = 4;
            //this.miControlFrmListBox.Text = "����Ʈ�ڽ� ��Ʈ��";
            //this.miControlFrmListBox.Click += new System.EventHandler(this.miControlFrmListBox_Click);
            //// 
            //// menuItem1
            //// 
            //this.menuItem1.Index = 5;
            //this.menuItem1.Text = "üũ�帮��Ʈ�ڽ� ��Ʈ��";
            //this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            //// 
            //// menuItem2
            //// 
            //this.menuItem2.Index = 6;
            //this.menuItem2.Text = "����ǥ����";
            //this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            //// 
            //// menuItem3
            //// 
            //this.menuItem3.Index = 7;
            //this.menuItem3.Text = "�������� ��Ʈ��";
            //this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            //// 
            //// menuItem5
            //// 
            //this.menuItem5.Index = 8;
            //this.menuItem5.Text = "���Ӹ����ٿ� ��Ʈ��";
            //this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            //// 
            //// menuItem6
            //// 
            //this.menuItem6.Index = 9;
            //this.menuItem6.Text = "��ũ�ѹ� ��Ʈ��";
            //this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            //// 
            //// menuItem7
            //// 
            //this.menuItem7.Index = 10;
            //this.menuItem7.Text = "Ʈ���� ��Ʈ��";
            //this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            //// 
            //// menuItem8
            //// 
            //this.menuItem8.Index = 11;
            //this.menuItem8.Text = "���ؽ�Ʈ�޴� ��Ʈ��";
            //this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            //// 
            //// menuItem10
            //// 
            //this.menuItem10.Index = 12;
            //this.menuItem10.Text = "��������̾����� ��Ʈ��";
            //this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            //// 
            //// menuItem14
            //// 
            //this.menuItem14.Index = 13;
            //this.menuItem14.Text = "�� ��Ʈ��";
            //this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            //// 
            //// menuItem15
            //// 
            //this.menuItem15.Index = 14;
            //this.menuItem15.Text = "Ʈ���� ��Ʈ��";
            //this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
            //// 
            //// menuItem16
            //// 
            //this.menuItem16.Index = 15;
            //this.menuItem16.Text = "����Ʈ�� ��Ʈ��";
            //this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
            //// 
            //// menuItem17
            //// 
            //this.menuItem17.Index = 16;
            //this.menuItem17.Text = "�������� ��Ʈ��(�̺�Ʈ)";
            //this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
            //// 
            //// menuItem18
            //// 
            //this.menuItem18.Index = 17;
            //this.menuItem18.Text = "Ÿ�̸� ��Ʈ��";
            //this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
            //// 
            //// menuItem19
            //// 
            //this.menuItem19.Index = 18;
            //this.menuItem19.Text = "�������ι��̴� ��Ʈ��";
            //this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
            //// 
            //// menuItem20
            //// 
            //this.menuItem20.Index = 19;
            //this.menuItem20.Text = "���� ��Ʈ��";
            //this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
            //// 
            //// menuItem21
            //// 
            //this.menuItem21.Index = 20;
            //this.menuItem21.Text = "��ġ�ؽ�Ʈ�ڽ� ��Ʈ��";
            //this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
            //// 
            //// menuItem22
            //// 
            //this.menuItem22.Index = 21;
            //this.menuItem22.Text = "���α׷����� ��Ʈ��";
            //this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
            //// 
            //// menuItem23
            //// 
            //this.menuItem23.Index = 22;
            //this.menuItem23.Text = "�������ι��̴� ��Ʈ��";
            //this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
            //// 
            //// menuItem24
            //// 
            //this.menuItem24.Index = 23;
            //this.menuItem24.Text = "����ƮŸ����Ŀ ��Ʈ��";
            //this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
            //// 
            //// menuItem25
            //// 
            //this.menuItem25.Index = 24;
            //this.menuItem25.Text = "ũ����Ż����Ʈ��� ��Ʈ��";
            //this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
            //// 
            //// menuItem26
            //// 
            //this.menuItem26.Index = 25;
            //this.menuItem26.Text = "�վ�Ķ���� ��Ʈ��";
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
            //this.menuItem27.Text = "���̾�α� ��Ʈ��";
            //// 
            //// menuItem28
            //// 
            //this.menuItem28.Index = 0;
            //this.menuItem28.Text = "�������ϴ��̾�α�";
            //this.menuItem28.Click += new System.EventHandler(this.menuItem28_Click);
            //// 
            //// menuItem29
            //// 
            //this.menuItem29.Index = 1;
            //this.menuItem29.Text = "���̺����ϴ��̾�α�";
            //this.menuItem29.Click += new System.EventHandler(this.menuItem29_Click);
            //// 
            //// menuItem30
            //// 
            //this.menuItem30.Index = 2;
            //this.menuItem30.Text = "��Ʈ���̾�α�";
            //this.menuItem30.Click += new System.EventHandler(this.menuItem30_Click);
            //// 
            //// menuItem31
            //// 
            //this.menuItem31.Index = 3;
            //this.menuItem31.Text = "�÷����̾�α�";
            //this.menuItem31.Click += new System.EventHandler(this.menuItem31_Click);
            //// 
            //// menuItem32
            //// 
            //this.menuItem32.Index = 4;
            //this.menuItem32.Text = "����Ʈ���̾�α�";
            //this.menuItem32.Click += new System.EventHandler(this.menuItem32_Click);
            //// 
            //// menuItem34
            //// 
            //this.menuItem34.Index = 5;
            //this.menuItem34.Text = "�������¾����̾�α�";
            //this.menuItem34.Click += new System.EventHandler(this.menuItem34_Click);
            //// 
            //// menuItem35
            //// 
            //this.menuItem35.Index = 6;
            //this.menuItem35.Text = "�������������̾�α�";
            //this.menuItem35.Click += new System.EventHandler(this.menuItem35_Click);
            //// 
            //// menuItem33
            //// 
            //this.menuItem33.Index = 27;
            //this.menuItem33.Text = "�����ͱ׸��� ��Ʈ��";
            //this.menuItem33.Click += new System.EventHandler(this.menuItem33_Click);
            //// 
            //// menuItem39
            //// 
            //this.menuItem39.Index = 3;
            //this.menuItem39.MenuStrips.AddRange(new System.Windows.Forms.MenuStrip[] {
            //this.miMessageBoxCreater});
            //this.menuItem39.Text = "�������α׷�(&A)";
            //// 
            //// miMessageBoxCreater
            //// 
            //this.miMessageBoxCreater.Index = 0;
            //this.miMessageBoxCreater.Text = "�޽����ڽ� ������";
            //this.miMessageBoxCreater.Click += new System.EventHandler(this.miMessageBoxCreater_Click);
            //// 
            //// menuItem36
            //// 
            //this.menuItem36.Index = 4;
            //this.menuItem36.MenuStrips.AddRange(new System.Windows.Forms.MenuStrip[] {
            //this.menuItem37,
            //this.menuItem38,
            //this.miBasic});
            //this.menuItem36.Text = "�����ͺ��̽�(&D)";
            // 
            // menuItem37
            // 
            //this.menuItem37.Index = 0;
            this.menuItem37.Text = "�����ͺ��̽����� �� ����";
            this.menuItem37.Click += new System.EventHandler(this.menuItem37_Click);
            // 
            // menuItem38
            // 
            //this.menuItem38.Index = 1;
            this.menuItem38.Text = "��Ʈ�� ���ε�";
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
            this.miBasic.Text = "�⺻���Խ���";
            // 
            // miBasicWrite
            // 
            //this.miBasicWrite.Index = 0;
            this.miBasicWrite.Text = "�Է�";
            // 
            // miBasicList
            // 
            //this.miBasicList.Index = 1;
            this.miBasicList.Text = "���";
            // 
            // miBasicView
            // 
            //this.miBasicView.Index = 2;
            this.miBasicView.Text = "��";
            // 
            // miBasicModify
            // 
            //this.miBasicModify.Index = 3;
            this.miBasicModify.Text = "����";
            //// 
            //// miBasicDelete
            //// 
            //this.miBasicDelete.Index = 4;
            //this.miBasicDelete.Text = "����";
            //// 
            //// miBasicSearch
            //// 
            //this.miBasicSearch.Index = 5;
            //this.miBasicSearch.Text = "�˻�";
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
            //this.miWindow.Text = "â(&W)";
            //// 
            //// miCascade
            //// 
            //this.miCascade.Index = 0;
            //this.miCascade.Text = "��ܽ�";
            //this.miCascade.Click += new System.EventHandler(this.miCascade_Click);
            //// 
            //// miHorizontal
            //// 
            //this.miHorizontal.Index = 1;
            //this.miHorizontal.Text = "���� �迭";
            //this.miHorizontal.Click += new System.EventHandler(this.miHorizontal_Click);
            //// 
            //// miVertical
            //// 
            //this.miVertical.Index = 2;
            //this.miVertical.Text = "���� �迭";
            //this.miVertical.Click += new System.EventHandler(this.miVertical_Click);
            //// 
            //// miIcon
            //// 
            //this.miIcon.Index = 3;
            //this.miIcon.Text = "������ ����";
            //this.miIcon.Click += new System.EventHandler(this.miIcon_Click);
            //// 
            //// miHelp
            //// 
            //this.miHelp.Index = 6;
            //this.miHelp.MenuStrips.AddRange(new System.Windows.Forms.MenuStrip[] {
            //this.miInformation});
            //this.miHelp.Text = "����(&H)";
            //// 
            //// miInformation
            //// 
            //this.miInformation.Index = 0;
            //this.miInformation.Text = "���α׷� ����(&A)...";
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
            this.toolBarButton1.Text = "������";
            this.toolBarButton1.ToolTipText = "������";
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
            this.toolBarButton6.Text = "���α׷� ����";
            this.toolBarButton6.ToolTipText = "���α׷� ����";
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
            //this.menuItem11.Text = "���α׷� ����(&A)";
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
            //this.menuItem13.Text = "���α׷� ����(&X)";
            //this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            //// 
            //// myNotifyIcon
            //// 
            //this.myNotifyIcon.ContextMenu = this.myContextMenu;
            //this.myNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("myNotifyIcon.Icon")));
            //this.myNotifyIcon.Text = "C# ������ ���α׷���";
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
            this.Text = "Windows Forms ���� ���α׷�";
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
            Application.Exit();//������
        }

        private void miPictureBoxContorl_Click(object sender, System.EventArgs e)
        {
            ��ó�ڽ�.PictureBoxControl pb =
                new ��ó�ڽ�.PictureBoxControl();
            pb.MdiParent = this;
            pb.Show();
        }

        private void miBasicControl_Click(object sender, System.EventArgs e)
        {
            ���̺����ư���ؽ�Ʈ�ڽ�.LabelButtonTextBox lbt =
                new ���̺����ư���ؽ�Ʈ�ڽ�.LabelButtonTextBox();
            lbt.MdiParent = this;
            lbt.Show();//��޸��� ��
        }

        private void miInformation_Click(object sender, System.EventArgs e)
        {
            ��ũ���̺�.FrmLinkLabel fl =
                new ��ũ���̺�.FrmLinkLabel();
            //fl.MdiParent = this;
            fl.ShowDialog();//��� ��
            fl.Dispose();//���ҽ� ����
        }

        private void miCascade_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);//��ܽ� �迭
        }

        private void miHorizontal_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);//���� �迭
        }

        private void miVertical_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);//���� �迭
        }

        private void miIcon_Click(object sender, System.EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);//������ ����
        }

        private void miContorlFrmEditMemu_Click(object sender, System.EventArgs e)
        {
            //�����޴�ó��.FrmEditMenu fem = new �����޴�ó��.FrmEditMenu();
            ////fem.MdiParent = this;
            //fem.ShowDialog();
            //fem.Dispose();
        }

        private void miEditUndo_Click(object sender, System.EventArgs e)
        {
            //TextBox ��ü�� �ϳ� �����ϰ�, �̸� ActiveControl�� �����Ѵ�.
            TextBox objTextBox = new TextBox();
            //���� ���α׷����� ActiceControl(Ȱ��ȭ�� ��Ʈ��:�ؽ�Ʈ �ڽ�) ����
            objTextBox = (TextBox)this.ActiveControl;
            //Ȱ��ȭ�� �ؽ�Ʈ �ڽ��� ������ ���
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
            ����Ʈ�ڽ�.FrmListBox lb = new ����Ʈ�ڽ�.FrmListBox();
            lb.MdiParent = this;
            lb.Show();
        }

        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            üũ�帮��Ʈ�ڽ�.FrmCheckedListBox clb =
                new üũ�帮��Ʈ�ڽ�.FrmCheckedListBox();
            clb.MdiParent = this;
            clb.Show();
        }

        private void menuItem2_Click(object sender, System.EventArgs e)
        {
            //����ǥ����.FrmStatusBar sb = new ����ǥ����.FrmStatusBar();
            //sb.MdiParent = this;
            //sb.Show();
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.statusBarPanel1.Text = "�Ϸ�";
            this.statusBarPanel2.Text = DateTime.Now.ToShortDateString();
            this.statusBarPanel3.Text = DateTime.Now.ToShortTimeString();
            this.Cursor = Cursors.Default;
        }

        //���� ����
        private void menuItem3_Click(object sender, System.EventArgs e)
        {
            //��������.FrmToolBar tb = new ��������.FrmToolBar();
            //tb.MdiParent = this;
            //tb.Show();
        }

        ////������ ��ư
        //private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolStripButtonClickEventArgs e)
        //{
        //    if (e.Button == this.toolBarButton1)
        //    {
        //        //Application.Exit();	
        //        miExit_Click(null, null);//�̹� ������ �̺�Ʈ �ڵ鷯 ȣ��
        //    }
        //    else if (e.Button == this.toolBarButton6)
        //    {
        //        this.miInformation_Click(null, null);
        //    }
        //}

        private void menuItem5_Click(object sender, System.EventArgs e)
        {
            ���Ӹ����ٿ�.FrmNumericUpDown nud =
                new ���Ӹ����ٿ�.FrmNumericUpDown();
            nud.MdiParent = this;
            nud.Show();
        }

        private void menuItem6_Click(object sender, System.EventArgs e)
        {
            ��ũ�ѹ�.FrmScrollBar sc = new ��ũ�ѹ�.FrmScrollBar();
            sc.MdiParent = this;
            sc.Show();
        }

        private void menuItem7_Click(object sender, System.EventArgs e)
        {
            Ʈ����.FrmTrackBar tb = new Ʈ����.FrmTrackBar();
            tb.MdiParent = this;
            tb.Show();
        }

        //private void menuItem8_Click(object sender, System.EventArgs e)
        //{
        //    ���ؽ�Ʈ�޴�.FrmContextMenu cm = new ���ؽ�Ʈ�޴�.FrmContextMenu();
        //    cm.MdiParent = this;
        //    cm.Show();
        //}

        //private void menuItem10_Click(object sender, System.EventArgs e)
        //{
        //    ��������̾�����.FrmNotifyIcon ni = new ��������̾�����.FrmNotifyIcon();
        //    ni.MdiParent = this;
        //    ni.Show();
        //}
        //��Ȳ �޴� : ���α׷� ����
        private void menuItem11_Click(object sender, System.EventArgs e)
        {
            this.miInformation_Click(null, null);
        }
        //��Ȳ �޴� : ���α׷� ����
        private void menuItem13_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        //Ʈ���� �������� ����Ŭ������ ��
        private void myNotifyIcon_DoubleClick(object sender, System.EventArgs e)
        {
            MessageBox.Show("������ ������� ��Ʈ���Դϴ�."
                , "������ ��"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }
        //�� ��Ʈ��
        private void menuItem14_Click(object sender, System.EventArgs e)
        {
            ��.FrmTabControl t = new ��.FrmTabControl();
            t.MdiParent = this;
            t.Show();
        }
        //Ʈ���� ��Ʈ��
        private void menuItem15_Click(object sender, System.EventArgs e)
        {
            Ʈ����.FrmTreeView tv = new Ʈ����.FrmTreeView();
            tv.MdiParent = this;
            tv.Show();
        }
        //����Ʈ�� ��Ʈ��
        private void menuItem16_Click(object sender, System.EventArgs e)
        {
            ����Ʈ��.FrmListView lv = new ����Ʈ��.FrmListView();
            lv.MdiParent = this;
            lv.Show();
        }

        //private void menuItem17_Click(object sender, System.EventArgs e)
        //{
        //    ��������.FrmToolBarEvent tbe = new CSharp_Windows.��������.FrmToolBarEvent();
        //    tbe.MdiParent = this;
        //    tbe.Show();
        //}

        private void menuItem18_Click(object sender, System.EventArgs e)
        {
            Ÿ�̸�.FrmTimer t = new CSharp_Windows.Ÿ�̸�.FrmTimer();
            t.MdiParent = this;
            t.Show();
        }

        private void menuItem19_Click(object sender, System.EventArgs e)
        {
            �������ι��̴�.FrmHelpProvider hp = new CSharp_Windows.�������ι��̴�.FrmHelpProvider();
            hp.MdiParent = this;
            hp.Show();
        }

        private void menuItem20_Click(object sender, System.EventArgs e)
        {
            ����.FrmToolTip tt = new CSharp_Windows.����.FrmToolTip();
            tt.MdiParent = this;
            tt.Show();
        }

        private void menuItem21_Click(object sender, System.EventArgs e)
        {
            ��ġ�ؽ�Ʈ�ڽ�.FrmRichTextBox rtb = new CSharp_Windows.��ġ�ؽ�Ʈ�ڽ�.FrmRichTextBox();
            rtb.MdiParent = this;
            rtb.Show();
        }

        private void menuItem22_Click(object sender, System.EventArgs e)
        {
            ���α׷�����.FrmProgressBar pb = new CSharp_Windows.���α׷�����.FrmProgressBar();
            pb.MdiParent = this;
            pb.Show();
        }

        private void menuItem23_Click(object sender, System.EventArgs e)
        {
            �������ι��̴�.FrmErrorProvider ep = new CSharp_Windows.�������ι��̴�.FrmErrorProvider();
            ep.MdiParent = this;
            ep.Show();
        }

        private void menuItem24_Click(object sender, System.EventArgs e)
        {
            ����ƮŸ����Ŀ.FrmDateTimePicker dtp = new CSharp_Windows.����ƮŸ����Ŀ.FrmDateTimePicker();
            dtp.MdiParent = this;
            dtp.Show();
        }

        private void menuItem25_Click(object sender, System.EventArgs e)
        {
        }

        private void menuItem26_Click(object sender, System.EventArgs e)
        {
            �վ�Ķ����.FrmMonthCalendar mc = new CSharp_Windows.�վ�Ķ����.FrmMonthCalendar();
            mc.MdiParent = this;
            mc.Show();
        }

        private void menuItem28_Click(object sender, System.EventArgs e)
        {
            �������ϴ��̾�α�.FrmOpenFileDialog ofd = new CSharp_Windows.�������ϴ��̾�α�.FrmOpenFileDialog();
            ofd.MdiParent = this;
            ofd.Show();
        }

        private void menuItem29_Click(object sender, System.EventArgs e)
        {
            ���̺����ϴ��̾�α�.FrmSaveFileDialog sfd = new CSharp_Windows.���̺����ϴ��̾�α�.FrmSaveFileDialog();
            sfd.MdiParent = this;
            sfd.Show();
        }

        private void menuItem30_Click(object sender, System.EventArgs e)
        {
            ��Ʈ���̾�α�.FrmFontDialog fd = new CSharp_Windows.��Ʈ���̾�α�.FrmFontDialog();
            fd.MdiParent = this;
            fd.Show();
        }

        private void menuItem31_Click(object sender, System.EventArgs e)
        {
            �÷����̾�α�.FrmColorDialog cd = new CSharp_Windows.�÷����̾�α�.FrmColorDialog();
            cd.MdiParent = this;
            cd.Show();
        }

        private void menuItem32_Click(object sender, System.EventArgs e)
        {
            ����Ʈ���̾�α�.FrmPrintDialog pd = new CSharp_Windows.����Ʈ���̾�α�.FrmPrintDialog();
            pd.MdiParent = this;
            pd.Show();
        }

        //private void menuItem33_Click(object sender, System.EventArgs e)
        //{
        //    �����ͱ׸���.FrmDataGrid dg = new CSharp_Windows.�����ͱ׸���.FrmDataGrid();
        //    dg.MdiParent = this;
        //    dg.Show();
        //}

        private void menuItem34_Click(object sender, System.EventArgs e)
        {
            �������¾����̾�α�.FrmPageSetupDialog psd = new CSharp_Windows.�������¾����̾�α�.FrmPageSetupDialog();
            psd.MdiParent = this;
            psd.Show();
        }

        private void menuItem35_Click(object sender, System.EventArgs e)
        {
            �������������̾�α�.FrmFolderBrowserDialog fbd = new CSharp_Windows.�������������̾�α�.FrmFolderBrowserDialog();
            fbd.MdiParent = this;
            fbd.Show();
        }

        private void menuItem37_Click(object sender, System.EventArgs e)
        {
            �����ͺ��̽���������� dbcc = new �����ͺ��̽����������();
            dbcc.MdiParent = this;
            dbcc.Show();
        }

        private void menuItem38_Click(object sender, System.EventArgs e)
        {
        }

        private void miMessageBoxCreater_Click(object sender, System.EventArgs e)
        {
            �޽����ڽ�������.MessageBoxCreater mbc = new �޽����ڽ�������.MessageBoxCreater();
            mbc.MdiParent = this;
            mbc.Show();
        }
    }
}












