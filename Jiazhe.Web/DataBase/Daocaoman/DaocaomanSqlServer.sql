use master
go
if exists(select * from sysdatabases where name ='DaocaomanDate')
drop database DaocaomanDate
go
create database DaocaomanDate----�������ݿ�
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
create table Managers  ----����Ա
(
	mID bigint identity(1,1) primary key,
	mName varchar(20) not null,	--����Ա����
	mPassword varchar(20) not null,	--����Ա����
)
go
------�û�����
create table ShokeyLevel
(
	sklID bigint identity(1,1) primary key not null,
	sklName varchar (20) not null,
)
go
create table Shokey -----�û�
(
	skID bigint identity (1,1) primary key,
	sklID bigint foreign key references ShokeyLevel(sklID) default(1),---�û�����ID
	skName varchar(20) not null,
	skPass varchar(20) not null,
	skSex varchar(2),     ----�Ա�
	skRealName varchar(16),  ----��ʵ����
	skAlipay varchar(80),
	skTencent varchar(20),
	skEmail varchar(20),
	skIdenCard varchar(20),  ---���֤��
	skTelphone varchar(12),  ----�绰
	skDate smalldatetime default(getdate()), -----ע��ʱ��
)
go
create table Category  -----����
(
	categoryID bigint identity (1,1) primary key,
	categoryName varchar(20),
	categoryHref varchar(20),
)
go
create table Items  -----��Ʒ
(
	itemsID bigint identity (1,1) primary key,
	categoryID bigint foreign key references Category(categoryID) default(1),---����
	num_iid varchar(20),---��ƷID
	title varchar(20),---��Ʒ����
	pict_url varchar(20),---��Ʒ��ͼ
	small_images varchar(20),---��ƷСͼ�б�
	reserve_price varchar(20),---��Ʒһ�ڼ۸�
	zk_final_price varchar(20),----��Ʒ�ۿۼ۸�
	user_type varchar(20),----�������ͣ�0��ʾ���У�1��ʾ�̳�
	provcity varchar(20),----�������ڵ�
	item_url varchar(20),----��Ʒ��ַ
	nick varchar(20),----�����ǳ�
	seller_id varchar(20),----����id
	volume	 varchar(20),----30������
)