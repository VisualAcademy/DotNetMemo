using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb; // 

namespace AddressApplication.ADONET
{
	/// <summary>
	/// FrmOleDbCommand�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmOleDbCommand : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtQuery;
		private System.Windows.Forms.Button btnExecute;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmOleDbCommand()
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
			this.txtQuery = new System.Windows.Forms.TextBox();
			this.btnExecute = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtQuery
			// 
			this.txtQuery.Location = new System.Drawing.Point(16, 16);
			this.txtQuery.Multiline = true;
			this.txtQuery.Name = "txtQuery";
			this.txtQuery.Size = new System.Drawing.Size(208, 168);
			this.txtQuery.TabIndex = 0;
			this.txtQuery.Text = "";
			// 
			// btnExecute
			// 
			this.btnExecute.Location = new System.Drawing.Point(256, 80);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(96, 23);
			this.btnExecute.TabIndex = 1;
			this.btnExecute.Text = "��ɾ� ����";
			this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
			// 
			// FrmOleDbCommand
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(368, 197);
			this.Controls.Add(this.btnExecute);
			this.Controls.Add(this.txtQuery);
			this.Name = "FrmOleDbCommand";
			this.Text = "FrmOleDbCommand";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExecute_Click(object sender, System.EventArgs e)
		{
			//OleDbConnection objCon = new OleDbConnection();
			//objCon.ConnectionString = 
			//	@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\CSharp\AddressApplication\Database\AddressDB.mdb;Persist Security Info=False";
			//objCon.Open();

			//OleDbCommand objCmd = new OleDbCommand();
			//objCmd.Connection = objCon;
			//objCmd.CommandText = txtQuery.Text;
			//objCmd.CommandType = CommandType.Text;
			//objCmd.ExecuteNonQuery();
			//MessageBox.Show("�����߽��ϴ�.","��ɾ� ����");

			//objCon.Close();
		}
	}
}
