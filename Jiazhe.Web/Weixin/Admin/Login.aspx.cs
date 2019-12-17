using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jiazhe.Web.Weixin.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPwd.Text = "";
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            FactoryBo.Owner.ConsumerFactoryBo iboFactory =
                (FactoryBo.Owner.ConsumerFactoryBo)
                FactoryBo.Factory.Context.GetContextRegistry.GetContext()
                .GetObject("ConsumerBoFactory");
            Entity.Owner.Consumer consumer = new Entity.Owner.Consumer();
            consumer.LevelId = 1;
            consumer.CName = txtName.Text;
            consumer.CPassword =txtPwd.Text;
            consumer.CDate = DateTime.Now.ToString();
            this.Session["Consumer"] = consumer;
            if (iboFactory.GetConsumerBo().ConsumerLogin(consumer))
                Response.Redirect("index.html");
            else
                Page.RegisterStartupScript("scriptThree", "<script>alert('" + "登陆失败!" + "');</script>");
        }
    }
}