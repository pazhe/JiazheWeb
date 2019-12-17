using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jiazhe.Web.Entity.Taobao.Tbk
{
    /// <summary>
    /// 选品库产品
    /// </summary>
    public class FavoriteItem
    {
        /// <summary>
        /// 主键
        /// </summary>
        public long IId { get; set; }

        /// <summary>
        /// --用户ID
        /// </summary>
        public long CId { get; set; }

        /// <summary>
        /// 选品库id
        /// </summary>
        public long FavoritesId { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public long NumIid { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 商品主图
        /// </summary>
        public string PictUrl { get; set; }

        /// <summary>
        /// 商品小图列表
        /// </summary>
        public List<string> SmallImages { get; set; }

        /// <summary>
        /// 商品一口价格
        /// </summary>
        public string ReservePrice { get; set; }

        /// <summary>
        /// 商品折扣价格
        /// </summary>
        public string ZkFinalPrice { get; set; }

        /// <summary>
        /// 卖家类型，0表示集市，1表示商城
        /// </summary>
        public long UserType { get; set; }

        /// <summary>
        /// 宝贝所在地
        /// </summary>
        public string Provcity { get; set; }

        /// <summary>
        /// 商品地址
        /// </summary>
        public string ItemUrl { get; set; }

        /// <summary>
        /// 淘客地址
        /// </summary>
        public string ClickUrl { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        public long SellerId { get; set; }

        /// <summary>
        /// 30天销量
        /// </summary>
        public long Volume { get; set; }

        /// <summary>
        /// 收入比例，举例，取值为20.00，表示比例20.00%
        /// </summary>
        public string TkRate { get; set; }

        /// <summary>
        /// 无线折扣价 ，即宝贝在无线上的实际售卖价格。
        /// </summary>
        public string ZkFinalPriceWap { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ShopTitle { get; set; }

        /// <summary>
        /// 招商活动开始时间；如果该宝贝取自普通选品组，则取值为1970-01-01 00:00:00；
        /// </summary>
        public string EventStartTime { get; set; }

        /// <summary>
        /// 招行活动的结束时间；如果该宝贝取自普通的选品组，则取值为1970-01-01 00:00:00
        /// </summary>
        public string EventEndTime { get; set; }

        /// <summary>
        /// 宝贝类型：1 普通商品； 2 鹊桥高佣金商品；3 定向招商商品；4 营销计划商品;
        /// </summary>
        public long Type { get; set; }

        /// <summary>
        /// 宝贝状态，0失效，1有效；注：失效可能是宝贝已经下线或者是被处罚不能在进行推广
        /// </summary>
        public long Status { get; set; }

        /// <summary>
        /// 后台一级类目
        /// </summary>
        public long Category { get; set; }

        /// <summary>
        /// 商品优惠券推广链接
        /// </summary>
        public string CouponClickUrl { get; set; }

        /// <summary>
        /// 优惠券结束时间
        /// </summary>
        public string CouponEndTime { get; set; }

        /// <summary>
        /// 优惠券面额
        /// </summary>
        public string CouponInfo { get; set; }

        /// <summary>
        /// 优惠券开始时间
        /// </summary>
        public string CouponStartTime { get; set; }

        /// <summary>
        /// 优惠券总量
        /// </summary>
        public long CouponTotalCount { get; set; }

        /// <summary>
        /// 优惠券剩余量
        /// </summary>
        public long CouponRemainCount { get; set; }

        /// <summary>
        /// 优惠券面额
        /// </summary>
        public string Model { get; set; }
    }
}
