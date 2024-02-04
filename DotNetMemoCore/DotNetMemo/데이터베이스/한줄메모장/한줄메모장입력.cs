using System;
using System.Data;
using System.Data.SqlClient;

namespace CSharp_Database
{
    public class 한줄메모장입력 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTitle;
        #region +
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public 한줄메모장입력()
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 : ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.TabIndex = 1;
            this.label2.Text = "이메일 : ";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(40, 128);
            this.label3.Name = "label3";
            this.label3.TabIndex = 2;
            this.label3.Text = "메모 : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 21);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 21);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(120, 120);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(160, 21);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(56, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "저장(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(168, 176);
            this.btnList.Name = "btnList";
            this.btnList.TabIndex = 7;
            this.btnList.Text = "리스트(&L)";
            // 
            // 한줄메모장입력
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(304, 221);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                                                                    this.btnList,
                                                                                                                                    this.btnSave,
                                                                                                                                    this.txtTitle,
                                                                                                                                    this.txtEmail,
                                                                                                                                    this.txtName,
                                                                                                                                    this.label3,
                                                                                                                                    this.label2,
                                                                                                                                    this.label1});
            this.Name = "한줄메모장입력";
            this.Text = "한줄메모장입력";
            this.ResumeLayout(false);

        }
        #endregion
        #endregion
        //저장 버튼
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            //[!] 변수 선언부
            string strName = this.txtName.Text;
            string strEmail = this.txtEmail.Text;
            string strTitle = this.txtTitle.Text;
            //[!] 작은(홑) 따옴표 처리
            //			strName = strName.Replace("'", "''");
            //			strEmail = strEmail.Replace("'", "''");
            //			strTitle = strTitle.Replace("'", "''");
            //[1] 커넥션 클래스의 인스턴스 생성
            SqlConnection objCon = new SqlConnection();
            //[2] ConnectionString 속성 지정
            objCon.ConnectionString =
                "server=(local);database=Web;uid=Web;pwd=Web;";//4가지 정보
                                                               //[3] 연결
            objCon.Open();
            SqlCommand objCmd = new SqlCommand();
            objCmd.Connection = objCon;//커넥션 객체 지정

            #region 원본 SQL문
            //			objCmd.CommandText = @"
            //				Insert Into Memo(Name, Email, Title, PostDate) 
            //				Values('홍길동', 'h@h.com', '홍길동입니다.', GetDate())
            //			";//일반 SQL문
            #endregion
            #region [1]인라인 SQL문
            //[1] 인라인 SQL문 : 순수데이터 -> " + 변수 + "
            //			objCmd.CommandText = @"
            //				Insert Into Memo(Name, Email, Title, PostDate) 
            //				Values('" 
            //					+ strName + @"', '" 
            //					+ strEmail + @"', '" 
            //					+ strTitle + @"', GetDate())
            //			";//일반 SQL문
            #endregion
            #region [2]SQL Parameter 방식
            //			//[!] SQL Parameter 방식 : Named 매개변수
            //			objCmd.CommandText = "Insert Into Memo(Name, Email, Title, PostDate) Values(@Name, @Email, @Title, @PostDate)";
            //			//[!] @변수 부분 채워넣기
            //			objCmd.Parameters.Add("@Name", SqlDbType.VarChar, 25);
            //			objCmd.Parameters["@Name"].Value = strName;//이름 대입
            //			objCmd.Parameters.Add("@Email", SqlDbType.VarChar, 100);
            //			objCmd.Parameters["@Email"].Value = strEmail;//이메일 대입
            //			objCmd.Parameters.Add("@Title", SqlDbType.VarChar, 150);
            //			objCmd.Parameters["@Title"].Value = strTitle;//메모 대입
            //      objCmd.Parameters.Add("@PostDate", SqlDbType.DateTime);//*
            //			objCmd.Parameters["@PostDate"].Value = DateTime.Now;//날짜 대입
            #endregion
            #region [3] SQL SP 방식
            //[!] SQL SP 방식
            objCmd.CommandText = "procInsertMemo";//저장프로시저명
                                                  //[!] @변수 부분 채워넣기
            objCmd.Parameters.Add("@Name", SqlDbType.VarChar, 25);
            objCmd.Parameters["@Name"].Value = strName;//이름 대입
            objCmd.Parameters.Add("@Email", SqlDbType.VarChar, 100);
            objCmd.Parameters["@Email"].Value = strEmail;//이메일 대입
            objCmd.Parameters.Add("@Title", SqlDbType.VarChar, 150);
            objCmd.Parameters["@Title"].Value = strTitle;//메모 대입
            objCmd.Parameters.Add("@PostDate", SqlDbType.DateTime);//*
            objCmd.Parameters["@PostDate"].Value = DateTime.Now;//날짜 대입

            objCmd.CommandType = CommandType.StoredProcedure;//변경
                                                             //objCmd.CommandType = CommandType.Text;
            #endregion

            objCmd.ExecuteNonQuery();//실행
                                     //[4] 종료
            objCon.Close();
            //[!] 텍스트박스 초기화
            this.txtName.Text = "";
            this.txtEmail.Clear();
            this.txtTitle.Text = String.Empty;
        }
    }
}
