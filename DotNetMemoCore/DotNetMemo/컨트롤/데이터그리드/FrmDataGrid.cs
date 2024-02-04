//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;
////
//using System.Data;
//using System.Data.SqlClient;

//namespace CSharp_Windows.데이터그리드{
//	public class FrmDataGrid : System.Windows.Forms.Form{
//		private System.Windows.Forms.Button btnCommand;
//		private System.Windows.Forms.DataGrid dgDataTable;
//		#region +
//		/// <summary>
//		/// 필수 디자이너 변수입니다.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmDataGrid()
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
//			this.dgDataTable = new System.Windows.Forms.DataGrid();
//			this.btnCommand = new System.Windows.Forms.Button();
//			((System.ComponentModel.ISupportInitialize)(this.dgDataTable)).BeginInit();
//			this.SuspendLayout();
//			// 
//			// dgDataTable
//			// 
//			this.dgDataTable.DataMember = "";
//			this.dgDataTable.HeaderForeColor = System.Drawing.SystemColors.ControlText;
//			this.dgDataTable.Location = new System.Drawing.Point(24, 16);
//			this.dgDataTable.Name = "dgDataTable";
//			this.dgDataTable.Size = new System.Drawing.Size(288, 88);
//			this.dgDataTable.TabIndex = 0;
//			// 
//			// btnCommand
//			// 
//			this.btnCommand.Location = new System.Drawing.Point(96, 112);
//			this.btnCommand.Name = "btnCommand";
//			this.btnCommand.Size = new System.Drawing.Size(160, 23);
//			this.btnCommand.TabIndex = 1;
//			this.btnCommand.Text = "데이터그리드 채우기";
//			this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
//			// 
//			// FrmDataGrid
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(336, 141);
//			this.Controls.Add(this.btnCommand);
//			this.Controls.Add(this.dgDataTable);
//			this.Name = "FrmDataGrid";
//			this.Text = "FrmDataGrid";
//			((System.ComponentModel.ISupportInitialize)(this.dgDataTable)).EndInit();
//			this.ResumeLayout(false);

//		}
//		#endregion
//		#endregion
//		private void btnCommand_Click(object sender, System.EventArgs e){
//			//[1] 테이블 만들기 : Member
//			DataTable objMember = new DataTable();
//			objMember.TableName = "Member";
//			//[2] 필드(컬럼) 만들기
//			//번호 필드
//			DataColumn objNum = new DataColumn();
//			objNum.ColumnName = "Num";
//			objNum.DataType = Type.GetType("System.Int32");//데이터 형
//			objNum.AllowDBNull = false;//널 값 허용 안함
//			objNum.ReadOnly = true;
//			objNum.Unique = true;//고유키
//			objNum.AutoIncrement = true;
//			objNum.AutoIncrementSeed = 1;
//			objNum.AutoIncrementStep = 1;
//            //이름 필드
//			DataColumn objName = new DataColumn();
//			objName.ColumnName = "Name";
//			objName.DataType = Type.GetType("System.String");//데이터 형
//			objName.AllowDBNull = false;//널 값 허용 안함
//			//필드 추가
//			objMember.Columns.Add(objNum);
//			objMember.Columns.Add(objName);
//			//기본키 설정
//			DataColumn [] objPrimaryKey = new DataColumn[1];
//			objPrimaryKey[0] = objNum;
//			objMember.PrimaryKey = objPrimaryKey;
//			//[3] 레코드 만들기
//			DataRow objRecord = objMember.NewRow();
//			objRecord["Name"] = "홍길동";
//			objMember.Rows.Add(objRecord);
//			objRecord = objMember.NewRow();
//			objRecord["Name"] = "백두산";
//			objMember.Rows.Add(objRecord);
//			//데이터그리드 컨트롤에 출력
//			this.dgDataTable.DataSource = objMember;
//		}
//	}
//}
