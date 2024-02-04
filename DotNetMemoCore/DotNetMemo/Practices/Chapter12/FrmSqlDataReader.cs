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
	/// FrmSqlDataReader�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmSqlDataReader : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Button btnGetDate;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmSqlDataReader()
		{
			//
			// Windows Form �����̳� ������ �ʿ��մϴ�.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
			//
		}

		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
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

		#region Windows Form �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
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
			this.btnGetDate.Text = "���� ��¥�� �ð�";
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
			//[1] SqlDataReader Ŭ������ �ν��Ͻ� ����
			SqlDataReader objDr = 
				objCmd.ExecuteReader();
			//[2] .Read() �޼��� : ������ �ִ��� Ȯ��
			if (objDr.Read())
			{
				//[3] .Get???() �޼��� : �ʵ尪 �б�
				// �Ǵ� �ε��� ���
				this.lblDisplay.Text = 
					objDr[0].ToString();
				//lblDisplay.Text = 
				//	objDr.GetDateTime(0).ToString();
			}
			//[4] .Close() �޼��� : �б� ����
			objDr.Close();
			objCon.Close();
		}
	}
}
