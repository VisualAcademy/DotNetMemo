using System.Windows.Forms;
using System.Data; //
using System.Data.SqlClient; //
using System.Configuration;

namespace AddressApplication
{
    /// <summary>
    /// FrmView 클래스 : 주소록 상세
    /// </summary>
    public class FrmView : System.Windows.Forms.Form
	{
		#region Controls
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Label lblNum;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.Label lblMobile;
		private System.Windows.Forms.Label lblZipCode;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblPostDate;
		private System.Windows.Forms.Label lblRecordNum;
		#endregion

		#region Private Members
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		#region Constructors
		public FrmView()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}
		#endregion

		#region Protected Methods
		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtNum = new System.Windows.Forms.TextBox();
			this.lblRecordNum = new System.Windows.Forms.Label();
			this.btnView = new System.Windows.Forms.Button();
			this.lblNum = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblMobile = new System.Windows.Forms.Label();
			this.lblZipCode = new System.Windows.Forms.Label();
			this.lblAddress = new System.Windows.Forms.Label();
			this.lblPostDate = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(144, 8);
			this.txtNum.Name = "txtNum";
			this.txtNum.TabIndex = 0;
			this.txtNum.Text = "";
			// 
			// lblRecordNum
			// 
			this.lblRecordNum.Location = new System.Drawing.Point(24, 8);
			this.lblRecordNum.Name = "lblRecordNum";
			this.lblRecordNum.TabIndex = 1;
			this.lblRecordNum.Text = "레코드 번호:";
			// 
			// btnView
			// 
			this.btnView.Location = new System.Drawing.Point(272, 8);
			this.btnView.Name = "btnView";
			this.btnView.TabIndex = 2;
			this.btnView.Text = "상세 보기";
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// lblNum
			// 
			this.lblNum.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblNum.Location = new System.Drawing.Point(24, 40);
			this.lblNum.Name = "lblNum";
			this.lblNum.Size = new System.Drawing.Size(96, 23);
			this.lblNum.TabIndex = 3;
			// 
			// lblName
			// 
			this.lblName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblName.Location = new System.Drawing.Point(184, 40);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(184, 23);
			this.lblName.TabIndex = 4;
			// 
			// lblEmail
			// 
			this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblEmail.Location = new System.Drawing.Point(24, 72);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(344, 23);
			this.lblEmail.TabIndex = 5;
			// 
			// lblPhone
			// 
			this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblPhone.Location = new System.Drawing.Point(24, 104);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(344, 23);
			this.lblPhone.TabIndex = 6;
			// 
			// lblMobile
			// 
			this.lblMobile.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblMobile.Location = new System.Drawing.Point(24, 136);
			this.lblMobile.Name = "lblMobile";
			this.lblMobile.Size = new System.Drawing.Size(344, 23);
			this.lblMobile.TabIndex = 7;
			// 
			// lblZipCode
			// 
			this.lblZipCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblZipCode.Location = new System.Drawing.Point(24, 168);
			this.lblZipCode.Name = "lblZipCode";
			this.lblZipCode.Size = new System.Drawing.Size(344, 23);
			this.lblZipCode.TabIndex = 8;
			// 
			// lblAddress
			// 
			this.lblAddress.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblAddress.Location = new System.Drawing.Point(24, 200);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(344, 23);
			this.lblAddress.TabIndex = 9;
			// 
			// lblPostDate
			// 
			this.lblPostDate.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblPostDate.Location = new System.Drawing.Point(24, 232);
			this.lblPostDate.Name = "lblPostDate";
			this.lblPostDate.Size = new System.Drawing.Size(344, 23);
			this.lblPostDate.TabIndex = 10;
			// 
			// FrmView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(392, 261);
			this.Controls.Add(this.lblPostDate);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.lblZipCode);
			this.Controls.Add(this.lblMobile);
			this.Controls.Add(this.lblPhone);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblNum);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.lblRecordNum);
			this.Name = "FrmView";
			this.Text = "상세";
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void btnView_Click(object sender, System.EventArgs e)
		{
			//[1] 변수 선언부
			string strNum = txtNum.Text.Trim();
			string strSql = "ViewAddress";
			#region ...
//				"Select * From Address " + 
//				"Where Num = @Num";
//30-> " + strNum + "
//				"Select * From Address " + 
//				"Where Num = " + strNum;
			#endregion
			//[2] 커넥션
			SqlConnection objCon = new SqlConnection();
            objCon.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            objCon.Open();
			//[3] 커멘드
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = strSql;
			objCmd.CommandType = 
				CommandType.StoredProcedure;
			//[!] 파라미터 추가
			objCmd.Parameters.Add("@Num", SqlDbType.Int);
			objCmd.Parameters["@Num"].Value = strNum;
			//[4] 데이터리더
			SqlDataReader objDr = 
				objCmd.ExecuteReader();
			//[5] 출력
			if (objDr.Read()){
				#region Data Bindings
				this.lblNum.Text = 
					objDr["Num"].ToString();//번호
				this.lblName.Text = 
					objDr["Name"].ToString();//이름
				this.lblEmail.Text = 
					objDr["Email"].ToString();
				this.lblPhone.Text = 
					objDr["Phone"].ToString();
				this.lblMobile.Text = //[1]필드명
					objDr["Mobile"].ToString();
				this.lblZipCode.Text = 
					objDr[5].ToString();//[2]서수
				this.lblAddress.Text = 
					objDr.GetString(6);//[3]Get???()
				this.lblPostDate.Text = 
					objDr.GetDateTime( 
					7).ToShortDateString();
				#endregion
			}
			else{
				MessageBox.Show("해당 데이터 없음");
			}
			//[6] 정리
			objDr.Close();//
			objCon.Close();
		}
		#endregion
	}
}
