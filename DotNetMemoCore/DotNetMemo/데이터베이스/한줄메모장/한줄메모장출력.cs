//using System;
//using System.Drawing;
//using System.Windows.Forms;
//using System.Data;
//using System.Data.SqlClient;

//namespace CSharp_Database
//{
//    public class ���ٸ޸������ : System.Windows.Forms.Form
//    {
//        private System.Windows.Forms.DataGrid dataGrid1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Button button1;
//        #region +
//        /// <summary>
//        /// �ʼ� �����̳� �����Դϴ�.
//        /// </summary>
//        private System.ComponentModel.Container components = null;

//        public ���ٸ޸������()
//        {
//            //
//            // Windows Form �����̳� ������ �ʿ��մϴ�.
//            //
//            InitializeComponent();

//            //
//            // TODO: InitializeComponent�� ȣ���� ���� ������ �ڵ带 �߰��մϴ�.
//            //
//        }

//        /// <summary>
//        /// ��� ���� ��� ���ҽ��� �����մϴ�.
//        /// </summary>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                if (components != null)
//                {
//                    components.Dispose();
//                }
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code
//        /// <summary>
//        /// �����̳� ������ �ʿ��� �޼����Դϴ�.
//        /// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.dataGrid1 = new System.Windows.Forms.DataGrid();
//            this.label2 = new System.Windows.Forms.Label();
//            this.button1 = new System.Windows.Forms.Button();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // dataGrid1
//            // 
//            this.dataGrid1.CaptionText = "���� �޸��� ���";
//            this.dataGrid1.DataMember = "";
//            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
//            this.dataGrid1.Location = new System.Drawing.Point(16, 16);
//            this.dataGrid1.Name = "dataGrid1";
//            this.dataGrid1.ReadOnly = true;
//            this.dataGrid1.Size = new System.Drawing.Size(336, 240);
//            this.dataGrid1.TabIndex = 0;
//            this.dataGrid1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseUp);
//            // 
//            // label2
//            // 
//            this.label2.Location = new System.Drawing.Point(16, 272);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(144, 23);
//            this.label2.TabIndex = 2;
//            this.label2.Text = "�۹�ȣ : ";
//            // 
//            // button1
//            // 
//            this.button1.Location = new System.Drawing.Point(168, 272);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(184, 23);
//            this.button1.TabIndex = 3;
//            this.button1.Text = "���� �� ��ȣ �����ϱ�";
//            this.button1.Click += new System.EventHandler(this.button1_Click);
//            // 
//            // ���ٸ޸������
//            // 
//            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//            this.ClientSize = new System.Drawing.Size(376, 309);
//            this.Controls.AddRange(new System.Windows.Forms.Control[] {
//                                                                          this.button1,
//                                                                          this.label2,
//                                                                          this.dataGrid1});
//            this.Name = "���ٸ޸������";
//            this.Text = "���ٸ޸������";
//            this.Load += new System.EventHandler(this.���ٸ޸������_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
//            this.ResumeLayout(false);

//        }
//        #endregion
//        #endregion
//        private void ���ٸ޸������_Load(object sender, System.EventArgs e)
//        {
//            //[1] Ŀ�ؼ� Ŭ������ �ν��Ͻ� ����
//            SqlConnection objCon = new SqlConnection();
//            //[2] ConnectionString �Ӽ� ����
//            objCon.ConnectionString =
//                "server=(local);database=Web;uid=Web;pwd=Web;";//4���� ����
//                                                               //[3] ����
//            objCon.Open();
//            SqlCommand objCmd = new SqlCommand();
//            objCmd.Connection = objCon;//Ŀ�ؼ� ��ü ����
//            objCmd.CommandText = "Select * From Memo";
//            objCmd.CommandType = CommandType.Text;
//            //[4] 
//            SqlDataAdapter objDa = new SqlDataAdapter();
//            objDa.SelectCommand = objCmd;
//            DataSet objDs = new DataSet();
//            objDa.Fill(objDs, "Memo");
//            this.dataGrid1.DataSource = objDs.Tables["Memo"];
//            //[4] ����
//            objCon.Close();

