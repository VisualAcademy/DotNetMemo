//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;
////
//using System.Data;
//using System.Data.SqlClient;

//namespace CSharp_Windows.�����ͱ׸���{
//	public class FrmDataGrid : System.Windows.Forms.Form{
//		private System.Windows.Forms.Button btnCommand;
//		private System.Windows.Forms.DataGrid dgDataTable;
//		#region +
//		/// <summary>
//		/// �ʼ� �����̳� �����Դϴ�.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmDataGrid()
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
//			this.dgDataTable = new System.Windows.Forms.DataGrid();
//			this.btnCommand = new System.Windows.Forms.Button();
//			((System.ComponentModel.ISupportInitialize)(this.dgDataTable)).BeginInit();
//			this.SuspendLayout();
//			// 
//			// dgDataTable
//			// 
//			this.dgDataTable.DataMember = "";
//			this.dgDataTable.HeaderForeColor = System.Drawing.SystemColors.ControlText;
//			this.dgDataTable.Location = new System.Drawing.Point(24, 16);
//			this.dgDataTable.Name = "dgDataTable";
//			this.dgDataTable.Size = new System.Drawing.Size(288, 88);
//			this.dgDataTable.TabIndex = 0;
//			// 
//			// btnCommand
//			// 
//			this.btnCommand.Location = new System.Drawing.Point(96, 112);
//			this.btnCommand.Name = "btnCommand";
//			this.btnCommand.Size = new System.Drawing.Size(160, 23);
//			this.btnCommand.TabIndex = 1;
//			this.btnCommand.Text = "�����ͱ׸��� ä���";
//			this.btnCommand.Click += new System.EventHandler(this.btnCommand_Click);
//			// 
//			// FrmDataGrid
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(336, 141);
//			this.Controls.Add(this.btnCommand);
//			this.Controls.Add(this.dgDataTable);
//			this.Name = "FrmDataGrid";
//			this.Text = "FrmDataGrid";
//			((System.ComponentModel.ISupportInitialize)(this.dgDataTable)).EndInit();
//			this.ResumeLayout(false);

//		}
//		#endregion
//		#endregion
//		private void btnCommand_Click(object sender, System.EventArgs e){
//			//[1] ���̺� ����� : Member
//			DataTable objMember = new DataTable();
//			objMember.TableName = "Member";
//			//[2] �ʵ�(�÷�) �����
//			//��ȣ �ʵ�
//			DataColumn objNum = new DataColumn();
//			objNum.ColumnName = "Num";
//			objNum.DataType = Type.GetType("System.Int32");//������ ��
//			objNum.AllowDBNull = false;//�� �� ��� ����
//			objNum.ReadOnly = true;
//			objNum.Unique = true;//����Ű
//			objNum.AutoIncrement = true;
//			objNum.AutoIncrementSeed = 1;
//			objNum.AutoIncrementStep = 1;
//            //�̸� �ʵ�
//			DataColumn objName = new DataColumn();
//			objName.ColumnName = "Name";
//			objName.DataType = Type.GetType("System.String");//������ ��
//			objName.AllowDBNull = false;//�� �� ��� ����
//			//�ʵ� �߰�
//			objMember.Columns.Add(objNum);
//			objMember.Columns.Add(objName);
//			//�⺻Ű ����
//			DataColumn [] objPrimaryKey = new DataColumn[1];
//			objPrimaryKey[0] = objNum;
//			objMember.PrimaryKey = objPrimaryKey;
//			//[3] ���ڵ� �����
//			DataRow objRecord = objMember.NewRow();
//			objRecord["Name"] = "ȫ�浿";
//			objMember.Rows.Add(objRecord);
//			objRecord = objMember.NewRow();
//			objRecord["Name"] = "��λ�";
//			objMember.Rows.Add(objRecord);
//			//�����ͱ׸��� ��Ʈ�ѿ� ���
//			this.dgDataTable.DataSource = objMember;
//		}
//	}
//}
