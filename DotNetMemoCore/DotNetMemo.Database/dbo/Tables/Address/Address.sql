--* 주소록 애플리케이션 DB

--[0] 주소록(Address) 테이블 생성
Create Table dbo.Address
(
	Num Int Identity(1, 1) 
		Primary Key Not Null,--번호
	[Name] NVarChar(25) Not Null, --이름
	Email NVarChar(100) Null,     --이메일
	Phone NVarChar(15) Null,	     --전화
	Mobile NVarChar(15) Null,     --휴대폰
	ZipCode NVarChar(7) Not Null, --우편번호
	Address NVarChar(150) Null,   --주소
	PostDate SmallDateTime Default(GetDate())   --등록일
)
Go
