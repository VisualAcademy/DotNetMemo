//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;
////
//using System.Data;
//using System.Data.SqlClient;

//namespace CSharp_Windows
//{
//	/// <summary>
//	/// FrmCategory�� ���� ��� �����Դϴ�.
//	/// </summary>
//	public class FrmCategory : System.Windows.Forms.Form
//	{
//		#region Controls
//		private System.Windows.Forms.DataGrid ctlCategoryList;
//		private System.Windows.Forms.Button btnAdd;
//		private System.Windows.Forms.Button btnList;
//		private System.Windows.Forms.Button btnModify;
//		#endregion

//		#region Private Member Variables
//		/// <summary>
//		/// �ʼ� �����̳� �����Դϴ�.
//		/// </summary>
//		private System.ComponentModel.Container components = null;
//		private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Commerce;Data Source=REDPLUSDESKTOP\SQLEXPRESS";
//		private DataSet objDs = new DataSet();
//		#endregion

//		public FrmCategory()
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
//			this.ctlCategoryList = new System.Windows.Forms.DataGrid();
//			this.btnAdd = new System.Windows.Forms.Button();
//			this.btnList = new System.Windows.Forms.Button();
//			this.btnModify = new System.Windows.Forms.Button();
//			((System.ComponentModel.ISupportInitialize)(this.ctlCategoryList)).BeginInit();
//			this.SuspendLayout();
//			// 
//			// ctlCategoryList
//			// 
//			this.ctlCategoryList.AlternatingBackColor = System.Drawing.Color.GhostWhite;
//			this.ctlCategoryList.BackColor = System.Drawing.Color.GhostWhite;
//			this.ctlCategoryList.BackgroundColor = System.Drawing.Color.Lavender;
//			this.ctlCategoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
//			this.ctlCategoryList.CaptionBackColor = System.Drawing.Color.RoyalBlue;
//			this.ctlCategoryList.CaptionForeColor = System.Drawing.Color.White;
//			this.ctlCategoryList.DataMember = "";
//			this.ctlCategoryList.FlatMode = true;
//			this.ctlCategoryList.Font = new System.Drawing.Font("Tahoma", 8F);
//			this.ctlCategoryList.ForeColor = System.Drawing.Color.MidnightBlue;
//			this.ctlCategoryList.GridLineColor = System.Drawing.Color.RoyalBlue;
//			this.ctlCategoryList.HeaderBackColor = System.Drawing.Color.MidnightBlue;
//			this.ctlCategoryList.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
//			this.ctlCategoryList.HeaderForeColor = System.Drawing.Color.Lavender;
//			this.ctlCategoryList.LinkColor = System.Drawing.Color.Teal;
//			this.ctlCategoryList.Location = new System.Drawing.Point(16, 16);
//			this.ctlCategoryList.Name = "ctlCategoryList";
//			this.ctlCategoryList.ParentRowsBackColor = System.Drawing.Color.Lavender;
//			this.ctlCategoryList.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
//			this.ctlCategoryList.PreferredColumnWidth = 100;
//			this.ctlCategoryList.PreferredRowHeight = 20;
//			this.ctlCategoryList.SelectionBackColor = System.Drawing.Color.Teal;
//			this.ctlCategoryList.SelectionForeColor = System.Drawing.Color.PaleGreen;
//			this.ctlCategoryList.Size = new System.Drawing.Size(464, 248);
//			this.ctlCategoryList.TabIndex = 0;
//			// 
//			// btnAdd
//			// 
//			this.btnAdd.Location = new System.Drawing.Point(80, 280);
//			this.btnAdd.Name = "btnAdd";
//			this.btnAdd.TabIndex = 1;
//			this.btnAdd.Text = "�Է�";
//			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
//			// 
//			// btnList
//			// 
//			this.btnList.Location = new System.Drawing.Point(208, 280);
//			this.btnList.Name = "btnList";
//			this.btnList.TabIndex = 2;
//			this.btnList.Text = "���";
//			this.btnList.Click += new System.EventHandler(this.btnList_Click);
//			// 
//			// btnModify
//			// 
//			this.btnModify.Location = new System.Drawing.Point(344, 280);
//			this.btnModify.Name = "btnModify";
//			this.btnModify.TabIndex = 3;
//			this.btnModify.Text = "����";
//			this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
//			// 
//			// FrmCategory
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(496, 318);
//			this.Controls.Add(this.btnModify);
//			this.Controls.Add(this.btnList);
//			this.Controls.Add(this.btnAdd);
//			this.Controls.Add(this.ctlCategoryList);
//			this.Name = "FrmCategory";
//			this.Text = "FrmCategory";
//			((System.ComponentModel.ISupportInitialize)(this.ctlCategoryList)).EndInit();
//			this.ResumeLayout(false);

