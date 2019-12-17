using Jiazhe.OpenSDK.Weixin.Log;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace Jiazhe.OpenSDK.Weixin.MessagesHandlers.Tools
{
    /// <summary>
    /// 信息处理工具类
    /// </summary>
    public class MessagesHelp
    {
        /// <summary>
        /// Request信息转成String类型
        /// </summary>
        /// <param name="InputStream">参数：传入的HTTP 实体主体的内容</param>
        /// <returns>String</returns>
        public static string GetPostStrConverToString(HttpContext context)
        {
            string postString = string.Empty;
            using (Stream stream = context.Request.InputStream)
            {
                Byte[] postBytes = new Byte[stream.Length];
                stream.Read(postBytes, 0, (Int32)stream.Length);
                postString = Encoding.UTF8.GetString(postBytes);
            }
            return postString;
        }

        /// <summary>
        /// 把Request信息string类型转换成XML格式
        /// </summary>
        /// <param name="postStr">Request信息string类型</param>
        /// <returns>xml</returns>
        public static XmlDocument GetPostStrConverToXmlDoc(HttpContext context)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(new System.IO.MemoryStream
                (System.Text.Encoding.GetEncoding("UTF-8").
                GetBytes(GetPostStrConverToString(context))));
            return xmldoc;
        }

        /// <summary>
        /// 获取公众号 原始id
        /// </summary>
        /// <param name="context"></param>
        /// <returns>返回 :公众号 原始id (ToUserName)</returns>
        public static string GetToUserName(XmlDocument xmldoc)
        {
            string toUserName = xmldoc.SelectSingleNode("/xml/ToUserName").InnerText;
            return toUserName;
        }

        /// <summary>
        /// 获取粉丝号原始id
        /// </summary>
        /// <param name="context"></param>
        /// <returns>返回 ：粉丝号原始id（FromUserName）</returns>
        public static string GetFromUserName(XmlDocument xmldoc)
        {
            string fromUserName = xmldoc.SelectSingleNode("/xml/FromUserName").InnerText;
            return fromUserName;
        }

        /// <summary>
        /// 获取公众号 MsgType 的类型
        /// </summary>
        /// <param name="xmldoc"></param>
        /// <returns>MsgType</returns>
        public static string GetMsgType(HttpContext context)
        {
            string msgType = GetPostStrConverToXmlDoc(context)
                .SelectSingleNode("/xml/MsgType").InnerText;
            try { if (msgType != null) return msgType; }
            catch { Log.LogHelper.WriteLog("MsgType is null!"); }
            return msgType;
        }

        /// <summary>
        /// 公众号发送的消息
        /// </summary>
        /// <param name="xmldoc"></param>
        /// <param name="rspContent"></param>
        /// <returns></returns>
        public static string ReturnResponseContent(XmlDocument xmldoc, string rspContent)
        {
            string responseContent = "";
            string MsgType = xmldoc.SelectSingleNode("/xml/MsgType").InnerText;
            switch (MsgType)
                {
                    case "event":
                        //responseContent = MessageTypeEventResponse.EventContent(xmldoc);//事件处理
                        break;
                    case "text":
                    responseContent = Response.Content.Text.Return(xmldoc, rspContent);
                        //responseContent = MessageTypeTextResponse.TextContent(xmldoc);//回复文本消息
                        //responseContent = MessageTypeNewsResponse.NewsContent(xmldoc);//回复图文消息
                    break;
                    case "image":
                        Log.LogHelper.WriteLog("【判断为*图片*消息类型开始分发处理】......");
                        //responseContent = MessageTypeImageResponse.ImageContent(xmldoc);//接受文本消息处理
                        break;
                    case "video":
                        Log.LogHelper.WriteLog("【判断为*视频*消息类型开始分发处理】......");
                        //responseContent = MessageTypeVideoResponse.VideoContent(xmldoc);//接受文本消息处理
                        break;
                    case "link":
                        Log.LogHelper.WriteLog("【判断为*连接*消息类型开始分发处理】......");
                        //responseContent = MessageTypeNewsResponse.NewsContent(xmldoc);//回复图文消息
                        break;
                    default:
                        break;
                }
            return responseContent;
        }
    }

}
