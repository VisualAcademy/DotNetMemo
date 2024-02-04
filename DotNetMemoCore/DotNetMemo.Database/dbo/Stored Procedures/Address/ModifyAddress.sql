--[4] 수정 : ModifyAddress, FrmModify,cs, Modify.aspx
Create Proc dbo.ModifyAddress
	@Name NVarChar(25),
	@Email NVarChar(100),
	@Phone NVarChar(15),
	@Mobile NVarChar(15),
	@ZipCode NVarChar(7),
	@Address NVarChar(150),
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
