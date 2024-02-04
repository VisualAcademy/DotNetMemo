--[6] 검색 : SearchAddress, FrmSearch.cs, Search.aspx
Create Proc dbo.SearchAddress
	@SearchField NVarChar(25),
	@SearchQuery NVarChar(25)
As
	Declare @strSql NVarChar(150)
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
