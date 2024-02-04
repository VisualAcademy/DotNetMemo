using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharp_Windows.트리뷰
{
	/// <summary>
	/// FrmTreeView에 대한 요약 설명입니다.
	/// </summary>
	public class FrmTreeView : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FrmTreeView()
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

		#region Windows Form Designer generated code
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.ImageIndex = -1;
			this.treeView1.Location = new System.Drawing.Point(40, 16);
			this.treeView1.Name = "treeView1";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
																																					new System.Windows.Forms.TreeNode("닷넷프로그래밍", new System.Windows.Forms.TreeNode[] {
																																																																														 new System.Windows.Forms.TreeNode("Windows", new System.Windows.Forms.TreeNode[] {
																																																																																																																								new System.Windows.Forms.TreeNode("C# 콘솔 응용프로그램"),
																																																																																																																								new System.Windows.Forms.TreeNode("C# 윈도우 응용프로그램")}),
																																																																														 new System.Windows.Forms.TreeNode("Web", new System.Windows.Forms.TreeNode[] {
																																																																																																																						new System.Windows.Forms.TreeNode("HTML"),
																																																																																																																						new System.Windows.Forms.TreeNode("CSS"),
																																																																																																																						new System.Windows.Forms.TreeNode("JavaScript"),
																																																																																																																						new System.Windows.Forms.TreeNode("ASP.NET")})})});
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.Size = new System.Drawing.Size(312, 224);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(72, 272);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 23);
			this.label1.TabIndex = 1;
			// 
			// FrmTreeView
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(400, 333);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.label1,
																																	this.treeView1});
			this.Name = "FrmTreeView";
			this.Text = "FrmTreeView";
			this.ResumeLayout(false);

		}
		#endregion

		//노드 선택시 레이블에 텍스트 출력
		private void treeView1_AfterSelect(object sender, 
			System.Windows.Forms.TreeViewEventArgs e)
		{
			if(e.Node == this.treeView1.Nodes[0])	//루트 노드
			{
				this.label1.Text = this.treeView1.Nodes[0].Text;
			}
			else if(e.Node == this.treeView1.Nodes[0].Nodes[0])//Windows
			{
				this.label1.Text = this.treeView1.Nodes[0].Nodes[0].Text;
			}
			else if(e.Node == this.treeView1.Nodes[0].Nodes[1].Nodes[2])//JS
			{
				this.label1.Text = 
					this.treeView1.Nodes[0].Nodes[1].Nodes[2].Text;
			}
		}
	}
}