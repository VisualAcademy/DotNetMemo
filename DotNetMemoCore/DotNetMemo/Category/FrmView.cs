using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[0] 네임스페이스 선언
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Category
{
	/// <summary>
	/// FrmView에 대한 요약 설명입니다.
	/// </summary>
	public class FrmView : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCategoryID;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblCategoryName;
		private System.Windows.Forms.Label lblSuperCategory;
		private System.Windows.Forms.Label lblAlign;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

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

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtCategoryID = new System.Windows.Forms.TextBox();
			this.btnView = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblCategoryName = new System.Windows.Forms.Label();
			this.lblSuperCategory = new System.Windows.Forms.Label();
			this.lblAlign = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "카테고리번호:";
			// 
			// txtCategoryID
			// 
			this.txtCategoryID.Location = new System.Drawing.Point(104, 16);
			this.txtCategoryID.Name = "txtCategoryID";
			this.txtCategoryID.TabIndex = 1;
			this.txtCategoryID.Text = "";
			// 
			// btnView
			// 
			this.btnView.Location = new System.Drawing.Point(224, 16);
			this.btnView.Name = "btnView";
			this.btnView.TabIndex = 2;
			this.btnView.Text = "상세보기";
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(56, 80);
			this.label2.Name = "label2";
			this.label2.TabIndex = 3;
			this.label2.Text = "카테고리명:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(40, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "부모카테고리번호:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(56, 144);
			this.label4.Name = "label4";
			this.label4.TabIndex = 5;
			this.label4.Text = "정렬순서:";
			// 
			// lblCategoryName
			// 
			this.lblCategoryName.Location = new System.Drawing.Point(176, 80);
			this.lblCategoryName.Name = "lblCategoryName";
			this.lblCategoryName.TabIndex = 6;
			// 
			// lblSuperCategory
			// 
			this.lblSuperCategory.Location = new System.Drawing.Point(176, 112);
			this.lblSuperCategory.Name = "lblSuperCategory";
			this.lblSuperCategory.TabIndex = 7;
			// 
			// lblAlign
			// 
			this.lblAlign.Location = new System.Drawing.Point(184, 144);
			this.lblAlign.Name = "lblAlign";
			this.lblAlign.TabIndex = 8;
			// 
			// FrmView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(320, 197);
			this.Controls.Add(this.lblAlign);
			this.Controls.Add(this.lblSuperCategory);
			this.Controls.Add(this.lblCategoryName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.txtCategoryID);
			this.Controls.Add(this.label1);
			this.Name = "FrmView";
			this.Text = "FrmView";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnView_Click(object sender, System.EventArgs e)
		{
			//[1] 변수 선언부
			string strCategoryID = 
				this.txtCategoryID.Text.Trim();
			string strSql = "ViewCategory";
			//[2] 커넥션
			SqlConnection objCon = new SqlConnection();
            //objCon.ConnectionString = "server=(local);database=Category;uid=Category;pwd=Category;";
            objCon.ConnectionString =
                ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            objCon.Open();
			//[3] 커멘드
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = strSql;
			objCmd.CommandType = CommandType.StoredProcedure;
			//[!] 파라미터 1개 추가
			objCmd.Parameters.Add("@CategoryID", SqlDbType.Int);
			objCmd.Parameters["@CategoryID"].Value = strCategoryID;
			//[4] 데이터리더
			SqlDataReader objDr = 
				objCmd.ExecuteReader();
			//[!] 바인딩
			while(objDr.Read())
			{
				this.lblCategoryName.Text = 
					objDr["CategoryName"].ToString();
				this.lblSuperCategory.Text = 
					objDr["SuperCategory"].ToString();
				this.lblAlign.Text = 
					objDr["Align"].ToString();
			}
			//[5] 닫기
			objDr.Close();
			objCon.Close();
		}
	}
}
