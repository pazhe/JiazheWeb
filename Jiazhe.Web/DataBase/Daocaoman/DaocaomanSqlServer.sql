use master
go
if exists(select * from sysdatabases where name ='DaocaomanDate')
drop database DaocaomanDate
go
create database DaocaomanDate----创建数据库
go
use DaocaomanDate
go

CREATE TABLE [dbo].[LogDetails] (  
[LogID] bigint NOT NULL IDENTITY(1,1) ,  
[LogDate] datetime NOT NULL ,  
[LogThread] nvarchar(100) NOT NULL ,  
[LogLevel] nvarchar(200) NOT NULL ,  
[LogLogger] nvarchar(500) NOT NULL ,  
[LogMessage] nvarchar(3000) NOT NULL ,  
[LogActionClick] nvarchar(4000) NULL ,  
[UserName] nvarchar(30) NULL ,  
[UserIP] varchar(20) NULL   
) 
go
create table Managers  ----管理员
(
	mID bigint identity(1,1) primary key,
	mName varchar(20) not null,	--管理员姓名
	mPassword varchar(20) not null,	--管理员密码
)
go
------用户级别
create table ShokeyLevel
(
	sklID bigint identity(1,1) primary key not null,
	sklName varchar (20) not null,
)
go
create table Shokey -----用户
(
	skID bigint identity (1,1) primary key,
	sklID bigint foreign key references ShokeyLevel(sklID) default(1),---用户级别ID
	skName varchar(20) not null,
	skPass varchar(20) not null,
	skSex varchar(2),     ----性别
	skRealName varchar(16),  ----真实姓名
	skAlipay varchar(80),
	skTencent varchar(20),
	skEmail varchar(20),
	skIdenCard varchar(20),  ---身份证号
	skTelphone varchar(12),  ----电话
	skDate smalldatetime default(getdate()), -----注册时间
)
go
create table Category  -----分类
(
	categoryID bigint identity (1,1) primary key,
	categoryName varchar(20),
	categoryHref varchar(20),
)
go
create table Items  -----产品
(
	itemsID bigint identity (1,1) primary key,
	categoryID bigint foreign key references Category(categoryID) default(1),---分类
	num_iid varchar(20),---商品ID
	title varchar(20),---商品标题
	pict_url varchar(20),---商品主图
	small_images varchar(20),---商品小图列表
	reserve_price varchar(20),---商品一口价格
	zk_final_price varchar(20),----商品折扣价格
	user_type varchar(20),----卖家类型，0表示集市，1表示商城
	provcity varchar(20),----宝贝所在地
	item_url varchar(20),----商品地址
	nick varchar(20),----卖家昵称
	seller_id varchar(20),----卖家id
	volume	 varchar(20),----30天销量
)