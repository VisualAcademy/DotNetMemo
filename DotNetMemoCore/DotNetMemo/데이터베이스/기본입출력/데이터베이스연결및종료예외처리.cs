using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//[1] ���ӽ����̽� �߰�
using System.Data;
using System.Data.SqlClient;

namespace CSharp_Database
{
	public class �����ͺ��̽���������Ό��ó�� : System.Windows.Forms.Form
	{
		#region +
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public �����ͺ��̽���������Ό��ó��()
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
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(96, 144);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 64);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// �����ͺ��̽���������Ό��ó��
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.label1,
																																	this.button1});
			this.Name = "�����ͺ��̽���������Ό��ó��";
			this.Text = "�����ͺ��̽���������Ό��ó��";
			this.ResumeLayout(false);

		}
		#endregion
		#endregion
		private void button1_Click(object sender, System.EventArgs e)
		{
			//[2] SqlConnectin Ŭ����
			SqlConnection objCon = new SqlConnection();
			//[3] ConnectionString �Ӽ�
			objCon.ConnectionString = 
				"server=(local);database=pubs;uid=sa;pwd=pass1;";
			try{
				//[4] Open() �޼���
				objCon.Open();
				//[5] State �Ӽ�
				if(objCon.State == ConnectionState.Open)
				{
					this.label1.Text = "���� �Ϸ�.";
				}
			}
			catch(Exception ex){
				this.label1.Text = "������� ����.\n===============" 
					+ ex.Message;
			}
			finally{
				//[6] Close() �޼���
				objCon.Close();		
				this.label1.Text += "�̰��� ����ɱ��???";	
			}			
			//[7] ����
			//objCon.Dispose();//objCon = null;
		}
	}
}
