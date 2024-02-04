--[2] 출력 : ListAddress, FrmList.cs, List.aspx
Create Proc dbo.ListAddress
As
	Select * 
	From Address
	Order By Num Desc
Go
