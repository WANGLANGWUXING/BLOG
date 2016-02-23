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
TaxonomyId                      int                                 not null ,
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
PostId                                  int                                   not null ,
UserId                                  int                                   not null ,
Commentsmeta                  nvarchar(max)                 not null ,
CommentsTime                  datetime                          default getdate(),
)
GO
select * from Admin
select * from Admin where AdminId=2

select * from Taxonomy
select Top 2 *from Taxonomy
select * from Taxonomy where TaxonomyId=2

select * from Posts
select * from Posts  where TaxonomyId =1
select * from Posts where PostId=2

select * from Users
select * from Users where UserId=2

select * from Users
select * from Comments
select top 3 * from Comments order by CommentsTime desc
select * from Comments where CommentId=2

insert into Admin(Adminlogin,Adminpassword) select 'wuxin','123456'

insert into Taxonomy(TaxonomyName,Taxonomydesc) select '心情','平时感悟及心情记录'
insert into Taxonomy(TaxonomyName,Taxonomydesc) select '分类实例','demo'
insert into Posts(TaxonomyId,Title,Post) select '1','xx','sadfasdfasdfasd'
insert into Posts(TaxonomyId,Title,Post) select '1','萨芬','阿骨打'
insert into Posts(TaxonomyId,Title,Post) select '2','aspnet','萨嘎哈尔'
insert into Posts(TaxonomyId,Title,Post) select '2','php','sadf'
insert into Users(Username,UserEmail,UserIP) select 'wuxin','1054356664@qq.com',''

insert into Comments(PostId,UserId,Commentsmeta) select '1','1','GOOD'

--delete from Admin where AdminId=2

--delete from Taxonomy where TaxonomyId=2

--delete from Posts where PostId=2

--delete from Users where UserId=2

--delete from Comments where CommentId=2

Update Taxonomy set TaxonomyName='娱乐',Taxonomydesc='日常娱乐' where TaxonomyId=3

Update Taxonomy set TaxonomyName='学习',Taxonomydesc='学习经验' where TaxonomyId=2


Update Posts set TaxonomyId=1,Title='',Post='asdfrgfdhgfhfg' where PostId=2

Update Comments set Commentsmeta='sd' where CommentId=2

GO
create proc proc_Login
@AdminName nvarchar(100),
@AdminPwd nvarchar(100)
as
begin 
	select *from Admin where Adminlogin=@AdminName and Adminpassword=@AdminPwd
end
GO
select * from Posts
GO

create proc proc_Insert_Comment
	@PostId int,
	@Username nvarchar(20),
	@UserEmail nvarchar(100),
	@Commentsmeta nvarchar(max),
	@UserIP  nvarchar(20)  
AS
BEGIN
	insert into Users(Username,UserEmail,UserIP) select @Username,@UserEmail,@UserIP;
	declare @UserId int;
	select @UserId=@@IDENTITY
	insert into Comments(PostId,UserId,Commentsmeta) select @PostId,@UserId,@Commentsmeta
END
GO

GO
create proc proc_Insert_Post
	@TaxonomyId int,
	@Title nvarchar(20),
	@Post nvarchar(max)
as
begin
	insert into Posts(TaxonomyId,Title,Post) select @TaxonomyId,@Title,@Post
end
GO
GO
create proc proc_Update_Post
	@TaxonomyId int,
	@Title nvarchar(20),
	@Post nvarchar(max),
	@PostId int
AS
begin
	Update Posts set TaxonomyId=@TaxonomyId,Title=@Title,Post=@Post where PostId=@PostId
end
GO

GO
create proc proc_Insert_Tax
	@TaxonomyName nvarchar(20),
	@Taxonomydesc nvarchar(100)
AS
BEGIN
	insert into Taxonomy(TaxonomyName,Taxonomydesc) select @TaxonomyName,@Taxonomydesc
END
GO

GO
create proc proc_Update_Tax
	@TaxonomyName nvarchar(20),
	@Taxonomydesc nvarchar(100),
	@TaxonomyId int
AS
Begin
	Update Taxonomy set TaxonomyName=@TaxonomyName,Taxonomydesc=@Taxonomydesc where TaxonomyId=@TaxonomyId
End
GO

GO
create proc proc_Register
	@AdminName nvarchar(100),
	@AdminPwd nvarchar(100)
AS
Begin
	insert into Admin(Adminlogin,Adminpassword) select @AdminName,@AdminPwd
end

GO


exec proc_Insert_Comment 1,'xx','sdfs','sadfasdf',''

truncate table Users
truncate table Comments
delete from Users
select * from Users
select * from Comments
--查出最新的三个帖子
select top 3 * from Posts order by PublishTime desc

select count(*) from Posts
select count(*) from Taxonomy
select count(*) from Comments

select count(*) from Comments where PostId=1
insert into Posts(TaxonomyId,Title,Post) select '1','神经啊费德勒','风格恢复'
insert into Posts(TaxonomyId,Title,Post) select '2','骨灰级的','阿斯顿功法'
insert into Posts(TaxonomyId,Title,Post) select '2','阿斯地方','风格化'
--分页查询
declare @pageSize int=10
declare @pageIndex int=2
select top (@pageSize) *from Posts 
where PostId not in
(select top ((@pageIndex-1)*@pageSize) PostId from Posts order by PostId)
order by PostId

select * from Posts
GO
declare @pageSize int=10
declare @pageIndex int=1
select top (@pageSize) *from Taxonomy 
where TaxonomyId not in
(select top ((@pageIndex-1)*@pageSize) TaxonomyId from Taxonomy order by TaxonomyId)
order by TaxonomyId
GO

GO
declare @pageSize int=10
declare @pageIndex int=1
select top (@pageSize) *from Comments 
where CommentId not in
(select top ((@pageIndex-1)*@pageSize) CommentId from Comments order by CommentId)
order by CommentId
GO




