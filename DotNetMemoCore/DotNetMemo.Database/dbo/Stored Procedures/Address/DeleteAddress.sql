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