//            //[!] �����ͱ׸��� �Ӽ� �����ϱ�
//            // DataGrid�� ���� ��ü���� ����
//            DataGridTableStyle objDataGridTableStyle = new DataGridTableStyle();
//            DataGridTextBoxColumn objDataGridTextBoxColumn = new DataGridTextBoxColumn();

//            // AlternatingBackColor �Ӽ� ����
//            objDataGridTableStyle.AlternatingBackColor = Color.WhiteSmoke;
//            // DataGridTableStyle�� MappingName ����
//            objDataGridTableStyle.MappingName = "Memo";

//            // ù��° ���� MappingName ����
//            objDataGridTextBoxColumn.MappingName = "Num";
//            // ���ο� HeaderText�� ����
//            objDataGridTextBoxColumn.HeaderText = "��ȣ";
//            // ���� ������ ����
//            objDataGridTextBoxColumn.Width = 50;
//            // DataGridTableStyle�� ���� �߰�
//            objDataGridTableStyle.GridColumnStyles.Add(objDataGridTextBoxColumn);

//            // �� ���� ���
//            objDataGridTextBoxColumn = new DataGridTextBoxColumn();
//            // �ι�° ���� MappingName ����
//            objDataGridTextBoxColumn.MappingName = "Name";
//            // HeaderText
//            objDataGridTextBoxColumn.HeaderText = "�̸�";
//            // Size
//            objDataGridTextBoxColumn.Width = 100;
//            // ����
//            objDataGridTextBoxColumn.Alignment = HorizontalAlignment.Right;
//            // �� �߰�
//            objDataGridTableStyle.GridColumnStyles.Add(objDataGridTextBoxColumn);

//            objDataGridTextBoxColumn = new DataGridTextBoxColumn();
//            objDataGridTextBoxColumn.MappingName = "Email";
//            objDataGridTextBoxColumn.HeaderText = "�̸���";
//            objDataGridTextBoxColumn.Width = 100;
//            objDataGridTableStyle.GridColumnStyles.Add(objDataGridTextBoxColumn);

//            objDataGridTextBoxColumn = new DataGridTextBoxColumn();
//            objDataGridTextBoxColumn.MappingName = "Title";
//            objDataGridTextBoxColumn.HeaderText = "�޸�";
//            objDataGridTextBoxColumn.Width = 200;
//            objDataGridTableStyle.GridColumnStyles.Add(objDataGridTextBoxColumn);

//            objDataGridTextBoxColumn = new DataGridTextBoxColumn();
//            objDataGridTextBoxColumn.MappingName = "PostDate";
//            objDataGridTextBoxColumn.HeaderText = "�ۼ���";
//            objDataGridTextBoxColumn.Width = 100;
//            objDataGridTableStyle.GridColumnStyles.Add(objDataGridTextBoxColumn);

//            this.dataGrid1.TableStyles.Add(objDataGridTableStyle);
//        }

//        private int intRecordNum = 0;

//        private void dataGrid1_MouseUp(
//            object sender, System.Windows.Forms.MouseEventArgs e)
//        {
//            try
//            {
//                DataGrid objDataGrid = (DataGrid)sender;
//                DataGrid.HitTestInfo objHitTestInfo = objDataGrid.HitTest(e.X, e.Y);

//                if (objHitTestInfo.Type == DataGrid.HitTestType.Cell)
//                {
//                    intRecordNum = Convert.ToInt32(
//                        objDataGrid[objHitTestInfo.Row, 0].ToString());
//                    this.label2.Text = "������ �� ��ȣ : " + intRecordNum.ToString();
//                }
//            }
//            finally
//            {

//            }
//        }

//        private void button1_Click(object sender, System.EventArgs e)
//        {

//        }
//    }
//}
