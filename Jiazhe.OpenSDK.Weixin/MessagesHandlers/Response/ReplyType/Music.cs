using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.OpenSDK.Weixin.MessagesHandlers.Response.ReplyType
{
    /// <summary>
    /// 回复音乐消息XML模板
    /// </summary>
    public class Music
    {
        //5、回复音乐消息类型
        /// <summary>
        /// 小视频消息类型
        /// </summary>
        public static string Format_Music
        {
            get
            {
                return @"<xml>
                        <ToUserName><![CDATA[toUser]]></ToUserName>
                        <FromUserName><![CDATA[fromUser]]></FromUserName>
                        <CreateTime>12345678</CreateTime><MsgType>
                        <![CDATA[music]]></MsgType>
                        <Music>
                        <Title><![CDATA[TITLE]]></Title>
                        <Description><![CDATA[DESCRIPTION]]></Description>
                        <MusicUrl><![CDATA[MUSIC_Url]]></MusicUrl>
                        <HQMusicUrl><![CDATA[HQ_MUSIC_Url]]></HQMusicUrl>
                        <ThumbMediaId><![CDATA[media_id]]></ThumbMediaId>
                        </Music>
                        </xml>";
            }
        }
    }
}
