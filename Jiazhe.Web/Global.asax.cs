using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Jiazhe.Web
{
    public class Global : System.Web.HttpApplication
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger("Logger");

        private static readonly ILog applicationInfoLog = LogManager.GetLogger("ApplicationInfoLog");

        protected void Application_Start(object sender, EventArgs e)
        {
            //初始化log4net
            //log4net.Config.XmlConfigurator.Configure();//直接配置到Web.config里面

            //
            OpenSDK.Weixin.Log.Log4Net.Log4NetInit();//配置到单独文件里

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            
        }
    }
}