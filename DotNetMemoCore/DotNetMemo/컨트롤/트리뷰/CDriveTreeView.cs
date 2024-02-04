using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Ʈ������Ʈ��{
	public class CDriveTreeView : System.Windows.Forms.Form{

		#region Code Hiding
		private System.Windows.Forms.TreeView directoryTreeView;
		/// <summary>
		/// �ʼ� �����̳� �����Դϴ�.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CDriveTreeView()
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
			this.directoryTreeView = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// directoryTreeView
			// 
			this.directoryTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.directoryTreeView.ImageIndex = -1;
			this.directoryTreeView.Location = new System.Drawing.Point(0, 0);
			this.directoryTreeView.Name = "directoryTreeView";
			this.directoryTreeView.SelectedImageIndex = -1;
			this.directoryTreeView.Size = new System.Drawing.Size(292, 273);
			this.directoryTreeView.TabIndex = 0;
			// 
			// CDriveTreeView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.directoryTreeView);
			this.Name = "CDriveTreeView";
			this.Text = "CDriveTreeView";
			this.Load += new System.EventHandler(this.CDriveTreeView_Load);
			this.ResumeLayout(false);

		}
		#endregion
		#endregion 

		//[1] �ε� �̺�Ʈ �ڵ鷯
		private void CDriveTreeView_Load(object sender, System.EventArgs e){
			// C:\ ����̺긦 directoryTreeView�� �߰��ϰ�, ���� ������ �Է��Ѵ�.
			directoryTreeView.Nodes.Add( "C:\\" );
			PopulateTreeView( 
				"C:\\", directoryTreeView.Nodes[ 0 ] );		
		}

		//[2] Ʈ���� �����
		public void PopulateTreeView( 
			string directoryValue, TreeNode parentNode ){
			// ���� ��������� �迭�� �����Ѵ�.
			string[] directoryArray = 
				System.IO.Directory.GetDirectories( directoryValue );

			// ���� ��忡 ���� ������ ��Ÿ����.
			try{
				if ( directoryArray.Length != 0 ){
					// �� ���� ��������, ���ο� Ʈ�� ��带 �����ϰ�,
					// ���� ��忡 �ڽ� ���� �߰��Ѵ�.
					// �ݺ������� ���� ������ �߰��Ѵ�.
					foreach ( string directory in directoryArray ){
						// ���� ������ ���� TreeNode�� �����Ѵ�.
						TreeNode myNode = new TreeNode( directory );

						// �θ� ��忡 ���� ���͸��� �߰��Ѵ�.
						parentNode.Nodes.Add( myNode );

						// �� ���� ������ �ݺ������� �߰��Ѵ�.
						PopulateTreeView( directory, myNode );
					}   
				} // end if
			}
			catch ( UnauthorizedAccessException ){  
				parentNode.Nodes.Add( "Access denied" );
			}                                                                             
		} // end PopulateTreeView 
	}
}
