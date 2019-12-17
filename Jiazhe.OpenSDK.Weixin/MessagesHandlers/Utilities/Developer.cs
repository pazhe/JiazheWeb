using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

/// <summary>
/// 信息交互公共类
/// </summary>
namespace Jiazhe.OpenSDK.Weixin.MessagesHandlers.Utilities
{
    /// <summary>
    /// 用于验证新用户成为开发者
    /// </summary>
    
    public static class Developer
    {
        /// <summary>
        /// 微信验证成为开发者
        /// </summary>
        /// <param name="context"></param>
        public static void ReturnDeveloper(HttpContext context)
        {
            //获取从微信服务器发过来的signature 、timestamp和nonce
            string signature = HttpContext.Current.Request.QueryString["signature"];
            string timestamp = HttpContext.Current.Request.QueryString["timestamp"];
            string nonce = HttpContext.Current.Request.QueryString["nonce"];

            //这里的Token来自于自己的变量声明 如public string Token = "123456";
            string token = ConfigurationManager.AppSettings["url_token"].ToString();
            string echoString = HttpContext.Current.Request.QueryString["echoStr"];

            if (CheckSignatureCheck(token, signature, timestamp, nonce) && !string.IsNullOrEmpty(echoString))
            {
                //这个是打印出取得的信息，与验证token没有关系
                //只有CheckSignature()返回的是true，token就
                //已经验证成功了
                //LogHelper.WriteLog("微信验证成功了");
                HttpContext.Current.Response.Write(echoString);//必须打印
                HttpContext.Current.Response.End();//必须打印
            }
        }

        /// <summary>
        /// signature 比较
        /// </summary>
        /// <param name="token"></param>
        /// <param name="signature"></param>
        /// <param name="timestamp"></param>
        /// <param name="nonce"></param>
        /// <returns></returns>
        private static bool CheckSignatureCheck(string token, string signature, string timestamp, string nonce)
        {
            //1. 将token、timestamp、nonce三个参数进行字典序排序
            string[] ArrTmp = { token, timestamp, nonce };

            //字典排序
            Array.Sort(ArrTmp);

            //2. 将三个参数字符串拼接成一个字符串进行sha1加密
            string tmpStr = string.Join("", ArrTmp);
            tmpStr = FormsAuthentication.HashPasswordForStoringInConfigFile(tmpStr, "SHA1");

            //3. 开发者获得加密后的字符串可与signature对比，标识该请求来源于微信
            //SHA1有大小写区别，先转成小写再对比
            tmpStr = tmpStr.ToLower();
            if (tmpStr == signature)
                //如果相同就返回微信服务器要求的signature，不相同就没有必要处理
                return true;
            else return false;
        }
    }
}
