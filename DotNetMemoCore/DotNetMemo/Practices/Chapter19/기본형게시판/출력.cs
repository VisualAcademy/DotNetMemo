//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;
////[0] ���ӽ����̽��߰�
//using System.Data;
//using System.Data.SqlClient;
//using System.IO;
//using System.Xml;

//namespace CSharp_Windows.�⺻���Խ���
//{
//	/// <summary>
//	/// ��¿� ���� ��� �����Դϴ�.
//	/// </summary>
//	public class ��� : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.Label label1;
//		private System.Windows.Forms.DataGrid dgList;
//		/// <summary>
//		/// �ʼ� �����̳� �����Դϴ�.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public ���()
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
//			this.label1 = new System.Windows.Forms.Label();
//			this.dgList = new System.Windows.Forms.DataGrid();
//			((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
//			this.SuspendLayout();
//			// 
//			// label1
//			// 
//			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
//			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
//			this.label1.Font = new System.Drawing.Font("����", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
//			this.label1.Location = new System.Drawing.Point(0, 0);
//			this.label1.Name = "label1";
//			this.label1.Size = new System.Drawing.Size(376, 32);
//			this.label1.TabIndex = 0;
//			this.label1.Text = "�⺻���Խ��� ����Ʈ";
//			// 
//			// dgList
//			// 
//			this.dgList.DataMember = "";
//			this.dgList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
//			this.dgList.Location = new System.Drawing.Point(8, 40);
//			this.dgList.Name = "dgList";
//			this.dgList.Size = new System.Drawing.Size(360, 168);
//			this.dgList.TabIndex = 1;
//			// 
//			// ���
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(376, 221);
//			this.Controls.Add(this.dgList);
//			this.Controls.Add(this.label1);
//			this.Name = "���";
//			this.Text = "���";
//			this.Load += new System.EventHandler(this.���_Load);
//			((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
//			this.ResumeLayout(false);

//		}
//		#endregion

//		private void ���_Load(object sender, System.EventArgs e)
//		{	
//			//[1] ���� �����
//			string strSql = "ListBasic";
//			//[2] Ŀ�ؼ�
//			SqlConnection objCon = new SqlConnection();
//			objCon.ConnectionString = "server=(local);database=Basic;User ID=Basic;Password=Basic;";
//			objCon.Open();
//			//[3] ��ɾ�
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;
//			objCmd.CommandType = CommandType.StoredProcedure;
//			//[!] ��� ���� : �����;���� + �����ͼ�
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			DataSet objDs = new DataSet();
//			objDa.Fill(objDs, "Basic");
//			this.dgList.DataSource = objDs.Tables["Basic"];//
//			//dgList.DataBind();//WebForm
//			//[4] �ݱ�
//			objCon.Close();
//			//[5] ����
//		}
//	}
//}
