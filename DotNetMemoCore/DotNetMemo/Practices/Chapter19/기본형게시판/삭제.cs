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
//	public class ���� : System.Windows.Forms.Form
//	{
//		#region Private Fields
//		private System.Windows.Forms.Label label1;
//		private System.Windows.Forms.DataGrid dgList;
//		private System.Windows.Forms.TextBox txtNum;
//		private System.Windows.Forms.Button btnDelete;
//		#endregion
//		#region +
//		/// <summary>
//		/// �ʼ� �����̳� �����Դϴ�.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public ����()
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
//			this.dgList = new System.Windows.Forms.DataGrid();
//			this.txtNum = new System.Windows.Forms.TextBox();
//			this.btnDelete = new System.Windows.Forms.Button();
//			this.label1 = new System.Windows.Forms.Label();
//			((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
//			this.SuspendLayout();
//			// 
//			// dgList
//			// 
//			this.dgList.DataMember = "";
//			this.dgList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
//			this.dgList.Location = new System.Drawing.Point(16, 16);
//			this.dgList.Name = "dgList";
//			this.dgList.ReadOnly = true;
//			this.dgList.Size = new System.Drawing.Size(136, 144);
//			this.dgList.TabIndex = 0;
//			// 
//			// txtNum
//			// 
//			this.txtNum.Location = new System.Drawing.Point(256, 56);
//			this.txtNum.Name = "txtNum";
//			this.txtNum.Size = new System.Drawing.Size(80, 21);
//			this.txtNum.TabIndex = 1;
//			this.txtNum.Text = "";
//			// 
//			// btnDelete
//			// 
//			this.btnDelete.Location = new System.Drawing.Point(208, 96);
//			this.btnDelete.Name = "btnDelete";
//			this.btnDelete.Size = new System.Drawing.Size(96, 23);
//			this.btnDelete.TabIndex = 2;
//			this.btnDelete.Text = "����";
//			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
//			// 
//			// label1
//			// 
//			this.label1.Location = new System.Drawing.Point(152, 56);
//			this.label1.Name = "label1";
//			this.label1.TabIndex = 3;
//			this.label1.Text = "������ �� ��ȣ :";
//			// 
//			// ����
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(360, 173);
//			this.Controls.Add(this.label1);
//			this.Controls.Add(this.btnDelete);
//			this.Controls.Add(this.txtNum);
//			this.Controls.Add(this.dgList);
//			this.Name = "����";
//			this.Text = "����";
//			this.Load += new System.EventHandler(this.����_Load);
//			((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
//			this.ResumeLayout(false);

//		}
//		#endregion
//		#endregion
//		//�ζ��� SQL��
//		private void ����_Load(object sender, System.EventArgs e)
//		{
//			//[1] ����
//			string strSql = "Select Num, Title From Basic";
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
//		//�������ν���
//		private void btnDelete_Click(object sender, System.EventArgs e)
//		{
//			//[1] ����
//			string strNum = this.txtNum.Text;
//			string strSql = "DeleteBasic";
//			//[2] ����
//			SqlConnection objCon = new SqlConnection();
//			objCon.ConnectionString = "server=(local);database=Basic;pwd=Basic;uid=Basic;";
//			objCon.Open();
//			//[3] ���
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;
//			objCmd.CommandType =CommandType.StoredProcedure;
//			//[!] SQL �Ķ����(�Ű�����) �߰�
//			objCmd.Parameters.Add("@Num", SqlDbType.Int);
//			objCmd.Parameters["@Num"].Value = strNum;
//			objCmd.ExecuteNonQuery();//����
//			//[4] �ݱ�/����			
//			objCon.Close(); this.txtNum.Text = "";
//			//[5] ������ ���� �о����
//			����_Load(null, null);
//		}
//	}
//}
