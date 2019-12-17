using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Jiazhe.OpenSDK.Weixin.MessagesHandlers.Response.Content
{
    class Image
    {
        //数据实现：发送图片信息给对方
        /// <summary>
        /// 数据实现：发送图片信息给对方
        /// </summary>
        /// <param name="xmldoc"></param>
        /// <returns></returns>
        public static string ImageContent(XmlDocument xmldoc)
        {
            string responseContent = "";
            XmlNode ToUserName = xmldoc.SelectSingleNode("/xml/ToUserName");
            XmlNode FromUserName = xmldoc.SelectSingleNode("/xml/FromUserName");
            XmlNode MediaId = xmldoc.SelectSingleNode("/xml/MediaId");
            try
            {
                Log.LogHelper.WriteLog("【图片MediaId判断之前：】" + MediaId.InnerText.ToString());
                if (MediaId != null)
                {
                    responseContent = string.Format(ReplyType.Image.Format_Image,
                    FromUserName.InnerText,
                    ToUserName.InnerText,
                    DateTime.Now.Ticks,
                    MediaId.InnerText);
                    Log.LogHelper.WriteLog("【发送图片消息是：】" + responseContent);
                }
                else { Log.LogHelper.WriteLog("【发送图片消息失败！MediaId为null】"); }

            }
            catch { Log.LogHelper.WriteLog("【发送图片消息失败！出现异常】"); }
            return responseContent;
        }
    }
}
