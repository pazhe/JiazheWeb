using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.OpenSDK.Weixin.MessagesHandlers.Response.ReplyType
{
    /// <summary>
    /// 回复语音消息XML模板
    /// </summary>
    public class Voice
    {
        //3、回复语音消息类型
        /// <summary>
        /// 语音消息类型
        /// </summary>
        public static string Format_Voice
        {
            get
            {
                return @"<xml>
                        <ToUserName><![CDATA[toUser]]></ToUserName>
                        <FromUserName><![CDATA[fromUser]]></FromUserName>
                        <CreateTime>1357290913</CreateTime>
                        <MsgType><![CDATA[voice]]></MsgType>
                        <MediaId><![CDATA[media_id] ]></MediaId>
                        <Format><![CDATA[Format]]></Format>
                        <MsgId>1234567890123456</MsgId>
                        </xml>";
            }
        }
    }
}
