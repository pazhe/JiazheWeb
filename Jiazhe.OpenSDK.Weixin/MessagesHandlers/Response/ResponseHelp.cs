using Jiazhe.OpenSDK.Weixin.MessagesHandlers.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace Jiazhe.OpenSDK.Weixin.MessagesHandlers.Response
{
    public class ResponseHelp
    {

        public static void Send(XmlDocument xmldoc,string content)
        {
            string responseContent = MessagesHelp.ReturnResponseContent(xmldoc, content);
            HttpContext.Current.Response.ContentEncoding = Encoding.UTF8;
            HttpContext.Current.Response.Write(responseContent);
        }
    }
}
