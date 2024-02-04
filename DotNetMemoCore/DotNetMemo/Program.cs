using CSharp_Windows;
using MyWinForms;
using System;
using System.Windows.Forms;

namespace DotNetMemo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ////시작 폼 띄우기
            //Application.Run(new FrmList());

            //메인 폼
            Application.Run(new StartForm());
            //Application.Run(new MainForm());
            //Application.Run(new FrmMain());
            //Application.Run(new MyWinForms.Controls.FrmButtonLableTextBox());

            //[1] Hello World
            //Application.Run(new Practices.Chapter02.FrmHelloWorld()); 

            // 5.3. Label 컨트롤
            //Application.Run(new CSharp_Windows.Controls.FrmLable());

            // 5.5. TextBox 컨트롤
            //Application.Run(new MyWinForms.Controls.FrmTextBox());


            //Application.Run(new CSharp_Windows.Applications.FrmMakeForm());

            //Application.Run(new CSharp_Windows.데이트타임픽커.FrmDateTimePicker());

            // 링크 레이블 컨트롤
            //Application.Run(new FrmAbout());

            // TreeView 컨트롤 사용하기 
            //Application.Run(new WinTreeView.WinTreeView());

            #region 11_00_닷넷노트(DotNetNote) 메모장 프로젝트
            // 11_00_닷넷노트(DotNetNote) 메모장 프로젝트
            //Application.Run(new DotNetNote.DotNetNote());  
            #endregion

            // UserControl 
            // Application.Run(new UserControls.FrmUserControl());

            //Application.Run(new FrmListBox());
        }
    }
}
