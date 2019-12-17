using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jiazhe.Web.Weixin.Admin.Pages
{
    public partial class WeixinPublicNumber : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label1.Text = ((Entity.Owner.Consumer)this.Session["Consumer"]).CName;
            BindToGridViewWeixinPublicNumber();
            BindToDetailsViewWeixinPublicNumber();
        }

        public void BindToGridViewWeixinPublicNumber()
        {
            GridViewWeixinPublic.DataSource=
            FactoryBo.Weixin.WeixinPublicSettingFactoryBo.
                GetObject("WeixinPublicBoFactory").WeixinPublicBo.GetIList();
            GridViewWeixinPublic.DataBind();
        }

        public void BindToDetailsViewWeixinPublicNumber()
        {
            DetailsViewWeixinPublic.DataSource =FactoryBo.Weixin.WeixinPublicSettingFactoryBo.
                GetObject("WeixinPublicBoFactory").WeixinPublicBo.GetIList();
            DetailsViewWeixinPublic.DataBind();

        }

        protected void DetailsViewWeixinPublic_ItemDeleting(object sender, DetailsViewDeleteEventArgs e)
        {

        }

        protected void DetailsViewWeixinPublic_ItemInserting(object sender, DetailsViewInsertEventArgs e)
        {

        }

        protected void DetailsViewWeixinPublic_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
        {

        }

        protected void DetailsViewWeixinPublic_ModeChanging(object sender, DetailsViewModeEventArgs e)
        {
            DetailsViewWeixinPublic.
            ChangeMode(e.NewMode);
            BindToDetailsViewWeixinPublicNumber();
        }

        protected void GridViewWeixinPublic_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetailsViewWeixinPublic.ChangeMode(DetailsViewMode.ReadOnly);
            DetailsViewWeixinPublic.PageIndex = GridViewWeixinPublic.SelectedIndex;
        }
    }
}