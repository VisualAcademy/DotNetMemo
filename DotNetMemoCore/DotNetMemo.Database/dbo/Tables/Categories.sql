--[1] 카테고리 테이블 생성
Create Table dbo.Categories
(
	CategoryID Int Identity(1, 1) 
		Not Null
		Primary Key,	--일련번호
	CategoryName NVarChar(50)
		Not Null,	--카테고리명
	SuperCategory Int 		
		Null, 		--부모카테고리번호
	Align SmallInt 
		Default(0)	--정렬순서
)
Go

----[!] 예시문
----[2] 입력
--Insert Categories
--	(CategoryName, SuperCategory, Align) 
--Values
--	('컴퓨터', NULL, 0)
--Go

----[3] 출력
--Select *
--From Categories
--Order By CategoryID Asc, Align Asc
--Go

----[4] 상세
--Select * 
--From Categories
--Where CategoryID = 1
--Go

----[5] 수정
--Begin Tran
--	Update Categories
--	Set 
--		CategoryName = '컴퓨러'
--	Where
--		CategoryID = 1
----RollBack Tran
--Commit Transaction
--Go

----[6] 삭제
--Delete Categories
--Where CategoryID = 1
--Go

----[7] 검색
--Select * 
--From Categories
--Where CategoryName Like '%컴%'
--Go
