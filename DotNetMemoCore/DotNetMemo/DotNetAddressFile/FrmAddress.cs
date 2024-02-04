using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 주소록
{
    public partial class FrmAddress : Form
    {
        private List<Address> addr;
        private string dir = System.IO.Path.Combine(Application.StartupPath, "MyAddress.txt");

        public FrmAddress()
        {
            InitializeComponent();
            addr = new List<Address>(); 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(dir))
            {
                LoadData();       
            }
            this.sslCount.Text = "등록수 : " + addr.Count.ToString();
            if (addr.Count > 0)
            {
                ShowRecord(0); // 첫번째 데이터를 표시
                btnAdd.Text = "추가"; 
            }
        }

        private void LoadData()
        {
            StreamReader sr = new StreamReader(dir, Encoding.Default);
            while (sr.Peek() >= 0) // -1 : 더 이상 읽을 문자가 없을때
            {
                string[] arr = sr.ReadLine().Trim().Split(',');

                if (arr[0] != "" && arr[0] != null) {
                    Address a = new Address();
                    a.Num = Convert.ToInt32(arr[0]); // 번호 : 인덱스+1
                    a.Name = arr[1];
                    a.Mobile = arr[2];
                    a.Email = arr[3];

                    addr.Add(a);  
                }
            }
            sr.Close(); // 
            sr.Dispose(); // 
            DisplayData(); 
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (btnAdd.Text == "입력") {
                Address a = new Address();
                a.Num = addr.Count + 1; // 
                a.Name = txtName.Text.Trim();
                a.Mobile = txtMobile.Text.Trim();
                a.Email = txtEmail.Text.Trim();
                addr.Add(a);
                DisplayData(); // 출력 
            }
            else {
                btnAdd.Text = "입력"; 
            }
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            txtName.Text = txtMobile.Text = txtEmail.Text = String.Empty;
        }

        private void DisplayData()
        {
            var q = (from a in addr select a).ToList();
            this.dgvAddress.DataSource = q;
        }
        // 검색전용
        private void DisplayData(string query)
        {
            var q = (from a in addr 
                     where 
                        a.Name == query || 
                        a.Mobile == query || 
                        a.Email == query
                     select a).ToList();
            this.dgvAddress.DataSource = q;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (addr.Count > 0)
            {
                SaveData();
            }
        }

        private void SaveData()
        {
            // 레코드는 엔터구분, 필드는 콤마구분으로 저장
            StringBuilder sb = new StringBuilder();
            int index = 0; 
            foreach (Address a in addr)
            {
                sb.AppendLine(String.Format("{0},{1},{2},{3}"
                    , ++index, a.Name, a.Mobile, a.Email)); 
            }
            StreamWriter sw = new StreamWriter(dir, false, Encoding.Default);
            sw.Write(sb.ToString());
            sw.Close();
            sw.Dispose(); // 
            MessageBox.Show("저장되었습니다.");
        }

        private void miBackup_Click(object sender, EventArgs e)
        {
            string name = Path.GetFileNameWithoutExtension(dir);
            string ext = Path.GetExtension(dir).Replace(".", "");
 
            // MyAddress20100101.txt로 저장가능하도록
            string newDir = 
                Path.Combine(Application.StartupPath, 
                    String.Format("{0}{1}.{2}"
                        , name
                        , String.Format("{0}{1:0#}{2}"
                            , DateTime.Now.Year
                            , DateTime.Now.Month
                            , DateTime.Now.Day.ToString().PadLeft(2, '0')
                          )
                        , ext
                    )
                );

            if (File.Exists(dir))
            {                
                File.Copy(dir, newDir, true); // 원본을 복사해서 백업
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private int currentIndex = -1; 
        private void dgvAddress_CellClick(object sender, 
            DataGridViewCellEventArgs e)
        {
            //currentIndex = e.RowIndex; // 현재 인덱스를 필드에 보관
            DataGridViewCell dgvc = dgvAddress.Rows[e.RowIndex].Cells[0];
            currentIndex = Convert.ToInt32(dgvc.Value.ToString()) - 1; 
            if (currentIndex != -1)
            {
                ShowRecord(currentIndex);
            }
        }

        private void ShowRecord(int index)
        {
            // 현재 선택된 인덱스 + 1을 번호 출력
            this.txtNum.Text = (index + 1).ToString();
            this.txtName.Text = addr[index].Name;
            this.txtMobile.Text = addr[index].Mobile;
            this.txtEmail.Text = addr[index].Email;

            btnAdd.Text = "추가";
            txtGo.Text = txtNum.Text; // 현재 선택된 인덱스 값 출력
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (currentIndex != -1 && blnModified == true)
            {
                // 변경된 데이터로 addr 개체의 현재 인덱스 데이터 변경
                addr[currentIndex].Name = txtName.Text;
                addr[currentIndex].Mobile = txtMobile.Text;
                addr[currentIndex].Email = txtEmail.Text;
                MessageBox.Show("수정되었습니다.", "수정완료");
                DisplayData(); 
                blnModified = false; // 다시 초기화
            }
        }

        // 3개 텍스트박스에서 KeyPress 이벤트 발생시 호출
        private bool blnModified = false;
        private void txtModify_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNum.Text != "") // 데이터가 로드된 상태에서만
            {
                blnModified = true; // 변경되었다... 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtNum.Text != "" && currentIndex != -1)
            {
                DialogResult dr = 
                    MessageBox.Show("정말로 삭제하시겠습니까?", "삭제확인"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr != DialogResult.No)
                {
                    // 메모리 상에서 현재 레코드 삭제
                    addr.RemoveAt(currentIndex);
                    DisplayData();  
                }
            }
        }

        // 처음, 이전, 다음, 마지막 버튼에 대한 공통 이벤트
        private void btnMove_Click(object sender, EventArgs e) {
            Button btn = sender as Button; 
            if (btn == btnFirst) {
                if (currentIndex > 0) {
                    currentIndex = 0; // 0번째 인덱스로 표시
                }
            }
            else if (btn == btnPrev) {
                if (currentIndex > 0) {
                    currentIndex--; 
                }
            }
            else if (btn == btnNext) {
                if (currentIndex < addr.Count - 1) {
                    currentIndex++; 
                }
            }
            else if (btn == btnLast) {
                if (currentIndex != -1) {
                    currentIndex = addr.Count - 1; 
                }
            }
            ShowRecord(currentIndex); // 다시 데이터 표시
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtGo.Text != "" && Convert.ToInt32(txtGo.Text) > 0 
                    && Convert.ToInt32(txtGo.Text) <= addr.Count)
            {
                ShowRecord(Convert.ToInt32(txtGo.Text) - 1);     
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisplayData(txtSearch.Text); 
        }
    }
}
