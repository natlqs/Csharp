
use StudentManageDB
go
select StudentName,StudentAddress from Students 
where StudentAddress like '天津%'

select StudentName,StudentAddress from Students
where StudentName like '%小%'

select * from ScoreList
where CSharp between 80 and 90

select StudentName,StudentAddress,Birthday from Students
where Birthday between '1987-01-01' and '1988-01-01' 

select StudentName,StudentAddress,age from Students
where Age in(21,22,23)

select StudentName,StudentAddress,age from Students
where StudentName in('王小虎','贺小张')


select SUM(CSharp) as C#总成绩 from ScoreList

select 总人数=COUNT(*) from Students 

select MAX(Csharp) as C#最高分 ,MIN(CSharp) as C#最低分,AVG(CSharp) as C#最低分 from ScoreList

select Students.StudentId,C#成绩=CSharp,StudentName,ClassName
from ScoreList
inner join Students on  Students.StudentId=ScoreList.StudentId
inner join StudentClass on Students.ClassId=StudentClass.ClassId
 where CSharp >80

select  Students.StudentId,StudentName,Gender ,C#成绩=CSharp from Students
left outer join ScoreList on Students.StudentId=ScoreList.StudentId
where Gender='男'

select  Students.StudentId,StudentName,Gender ,C#成绩=CSharp from ScoreList
left outer join Students on Students.StudentId=ScoreList.StudentId
where Gender='男'

select 班级=StudentClass.ClassName,人数=COUNT(*),C#最高分=Max(CSharp),DB最高分=MAX(SQLServerDB),
AVG(CSharp) as C#平均分,AVG(SQLServerDB) as DB平均分
from Students
inner Join StudentClass on Students.ClassId =StudentClass.ClassId
inner join ScoreList on ScoreList.StudentId=Students.StudentId
group by ClassName
having AVG(CSharp)>=70 and AVG(SQLServerDB)>=70

select * from ScoreList
select StudentId from ScoreList group by StudentId  having COUNT(*)>1

select * from ScoreList
where StudentId in(select StudentId from ScoreList group by StudentId  having COUNT(*)>1)
order by StudentId

select * from ScoreList
where (select COUNT(*) from ScoreList s where s.StudentId=ScoreList.StudentId)>1
order by StudentId