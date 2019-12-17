using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Jiazhe.OpenSDK.Weixin.MessagesHandlers.Response.Content
{
    public class Event
    {
        public static string EventContent(XmlDocument xmldoc,string Content)
        {
            Log.LogHelper.WriteLog("开始 处理Event事件");
            string responseContent = "";
            XmlNode Event = xmldoc.SelectSingleNode("/xml/Event");
            XmlNode EventKey = xmldoc.SelectSingleNode("/xml/EventKey");
            XmlNode ToUserName = xmldoc.SelectSingleNode("/xml/ToUserName");
            XmlNode FromUserName = xmldoc.SelectSingleNode("/xml/FromUserName");
            if (Event.InnerText.Equals("subscribe"))
            {
                Log.LogHelper.WriteLog("开始 处理Eventt：关注事件");
                responseContent = string.Format(ReplyType.Text.Format_Text,
                    FromUserName.InnerText,
                    ToUserName.InnerText,
                    DateTime.Now.Ticks,
                    "一一一/:rose欢迎使用/:rose一一一\n很高兴能和你成为好友\n我是您的私人返利助手\n只要3步，即可获得淘宝优惠券+返利\n/:heart①：把手机淘宝上要购买的商品链接发给我\n/:heart②：复制通过我查找出来的内部链接，返回淘宝下单，就会有优惠券\n/:heart③：确认收货后，发送“提现”就可以申请领取微信红包[Packet]\n-----------------------\n【更多功能】请回复“帮助”\n【轻松赚钱】请回复“赚钱”\n");
            }
            return responseContent;
        }
    }
}
