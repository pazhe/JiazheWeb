using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.OpenSDK.Weixin.MessagesHandlers.Response.ReplyType
{
    /// <summary>
    /// 回复普通文本消息XML模板
    /// </summary>
    public class Text
    {
        //1、回复普通文本消息类型
        /// <summary>
        /// 普通文本消息类型
        /// </summary>
        public static string Format_Text
        {
            get
            {
                return @"<xml>
                            <ToUserName><![CDATA[{0}]]></ToUserName>
                            <FromUserName><![CDATA[{1}]]></FromUserName>
                            <CreateTime>{2}</CreateTime>
                            <MsgType><![CDATA[text]]></MsgType>
                            <Content><![CDATA[{3}]]></Content>
                            </xml>";
            }
        }
    }
}
