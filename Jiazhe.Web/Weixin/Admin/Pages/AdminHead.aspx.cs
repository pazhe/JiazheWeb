using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jiazhe.Web.Weixin.Admin.Pages
{
    public partial class AdminHead : System.Web.UI.Page
    {
        private Entity.Owner.Consumer consumerEntity = new Entity.Owner.Consumer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                consumerEntity = (Entity.Owner.Consumer)this.Session["Consumer"];
                if (this.Session["Consumer"] == null)
                {
                    this.Response.Redirect("../Login.aspx");
                }
                else
                {
                    lblConsumerName.Text = consumerEntity.CName;
                }
            }
        }
    }
}