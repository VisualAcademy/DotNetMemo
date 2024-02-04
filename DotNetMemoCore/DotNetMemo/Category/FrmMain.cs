//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using System.Windows.Forms;

//namespace Category
//{
//	/// <summary>
//	/// FrmMain에 대한 요약 설명입니다.
//	/// </summary>
//	public class FrmMain : System.Windows.Forms.Form
//	{
//		private System.Windows.Forms.MainMenu mmCategory;
//		private System.Windows.Forms.MenuItem mnuFile;
//		private System.Windows.Forms.MenuItem mnuCategory;
//		private System.Windows.Forms.MenuItem miWrite;
//		private System.Windows.Forms.MenuItem miList;
//		private System.Windows.Forms.MenuItem miView;
//		private System.Windows.Forms.MenuItem miModify;
//		private System.Windows.Forms.MenuItem miDelete;
//		private System.Windows.Forms.MenuItem miSearch;
//		private System.Windows.Forms.MenuItem miExit;
//		/// <summary>
//		/// 필수 디자이너 변수입니다.
//		/// </summary>
//		private System.ComponentModel.Container components = null;

//		public FrmMain()
//		{
//			//
//			// Windows Form 디자이너 지원에 필요합니다.
//			//
//			InitializeComponent();

//			//
//			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
//			//
//		}

//		/// <summary>
//		/// 사용 중인 모든 리소스를 정리합니다.
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

//		#region Windows Form 디자이너에서 생성한 코드
//		/// <summary>
//		/// 디자이너 지원에 필요한 메서드입니다.
//		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
//		/// </summary>
//		private void InitializeComponent()
//		{
//			this.mmCategory = new System.Windows.Forms.MainMenu();
//			this.mnuFile = new System.Windows.Forms.MenuItem();
//			this.mnuCategory = new System.Windows.Forms.MenuItem();
//			this.miWrite = new System.Windows.Forms.MenuItem();
//			this.miList = new System.Windows.Forms.MenuItem();
//			this.miView = new System.Windows.Forms.MenuItem();
//			this.miModify = new System.Windows.Forms.MenuItem();
//			this.miDelete = new System.Windows.Forms.MenuItem();
//			this.miSearch = new System.Windows.Forms.MenuItem();
//			this.miExit = new System.Windows.Forms.MenuItem();
//			// 
//			// mmCategory
//			// 
//			this.mmCategory.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																							 this.mnuFile,
//																																							 this.mnuCategory});
//			// 
//			// mnuFile
//			// 
//			this.mnuFile.Index = 0;
//			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																						this.miExit});
//			this.mnuFile.Text = "파일(&F)";
//			// 
//			// mnuCategory
//			// 
//			this.mnuCategory.Index = 1;
//			this.mnuCategory.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
//																																								this.miWrite,
//																																								this.miList,
//																																								this.miView,
//																																								this.miModify,
//																																								this.miDelete,
//																																								this.miSearch});
//			this.mnuCategory.Text = "카테고리(&C)";
//			// 
//			// miWrite
//			// 
//			this.miWrite.Index = 0;
//			this.miWrite.Text = "입력";
//			this.miWrite.Click += new System.EventHandler(this.miWrite_Click);
//			// 
//			// miList
//			// 
//			this.miList.Index = 1;
//			this.miList.Text = "출력";
//			this.miList.Click += new System.EventHandler(this.miList_Click);
//			// 
//			// miView
//			// 
//			this.miView.Index = 2;
//			this.miView.Text = "상세";
//			this.miView.Click += new System.EventHandler(this.miView_Click);
//			// 
//			// miModify
//			// 
//			this.miModify.Index = 3;
//			this.miModify.Text = "수정";
//			this.miModify.Click += new System.EventHandler(this.miModify_Click);
//			// 
//			// miDelete
//			// 
//			this.miDelete.Index = 4;
//			this.miDelete.Text = "삭제";
//			this.miDelete.Click += new System.EventHandler(this.miDelete_Click);
//			// 
//			// miSearch
//			// 
//			this.miSearch.Index = 5;
//			this.miSearch.Text = "검색";
//			this.miSearch.Click += new System.EventHandler(this.miSearch_Click);
//			// 
//			// miExit
//			// 
//			this.miExit.Index = 0;
//			this.miExit.Text = "끝내기(&X)";
//			this.miExit.Click += new System.EventHandler(this.miExit_Click);
//			// 
//			// FrmMain
//			// 
//			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
//			this.ClientSize = new System.Drawing.Size(292, 254);
//			this.IsMdiContainer = true;
//			this.Menu = this.mmCategory;
//			this.Name = "FrmMain";
//			this.Text = "FrmMain";

//		}
//		#endregion

//		private void miExit_Click(object sender, System.EventArgs e)
//		{
//			Application.Exit();
//		}

//		private void miWrite_Click(object sender, System.EventArgs e)
//		{
//			FrmWrite fw = new FrmWrite();
//			fw.MdiParent = this;
//			fw.Show();
//		}

//		private void miList_Click(object sender, System.EventArgs e)
//		{
//			FrmList fl = new FrmList();
//			fl.MdiParent = this;
//			fl.Show();
//		}

//		private void miView_Click(object sender, System.EventArgs e)
//		{
//			FrmView fv = new FrmView();
//			fv.MdiParent = this;
//			fv.Show();
//		}

//		private void miModify_Click(object sender, System.EventArgs e)
//		{
//			FrmModify fm = new FrmModify();
//			fm.MdiParent = this;
//			fm.Show();
//		}

//		private void miDelete_Click(object sender, System.EventArgs e)
//		{
//			FrmDelete fd = new FrmDelete();
//			fd.MdiParent = this;
//			fd.Show();
//		}

//		private void miSearch_Click(object sender, System.EventArgs e)
//		{
//			FrmSearch fs = new FrmSearch();
//			fs.MdiParent = this;
//			fs.Show();
//		}
//	}
//}
