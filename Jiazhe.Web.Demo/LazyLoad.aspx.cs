using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Top.Api.Request;
using Top.Api.Response;

namespace Jiazhe.Web.Demo.JS
{
    public partial class LazyLoad : System.Web.UI.Page
    {
        long FavoritesId = 1L;
        //private Entity.Owner.Consumer consumer = new Entity.Owner.Consumer();
        protected void Page_Load(object sender, EventArgs e)
        {

            FavoritesId = 18494862;
            Response.Write(FavoritesId);
            if (!IsPostBack)
            {
                BindToRepeater(FavoritesId, 1, 20);
                //((Label)Repeater1.Controls[Repeater1.Controls.Count - 1].FindControl("lblNum")).Text = "1";
            }
        }

        public void BindToRepeater(long FavoritesId, long PageNo, long PageSize)
        {
            //consumer = (Entity.Owner.Consumer)this.Session["Consumer"];
            TbkUatmFavoritesItemGetRequest req = new TbkUatmFavoritesItemGetRequest();
            req.Platform = 1;//链接形式：1：PC，2：无线，默认：１
            req.PageSize = PageSize;//页大小，默认20，1~100
            req.AdzoneId = 42120264;//推广位id
            req.Unid = "3456";//自定义输入串
            req.FavoritesId = FavoritesId;//选品库的id
            req.PageNo = PageNo;//第几页，默认：1，从1开始计数
            req.Fields = @"num_iid,title,pict_url,small_images,reserve_price,
                        zk_final_price,user_type,provcity,item_url,click_url,
                        nick,seller_id,volume,tk_rate,zk_final_price_wap,shop_title,
                        event_start_time,event_end_time,type,status,category,
                        coupon_click_url,coupon_end_time,coupon_info,coupon_start_time,
                        coupon_total_count,coupon_remain_count";
            TbkUatmFavoritesItemGetResponse rsp = Tools.Taobao.DefaultTopClient.Get().Execute(req);

            //Repeater1.DataSource = FactoryBo.Taobao.Tbk.FactoryBo.GetObject("FavoriteItemBoFactory")
            //    .FavoriteItemBo.GetIList(FavoritesId, PageNo, PageSize, 42120264,
            //    FactoryBo.Taobao.Tbk.DiplomaFactoryBo.GetObject("DiplomaBoFactory")
            //    .DiplomaBo.GetById(1));
            Repeater1.DataSource = rsp.Results;
            Repeater1.DataBind();
        }
        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }

        //在创建项时激发
        protected void Repeater1_ItemCreated(object sender, RepeaterItemEventArgs e)
        {

        }
    }
}