// DataTable 관련 주요 기능 설정 예제
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProDataTable
{
    public partial class FrmDataTable : Form
    {
        public FrmDataTable()
        {
            InitializeComponent();
        }

        private DataTable objMemo;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            objMemo = new DataTable();
            objMemo.TableName = "AddressTable";

            // 번호 필드 추가
            DataColumn objNum = new DataColumn();
            objNum.DataType = Type.GetType("System.Int32");
            objNum.ColumnName = "Num";
            objNum.AllowDBNull = false;
            objNum.ReadOnly = true;
            objNum.Unique = true;
            objNum.AutoIncrement = true;
            objNum.AutoIncrementSeed = 1;
            objNum.AutoIncrementStep = 1;

            objMemo.Columns.Add(objNum);

            // 이름 필드 추가
            DataColumn objName = new DataColumn();
            objName.DataType = Type.GetType("System.String");
            objName.ColumnName = "Name";
            objName.AllowDBNull = false;

            objMemo.Columns.Add(objName);

            // 이메일 필드 추가
            DataColumn objEmail = new DataColumn();
            objEmail.DataType = Type.GetType("System.String");
            objEmail.ColumnName = "Email";
            objEmail.AllowDBNull = true;

            objMemo.Columns.Add(objEmail);

            // 제목 필드 추가
            DataColumn objTitle = new DataColumn();
            objTitle.DataType = Type.GetType("System.String");
            objTitle.ColumnName = "Title";
            objTitle.AllowDBNull = false;

            objMemo.Columns.Add(objTitle);

            // 번호 필드를 기본키로 설정
            DataColumn[] objPrkmaryKey = new DataColumn[1];
            objPrkmaryKey[0] = objMemo.Columns["Num"];
            objMemo.PrimaryKey = objPrkmaryKey;

            // Memo 테이블에 데이터 추가
            DataRow objDataRow = objMemo.NewRow();//
            objDataRow["Name"] = "홍길동";
            objDataRow["Email"] = "h@h.com";
            objDataRow["Title"] = "홍길동입니다.";

            objMemo.Rows.Add(objDataRow);

            this.ctlAddressList.DataSource = objMemo;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strName = this.txtName.Text.Trim();
            string strEmail = this.txtEmail.Text.Trim();
            string strTitle = this.txtTitle.Text.Trim();

            if (strName != "" && strTitle != String.Empty)
            {
                try
                {
                    DataRow objDataRow = objMemo.NewRow();
                    objDataRow["Name"] = strName;
                    objDataRow["Email"] = strEmail;
                    objDataRow["Title"] = strTitle;
                    objMemo.Rows.Add(objDataRow);
                }
                catch
                {
                    MessageBox.Show("이름과 제목을 잘못 입력하셨습니다.", "확인");
                }
            }
            else 
            {
                MessageBox.Show("이름과 제목을 작성하시오.", "확인");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                int intIndex = this.ctlAddressList.CurrentRow.Index;
                string strName = this.txtName.Text.Trim();
                string strEmail = this.txtEmail.Text.Trim();
                string strTitle = this.txtTitle.Text.Trim();

                DataRow objDataRow = objMemo.Rows[intIndex];//선택된 행
                objDataRow.BeginEdit();
                objDataRow["Name"] = strName;
                objDataRow["Email"] = strEmail;
                objDataRow["Title"] = strTitle;
                objDataRow.EndEdit();                
            }
            catch
            {
                MessageBox.Show("편집할 레코드를 선택하세요.", "확인");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int intIndex = this.ctlAddressList.CurrentRow.Index;

                DataRow objDataRow = objMemo.Rows[intIndex];
                objDataRow.Delete();//삭제
            }
            catch
            {
                MessageBox.Show("삭제할 행을 선택하세요.", "에러발생");
            }
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            try
            {
                objMemo.Rows.Clear(); // 전체 메모 삭제
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ctlAddressList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int intIndex = this.ctlAddressList.CurrentRow.Index;
                DataRow objDataRow = objMemo.Rows[intIndex];
                this.txtName.Text = objDataRow["Name"].ToString();
                this.txtEmail.Text = objDataRow["Email"].ToString();
                this.txtTitle.Text = objDataRow["Title"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ctlAddressList_Click(object sender, EventArgs e)
        {
            this.ctlAddressList_CellContentClick(null, null);
        }
    }
}