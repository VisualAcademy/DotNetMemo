using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[0] ���ӽ����̽� �߰�
using System.Data;//
using System.Data.SqlClient;//

namespace AddressApplication.ADONET
{
	/// <summary>
	/// FrmSqlConnection�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmSqlConnection : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnSqlConnection;
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Button btnExceptionHandling;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmSqlConnection()
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
			this.btnSqlConnection = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.btnExceptionHandling = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSqlConnection
			// 
			this.btnSqlConnection.Location = new System.Drawing.Point(72, 16);
			this.btnSqlConnection.Name = "btnSqlConnection";
			this.btnSqlConnection.Size = new System.Drawing.Size(184, 23);
			this.btnSqlConnection.TabIndex = 0;
			this.btnSqlConnection.Text = "�����ͺ��̽� ����";
			this.btnSqlConnection.Click += new System.EventHandler(this.btnSqlConnection_Click);
			// 
			// lblDisplay
			// 
			this.lblDisplay.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblDisplay.Location = new System.Drawing.Point(0, 102);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(320, 23);
			this.lblDisplay.TabIndex = 1;
			// 
			// btnExceptionHandling
			// 
			this.btnExceptionHandling.Location = new System.Drawing.Point(72, 56);
			this.btnExceptionHandling.Name = "btnExceptionHandling";
			this.btnExceptionHandling.Size = new System.Drawing.Size(184, 23);
			this.btnExceptionHandling.TabIndex = 2;
			this.btnExceptionHandling.Text = "�����ͺ��̽� ����(���� ó��)";
			this.btnExceptionHandling.Click += new System.EventHandler(this.btnExceptionHandling_Click);
			// 
			// FrmSqlConnection
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(320, 125);
			this.Controls.Add(this.btnExceptionHandling);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.btnSqlConnection);
			this.Name = "FrmSqlConnection";
			this.Text = "SqlConnection Ŭ���� : �����ͺ��̽� ����";
			this.Load += new System.EventHandler(this.FrmSqlConnection_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FrmSqlConnection_Load(object sender, System.EventArgs e)
		{
		
		}

		private void btnSqlConnection_Click(object sender, System.EventArgs e)
		{
			//[1] SqlConnection Ŭ������ �ν��Ͻ�
			SqlConnection objCon = 
				new SqlConnection(); 
			//[2] .ConnectionString �Ӽ� 4���� ����
			objCon.ConnectionString = 
				"server=(local);" + 
				"database=AddressDB;" + 
				"uid=AddressUid;pwd=AddressPwd;";
			//[3] .Open() �޼��� �����ͺ��̽� ���� �õ�
			objCon.Open();
			//[!] Process 
			this.lblDisplay.Text = "���� ����";
			//[4] .Close() �޼��� ���� �ݱ�
			objCon.Close();
		}

		// �����ͺ��̽� ����(����ó��)
		private void btnExceptionHandling_Click(object sender, System.EventArgs e)
		{
			SqlConnection objCon = 
				new SqlConnection();
			objCon.ConnectionString = 
				"Data Source=127.0.0.1;" + 
				"Initial Catalog=AddressDB;" + 
				"User ID=AddressUid;" + 
				"Password=AddressPwd__;";

			try{ // ���� �߻��� ���� �ڵ� �ۼ�				
				objCon.Open();
				//[!] Process
				this.lblDisplay.Text = "���� ����";
			}
			catch(Exception ex){ // ���� ���� ó��				
				this.lblDisplay.Text = ex.Message;
			}
			finally{ // ���� �߻�/�̹߻� ������ ����
				// .State �Ӽ� : ���� ���� ����
				// - ConnectionState ������
				if (objCon.State == 
					ConnectionState.Open){
					objCon.Close();
				}
			}

		}
	}
}
