
use StudentManageDB
go
select StudentName,StudentAddress from Students 
where StudentAddress like '���%'

select StudentName,StudentAddress from Students
where StudentName like '%С%'

select * from ScoreList
where CSharp between 80 and 90

select StudentName,StudentAddress,Birthday from Students
where Birthday between '1987-01-01' and '1988-01-01' 

select StudentName,StudentAddress,age from Students
where Age in(21,22,23)

select StudentName,StudentAddress,age from Students
where StudentName in('��С��','��С��')


select SUM(CSharp) as C#�ܳɼ� from ScoreList

select ������=COUNT(*) from Students 

select MAX(Csharp) as C#��߷� ,MIN(CSharp) as C#��ͷ�,AVG(CSharp) as C#��ͷ� from ScoreList

select Students.StudentId,C#�ɼ�=CSharp,StudentName,ClassName
from ScoreList
inner join Students on  Students.StudentId=ScoreList.StudentId
inner join StudentClass on Students.ClassId=StudentClass.ClassId
 where CSharp >80

select  Students.StudentId,StudentName,Gender ,C#�ɼ�=CSharp from Students
left outer join ScoreList on Students.StudentId=ScoreList.StudentId
where Gender='��'

select  Students.StudentId,StudentName,Gender ,C#�ɼ�=CSharp from ScoreList
left outer join Students on Students.StudentId=ScoreList.StudentId
where Gender='��'

select �༶=StudentClass.ClassName,����=COUNT(*),C#��߷�=Max(CSharp),DB��߷�=MAX(SQLServerDB),
AVG(CSharp) as C#ƽ����,AVG(SQLServerDB) as DBƽ����
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