//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;
////
//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;

//namespace Category
//{
//	/// <summary>
//	/// FrmList�� ���� ��� �����Դϴ�.
//	/// </summary>
//	public class FrmList : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.DataGrid ctlCategoryList;
//        private DataGridView dataGridView1;
//        private ComboBox comboBox1;
//        private Button button1;
//        private Button button2;

//        /// <summary>
//        /// �ʼ� �����̳� �����Դϴ�.
//        /// </summary>
//        private System.ComponentModel.Container components = null;

//		public FrmList()
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
//            this.ctlCategoryList = new System.Windows.Forms.DataGrid();
//            this.dataGridView1 = new System.Windows.Forms.DataGridView();
//            this.comboBox1 = new System.Windows.Forms.ComboBox();
//            this.button1 = new System.Windows.Forms.Button();
//            this.button2 = new System.Windows.Forms.Button();
//            ((System.ComponentModel.ISupportInitialize)(this.ctlCategoryList)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // ctlCategoryList
//            // 
//            this.ctlCategoryList.DataMember = "";
//            this.ctlCategoryList.HeaderForeColor = System.Drawing.SystemColors.ControlText;
//            this.ctlCategoryList.Location = new System.Drawing.Point(16, 8);
//            this.ctlCategoryList.Name = "ctlCategoryList";
//            this.ctlCategoryList.Size = new System.Drawing.Size(384, 256);
//            this.ctlCategoryList.TabIndex = 0;
            
//            // 
//            // dataGridView1
//            // 
//            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridView1.Location = new System.Drawing.Point(16, 287);
//            this.dataGridView1.Name = "dataGridView1";
//            this.dataGridView1.RowTemplate.Height = 23;
//            this.dataGridView1.Size = new System.Drawing.Size(384, 248);
//            this.dataGridView1.TabIndex = 1;
//            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
//            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
//            // 
//            // comboBox1
//            // 
//            this.comboBox1.FormattingEnabled = true;
//            this.comboBox1.Location = new System.Drawing.Point(16, 574);
//            this.comboBox1.Name = "comboBox1";
//            this.comboBox1.Size = new System.Drawing.Size(121, 20);
//            this.comboBox1.TabIndex = 2;
//            // 
//            // button1
//            // 
//            this.button1.Location = new System.Drawing.Point(195, 574);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(75, 23);
//            this.button1.TabIndex = 3;
//            this.button1.Text = "CategoryId";
//            this.button1.UseVisualStyleBackColor = true;
//            this.button1.Click += new System.EventHandler(this.button1_Click);
//            // 
//            // button2
//            // 
//            this.button2.Location = new System.Drawing.Point(287, 574);
//            this.button2.Name = "button2";
//            this.button2.Size = new System.Drawing.Size(96, 23);
//            this.button2.TabIndex = 4;
//            this.button2.Text = "CategoryName";
//            this.button2.UseVisualStyleBackColor = true;
//            this.button2.Click += new System.EventHandler(this.button2_Click);
//            // 
//            // FrmList
//            // 
//            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//            this.ClientSize = new System.Drawing.Size(416, 706);
//            this.Controls.Add(this.button2);
//            this.Controls.Add(this.button1);
//            this.Controls.Add(this.comboBox1);
//            this.Controls.Add(this.dataGridView1);
//            this.Controls.Add(this.ctlCategoryList);
//            this.Name = "FrmList";
//            this.Text = "FrmList";
//            this.Load += new System.EventHandler(this.FrmList_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.ctlCategoryList)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
//            this.ResumeLayout(false);

//		}
//		#endregion

//		private void FrmList_Load(object sender, System.EventArgs e)
//		{
//			//[1] ���� �����
//			string strSql = "ListCategory";
//			//[2] Ŀ�ؼ�
//			SqlConnection objCon = new SqlConnection();
//            //objCon.ConnectionString = "server=(local);database=Category;uid=Category;pwd=Category;";
//            objCon.ConnectionString =
//                ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
//            objCon.Open();
//			//[3] Ŀ���
//			SqlCommand objCmd = new SqlCommand();
//			objCmd.Connection = objCon;
//			objCmd.CommandText = strSql;
//			objCmd.CommandType = CommandType.StoredProcedure;
//			//[4] �����;����
//			SqlDataAdapter objDa = new SqlDataAdapter();
//			objDa.SelectCommand = objCmd;
//			//[5] �����ͼ�
//			DataSet objDs = new DataSet();
//			objDa.Fill(objDs, "Categories");
//			//[6] �����ͱ׸���
//			this.ctlCategoryList.DataSource = 
//				objDs.Tables["Categories"].DefaultView;

//            this.dataGridView1.DataSource = objDs.Tables["Categories"].DefaultView;

//            //[7] �ݱ�
//            objCon.Close();

//            this.comboBox1.DisplayMember = "CategoryName";
//            this.comboBox1.ValueMember = "CategoryId";
//            this.comboBox1.DataSource = objDs.Tables["Categories"].DefaultView;

//        }

//        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
//        {
//            var categoryId = dataGridView1.Rows[e.RowIndex].Cells[0].Value;

//            MessageBox.Show(categoryId.ToString()); 
//        }

//        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
//        {
//            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            MessageBox.Show(this.comboBox1.SelectedValue.ToString()); 
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            MessageBox.Show(this.comboBox1.Text);
//        }
//    }
//}
