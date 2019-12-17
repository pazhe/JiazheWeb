use DaocaomanDate
go
create table weixinApp -----配置开发需求
(
	vxID bigint identity (1,1) primary key,
	skID bigint foreign key references Shokey(skID) default(1),---用户ID
	vxName varchar(80) not null,---微信名称
	appID varchar(80) not null,---开发者ID(AppID)
	appSecret varchar(80) not null,---开发者密码(AppSecret)
	serverToken varchar(80),     ----令牌(Token)
	encodingAESKey varchar(80),  ----消息加解密密钥(EncodingAESKey)
	isflag bigint default(1),-----是否通过
	skDate smalldatetime default(getdate()), -----注册时间
	stopDate smalldatetime default(getdate()+7), -----注册时间
)
go