using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Top.Api.Request;
using Top.Api.Response;

namespace Jiazhe.Web.Manager.Pages
{
    public partial class FavoriteItems : System.Web.UI.Page
    {
        long FavoritesId =1L;
        Label lblNum;
        private Entity.Owner.Consumer consumer = new Entity.Owner.Consumer();
        protected void Page_Load(object sender, EventArgs e)
        {
            FavoritesId =long.Parse(Request.QueryString["FavoritesId"].ToString());
            Response.Write(FavoritesId);
            if (!IsPostBack)
            {
                BindToRepeater(FavoritesId, 1, 20);
                //((Label)Repeater1.Controls[Repeater1.Controls.Count - 1].FindControl("lblNum")).Text = "1";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FavoritesId">选品库Id</param>
        /// <param name="PageNo">第几页，默认：1，从1开始计数</param>
        /// <param name="PageSize">页大小，默认20，1~100</param>
        public void BindToRepeater(long FavoritesId, long PageNo, long PageSize)
        {
            consumer = (Entity.Owner.Consumer)this.Session["Consumer"];
            //TbkUatmFavoritesItemGetRequest req = new TbkUatmFavoritesItemGetRequest();
            //req.Platform = 1;//链接形式：1：PC，2：无线，默认：１
            //req.PageSize = PageSize;//页大小，默认20，1~100
            //req.AdzoneId = 42120264;//推广位id
            //req.Unid = "3456";//自定义输入串
            //req.FavoritesId = long.Parse(FavoritesId);//选品库的id
            //req.PageNo = PageNo;//第几页，默认：1，从1开始计数
            //req.Fields = @"num_iid,title,pict_url,small_images,reserve_price,
            //            zk_final_price,user_type,provcity,item_url,click_url,
            //            nick,seller_id,volume,tk_rate,zk_final_price_wap,shop_title,
            //            event_start_time,event_end_time,type,status,category,
            //            coupon_click_url,coupon_end_time,coupon_info,coupon_start_time,
            //            coupon_total_count,coupon_remain_count";
            //TbkUatmFavoritesItemGetResponse rsp = Tools.GetAppkeyTaoke.GetClient().Execute(req);

            Repeater1.DataSource = FactoryBo.Taobao.Tbk.FactoryBo.GetObject("FavoriteItemBoFactory")
                .FavoriteItemBo.GetIList(FavoritesId, PageNo, PageSize, 42120264,
                FactoryBo.Taobao.Tbk.DiplomaFactoryBo.GetObject("DiplomaBoFactory")
                .DiplomaBo.GetById(consumer.CId));
            //Repeater1.DataSource = rsp.Results;
            Repeater1.DataBind();
        }

        protected void btnUp_Click(object sender, EventArgs e)
        {
            lblNum = ((Label)Repeater1.Controls[Repeater1.Controls.Count - 1].FindControl("lblNum"));
            lblNum.Text = (Convert.ToInt32(lblNum.Text) - 1).ToString();
            ((Label)Repeater1.Controls[Repeater1.Controls.Count - 1].FindControl("lblNum")).Text = lblNum.Text;
            BindToRepeater(FavoritesId, long.Parse(lblNum.Text), 20);
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            lblNum = ((Label)Repeater1.Controls[Repeater1.Controls.Count - 1].FindControl("lblNum"));
            lblNum.Text = (Convert.ToInt32(lblNum.Text) + 1).ToString();
            BindToRepeater(FavoritesId, long.Parse(lblNum.Text), 20);
            ((Label)Repeater1.Controls[Repeater1.Controls.Count - 1].FindControl("lblNum")).Text = lblNum.Text;
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }

        //在创建项时激发
        protected void Repeater1_ItemCreated(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item)
            {
                if (e.Item.FindControl("itl") != null)
                {
                    HtmlTableRow htr_itl = (HtmlTableRow)e.Item.FindControl("itl");
                    ApplyStyle(htr_itl, htr_itl.BgColor);
                }
            }

            if (e.Item.ItemType == ListItemType.AlternatingItem)
            {
                if (e.Item.FindControl("att") != null)
                {
                    HtmlTableRow htr_att = (HtmlTableRow)e.Item.FindControl("att");
                    ApplyStyle(htr_att, htr_att.BgColor);
                }
            }
        }

        //鼠标移动变色
        private void ApplyStyle(HtmlTableRow htr, string trBackColor)
        {
            string onmouseoverStyle = "this.style.backgroundColor='Peachpuff'";
            string onmouseoutStyle = "this.style.backgroundColor='@BackColor'";

            htr.Attributes.Add("onmouseover", onmouseoverStyle);
            htr.Attributes.Add("onmouseout", onmouseoutStyle.Replace("@BackColor", trBackColor));

        }
    }
}