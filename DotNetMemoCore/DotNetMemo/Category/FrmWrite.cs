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
	/// FrmWrite에 대한 요약 설명입니다.
	/// </summary>
	public class FrmWrite : System.Windows.Forms.Form
	{
		#region Controls
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.TextBox txtSuperCategory;
		private System.Windows.Forms.TextBox txtAlign;
		private System.Windows.Forms.Button btnWrite;
		#endregion

		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmWrite()
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.txtSuperCategory = new System.Windows.Forms.TextBox();
			this.txtAlign = new System.Windows.Forms.TextBox();
			this.btnWrite = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "카테고리명:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "부모카테고리번호:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "정렬순서:";
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(152, 32);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.TabIndex = 3;
			this.txtCategoryName.Text = "";
			// 
			// txtSuperCategory
			// 
			this.txtSuperCategory.Location = new System.Drawing.Point(152, 64);
			this.txtSuperCategory.Name = "txtSuperCategory";
			this.txtSuperCategory.TabIndex = 4;
			this.txtSuperCategory.Text = "";
			// 
			// txtAlign
			// 
			this.txtAlign.Location = new System.Drawing.Point(152, 96);
			this.txtAlign.Name = "txtAlign";
			this.txtAlign.TabIndex = 5;
			this.txtAlign.Text = "";
			// 
			// btnWrite
			// 
			this.btnWrite.Location = new System.Drawing.Point(104, 136);
			this.btnWrite.Name = "btnWrite";
			this.btnWrite.TabIndex = 6;
			this.btnWrite.Text = "저장";
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			// 
			// FrmWrite
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 173);
			this.Controls.Add(this.btnWrite);
			this.Controls.Add(this.txtAlign);
			this.Controls.Add(this.txtSuperCategory);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmWrite";
			this.Text = "FrmWrite";
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Handlers
		private void btnWrite_Click(object sender, System.EventArgs e)
		{
			//[1] 변수 선언부
			string strCategoryName = 
				this.txtCategoryName.Text.Trim();
			string strSuperCategory = 
				this.txtSuperCategory.Text.Trim();
			string strAlign = 
				this.txtAlign.Text.Trim();
			string strSql = "WriteCategory";
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

			//[!] 파라미터 3개 추가
			objCmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar, 50);
			objCmd.Parameters["@CategoryName"].Value = strCategoryName;
			objCmd.Parameters.Add("@SuperCategory", SqlDbType.Int);
			objCmd.Parameters["@SuperCategory"].Value = strSuperCategory;
			objCmd.Parameters.Add("@Align", SqlDbType.SmallInt);
			objCmd.Parameters["@Align"].Value = strAlign;

			//[!] ExecuteNonQuery()
			objCmd.ExecuteNonQuery();
			MessageBox.Show("저장되었습니다.");

			//[4] 닫기
			objCon.Close();
		}
		#endregion
	}
}
