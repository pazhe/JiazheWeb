use master
go
if exists(select * from sysdatabases where name ='JiazheWebDataBase')
drop database JiazheWebDataBase
go
create database JiazheWebDataBase----创建数据库
go
use JiazheWebDataBase
go
------用户级别
create table ConsumerLevel
(
	levelId bigint identity(1,1) primary key not null,
	levelName varchar (20) not null,
)
go
insert into ConsumerLevel values('普通会员')
insert into ConsumerLevel values('中级会员')
insert into ConsumerLevel values('高级会员')
insert into ConsumerLevel values('钻石会员')
go
select * from ConsumerLevel
go
create table Consumer -----用户
(
	cId bigint identity (1,1) primary key,
	levelId bigint foreign key references ConsumerLevel(levelId) default(1),---用户级别ID
	cName varchar(20) not null,
	cPassword varchar(20) not null,
	cSex varchar(2),     ----性别
	cRealName varchar(16),  ----真实姓名
	cAlipay varchar(80),------支付宝账号
	cTencent varchar(20),-----QQ号
	cEmail varchar(20),----邮箱
	cIdenCard varchar(20),  ---身份证号
	cTelphone varchar(12),  ----电话
	cDate smalldatetime default(getdate()), -----注册时间
)
go
insert into Consumer values(1,'wanghewei','tianxiao',null,null,null,null,null,null,null,default)
go
select * from Consumer