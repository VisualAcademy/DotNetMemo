//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;

//namespace AddressApplication
//{
//    /// <summary>
//    /// FrmList�� ���� ��� �����Դϴ�.
//    /// </summary>
//    public class FrmList : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.DataGrid dataGrid1;

//        #region +
//        /// <summary>
//		/// �ʼ� �����̳� �����Դϴ�.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmList()
//		{
//			//
//			// Windows Form �����̳� ������ �ʿ��մϴ�.
//			//
//			InitializeComponent();

//			//
//			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
//			//
//		}

//		/// <summary>
//		/// ��� ���� ��� ���ҽ��� �����մϴ�.
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
//        }
//        #endregion

//        #region Windows Form �����̳ʿ��� ������ �ڵ�
//        /// <summary>
//		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
//		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
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
//			this.dataGrid1.Location = new System.Drawing.Point(16, 16);
//			this.dataGrid1.Name = "dataGrid1";
//			this.dataGrid1.Size = new System.Drawing.Size(416, 192);
//			this.dataGrid1.TabIndex = 0;
//			// 
//			// FrmList
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(448, 221);
//			this.Controls.Add(this.dataGrid1);
//			this.Name = "FrmList";
//			this.Text = "���";
//			this.Load += new System.EventHandler(this.FrmList_Load);
//			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
//			this.ResumeLayout(false);

//		}
//		#endregion

//		private void FrmList_Load(object sender, System.EventArgs e)
//		{
//			//[1] Ŀ�ؼ�
//			SqlConnection objCon = new SqlConnection();
//			objCon.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
//			objCon.Open();
//			//[2] Ŀ���
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = "ListAddress";//SP
//				//"Select * From Address";//Inline SQL
//			objCmd.CommandType = CommandType.StoredProcedure;
//			//[3] �����;����
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			//[4] �����ͼ�
//			DataSet objDs = new DataSet();
//			objDa.Fill(objDs, "Address");
//			//[5] �����ͱ׸���
//			this.dataGrid1.DataSource = objDs;
//		}
//	}
//}
