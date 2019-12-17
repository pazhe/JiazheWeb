using Jiazhe.OpenSDK.Weixin.Log;
using Jiazhe.OpenSDK.Weixin.MessagesHandlers.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace Jiazhe.OpenSDK.Weixin.MessagesHandlers.Response.Content
{
    public class Text
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="xmldoc"></param>
        /// <param name="rspContent"></param>
        /// <returns></returns>
        public static string Return(XmlDocument xmldoc, string rspContent)
        {
            string rspContentFormat = "";
            rspContentFormat = string.Format(ReplyType.Text.Format_Text,
                xmldoc.SelectSingleNode("/xml/FromUserName").InnerText,
                xmldoc.SelectSingleNode("/xml/ToUserName").InnerText,
                DateTime.Now.Ticks,
                rspContent);
            return rspContentFormat;
        }
    }
}
