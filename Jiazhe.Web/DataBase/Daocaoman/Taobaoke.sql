use DaocaomanDate
go
create table TaobaokeFavorites -----选品库
(
	taobaoke_favorites_id bigint identity (1,1)  primary key,
	skID bigint foreign key references Shokey(skID) default(1),---用户ID
	favorites_id bigint  not null,---选品库id（主键）
	favorites_type bigint not null,---选品库类型，1：普通类型，2高佣金类型
	favorites_title varchar(200),---选品组名称	
	total_results bigint,-----选品库产品数量
	update_time smalldatetime default(getdate()),----更新时间
)
go
create table ItemsTbk -----选品库产品
(
	itemsTbkId bigint identity (1,1) primary key,
	skID bigint foreign key references Shokey(skID) default(1),---用户ID
	favoritesId bigint ,---选品库id
	
	num_iid bigint not null,---商品ID
	title varchar(200),---商品标题
	pict_url varchar(200),---商品主图
	small_images varchar(200),     ----商品小图列表
	reserve_price varchar(200),  ----商品一口价格
	zk_final_price varchar(200),-----商品折扣价格
	user_type bigint, -----卖家类型，0表示集市，1表示商城
	provcity varchar(200), -----宝贝所在地
	
	item_url varchar(200),---商品地址
	click_url varchar(500),---淘客地址
	nick varchar(200),     ----卖家昵称
	seller_id bigint,  ----卖家id
	volume bigint,-----30天销量
	tk_rate varchar(200), -----收入比例，举例，取值为20.00，表示比例20.00%
	zk_final_price_wap varchar(200), -----无线折扣价 ，即宝贝在无线上的实际售卖价格。
	
	shop_title varchar(200),---
	event_start_time smalldatetime,---招商活动开始时间；如果该宝贝取自普通选品组，则取值为1970-01-01 00:00:00；
	event_end_time smalldatetime, ----招行活动的结束时间；如果该宝贝取自普通的选品组，则取值为1970-01-01 00:00:00
	[type] bigint,  ----宝贝类型：1 普通商品； 2 鹊桥高佣金商品；3 定向招商商品；4 营销计划商品;
	[status] bigint,-----宝贝状态，0失效，1有效；注：失效可能是宝贝已经下线或者是被处罚不能在进行推广
	category bigint, -----后台一级类目
	coupon_click_url varchar(200), -----商品优惠券推广链接
	
	coupon_end_time varchar(200),---优惠券结束时间
	coupon_info varchar(200),---优惠券面额
	coupon_start_time varchar(200), ----优惠券开始时间
	coupon_total_count bigint,  ----优惠券总量
	coupon_remain_count bigint,-----优惠券剩余量
	model varchar(200),---优惠券面额
	updateTime smalldatetime default(getdate()),----更新时间
)
go
