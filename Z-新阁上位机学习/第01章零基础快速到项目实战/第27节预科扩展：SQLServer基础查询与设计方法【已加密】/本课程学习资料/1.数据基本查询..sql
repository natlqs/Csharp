
use StudentManageDB
go
select StudentName as ����,Gender as �Ա�,��������=birthday 
from Students where Gender='��'

select ����=StudentName,��ַ�͵绰=StudentAddress+'��'+PhoneNumber+'��' 
from Students where Gender='��'

select �ܳɼ�=CSharp+SQLServerDB from ScoreList 

select * from ScoreList
insert into ScoreList(StudentId,CSharp) values(100009,78)

select * from ScoreList where SQLServerDB is null


select StudentName as ����,Gender as �Ա�,��������=birthday,����ѧУ='������ѧ'
from Students where Gender='��'

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





