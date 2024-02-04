using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace 트리뷰컨트롤{
	public class CDriveTreeView : System.Windows.Forms.Form{

		#region Code Hiding
		private System.Windows.Forms.TreeView directoryTreeView;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CDriveTreeView()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
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

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
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

		//[1] 로드 이벤트 핸들러
		private void CDriveTreeView_Load(object sender, System.EventArgs e){
			// C:\ 드라이브를 directoryTreeView에 추가하고, 서브 폴더를 입력한다.
			directoryTreeView.Nodes.Add( "C:\\" );
			PopulateTreeView( 
				"C:\\", directoryTreeView.Nodes[ 0 ] );		
		}

		//[2] 트리뷰 만들기
		public void PopulateTreeView( 
			string directoryValue, TreeNode parentNode ){
			// 하위 폴더목록을 배열에 저장한다.
			string[] directoryArray = 
				System.IO.Directory.GetDirectories( directoryValue );

			// 현재 노드에 하위 폴더를 나타낸다.
			try{
				if ( directoryArray.Length != 0 ){
					// 매 하위 폴더마다, 새로운 트리 노드를 생성하고,
					// 현재 노드에 자식 노드로 추가한다.
					// 반복적으로 하위 폴더를 추가한다.
					foreach ( string directory in directoryArray ){
						// 현재 폴더를 위한 TreeNode를 생성한다.
						TreeNode myNode = new TreeNode( directory );

						// 부모 노드에 현재 디렉터리를 추가한다.
						parentNode.Nodes.Add( myNode );

						// 매 하위 폴더를 반복적으로 추가한다.
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
