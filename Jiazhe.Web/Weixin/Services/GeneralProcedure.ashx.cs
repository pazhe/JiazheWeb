using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using Jiazhe.OpenSDK.Weixin.Log;
using Jiazhe.OpenSDK.Weixin.MessagesHandlers.Tools;
using System.Text;

namespace Jiazhe.Web.Weixin.Services
{
    /// <summary>
    /// GeneralProcedure (一般程序)的摘要说明
    /// </summary>
    public class GeneralProcedure : IHttpHandler
    {
        /// <summary>
        /// 获取请求微信服务器返回的数据
        /// </summary>
        /// <param name="context"></param>
        public void ProcessRequest(HttpContext context)
        {
            RequestHandle(context);
            context.Response.ContentType = "text/plain";
            context.Response.Write("恭喜您！微信公众号成功接入服务器");
        }

        /// <summary>
        /// 判断请求数据的传输方式
        /// 如果是 POST 方式，对数据进行处理
        /// 如果非 POST 方式，进行开发者认证
        /// </summary>
        /// <param name="context"></param>
        private void RequestHandle(HttpContext context)
        {
            if (HttpContext.Current.Request.HttpMethod.ToUpper() == "POST")
                //处理Request消息

                IsTrueMessages(context);

                //OpenSDK.Weixin.MessagesHandlers.Tools.MessagesHelp.GetToUserName(context);
            else
                OpenSDK.Weixin.MessagesHandlers.Utilities.Developer.ReturnDeveloper(context);
                //成为开发者
        }

        /// <summary>
        /// 判断公众号配置是否有效
        /// 如果无效发送无效信息
        /// 如果有效发送正确信息
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private bool IsTrueMessages(HttpContext context)
        {
            XmlDocument xmlContext = MessagesHelp.GetPostStrConverToXmlDoc(context);

            Entity.Weixin.WeixinBaseConfigure entity = new Entity.Weixin.WeixinBaseConfigure();
            //获取微信公众号实体信息
            entity = FactoryBo.Weixin.WeixinBaseConfigureFactoryBo.GetObject("WeixinConfigureBoFactory").
                WeixinConfigureBo.GetById(FactoryBo.Weixin.WeixinPublicSettingFactoryBo.GetObject("WeixinPublicBoFactory").
                WeixinPublicBo.GetByOriginalId(MessagesHelp.GetToUserName(xmlContext)).WxId);

            if (entity!=null && entity.WxIsFlag == 1)//判断成立 开始发送正常信息
            {
                OpenSDK.Weixin.MessagesHandlers.Response.ResponseHelp.Send(xmlContext, "发送正确信息123"+ xmlContext.InnerText);
                return true;
            }
            else
            {
                OpenSDK.Weixin.MessagesHandlers.Response.ResponseHelp.Send(xmlContext, "配置信息未通过审核或服务到期！");
                return false;
            }
        }

        /// <summary>废弃代码
        ///// 获取微信公众号实体信息
        ///// </summary>
        ///// <param name="context"></param>
        ///// <returns></returns>
        //private Entity.Weixin.WeixinPublicSetting GetWeixinPublic(string toUserName)
        //{
        //    return FactoryBo.Weixin.WeixinPublicSettingFactoryBo.GetObject("WeixinPublicBoFactory")
        //        .WeixinPublicBo.GetByOriginalId(toUserName);
        //}

        ///// <summary>
        ///// 获取微信公众号开发配置实体信息
        ///// </summary>
        ///// <param name="weixinPublic"></param>
        ///// <returns></returns>
        //private Entity.Weixin.WeixinBaseConfigure GetWeixinBaseConfigure(Entity.Weixin.WeixinPublicSetting weixinPublic)
        //{
        //    return FactoryBo.Weixin.WeixinBaseConfigureFactoryBo.GetObject("WeixinConfigureBoFactory")
        //        .WeixinConfigureBo.GetById(weixinPublic.WxId);
        //}

        ///// <summary>
        ///// 判断微信公众号 开发配置信息是否存在
        ///// </summary>
        ///// <param name="entity"></param>
        ///// <returns></returns>
        //private bool IsExist(Entity.Weixin.WeixinBaseConfigure entity)
        //{
        //    bool isExist = false;
        //    if (entity != null)//判断查询配置信息是否存在
        //        isExist = true;
        //    else isExist = false;
        //    return isExist;
        //}

        ///// <summary>
        ///// 判断微信公众号 开发配置信息是否通过审核
        ///// </summary>
        ///// <param name="entity"></param>
        ///// <returns></returns>
        //private bool IsIsFlag(Entity.Weixin.WeixinBaseConfigure entity)
        //{
        //    bool isExist = false;
        //    if (entity.WxIsFlag==1)//判断查询配置信息是否通过审核
        //        isExist = true;
        //    else isExist = false;
        //    return isExist;
        //}

        ///// <summary>
        ///// 发送正确信息
        ///// </summary>
        //public void ResponseContentisTrueMssages(XmlDocument xmldoc)
        //{
        //    OpenSDK.Weixin.MessagesHandlers.Response.ResponseHelp.Send(xmldoc, "发送正确信息123");
        //}

        ///// <summary>
        ///// 发送错误信息
        ///// </summary>
        //public void ResponseContentisErrorMssages(XmlDocument xmldoc)
        //{
        //    string responseContent = MessagesHelp.ReturnResponseContent(xmldoc, "配置信息未通过审核或服务到期！");
        //    HttpContext.Current.Response.ContentEncoding = Encoding.UTF8;
        //    HttpContext.Current.Response.Write(responseContent);
        //}

        /// <summary>
        /// 
        /// </summary>
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

    }
}