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
//	/// FrmSqlDataAdapter�� ���� ��� �����Դϴ�.
//	/// </summary>
//	public class FrmSqlDataAdapter : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.DataGrid dataGrid1;
//		/// <summary>
//		/// �ʼ� �����̳� �����Դϴ�.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmSqlDataAdapter()
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
//		}

//		#region Windows Form �����̳ʿ��� ������ �ڵ�
//		/// <summary>
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

//			//[1] SqlDataAdater Ŭ������ �ν��Ͻ� ����
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			//[2] .SelectCommand �Ӽ� ���� : Select�� 
//			objDa.SelectCommand = objCmd;
//			//[3] DataSet Ŭ���� : ������ ���� ����
//			DataSet objDs = new DataSet();
//			//[4] .Fill() �޼��� : �����ͼ� ä���
//			objDa.Fill(objDs, "Address");
//			//[5] DataGrid.DataSource�� �����ͼ� ����
//			this.dataGrid1.DataSource = objDs;

//			objCon.Close();
//		}
//	}
//}
