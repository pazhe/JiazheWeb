using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.OpenSDK.Weixin.Log
{
    public static class Log4Net
    {
        /// <summary>
        /// Log4Net初始化
        /// </summary>
        public static void Log4NetInit()
        {
            string a = System.Web.HttpContext.Current.Server.MapPath("Configs/Log4Net.config");
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo(System.Web.HttpContext.Current.Server.MapPath("Configs/Log4Net.config")));
        }

        /// <summary>
        /// 返回日志对象
        /// </summary>
        public static log4net.ILog Log()
        {
            return log4net.LogManager.GetLogger("KangarooLog");
        }

    }
}
