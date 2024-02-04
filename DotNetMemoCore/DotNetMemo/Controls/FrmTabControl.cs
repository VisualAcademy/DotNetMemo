//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;
//using System.IO;
//using Microsoft.Win32;

//namespace MyWinForms.Controls
//{
//    public partial class FrmTabControl : Form
//    {
//        public FrmTabControl()
//        {
//            InitializeComponent();
//        }

//        private void tbLevel_Scroll(object sender, EventArgs e)
//        {
//            switch (this.tbLevel.Value) {
//                case 0:
//                    lblDisplay.Text = "낮음";
//                    break;
//                case 1:
//                    lblDisplay.Text = "보통";
//                    break;
//                case 2:
//                    lblDisplay.Text = "높음";
//                    break;
//                default:
//                    break;
//            }
//        }
//        private void FrmTabControl_Load(object sender, EventArgs e)
//        {
//            LoadHome();
//            LoadLevel(); 
//            tbLevel_Scroll(null, null); 
//        }
//        private void LoadLevel() {
//            // Windows 레지스트리 정보 읽어오기
//            RegistryKey r = Registry.CurrentUser.OpenSubKey(dir);
//            if (r != null) {
//                tbLevel.Value = Convert.ToInt32(r.GetValue("Value"));
//                r.Close(); 
//            }
//        }
//        private void LoadHome()
//        {
//            if (File.Exists("C:\\Temp\\Home.dat"))
//            {
//                StreamReader sr = new StreamReader("C:\\Temp\\Home.dat");
//                this.txtHome.Text = sr.ReadLine();
//                sr.Close(); 
//            }
//        }
//        private void btnOK_Click(object sender, EventArgs e)
//        {
//            string msg = "홈페이지 : " + txtHome.Text;
//            msg += "\n보안수준 : " + lblDisplay.Text;
//            MessageBox.Show(msg, "옵션정보", MessageBoxButtons.OK
//                , MessageBoxIcon.Information);
//            // 홈페이지 정보 : 파일에 저장
//            SaveHome(txtHome.Text); 
//            // 보안수준 정보 : 레지스트리에 저장
//            SaveLevel(tbLevel.Value); 
//            this.Close(); 
//        }
//        private string dir = "Software\\Hawaso\\MyWinForms";
//        private void SaveLevel(int p) {
//            // Windows 레지스트리에 데이터 저장
//            RegistryKey r = Registry.CurrentUser.OpenSubKey(dir, true);
//            if (r == null) {
//                r = Registry.CurrentUser.CreateSubKey(dir); 
//            }
//            r.SetValue("Value", tbLevel.Value
//                , RegistryValueKind.DWord); // 0, 1, 2값 중 하나 저장
//            r.Close(); 
//        }
//        private void SaveHome(string home)
//        {
//            StreamWriter sw = new StreamWriter("C:\\Temp\\Home.dat");
//            sw.WriteLine(txtHome.Text);
//            sw.Close();
//        }
//    }
//}
