use master
go
if exists(select * from sysdatabases where name ='DateBaseDemo')
drop database DateBaseDemo
go
create database DateBaseDemo----�������ݿ�
go
use DateBaseDemo
go
go
create table Product  ----����Ա
(
	pId bigint identity(1,1) primary key,--����Զ�����
	pCode varchar(50),	--���
	pName varchar(50),	--����
	pQuantityPerUnit varchar(50),	--���
	pUnit varchar(50),	--��λ
	pSellPrice varchar(50),	--�ۼ�
	pBuyPrice varchar(50),	--����
	pRemark varchar(200),	--��ע
)
go
create table Managers  ----����Ա
(
	mID int identity(1,1) primary key,
	mName varchar(20) not null,	--����Ա����
	mPassword varchar(20) not null,	--����Ա����
)
go
select * from Managers
go