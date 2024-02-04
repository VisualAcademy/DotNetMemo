--[1] 카테고리 테이블 생성
Create Table dbo.Categories
(
	CategoryID Int Identity(1, 1) 
		Not Null
		Primary Key,	--일련번호
	CategoryName VarChar(50)
		Not Null,	--카테고리명
	SuperCategory Int 		
		Null, 		--부모카테고리번호
	Align SmallInt 
		Default(0)	--정렬순서
)
Go

--[!] 예시문
--[2] 입력
Insert Categories
	(CategoryName, SuperCategory, Align) 
Values
	('컴퓨터', NULL, 0)
Go

--[3] 출력
Select *
From Categories
Order By CategoryID Asc, Align Asc
Go

--[4] 상세
Select * 
From Categories
Where CategoryID = 1
Go

--[5] 수정
Begin Tran
	Update Categories
	Set 
		CategoryName = '컴퓨러'
	Where
		CategoryID = 1
--RollBack Tran
Commit Transaction
Go

--[6] 삭제
Delete Categories
Where CategoryID = 1
Go

--[7] 검색
Select * 
From Categories
Where CategoryName Like '%컴%'
Go

--[!] 저장 프로시저
--[8] 입력 : WriteCategory, FrmWrite.cs, Write.aspx
Create Procedure dbo.WriteCategory
(
	@CategoryName VarChar(50),
	@SuperCategory Int,
	@Align SmallInt
)
As
	Insert Categories
		(CategoryName, SuperCategory, Align) 
	Values
		(@CategoryName, @SuperCategory, @Align)
Go
Execute WriteCategory '핸드폰', NULL, 1
Go

--[9] 출력 : ListCategory, FrmList.cs, List.aspx
Create Proc dbo.ListCategory
With Encryption
As
	Select *
	From Categories
	Order By CategoryID Asc, Align Asc
Go
Exec ListCategory
Go

--[10] 상세 : ViewCategory, FrmView.cs, View.aspx 
Create Proc dbo.ViewCategory
	@CategoryID Int
As
	Select * 
	From Categories
	Where CategoryID = @CategoryID
Go
ViewCategory 1
Go

--[11] 수정 : ModifyCategory, FrmModify.cs, Modify.aspx
Create Proc dbo.ModifyCategory
(
	@CategoryName VarChar(50),
	@CategoryID Int
)
As
	Begin Tran
		Update Categories
		Set 
			CategoryName = @CategoryName
		Where
			CategoryID = @CategoryID
	--RollBack Tran
	Commit Transaction
Go
Exec ModifyCategory '컴퓨터'

--[12] 삭제 : DeleteCategory, FrmDelete.cs, Delete.aspx
Create Proc dbo.DeleteCategory
	@CategoryID Int
As
	Delete Categories
	Where CategoryID = @CategoryID
Go
Exec DeleteCategory 1
Go

--[13] 검색 : SearchCategory, FrmSearch.cs, Search.aspx
Create Proc dbo.SearchCategory
	@SearchField VarChar(50),
	@SearchQuery VarChar(50)
As
	Declare @strSql VarChar(200)
	Set @strSql = '		
	Select * 
	From Categories
	Where 
		' + @SearchField + 
	' Like ''%' + @SearchQuery + '%''
	'
	Exec(@strSql)
Go
Exec SearchCategory 'CategoryName', '퓨'
/*
컴퓨터
   노트북
      삼성
   데스크톱
핸드폰
   신규
   중고

1 컴퓨터 NULL 0
2 핸드폰 NULL 1
3 노트북 1    0
4 신규   2    0
5 데스크톱 1   1
6 중고    2   1
7 삼성    3   0
*/