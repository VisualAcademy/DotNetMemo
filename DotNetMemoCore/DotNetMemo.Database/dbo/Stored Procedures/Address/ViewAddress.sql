--[3] 상세 : ViewAddress, FrmView.cs, View.aspx
Create Proc dbo.ViewAddress
	@Num Int
As
	Select * 
	From Address
	Where Num = @Num
Go
