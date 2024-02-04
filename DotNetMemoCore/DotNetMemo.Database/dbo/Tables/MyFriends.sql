-- 주소록 테이블 설계
Create Table dbo.MyFriends
(
	ID Int Identity(1, 1) Primary Key,
	Name VarChar(20),
	Email VarChar(30),
	Phone VarChar(20),
	Mobile VarChar(20),
	Address VarChar(50),
	Company VarChar(20),
	Department VarChar(20),
	Introduce VarChar(255)
)
Go

---- 예시문 6개 타이핑 연습
---- 입력
--Insert Into MyFriends
--Values ('홍길동', 'h@h.com', '114', '119'
--	, '서울 영등포', '현다이', '닷넷', '안녕하세요.')
---- 출력
--Select * From MyFriends Order By ID Desc
---- 상세
--Select * From MyFriends Where ID = 1
---- 수정
--Update MyFriends
--Set 
--	Name = '백두산', Email = 'b@b.com'
--Where ID = 1
---- 삭제
--Delete MyFriends
--Where ID = 1
---- 검색
--Select * From MyFriends Where Name Like '%백%'




