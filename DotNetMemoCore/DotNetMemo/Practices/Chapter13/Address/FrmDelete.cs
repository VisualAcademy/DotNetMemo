using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AddressApplication
{
    /// <summary>
    /// FrmDelete에 대한 요약 설명입니다.
    /// </summary>
    public class FrmDelete : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Button btnDelete;

        #region +
        /// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmDelete()
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "삭제할 레코드 번호:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(136, 40);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(64, 21);
			this.txtNum.TabIndex = 1;
			this.txtNum.Text = "";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(224, 40);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(88, 23);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "삭제";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// FrmDelete
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(328, 109);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.label1);
			this.Name = "FrmDelete";
			this.Text = "삭제";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			//[1] 변수 선언부
			string strNum = txtNum.Text.Trim();
			string strSql = "DeleteAddress";
//				"Delete Address Where Num = @Num";
//				"Delete Address Where Num = " 
//				+ strNum;
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
			//[!] 실행
			int intAffected = 
				objCmd.ExecuteNonQuery();
			if(intAffected > 0)
			{
				MessageBox.Show(
					String.Format(
					"{0}개 삭제", intAffected)
					);
			}
			else
			{
				MessageBox.Show("삭제 안됨");
			}
		}

	}
}
