using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[0]
using System.Data;//
using System.Data.SqlClient;//

namespace CSharp_Database{
	public class ���� : System.Windows.Forms.Form{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		#region +
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ����()
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

		#region Windows Form Designer generated code
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(72, 40);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "�����ͺ��̽� ����/����";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(72, 88);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(160, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "���̺� ����";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label1.Location = new System.Drawing.Point(0, 142);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 23);
			this.label1.TabIndex = 2;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ����
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 165);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.label1,
																																	this.button2,
																																	this.button1});
			this.Name = "����";
			this.Text = "����";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void button1_Click(object sender, System.EventArgs e){
			//[1] 
			SqlConnection objCon = new SqlConnection();
			//[2]
			objCon.ConnectionString = 
				"server=(local);database=Web;uid=Web;pwd=Web;";
			try
			{
				//[3] 
				objCon.Open();
				//[4]
				if(objCon.State == ConnectionState.Open)
				{
					this.label1.Text = "�����ͺ��̽��� ����Ǿ����ϴ�.\n" 
						+ "�����ͺ��̽� : " + objCon.Database + "\n"
						+ "���Ṯ�ڿ� : " + objCon.ConnectionString + "\n"
						+ "�������� : " + objCon.ServerVersion;
				}
			}
			catch(Exception ex)
			{
				this.label1.Text = "�����ͺ��̽��� ������� �ʾҽ��ϴ�.\n" 
					+ ex.ToString();
			}
			finally
			{
				if(objCon != null)
				{
					//[5] 
					objCon.Close();
				}
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			SqlConnection objCon = new SqlConnection();
			objCon.ConnectionString = 
				"server=(local);database=Web;uid=Web;pwd=Web;";
			objCon.Open();

			//[1] Command Ŭ������ �ν��Ͻ� ����
			SqlCommand objCmd = new SqlCommand();
			//[2] � ������ ���?
			objCmd.Connection = objCon;
			//[3] � ����� ����?
			objCmd.CommandText = @"
				Create Table dbo.Memo
				(
					Num Int Identity(1, 1) Primary Key Not Null,	--��ȣ
					Name VarChar(25) Null,			--�̸�
					Email VarChar(100) Null,			--�̸���
					Title VarChar(150) Null,			--����
					PostDate DateTime Default GetDate()	--�ۼ���	
				)
			";
			//[4] ��ɾ � Ÿ������?
			objCmd.CommandType = CommandType.Text;//�Ϲ� SQL��
			//[5] ��ȯ���� ���� ��ɾ� ���� : Select ����
			objCmd.ExecuteNonQuery();

			objCon.Close();
		}
	}
}






