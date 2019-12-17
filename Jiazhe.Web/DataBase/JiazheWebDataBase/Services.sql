use master
go
if exists(select * from sysdatabases where name ='JiazheWebDataBase')
drop database JiazheWebDataBase
go
create database JiazheWebDataBase----�������ݿ�
go
use JiazheWebDataBase
go
------�û�����
create table ConsumerLevel
(
	levelId bigint identity(1,1) primary key not null,
	levelName varchar (20) not null,
)
go
insert into ConsumerLevel values('��ͨ��Ա')
insert into ConsumerLevel values('�м���Ա')
insert into ConsumerLevel values('�߼���Ա')
insert into ConsumerLevel values('��ʯ��Ա')
go
select * from ConsumerLevel
go
create table Consumer -----�û�
(
	cId bigint identity (1,1) primary key,
	levelId bigint foreign key references ConsumerLevel(levelId) default(1),---�û�����ID
	cName varchar(20) not null,
	cPassword varchar(20) not null,
	cSex varchar(2),     ----�Ա�
	cRealName varchar(16),  ----��ʵ����
	cAlipay varchar(80),------֧�����˺�
	cTencent varchar(20),-----QQ��
	cEmail varchar(20),----����
	cIdenCard varchar(20),  ---���֤��
	cTelphone varchar(12),  ----�绰
	cDate smalldatetime default(getdate()), -----ע��ʱ��
)
go
insert into Consumer values(1,'wanghewei','tianxiao',null,null,null,null,null,null,null,default)
go
select * from Consumer