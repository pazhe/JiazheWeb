use master
go
use JiazheWebDataBase
go
create table WeixinPublicSetting -----���ں�
(
	wxId bigint identity (1,1) primary key,
	cId bigint foreign key references Consumer(cId) default(1),---�û�ID
	wxName varchar(80) ,---΢������
	wxNumber varchar(80),---΢�ź�
	wxType varchar(80),---΢������
	wxEmali varchar(80),---��¼����
	wxOriginalId varchar(80),---ԭʼid
)
go
insert into WeixinPublicSetting values(default,'�ϲ��ְ���','ncpazhe','���ĺ�','17652937@qq.com','gh_78457321fa83')
insert into WeixinPublicSetting values(default,'�ϲ��Ά�','ncjiazhe','�����','250672999@qq.com','gh_7a7fb4576fc5')
go
select * from WeixinPublicSetting
go
create table WeixinBaseConfigure -----���ÿ�������
(
	wxcId bigint identity (1,1) primary key,
	wxId bigint foreign key references WeixinPublicSetting(wxId) default(1),---���ں�ID
	wxAppId varchar(80) not null,---������ID(AppID)
	wxAppSecret varchar(80) not null,---����������(AppSecret)
	wxServicesUrl varchar(300),     ----��������ַ��Url��
	wxServerToken varchar(80),     ----����(Token)
	
	wxEncodingAESKey varchar(80),  ----��Ϣ�ӽ�����Կ(EncodingAESKey)
	wxEncodingType varchar(80),----��Ϣ�ӽ��ܷ�ʽ
	wxIsFlag bigint default(1),-----�Ƿ�ͨ��
	wxBeginDate smalldatetime default(getdate()), -----ע��ʱ��
	wxStopDate smalldatetime default(getdate()+30), -----��Чʱ��
)
go
insert into WeixinBaseConfigure values(1,'wx1de5244f225dbd99','8f32ce052352cb4ad6f30485af35bd00',default,'123456',
'uDTimoB11VvifKWMSWjYaIp1nqAP81ySylltrvXAeG8','����ģʽ',default,default,default)

insert into WeixinBaseConfigure values(1,'wxac7fa4983c2a4986','a6e6dc2bd21c43d94f837cbf6a5a7bac',default,'123456',
'mI3Clys2lCCtrPZfRDQajOHUFvLMYeywPlpAXHmi26y','����ģʽ',default,default,default)
go
select * from WeixinBaseConfigure
go
create table WeixinEvent  -----΢��EVENT�¼�
(
	wxeId bigint identity (1,1) primary key,
	wxeText varchar(300),
	wxeName varchar(300),
	
)
go
insert into WeixinEvent values('subscribe','��ע')
go
select * from WeixinEvent
go
create table WeixinReplyContentEvent -----΢��EVENT�¼��ظ�����
(
	wxrId bigint identity (1,1) primary key,
	wxeId bigint foreign key references WeixinEvent(wxeId) default(1),---΢��EVENT�¼�ID
	wxrContent varchar(2000),
)
go
insert into WeixinReplyContentEvent values (1,'һһһ/:rose��ӭʹ��/:roseһһһ\n�ܸ����ܺ����Ϊ����\n��������˽�˷�������\nֻҪ3�������ɻ���Ա��Ż�ȯ+����\n/:heart�٣����ֻ��Ա���Ҫ�������Ʒ���ӷ�����\n/:heart�ڣ�����ͨ���Ҳ��ҳ������ڲ����ӣ������Ա��µ����ͻ����Ż�ȯ\n/:heart�ۣ�ȷ���ջ��󣬷��͡����֡��Ϳ���������ȡ΢�ź��[Packet]\n-----------------------\n�����๦�ܡ���ظ���������\n������׬Ǯ����ظ���׬Ǯ��\n')
go
select * from WeixinReplyContentEvent






