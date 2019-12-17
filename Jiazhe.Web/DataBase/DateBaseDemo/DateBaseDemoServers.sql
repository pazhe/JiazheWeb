use master
go
if exists(select * from sysdatabases where name ='DateBaseDemo')
drop database DateBaseDemo
go
create database DateBaseDemo----创建数据库
go
use DateBaseDemo
go
go
create table Product  ----管理员
(
	pId bigint identity(1,1) primary key,--序号自动递增
	pCode varchar(50),	--编号
	pName varchar(50),	--名称
	pQuantityPerUnit varchar(50),	--规格
	pUnit varchar(50),	--单位
	pSellPrice varchar(50),	--售价
	pBuyPrice varchar(50),	--进价
	pRemark varchar(200),	--备注
)
go
create table Managers  ----管理员
(
	mID int identity(1,1) primary key,
	mName varchar(20) not null,	--管理员姓名
	mPassword varchar(20) not null,	--管理员密码
)
go
select * from Managers
go