--* 주소록 애플리케이션 DB

--[0] 주소록(Address) 테이블 생성
Create Table dbo.Address
(
	Num Int Identity(1, 1) 
		Primary Key Not Null,--번호
	[Name] VarChar(25) Not Null, --이름
	Email VarChar(100) Null,     --이메일
	Phone VarChar(15) Null,	     --전화
	Mobile VarChar(15) Null,     --휴대폰
	ZipCode VarChar(7) Not Null, --우편번호
	Address VarChar(150) Null,   --주소
	PostDate SmallDateTime 
		Default(GetDate())   --등록일
)
Go

--[1] 입력
Insert Address
(
	Name,
	Email,
	Phone,
	Mobile,
	ZipCode,
	Address,
	PostDate
)
Values
(
	'홍길동',
	'h@h.com',
	'114',
	'119',
	'123-445',
	'서울',
	GetDate()
)
Go

--[2] 출력
Select * 
From Address
Order By Num Desc
Go

--[3] 상세
Select * 
From Address
Where Num = 5
Go

--[4] 수정
Begin Transaction
	Update Address
	Set
		Name = '백두산',
		Email = 'b@b.com',
		Phone = '116',
		Mobile = '110',
		ZipCode = '456-123',
		Address = '부산',
		PostDate = GetDate()
	Where
		Num = 5
--RollBack Tran
Commit Tran
Go

--[5] 삭제
Begin Tran
	Delete Address Where Num = 1
	Go
	--에러 : X
	Delete Address Where Num = 3
	Go
	--에러 : X
	Delete Address Where Num = 5
	Go
	--에러 : X
--RollBack Tran
Commit Tran
--에러 : O
Go

--[6] 검색
Select * 
From Address
Where
	Name Like '%홍%'
	Or
	Address Like '%서%'
Go

--Stored Procedure
--[1] 입력 : WriteAddress, FrmWrite.cs, Write.aspx
Create Procedure dbo.WriteAddress
(
	@Name VarChar(25),
	@Email VarChar(100),
	@Phone VarChar(15),
	@Mobile VarChar(15),
	@ZipCode VarChar(7),
	@Address VarChar(150)
)
As
	Insert Address
	(
		Name,
		Email,
		Phone,
		Mobile,
		ZipCode,
		Address,
		PostDate
	)
	Values
	(
		@Name,
		@Email,
		@Phone,
		@Mobile,
		@ZipCode,
		@Address,
		GetDate()
	)
Go

Execute WriteAddress 
	'한라산', 'h@h.com', 
	'114', '115', '123-456', '대전'
Go

--[2] 출력 : ListAddress, FrmList.cs, List.aspx
Create Proc dbo.ListAddress
As
	Select * 
	From Address
	Order By Num Desc
Go

Exec ListAddress
Go

--[3] 상세 : ViewAddress, FrmView.cs, View.aspx
Create Proc dbo.ViewAddress
	@Num Int
As
	Select * 
	From Address
	Where Num = @Num
Go

ViewAddress 10
Go

--[4] 수정 : ModifyAddress, FrmModify,cs, Modify.aspx
Create Proc dbo.ModifyAddress
	@Name VarChar(25),
	@Email VarChar(100),
	@Phone VarChar(15),
	@Mobile VarChar(15),
	@ZipCode VarChar(7),
	@Address VarChar(150),
	@Num Int
As	
	Begin Transaction
		Update Address
		Set
			Name = @Name,
			Email = @Email,
			Phone = @Phone,
			Mobile = @Mobile,
			ZipCode = @ZipCode,
			Address = @Address,
			PostDate = GetDate()
		Where
			Num = @Num
	--RollBack Tran
	Commit Tran
Go

Execute ModifyAddress '지리산', 'j@j.com', '114', '119', '123-123', '전북', 10
Go

--[5] 삭제 : DeleteAddress, FrmDelete.cs, Delete.aspx
Create Procedure dbo.DeleteAddress
	@Num Int
As
	Begin Tran
		Delete Address 
		Where Num = @Num
	--RollBack Tran
	Commit Tran
Go

Execute DeleteAddress 10
Go

--[6] 검색 : SearchAddress, FrmSearch.cs, Search.aspx
Create Proc dbo.SearchAddress
	@SearchField VarChar(25),
	@SearchQuery VarChar(25)
As
	Declare @strSql VarChar(150)
	Set @strSql = '
		Select * 
		From Address
		Where
			' + @SearchField 
			+ ' Like ''%' 
			+ @SearchQuery + '%'''
	--Print @strSql
	Exec (@strSql)
Go

Exec SearchAddress 'Address', '서울'
Go

--배포 URL : http://www.dotnetkorea.com/
--테스트 URL : http://sample.redplus.net/Web/Address/List.aspx