//		}
//		#endregion

//		#region Event Handlers
//		private void btnAdd_Click(object sender, System.EventArgs e)
//		{
//			objDs.Clear();
//			//[1] ���� �����
//			string strSql = "Select * From Categories";
//			//[2] Ŀ�ؼ�
//			SqlConnection objCon = new SqlConnection();
//			objCon.ConnectionString = strCon;
//			objCon.Open();
//			//[3] Ŀ���
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;
//			objCmd.CommandType = CommandType.Text;
//			//[4] �����;����
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			SqlCommandBuilder objCb = new SqlCommandBuilder(objDa);//
//			//[5] �����ͼ�
////			DataSet objDs = new DataSet();
//			objDa.Fill(objDs, "Categories");
//			//[6] �����ͱ׸���
//			this.ctlCategoryList.DataSource = 
//				objDs.Tables["Categories"].DefaultView;
//			//[7] �����ͷο�
//			DataRow objDr = objDs.Tables["Categories"].NewRow();
//			objDr["CategoryName"] = "ī�װ�" + 
//				objDs.Tables["Categories"].Rows.Count.ToString();
//			objDr["SuperCategory"] = 1;
//			objDr["Align"] = 0;
//			objDs.Tables["Categories"].Rows.Add(objDr);
//			//[!] ������Ʈ
//			objDa.Update(objDs, "Categories");
//			//[8] ������
//			objCon.Close();
//		}

//		private void btnList_Click(object sender, System.EventArgs e)
//		{
//			objDs.Clear();
//			//[1] ���� �����
//			string strSql = "Select * From Categories";
//			//[2] Ŀ�ؼ�
//			SqlConnection objCon = new SqlConnection();
//			objCon.ConnectionString = strCon;
//			objCon.Open();
//			//[3] Ŀ���
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;
//			objCmd.CommandType = CommandType.Text;
//			//[4] �����;����
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			SqlCommandBuilder objCb = new SqlCommandBuilder(objDa);//
//			//[5] �����ͼ�
////			DataSet objDs = new DataSet();
//			objDa.Fill(objDs, "Categories");
//			//[6] �����ͱ׸���
//			this.ctlCategoryList.DataSource = 
//				objDs.Tables["Categories"].DefaultView;
//			//[7] ������
//			objCon.Close();		
//		}

//		private void btnModify_Click(object sender, System.EventArgs e)
//		{
//			//[1] ���� �����
//			string strSql = "Select * From Categories";
//			//[2] Ŀ�ؼ�
//			SqlConnection objCon = new SqlConnection();
//			objCon.ConnectionString = strCon;
//			objCon.Open();
//			//[3] Ŀ���
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;
//			objCmd.CommandType = CommandType.Text;
//			//[4] �����;����
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			SqlCommandBuilder objCb = new SqlCommandBuilder(objDa);//
//			//[!] ������ ������Ʈ
//			objDa.Update(objDs, "Categories");
//			//[5] ������
//			objCon.Close();		
//			objDs.Clear();
//			this.btnList_Click(null, null);
//		}
//		#endregion
//	}
//}
