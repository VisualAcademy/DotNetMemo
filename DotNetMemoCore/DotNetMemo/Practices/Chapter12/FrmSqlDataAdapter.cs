//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;
////
//using System.Data;
//using System.Data.SqlClient;

//namespace AddressApplication.ADONET
//{
//	/// <summary>
//	/// FrmSqlDataAdapter에 대한 요약 설명입니다.
//	/// </summary>
//	public class FrmSqlDataAdapter : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.DataGrid dataGrid1;
//		/// <summary>
//		/// 필수 디자이너 변수입니다.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmSqlDataAdapter()
//		{
//			//
//			// Windows Form 디자이너 지원에 필요합니다.
//			//
//			InitializeComponent();

//			//
//			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
//			//
//		}

//		/// <summary>
//		/// 사용 중인 모든 리소스를 정리합니다.
//		/// </summary>
//		protected override void Dispose( bool disposing )
//		{
//			if( disposing )
//			{
//				if(components != null)
//				{
//					components.Dispose();
//				}
//			}
//			base.Dispose( disposing );
//		}

//		#region Windows Form 디자이너에서 생성한 코드
//		/// <summary>
//		/// 디자이너 지원에 필요한 메서드입니다.
//		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
//		/// </summary>
//		private void InitializeComponent()
//		{
//			this.dataGrid1 = new System.Windows.Forms.DataGrid();
//			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
//			this.SuspendLayout();
//			// 
//			// dataGrid1
//			// 
//			this.dataGrid1.DataMember = "";
//			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
//			this.dataGrid1.Location = new System.Drawing.Point(32, 24);
//			this.dataGrid1.Name = "dataGrid1";
//			this.dataGrid1.Size = new System.Drawing.Size(296, 168);
//			this.dataGrid1.TabIndex = 0;
//			// 
//			// FrmSqlDataAdapter
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(360, 213);
//			this.Controls.Add(this.dataGrid1);
//			this.Name = "FrmSqlDataAdapter";
//			this.Text = "FrmSqlDataAdapter";
//			this.Load += new System.EventHandler(this.FrmSqlDataAdapter_Load);
//			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
//			this.ResumeLayout(false);

//		}
//		#endregion

//		private void FrmSqlDataAdapter_Load(object sender, System.EventArgs e)
//		{
//			SqlConnection objCon = new SqlConnection();
//			objCon.ConnectionString = "server=(local);database=AddressDB;uid=AddressUid;pwd=AddressPwd;";
//			objCon.Open();

//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = 
//				"Select * From Address";
//			objCmd.CommandType = CommandType.Text;

//			//[1] SqlDataAdater 클래스의 인스턴스 생성
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			//[2] .SelectCommand 속성 지정 : Select문 
//			objDa.SelectCommand = objCmd;
//			//[3] DataSet 클래스 : 데이터 담을 공간
//			DataSet objDs = new DataSet();
//			//[4] .Fill() 메서드 : 데이터셋 채우기
//			objDa.Fill(objDs, "Address");
//			//[5] DataGrid.DataSource에 데이터셋 지정
//			this.dataGrid1.DataSource = objDs;

//			objCon.Close();
//		}
//	}
//}
