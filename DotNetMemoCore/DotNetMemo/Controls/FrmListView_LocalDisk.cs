using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.Controls
{
	/// <summary>
	/// FrmListView�� ���� ��� �����Դϴ�.
	/// </summary>
	public class FrmListView_LocalDisk : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmListView_LocalDisk()
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
																																																						 "C:",
																																																						 "���õ�ũ"}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
																																																						 "D:",
																																																						 "���� ��ũ"}, -1);
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																																								this.columnHeader1,
																																								this.columnHeader2});
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
																																							listViewItem1,
																																							listViewItem2});
			this.listView1.Location = new System.Drawing.Point(16, 16);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(248, 168);
			this.listView1.TabIndex = 0;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.Click += new System.EventHandler(this.listView1_Click);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "�̸�";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "����";
			this.columnHeader2.Width = 100;
			// 
			// FrmListView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(280, 205);
			this.Controls.Add(this.listView1);
			this.Name = "FrmListView";
			this.Text = "FrmListView";
			this.ResumeLayout(false);

		}
		#endregion

		// Ŭ�� �̺�Ʈ
		private void listView1_Click(object sender, System.EventArgs e)
		{
			string strItem = 
				this.listView1.SelectedItems[0].Text;
			MessageBox.Show(strItem);//C:, D:
			strItem = 
				this.listView1.SelectedItems[0].SubItems[
					1].Text;//���� ��ũ
		}
		
	}
}
