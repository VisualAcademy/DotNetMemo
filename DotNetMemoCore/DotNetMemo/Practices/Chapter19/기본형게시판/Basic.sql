--Basic ���̺� ����
--Drop Table dbo.Basic
Create Table dbo.Basic
(
     Num Int Identity(1, 1) Not Null Primary Key,  --��ȣ
     [Name] VarChar(25) Not Null,                    --�̸�
     Email VarChar(100) Null,                     --�̸���     
     Title VarChar(150) Not Null,                  --����
     PostDate DateTime Default(GetDate()) Not Null, --�ۼ���     
     PostIP VarChar(15) Not Null,                  --�ۼ�IP
     Content Text Not Null,                        --����
     [Password] VarChar(20) Not Null,                --��й�ȣ
     ReadCount SmallInt Default 0,                    --��ȸ��
     Encoding VarChar(10) Not Null,	        --���ڵ�(HTML/Text)
     HomePage VarChar(100) Null,                 --Ȩ������
     ModifyDate DateTime Null,                   --������     
     ModifyIP VarChar(15) Null                   --����IP
)
Go

--Insert ���ù�
Insert Basic
(
     Name, Email, Title, 
     PostDate, PostIP, 
     Content, Password, 
     Encoding, HomePage
)
Values
(
     'ȫ�浿', 'h@h.com', 'ȫ�浿�Դϴ�.', 
     GetDate(), '127.0.0.1', 
     '�ȳ��ϼ���''�ݰ����ϴ�.', '1234', 
     'Text', ''
)

--Insert SP��
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

--��� ���ù�
Select Num, Title, Name, ReadCount, PostDate 
From Basic 
Order By Num Desc

--��� �������ν���
Create Procedure dbo.ListBasic
As
	Select Num, Title, Name, ReadCount, PostDate 
	From Basic 
	Order By Num Desc
Go

--�� ���ù�
Select * From Basic Where Num = 2

--�� ���� ���ν���
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

--���� ���ù�
Update Basic
Set 
	Name = '',
	Email = '',
	HomePage = '',
	Title = '',
	Content = '',
	Encoding = '',
	Password = '' --������ ����(���߿� ��ȣ ó��)
Where 
	Num = 1

--���� ���� ���ν���
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
		Password = @Password --������ ����(���߿� ��ȣ ó��)
	Where 
		Num = @Num
Go

--���� ���ù�
Delete Basic Where Num = 1

--���� �������ν���
Create Procedure dbo.DeleteBasic
(
	@Num Int
)
As
	Delete Basic Where Num = @Num	
Go

--�˻� ���ù�(�Ϲ�)
Select * From Basic 
Where 
	Name Like '%ȫ�浿%'

--�˻� ���ù�(��ü) : All
Select * From Basic
Where 
	Name Like '%ȫ�浿%'
	Or
	Title Like '%����%'
	Or
	Content Like '%����%'

--�˻� �������ν��� : �˻��� C#���� ó��
--Drop Proc dbo.SearchBasic
Create Proc dbo.SearchBasic
As
	Select * From Basic Order By Num Desc
Go



