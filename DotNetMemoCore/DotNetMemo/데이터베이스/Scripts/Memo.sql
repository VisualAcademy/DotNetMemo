--Drop Table dbo.Memo
Create Table dbo.Memo
(
	Num Int Identity(1, 1) Primary Key Not Null,	--��ȣ
	Name VarChar(25) Null,			--�̸�
	Email VarChar(100) Null,			--�̸���
	Title VarChar(150) Null,			--����
	PostDate DateTime Default GetDate()	--�ۼ���	
)
Go

Select * From Memo

--�ζ��� SQL
Insert Into Memo(Name, Email, Title, PostDate) 
Values('ȫ�浿', 'h@h.com', 'ȫ�浿�Դϴ�.', GetDate())

--SQL �Ķ���� ���
Insert Into Memo(Name, Email, Title, PostDate) 
Values(@Name, @Email, @Title, @PostDate)

--�������ν���
Create Procedure dbo.procInsertMemo
	@Name VarChar(25),
	@Email VarChar(100),
	@Title VarChar(150),
	@PostDate DateTime
As
	Insert Into Memo(Name, Email, Title, PostDate) 
	Values(@Name, @Email, @Title, @PostDate)
Go


