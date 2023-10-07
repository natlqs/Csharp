use master
go
--判断当前数据库是否存在
if exists (select * from sysdatabases where name='CourseManageDB')
drop database CourseManageDB--删除数据库
go
--创建数据库
create database CourseManageDB
on primary
(
	--数据库文件的逻辑名
    name='CourseManageDB_data',
    --数据库物理文件名（绝对路径）
    filename='D:\DB\CourseManageDB_data.mdf',
    --数据库文件初始大小
    size=10MB,
    --数据文件增长量
    filegrowth=1MB
)
--创建日志文件
log on
(
    name='CourseManageDB_log',
    filename='D:\DB\CourseManageDB_log.ldf',
    size=2MB,
    filegrowth=1MB
)
go
--创建讲师数据表
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
	 NowAddress nvarchar(100) default('地址不详')
)
go
--课程分类表
if exists (select * from sysobjects where name='CourseCategory')
drop table CourseCategory
go
create table CourseCategory
(
     CategoryId  int identity(10,1) primary key,
     CategoryName varchar(20) not null    
)
go
--课程表
if exists (select * from sysobjects where name='Course')
drop table Course
go
create table Course
(
    CourseId int identity(1000,1) primary key,
    CourseName varchar(100) not null,
	CourseContent nvarchar(500) not null,
    ClassHour int not null,  --课时
	Credit int not null check(Credit>=1 and Credit<=30),--学分
	CategoryId int references CourseCategory(CategoryId),
	TeacherId int references Teacher(TeacherId) --引用讲师表
)
go

--添加测试数据
insert into Teacher(LoginAccount,LoginPwd,TeacherName,PhoneNumber)values
('xiketang01','123456','常老师','13602011111'),
('xiketang02','123456','张老师','13602011112'),
('xiketang03','123456','王老师','13602011113')
insert into CourseCategory(CategoryName)values('.Net开发'),('Java开发'),('微信小程序')
insert into Course(CourseName, CourseContent, ClassHour, Credit,CategoryId, TeacherId)values
('.Net全栈开发课程20','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net全栈开发课程15','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',510,10,10,1000),
('.Net全栈开发课程13','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',480,10,10,1000),
('.Net全栈开发课程12','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',505,10,10,1000),
('.Net全栈开发课程09','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net全栈开发课程06','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1002),
('.Net全栈开发课程01','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net全栈开发课程11','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',566,10,10,1002),
('.Net全栈开发课程14','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',380,10,10,1000),
('.Net全栈开发课程02','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',450,10,10,1001),
('.Net全栈开发课程05','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net全栈开发课程03','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net全栈开发课程07','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1001),
('.Net全栈开发课程08','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1001),
('.Net全栈开发课程10','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1001),
('.Net全栈开发课程16','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1000),
('.Net全栈开发课程17','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',550,10,10,1002),
('.Net全栈开发课程18','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',500,10,10,1002),
('.Net全栈开发课程13','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',520,10,10,1000),
('.Net全栈开发课程19','C#基础/OOP/SQL/WinForm/ASP.NET/WPF/WCF',510,10,10,1000),

('Java全栈开发课程20','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Java全栈开发课程15','OOP/JSP/HTML/Servlet/MVC/SSH',510,12,11,1000),
('Java全栈开发课程13','OOP/JSP/HTML/Servlet/MVC/SSH',480,12,11,1000),
('Java全栈开发课程12','OOP/JSP/HTML/Servlet/MVC/SSH',505,12,11,1000),
('Java全栈开发课程09','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Java全栈开发课程06','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1002),
('Java全栈开发课程01','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Java全栈开发课程11','OOP/JSP/HTML/Servlet/MVC/SSH',566,12,11,1002),
('Java全栈开发课程14','OOP/JSP/HTML/Servlet/MVC/SSH',380,12,11,1000),
('Java全栈开发课程02','OOP/JSP/HTML/Servlet/MVC/SSH',450,12,11,1001),
('Java全栈开发课程05','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Java全栈开发课程03','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Java全栈开发课程07','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1001),
('Java全栈开发课程08','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1001),
('Java全栈开发课程10','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1001),
('Java全栈开发课程16','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1000),
('Java全栈开发课程17','OOP/JSP/HTML/Servlet/MVC/SSH',550,12,11,1002),
('Java全栈开发课程18','OOP/JSP/HTML/Servlet/MVC/SSH',500,12,11,1002),
('Java全栈开发课程13','OOP/JSP/HTML/Servlet/MVC/SSH',520,12,11,1000),
('Java全栈开发课程19','OOP/JSP/HTML/Servlet/MVC/SSH',510,12,11,1000)

select * from Teacher
select * from CourseCategory
select * from Course


--添加约束

--创建数据关系图

--基本CRUD操作

--查询

--修改

--删除