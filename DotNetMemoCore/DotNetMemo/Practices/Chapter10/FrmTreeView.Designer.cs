namespace MyWinForms.Controls
{
    partial class FrmTreeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Windows");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("C : ", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("D : ");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("니 컴퓨터", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(23, 25);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "노드5";
            treeNode1.Text = "Windows";
            treeNode2.Name = "노드1";
            treeNode2.Text = "C : ";
            treeNode3.Name = "노드3";
            treeNode3.Text = "D : ";
            treeNode4.Name = "노드0";
            treeNode4.Text = "니 컴퓨터";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(243, 206);
            this.treeView1.TabIndex = 0;
            // 
            // FrmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.treeView1);
            this.Name = "FrmTreeView";
            this.Text = "FrmTreeView";
            this.Load += new System.EventHandler(this.FrmTreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}