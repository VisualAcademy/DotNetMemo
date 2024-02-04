using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AddressApplication
{
    /// <summary>
    /// FrmDelete�� ���� ��� �����Դϴ�.
    /// </summary>
    public class FrmDelete : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Button btnDelete;

        #region +
        /// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmDelete()
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
        #endregion

        #region Windows Form �����̳ʿ��� ������ �ڵ�
        /// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "������ ���ڵ� ��ȣ:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(136, 40);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(64, 21);
			this.txtNum.TabIndex = 1;
			this.txtNum.Text = "";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(224, 40);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(88, 23);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "����";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// FrmDelete
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(328, 109);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.label1);
			this.Name = "FrmDelete";
			this.Text = "����";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			//[1] ���� �����
			string strNum = txtNum.Text.Trim();
			string strSql = "DeleteAddress";
//				"Delete Address Where Num = @Num";
//				"Delete Address Where Num = " 
//				+ strNum;
			//[2] Ŀ�ؼ�
			SqlConnection objCon = new SqlConnection();
            objCon.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
			objCon.Open();
			//[3] Ŀ���
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = strSql;
			objCmd.CommandType = 
				CommandType.StoredProcedure;
			//[!] �Ķ���� �߰�
			objCmd.Parameters.Add("@Num", SqlDbType.Int);
			objCmd.Parameters["@Num"].Value = strNum;
			//[!] ����
			int intAffected = 
				objCmd.ExecuteNonQuery();
			if(intAffected > 0)
			{
				MessageBox.Show(
					String.Format(
					"{0}�� ����", intAffected)
					);
			}
			else
			{
				MessageBox.Show("���� �ȵ�");
			}
		}

	}
}
