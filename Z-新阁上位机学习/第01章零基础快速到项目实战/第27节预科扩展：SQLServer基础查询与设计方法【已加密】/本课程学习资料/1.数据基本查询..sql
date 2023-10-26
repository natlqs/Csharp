
use StudentManageDB
go
select StudentName as 姓名,Gender as 性别,出生日期=birthday 
from Students where Gender='男'

select 姓名=StudentName,地址和电话=StudentAddress+'【'+PhoneNumber+'】' 
from Students where Gender='男'

select 总成绩=CSharp+SQLServerDB from ScoreList 

select * from ScoreList
insert into ScoreList(StudentId,CSharp) values(100009,78)

select * from ScoreList where SQLServerDB is null


select StudentName as 姓名,Gender as 性别,出生日期=birthday,所在学校='北京大学'
from Students where Gender='男'

select top 5 StudentName,Gender,Birthday from Students

select top 20 percent StudentName,Gender,Birthday from Students

select StudentId,(CSharp+5) as C#,DB=SQLServerDB
from ScoreList where (CSharp+5)>90
order by CSharp ASC

select StudentId,(CSharp+5) as C#,DB=SQLServerDB
from ScoreList where (CSharp+5)>90
order by CSharp DESC

select top 3 StudentId,CSharp as C#,DB=SQLServerDB
from ScoreList  
where StudentId not in(select top 6 StudentId from ScoreList order by SQLServerDB DESC,CSharp DESC )
order by SQLServerDB DESC,CSharp DESC

select StudentId,CSharp as C#,DB=SQLServerDB
from ScoreList  
order by SQLServerDB DESC,CSharp DESC





