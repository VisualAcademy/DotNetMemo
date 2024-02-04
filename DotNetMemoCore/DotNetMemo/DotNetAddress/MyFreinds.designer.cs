//namespace MyFriends
//{
//  partial class MyFreinds
//  {
//    /// <summary>
//    /// 필수 디자이너 변수입니다.
//    /// </summary>
//    private System.ComponentModel.IContainer components = null;

//    /// <summary>
//    /// 사용 중인 모든 리소스를 정리합니다.
//    /// </summary>
//    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
//    protected override void Dispose(bool disposing)
//    {
//      if (disposing && (components != null))
//      {
//        components.Dispose();
//      }
//      base.Dispose(disposing);
//    }

//    #region Windows Form 디자이너에서 생성한 코드

//    /// <summary>
//    /// 디자이너 지원에 필요한 메서드입니다.
//    /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
//    /// </summary>
//    private void InitializeComponent()
//    {
//      this.SearchGroup = new System.Windows.Forms.GroupBox();
//      this.DataGroup = new System.Windows.Forms.GroupBox();
//      this.txtSearch = new System.Windows.Forms.TextBox();
//      this.SearchBtn = new System.Windows.Forms.Button();
//      this.NameList = new System.Windows.Forms.ListBox();
//      this.label1 = new System.Windows.Forms.Label();
//      this.label2 = new System.Windows.Forms.Label();
//      this.label3 = new System.Windows.Forms.Label();
//      this.label4 = new System.Windows.Forms.Label();
//      this.label5 = new System.Windows.Forms.Label();
//      this.label6 = new System.Windows.Forms.Label();
//      this.label7 = new System.Windows.Forms.Label();
//      this.label8 = new System.Windows.Forms.Label();
//      this.txtName = new System.Windows.Forms.TextBox();
//      this.txtPhone = new System.Windows.Forms.TextBox();
//      this.txtAddress = new System.Windows.Forms.TextBox();
//      this.txtCompany = new System.Windows.Forms.TextBox();
//      this.txtIntroduce = new System.Windows.Forms.TextBox();
//      this.txtEmail = new System.Windows.Forms.TextBox();
//      this.txtMobile = new System.Windows.Forms.TextBox();
//      this.txtDepartment = new System.Windows.Forms.TextBox();
//      this.PrevBtn = new System.Windows.Forms.Button();
//      this.NextBtn = new System.Windows.Forms.Button();
//      this.InsertBtn = new System.Windows.Forms.Button();
//      this.UpdateBtn = new System.Windows.Forms.Button();
//      this.DeleteBtn = new System.Windows.Forms.Button();
//      this.SearchGroup.SuspendLayout();
//      this.DataGroup.SuspendLayout();
//      this.SuspendLayout();
//      // 
//      // SearchGroup
//      // 
//      this.SearchGroup.Controls.Add(this.NameList);
//      this.SearchGroup.Controls.Add(this.SearchBtn);
//      this.SearchGroup.Controls.Add(this.txtSearch);
//      this.SearchGroup.Location = new System.Drawing.Point(13, 21);
//      this.SearchGroup.Name = "SearchGroup";
//      this.SearchGroup.Size = new System.Drawing.Size(163, 273);
//      this.SearchGroup.TabIndex = 0;
//      this.SearchGroup.TabStop = false;
//      // 
//      // DataGroup
//      // 
//      this.DataGroup.Controls.Add(this.txtDepartment);
//      this.DataGroup.Controls.Add(this.txtMobile);
//      this.DataGroup.Controls.Add(this.txtEmail);
//      this.DataGroup.Controls.Add(this.txtIntroduce);
//      this.DataGroup.Controls.Add(this.txtCompany);
//      this.DataGroup.Controls.Add(this.txtAddress);
//      this.DataGroup.Controls.Add(this.txtPhone);
//      this.DataGroup.Controls.Add(this.txtName);
//      this.DataGroup.Controls.Add(this.label8);
//      this.DataGroup.Controls.Add(this.label7);
//      this.DataGroup.Controls.Add(this.label6);
//      this.DataGroup.Controls.Add(this.label5);
//      this.DataGroup.Controls.Add(this.label4);
//      this.DataGroup.Controls.Add(this.label3);
//      this.DataGroup.Controls.Add(this.label2);
//      this.DataGroup.Controls.Add(this.label1);
//      this.DataGroup.Location = new System.Drawing.Point(185, 21);
//      this.DataGroup.Name = "DataGroup";
//      this.DataGroup.Size = new System.Drawing.Size(317, 273);
//      this.DataGroup.TabIndex = 1;
//      this.DataGroup.TabStop = false;
//      // 
//      // txtSearch
//      // 
//      this.txtSearch.Location = new System.Drawing.Point(7, 21);
//      this.txtSearch.Name = "txtSearch";
//      this.txtSearch.Size = new System.Drawing.Size(81, 21);
//      this.txtSearch.TabIndex = 0;
//      // 
//      // SearchBtn
//      // 
//      this.SearchBtn.Location = new System.Drawing.Point(95, 21);
//      this.SearchBtn.Name = "SearchBtn";
//      this.SearchBtn.Size = new System.Drawing.Size(62, 23);
//      this.SearchBtn.TabIndex = 1;
//      this.SearchBtn.Text = "찾기";
//      this.SearchBtn.UseVisualStyleBackColor = true;
//      this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
//      // 
//      // NameList
//      // 
//      this.NameList.FormattingEnabled = true;
//      this.NameList.ItemHeight = 12;
//      this.NameList.Location = new System.Drawing.Point(7, 49);
//      this.NameList.Name = "NameList";
//      this.NameList.Size = new System.Drawing.Size(150, 208);
//      this.NameList.TabIndex = 2;
//      this.NameList.SelectedIndexChanged += new System.EventHandler(this.NameList_SelectedIndexChanged);
//      // 
//      // label1
//      // 
//      this.label1.AutoSize = true;
//      this.label1.Location = new System.Drawing.Point(13, 37);
//      this.label1.Name = "label1";
//      this.label1.Size = new System.Drawing.Size(33, 12);
//      this.label1.TabIndex = 0;
//      this.label1.Text = "이름:";
//      // 
//      // label2
//      // 
//      this.label2.AutoSize = true;
//      this.label2.Location = new System.Drawing.Point(13, 77);
//      this.label2.Name = "label2";
//      this.label2.Size = new System.Drawing.Size(57, 12);
//      this.label2.TabIndex = 1;
//      this.label2.Text = "전화번호:";
//      // 
//      // label3
//      // 
//      this.label3.AutoSize = true;
//      this.label3.Location = new System.Drawing.Point(13, 117);
//      this.label3.Name = "label3";
//      this.label3.Size = new System.Drawing.Size(33, 12);
//      this.label3.TabIndex = 2;
//      this.label3.Text = "주소:";
//      // 
//      // label4
//      // 
//      this.label4.AutoSize = true;
//      this.label4.Location = new System.Drawing.Point(13, 157);
//      this.label4.Name = "label4";
//      this.label4.Size = new System.Drawing.Size(63, 12);
//      this.label4.TabIndex = 3;
//      this.label4.Text = "회사/학교:";
//      // 
//      // label5
//      // 
//      this.label5.AutoSize = true;
//      this.label5.Location = new System.Drawing.Point(13, 189);
//      this.label5.Name = "label5";
//      this.label5.Size = new System.Drawing.Size(33, 12);
//      this.label5.TabIndex = 4;
//      this.label5.Text = "소개:";
//      // 
//      // label6
//      // 
//      this.label6.AutoSize = true;
//      this.label6.Location = new System.Drawing.Point(183, 45);
//      this.label6.Name = "label6";
//      this.label6.Size = new System.Drawing.Size(41, 12);
//      this.label6.TabIndex = 5;
//      this.label6.Text = "Email:";
//      // 
//      // label7
//      // 
//      this.label7.AutoSize = true;
//      this.label7.Location = new System.Drawing.Point(183, 85);
//      this.label7.Name = "label7";
//      this.label7.Size = new System.Drawing.Size(45, 12);
//      this.label7.TabIndex = 6;
//      this.label7.Text = "휴대폰:";
//      // 
//      // label8
//      // 
//      this.label8.AutoSize = true;
//      this.label8.Location = new System.Drawing.Point(183, 125);
//      this.label8.Name = "label8";
//      this.label8.Size = new System.Drawing.Size(47, 12);
//      this.label8.TabIndex = 7;
//      this.label8.Text = "부서/과";
//      // 
//      // txtName
//      // 
//      this.txtName.Location = new System.Drawing.Point(77, 42);
//      this.txtName.Name = "txtName";
//      this.txtName.Size = new System.Drawing.Size(100, 21);
//      this.txtName.TabIndex = 8;
//      // 
//      // txtPhone
//      // 
//      this.txtPhone.Location = new System.Drawing.Point(77, 74);
//      this.txtPhone.Name = "txtPhone";
//      this.txtPhone.Size = new System.Drawing.Size(100, 21);
//      this.txtPhone.TabIndex = 9;
//      // 
//      // txtAddress
//      // 
//      this.txtAddress.Location = new System.Drawing.Point(77, 106);
//      this.txtAddress.Name = "txtAddress";
//      this.txtAddress.Size = new System.Drawing.Size(100, 21);
//      this.txtAddress.TabIndex = 10;
//      // 
//      // txtCompany
//      // 
//      this.txtCompany.Location = new System.Drawing.Point(77, 138);
//      this.txtCompany.Name = "txtCompany";
//      this.txtCompany.Size = new System.Drawing.Size(100, 21);
//      this.txtCompany.TabIndex = 11;
//      // 
//      // txtIntroduce
//      // 
//      this.txtIntroduce.Location = new System.Drawing.Point(77, 170);
//      this.txtIntroduce.Name = "txtIntroduce";
//      this.txtIntroduce.Size = new System.Drawing.Size(100, 21);
//      this.txtIntroduce.TabIndex = 12;
//      // 
//      // txtEmail
//      // 
//      this.txtEmail.Location = new System.Drawing.Point(242, 42);
//      this.txtEmail.Name = "txtEmail";
//      this.txtEmail.Size = new System.Drawing.Size(71, 21);
//      this.txtEmail.TabIndex = 13;
//      // 
//      // txtMobile
//      // 
//      this.txtMobile.Location = new System.Drawing.Point(242, 85);
//      this.txtMobile.Name = "txtMobile";
//      this.txtMobile.Size = new System.Drawing.Size(71, 21);
//      this.txtMobile.TabIndex = 14;
//      // 
//      // txtDepartment
//      // 
//      this.txtDepartment.Location = new System.Drawing.Point(242, 114);
//      this.txtDepartment.Name = "txtDepartment";
//      this.txtDepartment.Size = new System.Drawing.Size(71, 21);
//      this.txtDepartment.TabIndex = 15;
//      // 
//      // PrevBtn
//      // 
//      this.PrevBtn.Location = new System.Drawing.Point(20, 313);
//      this.PrevBtn.Name = "PrevBtn";
//      this.PrevBtn.Size = new System.Drawing.Size(75, 23);
//      this.PrevBtn.TabIndex = 2;
//      this.PrevBtn.Text = "앞으로";
//      this.PrevBtn.UseVisualStyleBackColor = true;
//      this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
//      // 
//      // NextBtn
//      // 
//      this.NextBtn.Location = new System.Drawing.Point(108, 312);
//      this.NextBtn.Name = "NextBtn";
//      this.NextBtn.Size = new System.Drawing.Size(75, 23);
//      this.NextBtn.TabIndex = 3;
//      this.NextBtn.Text = "뒤로";
//      this.NextBtn.UseVisualStyleBackColor = true;
//      this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
//      // 
//      // InsertBtn
//      // 
//      this.InsertBtn.Location = new System.Drawing.Point(234, 313);
//      this.InsertBtn.Name = "InsertBtn";
//      this.InsertBtn.Size = new System.Drawing.Size(75, 23);
//      this.InsertBtn.TabIndex = 4;
//      this.InsertBtn.Text = "추가";
//      this.InsertBtn.UseVisualStyleBackColor = true;
//      this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
//      // 
//      // UpdateBtn
//      // 
//      this.UpdateBtn.Location = new System.Drawing.Point(340, 313);
//      this.UpdateBtn.Name = "UpdateBtn";
//      this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
//      this.UpdateBtn.TabIndex = 5;
//      this.UpdateBtn.Text = "수정";
//      this.UpdateBtn.UseVisualStyleBackColor = true;
//      this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
//      // 
//      // DeleteBtn
//      // 
//      this.DeleteBtn.Location = new System.Drawing.Point(427, 313);
//      this.DeleteBtn.Name = "DeleteBtn";
//      this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
//      this.DeleteBtn.TabIndex = 6;
//      this.DeleteBtn.Text = "삭제";
//      this.DeleteBtn.UseVisualStyleBackColor = true;
//      this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
//      // 
//      // MainForm
//      // 
//      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
//      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//      this.ClientSize = new System.Drawing.Size(508, 348);
//      this.Controls.Add(this.DeleteBtn);
//      this.Controls.Add(this.UpdateBtn);
//      this.Controls.Add(this.InsertBtn);
//      this.Controls.Add(this.NextBtn);
//      this.Controls.Add(this.PrevBtn);
//      this.Controls.Add(this.DataGroup);
//      this.Controls.Add(this.SearchGroup);
//      this.Name = "MainForm";
//      this.Text = "MainForm";
//      this.Load += new System.EventHandler(this.MainForm_Load);
//      this.SearchGroup.ResumeLayout(false);
//      this.SearchGroup.PerformLayout();
//      this.DataGroup.ResumeLayout(false);
//      this.DataGroup.PerformLayout();
//      this.ResumeLayout(false);

