using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.OpenSDK.Weixin.MessagesHandlers.Response.ReplyType
{
    /// <summary>
    /// 回复视频消息XML模板
    /// </summary>
    public class Video
    {
        //4、回复视频消息类型
        /// <summary>
        /// 视频消息类型
        /// </summary>
        public static string Format_Video
        {
            get
            {
                return @"<xml><ToUserName><![CDATA[{0}]]></ToUserName>
                        <FromUserName><![CDATA[{1}]]></FromUserName>
                        <CreateTime>{2}</CreateTime>
                        <MsgType><![CDATA[video]]></MsgType>
                        <Video>
                        <MediaId><![CDATA[{3}]]></MediaId>
                        <Title><![CDATA[title]]></Title>
                        <Description><![CDATA[description]]></Description>
                        </Video> 
                        </xml>";
            }
        }
    }
}
