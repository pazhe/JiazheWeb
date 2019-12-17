using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.OpenSDK.Weixin.MessagesHandlers.Response.ReplyType
{
    /// <summary>
    /// 回复图文消息XML模板
    /// </summary>
    public class news
    {
        //6、回复图文消息类型
        /// <summary>
        /// 图文消息类型
        /// </summary>
        public static string Format_news
        {
            get
            {
                return @"<xml>
                        <ToUserName><![CDATA[{0}]]></ToUserName>
                        <FromUserName><![CDATA[{1}]]></FromUserName>
                        <CreateTime>{2}</CreateTime>
                        <MsgType><![CDATA[news]]></MsgType>
                        <ArticleCount>1</ArticleCount>
                        <Articles>
                        <item>
                        <Title><![CDATA[{3}]]></Title>
                        <Description><![CDATA[{4}]]></Description>
                        <PicUrl><![CDATA[{5}]]></PicUrl>
                        <Url><![CDATA[{6}]]></Url>
                        </item>
                        </Articles>
                        </xml>";
            }
        }
    }
}
