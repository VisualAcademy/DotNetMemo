using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[0] ���ӽ����̽� �߰�
using System.Data;
using System.Data.SqlClient;

namespace CSharp_Windows.�⺻���Խ���
{
	/// <summary>
	/// �󼼿� ���� ��� �����Դϴ�.
	/// </summary>
	public class �� : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblHomePage;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtContent;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Button btnView;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ��()
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblHomePage = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.txtContent = new System.Windows.Forms.TextBox();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.btnView = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "��ȣ:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "�̸�:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "�̸���:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Ȩ������:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "����:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 184);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "����:";
			// 
			// lblName
			// 
			this.lblName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblName.Location = new System.Drawing.Point(80, 56);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(248, 23);
			this.lblName.TabIndex = 7;
			// 
			// lblEmail
			// 
			this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblEmail.Location = new System.Drawing.Point(80, 88);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(248, 23);
			this.lblEmail.TabIndex = 8;
			// 
			// lblHomePage
			// 
			this.lblHomePage.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblHomePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblHomePage.Location = new System.Drawing.Point(80, 120);
			this.lblHomePage.Name = "lblHomePage";
			this.lblHomePage.Size = new System.Drawing.Size(248, 23);
			this.lblHomePage.TabIndex = 9;
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTitle.Location = new System.Drawing.Point(80, 152);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(248, 23);
			this.lblTitle.TabIndex = 10;
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(80, 176);
			this.txtContent.Multiline = true;
			this.txtContent.Name = "txtContent";
			this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtContent.Size = new System.Drawing.Size(248, 72);
			this.txtContent.TabIndex = 11;
			this.txtContent.Text = "";
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(80, 24);
			this.txtNum.Name = "txtNum";
			this.txtNum.TabIndex = 12;
			this.txtNum.Text = "";
			// 
			// btnView
			// 
			this.btnView.Location = new System.Drawing.Point(216, 24);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(112, 23);
			this.btnView.TabIndex = 13;
			this.btnView.Text = "�󼼺���";
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// ��
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(360, 261);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.txtContent);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblHomePage);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "��";
			this.Text = "��";
			this.ResumeLayout(false);

		}
		#endregion

		//�󼼺��� ��ư Ŭ��
		private void btnView_Click(object sender, System.EventArgs e)
		{
			if(this.txtNum.Text == ""){
				MessageBox.Show("��ȣ�� �Է��ϼ���.");
			}
			else{
				UpdateReadCountBasic();//[1]��ȸ�� ���� �Լ� ����
				ViewBasic();//[2]�󼼺��� ���
			}
		}

		//[1]�󼼺��� ���� �Լ� : Select / �������ν���
		private void ViewBasic(){
			//[1] ���� �����
			string strNum = this.txtNum.Text;//��ȣ
			string strSql = "ViewBasic";//�������ν���
			//[2] ����
			SqlConnection objCon = new SqlConnection();
			objCon.ConnectionString = "server=(local);database=Basic;pwd=Basic;uid=Basic;";
			objCon.Open();
			//[3] ��ɾ�
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = strSql;
			objCmd.CommandType =CommandType.StoredProcedure;
			//[!] �Ű����� �߰�
			objCmd.Parameters.Add("@Num", SqlDbType.Int);
			objCmd.Parameters["@Num"].Value = strNum;
			//[4] ��� : SqlDataReader Ŭ������ ���
			SqlDataReader objDr = objCmd.ExecuteReader();//*
			if(objDr.Read())
			{
				this.lblName.Text = objDr["Name"].ToString();//�̸��ʵ����
				this.lblEmail.Text = objDr["Email"].ToString();
				this.lblHomePage.Text = objDr["HomePage"].ToString();
				lblTitle.Text = objDr["Title"].ToString();
				txtContent.Text = objDr["Content"].ToString();
			}
			else
			{
				MessageBox.Show(strNum + "�� ���� �����ϴ�.");
			}
			objDr.Close();
			//[5] �ݱ�
			objCon.Close();
			//[6] ����
			this.txtNum.Text = "";
		}

		//[2]��ȸ�� ���� �Լ� : Update / �ζ��� SQL
		private void UpdateReadCountBasic(){
			//[1] ���� �����
			string strNum = this.txtNum.Text;//��ȣ
			string strSql = "Update Basic Set ReadCount = ReadCount + 1 Where Num = " + strNum;//�ζ��� SQL
			//[2] ����
			SqlConnection objCon = new SqlConnection();
			objCon.ConnectionString = "server=(local);database=Basic;pwd=Basic;uid=Basic;";
			objCon.Open();
			//[3] ��ɾ�
			SqlCommand objCmd = new SqlCommand();
			objCmd.Connection = objCon;
			objCmd.CommandText = strSql;
			objCmd.CommandType =CommandType.Text;
			objCmd.ExecuteNonQuery();
			//[4] �ݱ�
			objCon.Close();
		}
	}
}
