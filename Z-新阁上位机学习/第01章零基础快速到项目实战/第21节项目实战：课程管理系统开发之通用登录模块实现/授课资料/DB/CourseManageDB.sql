use master
go
--�жϵ�ǰ���ݿ��Ƿ����
if exists (select * from sysdatabases where name='CourseManageDB')
drop database CourseManageDB--ɾ�����ݿ�
go
--�������ݿ�
create database CourseManageDB
on primary
(
	--���ݿ��ļ����߼���
    name='CourseManageDB_data',
    --���ݿ������ļ���������·����
    filename='D:\DB\CourseManageDB_data.mdf',
    --���ݿ��ļ���ʼ��С
    size=10MB,
    --�����ļ�������
    filegrowth=1MB
)
--������־�ļ�
log on
(
    name='CourseManageDB_log',
    filename='D:\DB\CourseManageDB_log.ldf',
    size=2MB,
    filegrowth=1MB
)
go
--������ʦ���ݱ�
use CourseManageDB
go
if exists (select * from sysobjects where name='Teacher')
drop table Teacher
go
create table Teacher
(
     TeacherId  int identity(1000,1) primary key,
     LoginAccount varchar(50) not null,
     LoginPwd varchar(18) not null check(len(LoginPwd)>=6 and len(LoginPwd)<=18 ),
     TeacherName varchar(20) not null,
	 PhoneNumber char(11) not null,
	 NowAddress nvarchar(100) default('��ַ����')
)
go
--�γ̷����
if exists (select * from sysobjects where name='CourseCategory')
drop table CourseCategory
go
create table CourseCategory
(
     CategoryId  int identity(10,1) primary key,
     CategoryName varchar(20) not null    
)
go
--�γ̱�
if exists (select * from sysobjects where name='Course')
drop table Course
go
create table Course
(
    CourseId int identity(1000,1) primary key,
    CourseName varchar(100) not null,
	CourseContent nvarchar(500) not null,
    ClassHour int not null,  --��ʱ
	Credit int not null check(Credit>=1 and Credit<=30),--ѧ��
	CategoryId int references CourseCategory(CategoryId),
	TeacherId int references Teacher(TeacherId) --���ý�ʦ��
)
go

--��Ӳ�������
insert into Teacher(LoginAccount,LoginPwd,TeacherName,PhoneNumber)values
('xiketang01','123456','����ʦ','13602011111'),
('xiketang02','123456','����ʦ','13602011112'),
('xiketang03','123456','����ʦ','13602011113')
insert into CourseCategory(CategoryName)values('.Net����'),('Java����'),('΢��С����')
insert into Course(CourseName, CourseContent, ClassHour, Credit,CategoryId, TeacherId)values
('.Netȫջ�����γ�20','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Netȫջ�����γ�15','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',510,10,10,1000),
('.Netȫջ�����γ�13','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',480,10,10,1000),
('.Netȫջ�����γ�12','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',505,10,10,1000),
('.Netȫջ�����γ�09','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Netȫջ�����γ�06','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1002),
('.Netȫջ�����γ�01','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Netȫջ�����γ�11','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',566,10,10,1002),
('.Netȫջ�����γ�14','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',380,10,10,1000),
('.Netȫջ�����γ�02','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',450,10,10,1001),
('.Netȫջ�����γ�05','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Netȫջ�����γ�03','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Netȫջ�����γ�07','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1001),
('.Netȫջ�����γ�08','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1001),
('.Netȫջ�����γ�10','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1001),
('.Netȫջ�����γ�16','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Netȫջ�����γ�17','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',550,10,10,1002),
('.Netȫջ�����γ�18','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1002),
('.Netȫջ�����γ�13','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',520,10,10,1000),
('.Netȫջ�����γ�19','C#����/OOP/SQL/WinForm/ASP.NET/WPF/WCF',510,10,10,1000),

('Javaȫջ�����γ�20','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Javaȫջ�����γ�15','OOP/JSP/HTML/Servlet/MVC/SSH',510,12,11,1000),
('Javaȫջ�����γ�13','OOP/JSP/HTML/Servlet/MVC/SSH',480,12,11,1000),
('Javaȫջ�����γ�12','OOP/JSP/HTML/Servlet/MVC/SSH',505,12,11,1000),
('Javaȫջ�����γ�09','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Javaȫջ�����γ�06','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1002),
('Javaȫջ�����γ�01','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Javaȫջ�����γ�11','OOP/JSP/HTML/Servlet/MVC/SSH',566,12,11,1002),
('Javaȫջ�����γ�14','OOP/JSP/HTML/Servlet/MVC/SSH',380,12,11,1000),
('Javaȫջ�����γ�02','OOP/JSP/HTML/Servlet/MVC/SSH',450,12,11,1001),
('Javaȫջ�����γ�05','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Javaȫջ�����γ�03','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Javaȫջ�����γ�07','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1001),
('Javaȫջ�����γ�08','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1001),
('Javaȫջ�����γ�10','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1001),
('Javaȫջ�����γ�16','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Javaȫջ�����γ�17','OOP/JSP/HTML/Servlet/MVC/SSH',550,12,11,1002),
('Javaȫջ�����γ�18','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1002),
('Javaȫջ�����γ�13','OOP/JSP/HTML/Servlet/MVC/SSH',520,12,11,1000),
('Javaȫջ�����γ�19','OOP/JSP/HTML/Servlet/MVC/SSH',510,12,11,1000)

select * from Teacher
select * from CourseCategory
select * from Course


--���Լ��

--�������ݹ�ϵͼ

--����CRUD����

--��ѯ

--�޸�

--ɾ��