//    }

//    #endregion

//    private System.Windows.Forms.GroupBox SearchGroup;
//    private System.Windows.Forms.GroupBox DataGroup;
//    private System.Windows.Forms.ListBox NameList;
//    private System.Windows.Forms.Button SearchBtn;
//    private System.Windows.Forms.TextBox txtSearch;
//    private System.Windows.Forms.TextBox txtDepartment;
//    private System.Windows.Forms.TextBox txtMobile;
//    private System.Windows.Forms.TextBox txtEmail;
//    private System.Windows.Forms.TextBox txtIntroduce;
//    private System.Windows.Forms.TextBox txtCompany;
//    private System.Windows.Forms.TextBox txtAddress;
//    private System.Windows.Forms.TextBox txtPhone;
//    private System.Windows.Forms.TextBox txtName;
//    private System.Windows.Forms.Label label8;
//    private System.Windows.Forms.Label label7;
//    private System.Windows.Forms.Label label6;
//    private System.Windows.Forms.Label label5;
//    private System.Windows.Forms.Label label4;
//    private System.Windows.Forms.Label label3;
//    private System.Windows.Forms.Label label2;
//    private System.Windows.Forms.Label label1;
//    private System.Windows.Forms.Button PrevBtn;
//    private System.Windows.Forms.Button NextBtn;
//    private System.Windows.Forms.Button InsertBtn;
//    private System.Windows.Forms.Button UpdateBtn;
//    private System.Windows.Forms.Button DeleteBtn;
//  }
//}