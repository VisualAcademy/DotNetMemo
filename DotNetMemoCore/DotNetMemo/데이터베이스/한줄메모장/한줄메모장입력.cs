using System;
using System.Data;
using System.Data.SqlClient;

namespace CSharp_Database
{
    public class ���ٸ޸����Է� : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTitle;
        #region +
        /// <summary>
        /// �ʼ� �����̳� �����Դϴ�.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public ���ٸ޸����Է�()
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// �����̳� ������ �ʿ��� �޼����Դϴ�.
        /// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.TabIndex = 0;
            this.label1.Text = "�̸� : ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.TabIndex = 1;
            this.label2.Text = "�̸��� : ";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(40, 128);
            this.label3.Name = "label3";
            this.label3.TabIndex = 2;
            this.label3.Text = "�޸� : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 21);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 21);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(120, 120);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(160, 21);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(56, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "����(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(168, 176);
            this.btnList.Name = "btnList";
            this.btnList.TabIndex = 7;
            this.btnList.Text = "����Ʈ(&L)";
            // 
            // ���ٸ޸����Է�
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(304, 221);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                                                                    this.btnList,
                                                                                                                                    this.btnSave,
                                                                                                                                    this.txtTitle,
                                                                                                                                    this.txtEmail,
                                                                                                                                    this.txtName,
                                                                                                                                    this.label3,
                                                                                                                                    this.label2,
                                                                                                                                    this.label1});
            this.Name = "���ٸ޸����Է�";
            this.Text = "���ٸ޸����Է�";
            this.ResumeLayout(false);

        }
        #endregion
        #endregion
        //���� ��ư
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            //[!] ���� �����
            string strName = this.txtName.Text;
            string strEmail = this.txtEmail.Text;
            string strTitle = this.txtTitle.Text;
            //[!] ����(Ȭ) ����ǥ ó��
            //			strName = strName.Replace("'", "''");
            //			strEmail = strEmail.Replace("'", "''");
            //			strTitle = strTitle.Replace("'", "''");
            //[1] Ŀ�ؼ� Ŭ������ �ν��Ͻ� ����
            SqlConnection objCon = new SqlConnection();
            //[2] ConnectionString �Ӽ� ����
            objCon.ConnectionString =
                "server=(local);database=Web;uid=Web;pwd=Web;";//4���� ����
                                                               //[3] ����
            objCon.Open();
            SqlCommand objCmd = new SqlCommand();
            objCmd.Connection = objCon;//Ŀ�ؼ� ��ü ����

            #region ���� SQL��
            //			objCmd.CommandText = @"
            //				Insert Into Memo(Name, Email, Title, PostDate) 
            //				Values('ȫ�浿', 'h@h.com', 'ȫ�浿�Դϴ�.', GetDate())
            //			";//�Ϲ� SQL��
            #endregion
            #region [1]�ζ��� SQL��
            //[1] �ζ��� SQL�� : ���������� -> " + ���� + "
            //			objCmd.CommandText = @"
            //				Insert Into Memo(Name, Email, Title, PostDate) 
            //				Values('" 
            //					+ strName + @"', '" 
            //					+ strEmail + @"', '" 
            //					+ strTitle + @"', GetDate())
            //			";//�Ϲ� SQL��
            #endregion
            #region [2]SQL Parameter ���
            //			//[!] SQL Parameter ��� : Named �Ű�����
            //			objCmd.CommandText = "Insert Into Memo(Name, Email, Title, PostDate) Values(@Name, @Email, @Title, @PostDate)";
            //			//[!] @���� �κ� ä���ֱ�
            //			objCmd.Parameters.Add("@Name", SqlDbType.VarChar, 25);
            //			objCmd.Parameters["@Name"].Value = strName;//�̸� ����
            //			objCmd.Parameters.Add("@Email", SqlDbType.VarChar, 100);
            //			objCmd.Parameters["@Email"].Value = strEmail;//�̸��� ����
            //			objCmd.Parameters.Add("@Title", SqlDbType.VarChar, 150);
            //			objCmd.Parameters["@Title"].Value = strTitle;//�޸� ����
            //      objCmd.Parameters.Add("@PostDate", SqlDbType.DateTime);//*
            //			objCmd.Parameters["@PostDate"].Value = DateTime.Now;//��¥ ����
            #endregion
            #region [3] SQL SP ���
            //[!] SQL SP ���
            objCmd.CommandText = "procInsertMemo";//�������ν�����
                                                  //[!] @���� �κ� ä���ֱ�
            objCmd.Parameters.Add("@Name", SqlDbType.VarChar, 25);
            objCmd.Parameters["@Name"].Value = strName;//�̸� ����
            objCmd.Parameters.Add("@Email", SqlDbType.VarChar, 100);
            objCmd.Parameters["@Email"].Value = strEmail;//�̸��� ����
            objCmd.Parameters.Add("@Title", SqlDbType.VarChar, 150);
            objCmd.Parameters["@Title"].Value = strTitle;//�޸� ����
            objCmd.Parameters.Add("@PostDate", SqlDbType.DateTime);//*
            objCmd.Parameters["@PostDate"].Value = DateTime.Now;//��¥ ����

            objCmd.CommandType = CommandType.StoredProcedure;//����
                                                             //objCmd.CommandType = CommandType.Text;
            #endregion

            objCmd.ExecuteNonQuery();//����
                                     //[4] ����
            objCon.Close();
            //[!] �ؽ�Ʈ�ڽ� �ʱ�ȭ
            this.txtName.Text = "";
            this.txtEmail.Clear();
            this.txtTitle.Text = String.Empty;
        }
    }
}
