--* �ּҷ� ���ø����̼� DB

--[0] �ּҷ�(Address) ���̺� ����
Create Table dbo.Address
(
	Num Int Identity(1, 1) 
		Primary Key Not Null,--��ȣ
	[Name] VarChar(25) Not Null, --�̸�
	Email VarChar(100) Null,     --�̸���
	Phone VarChar(15) Null,	     --��ȭ
	Mobile VarChar(15) Null,     --�޴���
	ZipCode VarChar(7) Not Null, --�����ȣ
	Address VarChar(150) Null,   --�ּ�
	PostDate SmallDateTime 
		Default(GetDate())   --�����
)
Go

--[1] �Է�
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
	'ȫ�浿',
	'h@h.com',
	'114',
	'119',
	'123-445',
	'����',
	GetDate()
)
Go

--[2] ���
Select * 
From Address
Order By Num Desc
Go

--[3] ��
Select * 
From Address
Where Num = 5
Go

--[4] ����
Begin Transaction
	Update Address
	Set
		Name = '��λ�',
		Email = 'b@b.com',
		Phone = '116',
		Mobile = '110',
		ZipCode = '456-123',
		Address = '�λ�',
		PostDate = GetDate()
	Where
		Num = 5
--RollBack Tran
Commit Tran
Go

--[5] ����
Begin Tran
	Delete Address Where Num = 1
	Go
	--���� : X
	Delete Address Where Num = 3
	Go
	--���� : X
	Delete Address Where Num = 5
	Go
	--���� : X
--RollBack Tran
Commit Tran
--���� : O
Go

--[6] �˻�
Select * 
From Address
Where
	Name Like '%ȫ%'
	Or
	Address Like '%��%'
Go

--Stored Procedure
--[1] �Է� : WriteAddress, FrmWrite.cs, Write.aspx
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
	'�Ѷ��', 'h@h.com', 
	'114', '115', '123-456', '����'
Go

--[2] ��� : ListAddress, FrmList.cs, List.aspx
Create Proc dbo.ListAddress
As
	Select * 
	From Address
	Order By Num Desc
Go

Exec ListAddress
Go

--[3] �� : ViewAddress, FrmView.cs, View.aspx
Create Proc dbo.ViewAddress
	@Num Int
As
	Select * 
	From Address
	Where Num = @Num
Go

ViewAddress 10
Go

--[4] ���� : ModifyAddress, FrmModify,cs, Modify.aspx
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

Execute ModifyAddress '������', 'j@j.com', '114', '119', '123-123', '����', 10
Go

--[5] ���� : DeleteAddress, FrmDelete.cs, Delete.aspx
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

--[6] �˻� : SearchAddress, FrmSearch.cs, Search.aspx
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

Exec SearchAddress 'Address', '����'
Go

--���� URL : http://www.dotnetkorea.com/
--�׽�Ʈ URL : http://sample.redplus.net/Web/Address/List.aspx