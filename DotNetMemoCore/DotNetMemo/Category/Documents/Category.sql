--[1] ī�װ� ���̺� ����
Create Table dbo.Categories
(
	CategoryID Int Identity(1, 1) 
		Not Null
		Primary Key,	--�Ϸù�ȣ
	CategoryName VarChar(50)
		Not Null,	--ī�װ���
	SuperCategory Int 		
		Null, 		--�θ�ī�װ���ȣ
	Align SmallInt 
		Default(0)	--���ļ���
)
Go

--[!] ���ù�
--[2] �Է�
Insert Categories
	(CategoryName, SuperCategory, Align) 
Values
	('��ǻ��', NULL, 0)
Go

--[3] ���
Select *
From Categories
Order By CategoryID Asc, Align Asc
Go

--[4] ��
Select * 
From Categories
Where CategoryID = 1
Go

--[5] ����
Begin Tran
	Update Categories
	Set 
		CategoryName = '��ǻ��'
	Where
		CategoryID = 1
--RollBack Tran
Commit Transaction
Go

--[6] ����
Delete Categories
Where CategoryID = 1
Go

--[7] �˻�
Select * 
From Categories
Where CategoryName Like '%��%'
Go

--[!] ���� ���ν���
--[8] �Է� : WriteCategory, FrmWrite.cs, Write.aspx
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
Execute WriteCategory '�ڵ���', NULL, 1
Go

--[9] ��� : ListCategory, FrmList.cs, List.aspx
Create Proc dbo.ListCategory
With Encryption
As
	Select *
	From Categories
	Order By CategoryID Asc, Align Asc
Go
Exec ListCategory
Go

--[10] �� : ViewCategory, FrmView.cs, View.aspx 
Create Proc dbo.ViewCategory
	@CategoryID Int
As
	Select * 
	From Categories
	Where CategoryID = @CategoryID
Go
ViewCategory 1
Go

--[11] ���� : ModifyCategory, FrmModify.cs, Modify.aspx
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
Exec ModifyCategory '��ǻ��'

--[12] ���� : DeleteCategory, FrmDelete.cs, Delete.aspx
Create Proc dbo.DeleteCategory
	@CategoryID Int
As
	Delete Categories
	Where CategoryID = @CategoryID
Go
Exec DeleteCategory 1
Go

--[13] �˻� : SearchCategory, FrmSearch.cs, Search.aspx
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
Exec SearchCategory 'CategoryName', 'ǻ'
/*
��ǻ��
   ��Ʈ��
      �Ｚ
   ����ũ��
�ڵ���
   �ű�
   �߰�

1 ��ǻ�� NULL 0
2 �ڵ��� NULL 1
3 ��Ʈ�� 1    0
4 �ű�   2    0
5 ����ũ�� 1   1
6 �߰�    2   1
7 �Ｚ    3   0
*/