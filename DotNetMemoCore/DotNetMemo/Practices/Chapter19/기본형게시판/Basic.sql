--Basic 테이블 설계
--Drop Table dbo.Basic
Create Table dbo.Basic
(
     Num Int Identity(1, 1) Not Null Primary Key,  --번호
     [Name] VarChar(25) Not Null,                    --이름
     Email VarChar(100) Null,                     --이메일     
     Title VarChar(150) Not Null,                  --제목
     PostDate DateTime Default(GetDate()) Not Null, --작성일     
     PostIP VarChar(15) Not Null,                  --작성IP
     Content Text Not Null,                        --내용
     [Password] VarChar(20) Not Null,                --비밀번호
     ReadCount SmallInt Default 0,                    --조회수
     Encoding VarChar(10) Not Null,	        --인코딩(HTML/Text)
     HomePage VarChar(100) Null,                 --홈페이지
     ModifyDate DateTime Null,                   --수정일     
     ModifyIP VarChar(15) Null                   --수정IP
)
Go

--Insert 예시문
Insert Basic
(
     Name, Email, Title, 
     PostDate, PostIP, 
     Content, Password, 
     Encoding, HomePage
)
Values
(
     '홍길동', 'h@h.com', '홍길동입니다.', 
     GetDate(), '127.0.0.1', 
     '안녕하세요''반갑습니다.', '1234', 
     'Text', ''
)

--Insert SP문
Create Proc dbo.WriteBasic
(
	@Name VarChar(25),
	@Email VarChar(20),
	@Title VarChar(150),
	@PostIP	VarChar(15),
	@Content Text,
	@Password VarChar(20),
	@Encoding VarChar(10),
	@HomePage VarChar(100)
)
As
	Insert Basic
	(
	     Name, Email, Title, PostIP, 
	     Content, Password, Encoding, HomePage
	)
	Values
	(
	     @Name, @Email, @Title, @PostIP, 
	     @Content, @Password, @Encoding, @HomePage
	)
Go

--출력 예시문
Select Num, Title, Name, ReadCount, PostDate 
From Basic 
Order By Num Desc

--출력 저장프로시저
Create Procedure dbo.ListBasic
As
	Select Num, Title, Name, ReadCount, PostDate 
	From Basic 
	Order By Num Desc
Go

--상세 예시문
Select * From Basic Where Num = 2

--상세 저장 프로시저
--Drop Proc ViewBasic
Create Proc dbo.ViewBasic
(
	@Num Int
)
As
	Select 
		Num, Name, Email, HomePage,
		Title, Content 
	From Basic 
	Where Num = @Num
Go

--수정 예시문
Update Basic
Set 
	Name = '',
	Email = '',
	HomePage = '',
	Title = '',
	Content = '',
	Encoding = '',
	Password = '' --무조건 수정(나중에 암호 처리)
Where 
	Num = 1

--수정 저장 프로시저
Create Proc dbo.ModifyBasic
(
	@Name VarChar(25),	@Email VarChar(50),
	@HomePage VarChar(100),	@Title VarChar(150),
	@Content Text, @Encoding VarChar(10),
	@Password VarChar(20), @Num Int
)
As
	Update Basic
	Set 
		Name = @Name,	Email = @Email,
		HomePage = @HomePage,
		Title = @Title,	Content = @Content,
		Encoding = @Encoding,
		Password = @Password --무조건 수정(나중에 암호 처리)
	Where 
		Num = @Num
Go

--삭제 예시문
Delete Basic Where Num = 1

--삭제 저장프로시저
Create Procedure dbo.DeleteBasic
(
	@Num Int
)
As
	Delete Basic Where Num = @Num	
Go

--검색 예시문(일반)
Select * From Basic 
Where 
	Name Like '%홍길동%'

--검색 예시문(전체) : All
Select * From Basic
Where 
	Name Like '%홍길동%'
	Or
	Title Like '%제목%'
	Or
	Content Like '%내용%'

--검색 저장프로시저 : 검색은 C#에서 처리
--Drop Proc dbo.SearchBasic
Create Proc dbo.SearchBasic
As
	Select * From Basic Order By Num Desc
Go



