
use StudentManageDB
go
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100006,52,80) 
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100007,91,66)
insert into ScoreList (StudentId,CSharp,SQLServerDB)values(100009,78,35)

select * from ScoreList order by StudentId

--��֪���Ǹ��ֶ��ظ������
select StudentId from ScoreList  group by StudentId having COUNT(*)>1

--��ѯ�����ظ��ļ�¼
select * from ScoreList
where StudentId in(select StudentId from ScoreList  group by StudentId having COUNT(*)>1)
order by StudentId

--��������
select * from ScoreList
where (select COUNT(*) from ScoreList  s where s.StudentId=ScoreList.StudentId)>1
order by StudentId

--���˵��ظ�����
select distinct StudentId,CSharp from ScoreList

select distinct StudentId,CSharp,SQLServerDB from ScoreList