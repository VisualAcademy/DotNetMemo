//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms;
//using System.Data.SqlClient; // SQL 서버 관련 명령어 집합

//namespace MyFriends
//{
//  public partial class MyFreinds : Form
//  {
//    #region Private Member Variables
//    SqlDataAdapter DBAdapter; // 데이터 어댑터 객체 생성 : 명령어 대신 실행
//    DataSet DS; // 데이터셋 객체 생성 : 메모리상에 데이터를 저장해 놓는 큰 그릇 
//    SqlCommandBuilder myCommandBuilder; // 입/출력수정삭제 자동화(?) 기능
//    #endregion
//    #region Constructors
//    public MyFreinds()
//    {
//      InitializeComponent();
//      try
//      {
//        // DataAdapter 개체에 명령어 및 데이터베이스 관련 정보 담기
//        DBAdapter = new SqlDataAdapter(
//          "Select * From MyFriends"
//        , @"server=(localdb)\mssqllocaldb;database=DotNetMemo;integrated security=true;");
//        // Select문을 바탕으로 4가지 구문 자동 생성:Select->Insert/Update/Delete
//        myCommandBuilder = new SqlCommandBuilder(DBAdapter);
//        // 데이터셋 객체 만들기 : 메모리 상에 데이터베이스 하나 만들기
//        DS = new DataSet();
//      }
//      catch (Exception DE)
//      {
//        MessageBox.Show(DE.Message); // 에러가 발생하면 에러메시지 출력
//      }
//    } 
//    #endregion
//    #region Event Handlers
//    private void MainForm_Load(object sender, EventArgs e)
//    {

//    }
//    // 검색
//    private void SearchBtn_Click(object sender, EventArgs e)
//    {
//      DS.Clear();
//      DBAdapter.Fill(DS, "MyFriends");
//      // 메모리 상의 테이블 : 물리적인 테이블을 그대로 메모리로 옮겨 놓은 상태
//      DataTable FriendsTable = DS.Tables["MyFriends"];

//      // 필터링(검색) : DataRow는 메모리 상의 하나의 레코드(행) 
//      DataRow[] ResultRows = 
//        FriendsTable.Select("Name Like '%" + txtSearch.Text + "%'");

//      // 리스트 박스 클리어 후 출력
//      NameList.Items.Clear();

//      foreach (DataRow currRow in ResultRows)
//      {
//        NameList.Items.Add(
//          String.Format("{0} {1}", currRow["ID"], currRow["Name"]));  
//      }
//    }
//    //[4] 424페이지 참조
//    private void PrevBtn_Click(object sender, EventArgs e)
//    {

//    }
//    //[5] 425페이지 참조
//    private void NextBtn_Click(object sender, EventArgs e)
//    {

//    }
//    // 입력
//    private void InsertBtn_Click(object sender, EventArgs e)
//    {
//      // 417 페이지
//      try
//      {
//        DS.Clear();
//        DBAdapter.Fill(DS, "MyFriends"); // 데이터셋 채우기
//        DataTable FriendsTale = DS.Tables["MyFriends"];//DataSet->DataTable
//        DataRow newRow = FriendsTale.NewRow(); // 입력될(새로운) 레코드/행 모양

//        newRow["Name"] = txtName.Text; // 이름 저장
//        newRow[2] = txtEmail.Text; // 
//        newRow[3] = txtPhone.Text; // 
//        newRow[4] = txtMobile.Text; //
//        newRow[5] = txtAddress.Text; 
//        newRow[6] = txtCompany.Text; 
//        newRow[7] = txtDepartment.Text;
//        newRow[8] = txtIntroduce.Text;

//        FriendsTale.Rows.Add(newRow); // 위에서 채워진 하나의 행들 테이블에 추가
//        DBAdapter.Update(DS, "MyFriends");
//        DS.AcceptChanges(); // 메모리상의 DB의 내용을 그대로 물리적 DB에 적용

//        ClearTextBoxes(); // 클리어
//      }
//      catch (Exception DE)
//      {
//        MessageBox.Show(DE.Message); ;
//      }
//    }
//    //[1] 421페이지 참조
//    private void UpdateBtn_Click(object sender, EventArgs e)
//    {

//    }
//    //[2] 423페이지 참조
//    private void DeleteBtn_Click(object sender, EventArgs e)
//    {

//    }
//    //[3] 421페이지 참조
//    private void NameList_SelectedIndexChanged(object sender, EventArgs e)
//    {

//    } 
//    #endregion
//    #region Public Methods
//    private void ClearTextBoxes() // 417페이지
//    {
//      txtName.Clear(); 
//      txtEmail.Clear(); 
//      txtPhone.Text = ""; // 제일 많이 쓰는 모양 : 공통
//      txtMobile.Text = String.Empty;
//      txtAddress.Text = "";
//      txtCompany.Text = "";
//      txtDepartment.Text = String.Empty;
//      txtIntroduce.Text = "";
//    }
//    #endregion
//  }
//}