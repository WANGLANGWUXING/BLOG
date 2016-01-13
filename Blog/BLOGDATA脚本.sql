use master
GO
if exists(select *from sysdatabases where name='BLOGDB')
	drop database BLOGDB
GO
CREATE DATABASE BLOGDB
ON
(
NAME='BLOGDB',
FILENAME='D:\BLOGDATA\BLOGDB.mdf',
SIZE=5,
FILEGROWTH=1MB
)
LOG ON
(
NAME='BLOGDB_log',
FILENAME='D:\BLOGDATA\BLOGDB_log.ldf',
SIZE=2,
FILEGROWTH=10%
)
GO
--查询所以数据库
select * from sysdatabases
GO
use BLOGDB
GO
create table Admin--管理员表
(
AdminId                        int                                not null primary key identity(1,1),
Adminlogin                 nvarchar(100)                not null ,
Adminpassword          nvarchar(100)                not null 
)
GO
create table Taxonomy--博客分类表
(
TaxonomyId                      int                                not null primary key identity(1,1),
TaxonomyName                nvarchar(20)                not null,
Taxonomydesc                   nvarchar(100)              not null
)
GO
create table Posts--帖子表
(
PostId                                int                                 not null primary key identity(1,1),
TaxonomyId                      int                                 not null foreign key references Taxonomy(TaxonomyId),
Title                                   nvarchar(20)                 not null,
Post                               nvarchar(max)                  not null ,
PublishTime                      datetime                        default getdate()
)
GO
create table Users--访客表
(
UserId                                      int                                 not null primary key identity(1,1),
Username                              nvarchar(20)                     not null,
UserEmail                              nvarchar(100)                 not null,
UserIP                                   nvarchar(20)                      
)
GO
create table Comments--评论表
(
CommentId                         int                                  not null primary key identity(1,1),
PostId                                  int                                   not null foreign key references Posts(PostId),
UserId                                  int                                   not null foreign key references Users(UserId),
Commentsmeta                  nvarchar(max)                 not null ,
CommentsTime                  datetime                          default getdate(),
)
GO
select * from Admin
select * from Admin where AdminId=2

select * from Taxonomy
select * from Taxonomy where TaxonomyId=2

select * from Posts
select * from Posts where PostId=2

select * from Users
select * from Users where UserId=2

select * from Comments
select * from Comments where CommentId=2

insert into Admin(Adminlogin,Adminpassword) select 'wuxin','123456'

insert into Taxonomy(TaxonomyName,Taxonomydesc) select '心情','平时感悟及心情记录'

insert into Posts(TaxonomyId,Title,Post) select '1','xx','sadfasdfasdfasd'

insert into Users(Username,UserEmail,UserIP) select 'wuxin','1054356664@qq.com',''

insert into Comments(PostId,UserId,Commentsmeta) select '1','1','GOOD'

delete from Admin where AdminId=2

delete from Taxonomy where TaxonomyId=2

delete from Posts where PostId=2

delete from Users where UserId=2

delete from Comments where CommentId=2

Update Taxonomy set TaxonomyName='娱乐',Taxonomydesc='日常娱乐' where TaxonomyId=2

Update Posts set TaxonomyId=1,Post='asdfrgfdhgfhfg' where PostId=2

Update Comments set Commentsmeta='sd' where CommentId=2
GO
create proc proc_Login
@AdminName nvarchar(20),
@AdminPwd nvarchar(20)
as
begin 
	select *from Admin where Adminlogin=@AdminName and Adminpassword=@AdminPwd
end
go
