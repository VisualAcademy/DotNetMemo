////[0] ���ӽ����̽� �߰�
//using System.Data.OleDb; //

//namespace AddressApplication.ADONET
//{
//    /// <summary>
//    /// FrmOleDbConnection�� ���� ��� �����Դϴ�.
//    /// </summary>
//    public class FrmOleDbConnection : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.Button btnOleDbConnection;
//		private System.Windows.Forms.Label lblDisplay;
//		/// <summary>
//		/// �ʼ� �����̳� �����Դϴ�.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmOleDbConnection()
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
//			this.btnOleDbConnection = new System.Windows.Forms.Button();
//			this.lblDisplay = new System.Windows.Forms.Label();
//			this.SuspendLayout();
//			// 
//			// btnOleDbConnection
//			// 
//			this.btnOleDbConnection.Location = new System.Drawing.Point(136, 24);
//			this.btnOleDbConnection.Name = "btnOleDbConnection";
//			this.btnOleDbConnection.Size = new System.Drawing.Size(136, 23);
//			this.btnOleDbConnection.TabIndex = 0;
//			this.btnOleDbConnection.Text = "Access DB ����";
//			this.btnOleDbConnection.Click += new System.EventHandler(this.btnOleDbConnection_Click);
//			// 
//			// lblDisplay
//			// 
//			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
//			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
//			this.lblDisplay.Location = new System.Drawing.Point(0, 78);
//			this.lblDisplay.Name = "lblDisplay";
//			this.lblDisplay.Size = new System.Drawing.Size(424, 23);
//			this.lblDisplay.TabIndex = 1;
//			// 
//			// FrmOleDbConnection
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(424, 101);
//			this.Controls.Add(this.lblDisplay);
//			this.Controls.Add(this.btnOleDbConnection);
//			this.Name = "FrmOleDbConnection";
//			this.Text = "OleDbConnection Ŭ���� : �����ͺ��̽� ����(Access,Oracle)";
//			this.ResumeLayout(false);

//		}
//		#endregion

//		private void btnOleDbConnection_Click(object sender, System.EventArgs e)
//		{
//			//[1] OleDbConnection Ŭ���� �ν��Ͻ�
//			OleDbConnection objCon = 
//				new OleDbConnection();
//			//[2] .ConnectionString �Ӽ� ����:UDL
//			objCon.ConnectionString = 
//				@"Provider=Microsoft.Jet.OLEDB.4.0;
//					Data Source=C:\CSharp\" + 
//				@"AddressApplication\Database\" + 
//				@"AddressDB.mdb;" + 
//					"Persist Security Info=False";
//			//[3] .Open() �޼���
//			objCon.Open();
//			//[!] Process
//			this.lblDisplay.Text = "���� ����";
//			//[4] .Close() �޼���
//			objCon.Close();
//		}

//	}
//}
