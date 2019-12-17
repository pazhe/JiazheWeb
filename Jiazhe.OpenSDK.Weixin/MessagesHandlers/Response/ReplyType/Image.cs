using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.OpenSDK.Weixin.MessagesHandlers.Response.ReplyType
{
    /// <summary>
    /// 回复图片消息XML模板
    /// </summary>
    public class Image
    {
        //2、回复图片消息类型
        /// <summary>
        /// 图片消息类型
        /// </summary>
        public static string Format_Image
        {
            get
            {
                return @"<xml>
                        <ToUserName><![CDATA[{0}]]></ToUserName>
                        <FromUserName><![CDATA[{1}]]></FromUserName>
                        <CreateTime>{2}</CreateTime>
                        <MsgType><![CDATA[image]]></MsgType>
                        <Image>
                        <MediaId><![CDATA[{3}]]></MediaId>
                        </Image>
                        </xml>";
            }
        }
    }
}
