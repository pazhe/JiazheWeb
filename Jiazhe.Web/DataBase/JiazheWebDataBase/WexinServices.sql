use master
go
use JiazheWebDataBase
go
create table WeixinPublicSetting -----公众号
(
	wxId bigint identity (1,1) primary key,
	cId bigint foreign key references Consumer(cId) default(1),---用户ID
	wxName varchar(80) ,---微信名称
	wxNumber varchar(80),---微信号
	wxType varchar(80),---微信类型
	wxEmali varchar(80),---登录邮箱
	wxOriginalId varchar(80),---原始id
)
go
insert into WeixinPublicSetting values(default,'南昌胖阿喆','ncpazhe','订阅号','17652937@qq.com','gh_78457321fa83')
insert into WeixinPublicSetting values(default,'南昌嘉喆','ncjiazhe','服务号','250672999@qq.com','gh_7a7fb4576fc5')
go
select * from WeixinPublicSetting
go
create table WeixinBaseConfigure -----配置开发需求
(
	wxcId bigint identity (1,1) primary key,
	wxId bigint foreign key references WeixinPublicSetting(wxId) default(1),---公众号ID
	wxAppId varchar(80) not null,---开发者ID(AppID)
	wxAppSecret varchar(80) not null,---开发者密码(AppSecret)
	wxServicesUrl varchar(300),     ----服务器地址（Url）
	wxServerToken varchar(80),     ----令牌(Token)
	
	wxEncodingAESKey varchar(80),  ----消息加解密密钥(EncodingAESKey)
	wxEncodingType varchar(80),----消息加解密方式
	wxIsFlag bigint default(1),-----是否通过
	wxBeginDate smalldatetime default(getdate()), -----注册时间
	wxStopDate smalldatetime default(getdate()+30), -----有效时间
)
go
insert into WeixinBaseConfigure values(1,'wx1de5244f225dbd99','8f32ce052352cb4ad6f30485af35bd00',default,'123456',
'uDTimoB11VvifKWMSWjYaIp1nqAP81ySylltrvXAeG8','明文模式',default,default,default)

insert into WeixinBaseConfigure values(1,'wxac7fa4983c2a4986','a6e6dc2bd21c43d94f837cbf6a5a7bac',default,'123456',
'mI3Clys2lCCtrPZfRDQajOHUFvLMYeywPlpAXHmi26y','明文模式',default,default,default)
go
select * from WeixinBaseConfigure
go
create table WeixinEvent  -----微信EVENT事件
(
	wxeId bigint identity (1,1) primary key,
	wxeText varchar(300),
	wxeName varchar(300),
	
)
go
insert into WeixinEvent values('subscribe','关注')
go
select * from WeixinEvent
go
create table WeixinReplyContentEvent -----微信EVENT事件回复内容
(
	wxrId bigint identity (1,1) primary key,
	wxeId bigint foreign key references WeixinEvent(wxeId) default(1),---微信EVENT事件ID
	wxrContent varchar(2000),
)
go
insert into WeixinReplyContentEvent values (1,'一一一/:rose欢迎使用/:rose一一一\n很高兴能和你成为好友\n我是您的私人返利助手\n只要3步，即可获得淘宝优惠券+返利\n/:heart①：把手机淘宝上要购买的商品链接发给我\n/:heart②：复制通过我查找出来的内部链接，返回淘宝下单，就会有优惠券\n/:heart③：确认收货后，发送“提现”就可以申请领取微信红包[Packet]\n-----------------------\n【更多功能】请回复“帮助”\n【轻松赚钱】请回复“赚钱”\n')
go
select * from WeixinReplyContentEvent






