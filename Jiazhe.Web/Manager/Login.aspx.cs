using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jiazhe.Web.Manager
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void login()
        {
            FactoryBo.Owner.ConsumerFactoryBo iboFactory =
                (FactoryBo.Owner.ConsumerFactoryBo)
                FactoryBo.Factory.Context.GetContextRegistry.GetContext()
                .GetObject("ConsumerBoFactory");
            Entity.Owner.Consumer consumer = new Entity.Owner.Consumer();
            consumer = iboFactory.ConsumerBo.GetConsumerIsExist(txtName.Text, txtPwd.Text);
            this.Session["Consumer"] = consumer;

            if (iboFactory.GetConsumerBo().ConsumerLogin(consumer))
                Response.Redirect("index.html");
            else
                Page.RegisterStartupScript("scriptThree", "<script>alert('" + "登陆失败!" + "');</script>");
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            login();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPwd.Text = "";
        }
    }
}