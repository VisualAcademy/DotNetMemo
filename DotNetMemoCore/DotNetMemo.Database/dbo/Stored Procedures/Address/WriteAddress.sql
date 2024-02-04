--[1] 입력 : WriteAddress, FrmWrite.cs, Write.aspx
Create Procedure dbo.WriteAddress
(
	@Name NVarChar(25),
	@Email NVarChar(100),
	@Phone NVarChar(15),
	@Mobile NVarChar(15),
	@ZipCode NVarChar(7),
	@Address NVarChar(150)
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
