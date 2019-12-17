using Jiazhe.Web.Entity.Taobao.Tbk;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;

namespace Jiazhe.Web.Tools.Taobao
{
    public class DefaultTopClient
    {
        private static ITopClient client;

        /// <summary>
        /// 在Web.config文件里获取淘宝开发者配置信息
        /// </summary>
        /// <returns>返回：TOP客户端</returns>
        public static ITopClient Get()
        {
            String taoke_url = ConfigurationManager.AppSettings["taoke_url"].ToString();
            String taoke_appkey = ConfigurationManager.AppSettings["taoke_appkey"].ToString();
            String taoke_secret = ConfigurationManager.AppSettings["taoke_secret"].ToString();
            if (client == null)
            {
                client = new Top.Api.DefaultTopClient(taoke_url, taoke_appkey, taoke_secret);
            }
            return client;
        }

        /// <summary>
        /// 传入淘宝开发者配置信息
        /// </summary>
        /// <param name="url">参数：调用环境</param>
        /// <param name="appkey">参数：App Key</param>
        /// <param name="secret">参数：App Secret</param>
        /// <returns>返回：TOP客户端</returns>
        public static ITopClient Get(string url,string appkey,string secret)
        {
            if (client == null)
            {
                client = new Top.Api.DefaultTopClient(url, appkey, secret);
            }
            return client;
        }

        public static string TbkTpwdParse(string TbkTpwd)
        {
            TbkTpwdParseRequest req = new TbkTpwdParseRequest();
            req.PasswordContent = TbkTpwd;
            TbkTpwdParseResponse rsp = DefaultTopClient.Get().Execute(req);
            return rsp.Data.Model;
        }
    }
}
