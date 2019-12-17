using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jiazhe.Web.Weixin.Admin.Pages
{
    public partial class WeixinPublicNumberConfigure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindToDetailsViewWeixinConfigure();
        }

        public void BindToDetailsViewWeixinConfigure()
        {
            DetailsViewWeixinConfigure.DataSource = FactoryBo.Weixin.WeixinBaseConfigureFactoryBo.
                GetObject("WeixinConfigureBoFactory").WeixinConfigureBo.GetIListById
                (long.Parse( Request.QueryString["wxId"]));
            DetailsViewWeixinConfigure.DataBind();
        }
    }
}