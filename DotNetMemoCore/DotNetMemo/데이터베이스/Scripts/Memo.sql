--Drop Table dbo.Memo
Create Table dbo.Memo
(
	Num Int Identity(1, 1) Primary Key Not Null,	--번호
	Name VarChar(25) Null,			--이름
	Email VarChar(100) Null,			--이메일
	Title VarChar(150) Null,			--제목
	PostDate DateTime Default GetDate()	--작성일	
)
Go

Select * From Memo

--인라인 SQL
Insert Into Memo(Name, Email, Title, PostDate) 
Values('홍길동', 'h@h.com', '홍길동입니다.', GetDate())

--SQL 파라미터 방식
Insert Into Memo(Name, Email, Title, PostDate) 
Values(@Name, @Email, @Title, @PostDate)

--저장프로시저
Create Procedure dbo.procInsertMemo
	@Name VarChar(25),
	@Email VarChar(100),
	@Title VarChar(150),
	@PostDate DateTime
As
	Insert Into Memo(Name, Email, Title, PostDate) 
	Values(@Name, @Email, @Title, @PostDate)
Go


