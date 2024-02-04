//using System;
//using System.Drawing;
//using System.Windows.Forms;
//using System.Data;
//using System.Data.SqlClient;

//namespace CSharp_Database
//{
//    public class 한줄메모장출력 : System.Windows.Forms.Form
//    {
//        private System.Windows.Forms.DataGrid dataGrid1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Button button1;
//        #region +
//        /// <summary>
//        /// 필수 디자이너 변수입니다.
//        /// </summary>
//        private System.ComponentModel.Container components = null;

//        public 한줄메모장출력()
//        {
//            //
//            // Windows Form 디자이너 지원에 필요합니다.
//            //
//            InitializeComponent();

//            //
//            // TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
//            //
//        }

//        /// <summary>
//        /// 사용 중인 모든 리소스를 정리합니다.
//        /// </summary>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                if (components != null)
//                {
//                    components.Dispose();
//                }
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code
//        /// <summary>
//        /// 디자이너 지원에 필요한 메서드입니다.
//        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.dataGrid1 = new System.Windows.Forms.DataGrid();
//            this.label2 = new System.Windows.Forms.Label();
//            this.button1 = new System.Windows.Forms.Button();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // dataGrid1
//            // 
//            this.dataGrid1.CaptionText = "한줄 메모장 출력";
//            this.dataGrid1.DataMember = "";
//            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
//            this.dataGrid1.Location = new System.Drawing.Point(16, 16);
//            this.dataGrid1.Name = "dataGrid1";
//            this.dataGrid1.ReadOnly = true;
//            this.dataGrid1.Size = new System.Drawing.Size(336, 240);
//            this.dataGrid1.TabIndex = 0;
//            this.dataGrid1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseUp);
//            // 
//            // label2
//            // 
//            this.label2.Location = new System.Drawing.Point(16, 272);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(144, 23);
//            this.label2.TabIndex = 2;
//            this.label2.Text = "글번호 : ";
//            // 
//            // button1
//            // 
//            this.button1.Location = new System.Drawing.Point(168, 272);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(184, 23);
//            this.button1.TabIndex = 3;
//            this.button1.Text = "현재 글 번호 수정하기";
//            this.button1.Click += new System.EventHandler(this.button1_Click);
//            // 
//            // 한줄메모장출력
//            // 
//            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//            this.ClientSize = new System.Drawing.Size(376, 309);
//            this.Controls.AddRange(new System.Windows.Forms.Control[] {
//                                                                          this.button1,
//                                                                          this.label2,
//                                                                          this.dataGrid1});
//            this.Name = "한줄메모장출력";
//            this.Text = "한줄메모장출력";
//            this.Load += new System.EventHandler(this.한줄메모장출력_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
//            this.ResumeLayout(false);

//        }
//        #endregion
//        #endregion
//        private void 한줄메모장출력_Load(object sender, System.EventArgs e)
//        {
//            //[1] 커넥션 클래스의 인스턴스 생성
//            SqlConnection objCon = new SqlConnection();
//            //[2] ConnectionString 속성 지정
//            objCon.ConnectionString =
//                "server=(local);database=Web;uid=Web;pwd=Web;";//4가지 정보
//                                                               //[3] 연결
//            objCon.Open();
//            SqlCommand objCmd = new SqlCommand();
//            objCmd.Connection = objCon;//커넥션 객체 지정
//            objCmd.CommandText = "Select * From Memo";
//            objCmd.CommandType = CommandType.Text;
//            //[4] 
//            SqlDataAdapter objDa = new SqlDataAdapter();
//            objDa.SelectCommand = objCmd;
//            DataSet objDs = new DataSet();
//            objDa.Fill(objDs, "Memo");
//            this.dataGrid1.DataSource = objDs.Tables["Memo"];
//            //[4] 종료
//            objCon.Close();

//            //[!] 데이터그리드 속성 변경하기
//            // DataGrid를 위한 객체들을 선언
//            DataGridTableStyle objDataGridTableStyle = new DataGridTableStyle();
//            DataGridTextBoxColumn objDataGridTextBoxColumn = new DataGridTextBoxColumn();

//            // AlternatingBackColor 속성 지정
//            objDataGridTableStyle.AlternatingBackColor = Color.WhiteSmoke;
//            // DataGridTableStyle의 MappingName 지정
//            objDataGridTableStyle.MappingName = "Memo";

//            // 첫번째 열의 MappingName 지정
//            objDataGridTextBoxColumn.MappingName = "Num";
//            // 새로운 HeaderText를 지정
//            objDataGridTextBoxColumn.HeaderText = "번호";
//            // 열의 사이즈 지정
//            objDataGridTextBoxColumn.Width = 50;
//            // DataGridTableStyle에 열을 추가
//            objDataGridTableStyle.GridColumnStyles.Add(objDataGridTextBoxColumn);

//            // 새 참조 얻기
//            objDataGridTextBoxColumn = new DataGridTextBoxColumn();
//            // 두번째 열의 MappingName 지정
//            objDataGridTextBoxColumn.MappingName = "Name";
//            // HeaderText
//            objDataGridTextBoxColumn.HeaderText = "이름";
//            // Size
//            objDataGridTextBoxColumn.Width = 100;
//            // 정렬
//            objDataGridTextBoxColumn.Alignment = HorizontalAlignment.Right;
//            // 열 추가
//            objDataGridTableStyle.GridColumnStyles.Add(objDataGridTextBoxColumn);

//            objDataGridTextBoxColumn = new DataGridTextBoxColumn();
//            objDataGridTextBoxColumn.MappingName = "Email";
//            objDataGridTextBoxColumn.HeaderText = "이메일";
//            objDataGridTextBoxColumn.Width = 100;
//            objDataGridTableStyle.GridColumnStyles.Add(objDataGridTextBoxColumn);

//            objDataGridTextBoxColumn = new DataGridTextBoxColumn();
//            objDataGridTextBoxColumn.MappingName = "Title";
//            objDataGridTextBoxColumn.HeaderText = "메모";
//            objDataGridTextBoxColumn.Width = 200;
//            objDataGridTableStyle.GridColumnStyles.Add(objDataGridTextBoxColumn);

//            objDataGridTextBoxColumn = new DataGridTextBoxColumn();
//            objDataGridTextBoxColumn.MappingName = "PostDate";
//            objDataGridTextBoxColumn.HeaderText = "작성일";
//            objDataGridTextBoxColumn.Width = 100;
//            objDataGridTableStyle.GridColumnStyles.Add(objDataGridTextBoxColumn);

//            this.dataGrid1.TableStyles.Add(objDataGridTableStyle);
//        }

//        private int intRecordNum = 0;

//        private void dataGrid1_MouseUp(
//            object sender, System.Windows.Forms.MouseEventArgs e)
//        {
//            try
//            {
//                DataGrid objDataGrid = (DataGrid)sender;
//                DataGrid.HitTestInfo objHitTestInfo = objDataGrid.HitTest(e.X, e.Y);

//                if (objHitTestInfo.Type == DataGrid.HitTestType.Cell)
//                {
//                    intRecordNum = Convert.ToInt32(
//                        objDataGrid[objHitTestInfo.Row, 0].ToString());
//                    this.label2.Text = "선택한 글 번호 : " + intRecordNum.ToString();
//                }
//            }
//            finally
//            {

//            }
//        }

//        private void button1_Click(object sender, System.EventArgs e)
//        {

//        }
//    }
//}
