use DaocaomanDate
go
create table weixinApp -----���ÿ�������
(
	vxID bigint identity (1,1) primary key,
	skID bigint foreign key references Shokey(skID) default(1),---�û�ID
	vxName varchar(80) not null,---΢������
	appID varchar(80) not null,---������ID(AppID)
	appSecret varchar(80) not null,---����������(AppSecret)
	serverToken varchar(80),     ----����(Token)
	encodingAESKey varchar(80),  ----��Ϣ�ӽ�����Կ(EncodingAESKey)
	isflag bigint default(1),-----�Ƿ�ͨ��
	skDate smalldatetime default(getdate()), -----ע��ʱ��
	stopDate smalldatetime default(getdate()+7), -----ע��ʱ��
)
go