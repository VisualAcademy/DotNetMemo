using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//
using System.Data;
using System.Data.SqlClient; // 

namespace AddressApplication.ADONET
{
	/// <summary>
	/// FrmSqlDataReader에 대한 요약 설명입니다.
	/// </summary>
	public class FrmSqlDataReader : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Button btnGetDate;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmSqlDataReader()
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
			this.lblDisplay = new System.Windows.Forms.Label();
			this.btnGetDate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDisplay.Location = new System.Drawing.Point(0, 0);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(336, 23);
			this.lblDisplay.TabIndex = 0;
			this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnGetDate
			// 
			this.btnGetDate.Location = new System.Drawing.Point(112, 40);
			this.btnGetDate.Name = "btnGetDate";
			this.btnGetDate.Size = new System.Drawing.Size(120, 23);
			this.btnGetDate.TabIndex = 1;
			this.btnGetDate.Text = "현재 날짜와 시간";
			this.btnGetDate.Click += new System.EventHandler(this.btnGetDate_Click);
			// 
			// FrmSqlDataReader
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(336, 77);
			this.Controls.Add(this.btnGetDate);
			this.Controls.Add(this.lblDisplay);
			this.Name = "FrmSqlDataReader";
			this.Text = "FrmSqlDataReader";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnGetDate_Click(object sender, System.EventArgs e)
		{
			SqlConnection objCon = new SqlConnection();
			objCon.ConnectionString = 
				String.Format(
					"server={0};database={1};" + 
					"uid={2};pwd={3};",
					"(local)", "AddressDB", 
					"AddressUid", "AddressPwd");
			objCon.Open();
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = 
				"Select GetDate()";
			objCmd.CommandType = CommandType.Text;
			//[1] SqlDataReader 클래스의 인스턴스 생성
			SqlDataReader objDr = 
				objCmd.ExecuteReader();
			//[2] .Read() 메서드 : 데이터 있는지 확인
			if (objDr.Read())
			{
				//[3] .Get???() 메서드 : 필드값 읽기
				// 또는 인덱서 사용
				this.lblDisplay.Text = 
					objDr[0].ToString();
				//lblDisplay.Text = 
				//	objDr.GetDateTime(0).ToString();
			}
			//[4] .Close() 메서드 : 읽기 종료
			objDr.Close();
			objCon.Close();
		}
	}
}
