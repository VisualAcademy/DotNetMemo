//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;
////[0] ���ӽ����̽� �߰�
//using System.Data;
//using System.Data.SqlClient;

//namespace CSharp_Windows.�⺻���Խ���
//{
//	/// <summary>
//	/// �˻��� ���� ��� �����Դϴ�.
//	/// </summary>
//	public class �˻� : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.ComboBox comSearchField;
//		private System.Windows.Forms.TextBox txtSearchQuery;
//		private System.Windows.Forms.Button btnSearch;
//		private System.Windows.Forms.DataGrid dgList;
//		private System.Windows.Forms.Button cmdSearch;
//		/// <summary>
//		/// �ʼ� �����̳� �����Դϴ�.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public �˻�()
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
//			this.comSearchField = new System.Windows.Forms.ComboBox();
//			this.txtSearchQuery = new System.Windows.Forms.TextBox();
//			this.btnSearch = new System.Windows.Forms.Button();
//			this.dgList = new System.Windows.Forms.DataGrid();
//			this.cmdSearch = new System.Windows.Forms.Button();
//			((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
//			this.SuspendLayout();
//			// 
//			// comSearchField
//			// 
//			this.comSearchField.Items.AddRange(new object[] {
//																																																				"Name",
//																																																				"Title",
//																																																				"Content",
//																																																				"All"});
//			this.comSearchField.Location = new System.Drawing.Point(16, 24);
//			this.comSearchField.Name = "comSearchField";
//			this.comSearchField.Size = new System.Drawing.Size(121, 20);
//			this.comSearchField.TabIndex = 0;
//			this.comSearchField.Text = "Name";
//			// 
//			// txtSearchQuery
//			// 
//			this.txtSearchQuery.Location = new System.Drawing.Point(144, 24);
//			this.txtSearchQuery.Name = "txtSearchQuery";
//			this.txtSearchQuery.TabIndex = 1;
//			this.txtSearchQuery.Text = "";
//			// 
//			// btnSearch
//			// 
//			this.btnSearch.Location = new System.Drawing.Point(248, 8);
//			this.btnSearch.Name = "btnSearch";
//			this.btnSearch.TabIndex = 2;
//			this.btnSearch.Text = "�˻�";
//			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
//			// 
//			// dgList
//			// 
//			this.dgList.DataMember = "";
//			this.dgList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
//			this.dgList.Location = new System.Drawing.Point(16, 64);
//			this.dgList.Name = "dgList";
//			this.dgList.Size = new System.Drawing.Size(312, 192);
//			this.dgList.TabIndex = 3;
//			// 
//			// cmdSearch
//			// 
//			this.cmdSearch.Location = new System.Drawing.Point(248, 40);
//			this.cmdSearch.Name = "cmdSearch";
//			this.cmdSearch.TabIndex = 4;
//			this.cmdSearch.Text = "�˻�";
//			this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
//			// 
//			// �˻�
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(344, 273);
//			this.Controls.Add(this.cmdSearch);
//			this.Controls.Add(this.dgList);
//			this.Controls.Add(this.btnSearch);
//			this.Controls.Add(this.txtSearchQuery);
//			this.Controls.Add(this.comSearchField);
//			this.Name = "�˻�";
//			this.Text = "�˻�";
//			((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
//			this.ResumeLayout(false);

//		}
//		#endregion

//		//�ζ��� SQL ���
//		private void btnSearch_Click(object sender, System.EventArgs e)
//		{
//			//[1] ����
//			string strSearchField = 
//				comSearchField.Text;//�ʵ�
//			string strSearchQuery = 
//				txtSearchQuery.Text;//�˻���
//			string strSql = String.Empty;
//			if(strSearchField.ToLower() == "all"){
//				strSql = @"
//					Select * From Basic
//					Where 
//						Name Like '%" + strSearchQuery + @"%'
//						Or
//						Title Like '%" + strSearchQuery + @"%'
//						Or
//						Content Like '%" + strSearchQuery + @"%'
//				";
//			}
//			else{ //����ó�� : ȫ�浿 -> " + ���� + @"
//				strSql = @"
//					Select * From Basic 
//					Where 
//					" + strSearchField + @" Like '%" 
//					+ strSearchQuery + @"%'
//				";
//			}
//			//[2] ����
//			SqlConnection objCon = new SqlConnection();
//			objCon.ConnectionString = "server=(local);database=Basic;pwd=Basic;uid=Basic;";
//			objCon.Open();
//			//[3] ���
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;
//			objCmd.CommandType = CommandType.Text;
//			//[4] ��� : �����;����+�����ͼ�+����Ʈ�׸���
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			DataSet objDs = new DataSet();
//			objDa.Fill(objDs, "Basic");
//			this.dgList.DataSource = objDs.Tables["Basic"];
//		}

//		//���� ���ν��� : ���͸� ���
//		private void cmdSearch_Click(object sender, System.EventArgs e)
//		{
//			//[1] ����
//			string strSearchField = 
//				comSearchField.Text;//�ʵ�
//			string strSearchQuery = 
//				txtSearchQuery.Text;//�˻���
//			string strSql = "SearchBasic";
//			string strFilter = String.Empty;
//			if(strSearchField.ToLower() == "all"){
//				strFilter = String.Format(
//					"Name Like '%{0}%' Or Title Like '%{0}%' Or Content Like '%{0}%'", strSearchQuery);
//			}
//			else{
//				strFilter = String.Format("{0} Like '%{1}%'"
//					, strSearchField, strSearchQuery);
//			}				
//			//[2] ����
//			SqlConnection objCon = new SqlConnection();
//			objCon.ConnectionString = "server=(local);database=Basic;pwd=Basic;uid=Basic;";
//			objCon.Open();
//			//[3] ���
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;
//			objCmd.CommandType = CommandType.Text;
//			//[4] ��� : �����;����+�����ͼ�+����Ʈ�׸���
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			DataSet objDs = new DataSet();
//			objDa.Fill(objDs, "Basic");
//			//[!] �˻� : ���͸� 
//			DataView objDv =	//[1]DataView �������� ��ȯ
//				objDs.Tables["Basic"].DefaultView;
//			objDv.RowFilter = strFilter;//[2]���ǿ� �´� �׸�˻�
//			this.dgList.DataSource = objDv;//[3]DataView ���
//		}
//	}
//}
