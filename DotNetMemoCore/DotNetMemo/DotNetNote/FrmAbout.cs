using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DotNetNote
{
    public partial class FrmAbout : Form
    {
      #region Constructors
      public FrmAbout()
      {
        InitializeComponent();
      } 
      #endregion

      #region Event Handlers
      private void btnOK_Click(object sender, EventArgs e)
      {
        this.Close();
      }

      private void FrmAbout_Load(object sender, EventArgs e)
      {
        // 아이콘 출력
        this.picIcon.Image = this.Icon.ToBitmap();
        // 사용자 이름
        this.lblUserName.Text = SystemInformation.UserName;
        // 컴퓨터 이름
        this.lblComputerName.Text = SystemInformation.ComputerName;
        // 프로그램 버전
        this.lblVersion.Text = "버전: " + Application.ProductVersion;
        // 메모리 사이즈
        Win32Api.MEMORYSTATUS objMemoryStatus =
            new Win32Api.MEMORYSTATUS();
        Win32Api.GlobalMemoryStatus(ref objMemoryStatus);
        this.lblMemorySize.Text = String.Format(
            "{0:N} KB", objMemoryStatus.dwTotalPhys / 1024);
        // 이미지 표시
        this.picBackground.Image = this.picWin2003bmp.Image;
        this.picBackground.Left = -this.picBackground.Width;
      }

      private void btnEula_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      {
        System.Diagnostics.Process.Start(
            System.Environment.SystemDirectory + @"\eula.txt");
      }

      private void dnnAboutTimer_Tick(object sender, EventArgs e)
      {
        this.picWin2003bmp.Left += 20;
        this.picBackground.Left += 20;
        if (this.picWin2003bmp.Left >= this.Width)
        {
          this.picWin2003bmp.Left = 0;
          this.picBackground.Left = -this.picWin2003bmp.Width;
        }
      } 
      #endregion
    }
}