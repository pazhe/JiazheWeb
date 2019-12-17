use DaocaomanDate
go
create table TaobaokeFavorites -----ѡƷ��
(
	taobaoke_favorites_id bigint identity (1,1)  primary key,
	skID bigint foreign key references Shokey(skID) default(1),---�û�ID
	favorites_id bigint  not null,---ѡƷ��id��������
	favorites_type bigint not null,---ѡƷ�����ͣ�1����ͨ���ͣ�2��Ӷ������
	favorites_title varchar(200),---ѡƷ������	
	total_results bigint,-----ѡƷ���Ʒ����
	update_time smalldatetime default(getdate()),----����ʱ��
)
go
create table ItemsTbk -----ѡƷ���Ʒ
(
	itemsTbkId bigint identity (1,1) primary key,
	skID bigint foreign key references Shokey(skID) default(1),---�û�ID
	favoritesId bigint ,---ѡƷ��id
	
	num_iid bigint not null,---��ƷID
	title varchar(200),---��Ʒ����
	pict_url varchar(200),---��Ʒ��ͼ
	small_images varchar(200),     ----��ƷСͼ�б�
	reserve_price varchar(200),  ----��Ʒһ�ڼ۸�
	zk_final_price varchar(200),-----��Ʒ�ۿۼ۸�
	user_type bigint, -----�������ͣ�0��ʾ���У�1��ʾ�̳�
	provcity varchar(200), -----�������ڵ�
	
	item_url varchar(200),---��Ʒ��ַ
	click_url varchar(500),---�Կ͵�ַ
	nick varchar(200),     ----�����ǳ�
	seller_id bigint,  ----����id
	volume bigint,-----30������
	tk_rate varchar(200), -----���������������ȡֵΪ20.00����ʾ����20.00%
	zk_final_price_wap varchar(200), -----�����ۿۼ� ���������������ϵ�ʵ�������۸�
	
	shop_title varchar(200),---
	event_start_time smalldatetime,---���̻��ʼʱ�䣻����ñ���ȡ����ͨѡƷ�飬��ȡֵΪ1970-01-01 00:00:00��
	event_end_time smalldatetime, ----���л�Ľ���ʱ�䣻����ñ���ȡ����ͨ��ѡƷ�飬��ȡֵΪ1970-01-01 00:00:00
	[type] bigint,  ----�������ͣ�1 ��ͨ��Ʒ�� 2 ȵ�Ÿ�Ӷ����Ʒ��3 ����������Ʒ��4 Ӫ���ƻ���Ʒ;
	[status] bigint,-----����״̬��0ʧЧ��1��Ч��ע��ʧЧ�����Ǳ����Ѿ����߻����Ǳ����������ڽ����ƹ�
	category bigint, -----��̨һ����Ŀ
	coupon_click_url varchar(200), -----��Ʒ�Ż�ȯ�ƹ�����
	
	coupon_end_time varchar(200),---�Ż�ȯ����ʱ��
	coupon_info varchar(200),---�Ż�ȯ���
	coupon_start_time varchar(200), ----�Ż�ȯ��ʼʱ��
	coupon_total_count bigint,  ----�Ż�ȯ����
	coupon_remain_count bigint,-----�Ż�ȯʣ����
	model varchar(200),---�Ż�ȯ���
	updateTime smalldatetime default(getdate()),----����ʱ��
)
go
