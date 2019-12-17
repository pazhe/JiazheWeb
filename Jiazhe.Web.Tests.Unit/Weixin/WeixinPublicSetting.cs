using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Context;
using Spring.Context.Support;

namespace Jiazhe.Web.Tests.Unit.Weixin
{
    [TestClass]
    public class WeixinPublicSetting
    {
        [TestMethod]
        public void ContextTest()
        {
            //非单例模式
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Weixin.WeixinPublicSettingIbo ibo =
                (IBLL.Weixin.WeixinPublicSettingIbo)ctx.GetObject("WeixinPublicBo");

            FactoryBo.Weixin.WeixinPublicSettingFactoryBo iboFactory =
                (FactoryBo.Weixin.WeixinPublicSettingFactoryBo)ctx
                .GetObject("WeixinPublicBoFactory");

            //单例模式
            //FactoryBo.Weixin.WeixinPublicSettingFactoryBo.GetFactory.GetWeixinPublicBo().GetWeixinPublicList();

            //封装模式
            FactoryBo.Weixin.WeixinPublicSettingFactoryBo iboFactory1 =
                (FactoryBo.Weixin.WeixinPublicSettingFactoryBo)
                FactoryBo.Factory.Context.GetContextRegistry.GetContext()
                .GetObject("WeixinPublicBoFactory");

        }

        [TestMethod]
        public void InsertWeixinPublic()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            FactoryBo.Weixin.WeixinPublicSettingFactoryBo iboFactory =
                (FactoryBo.Weixin.WeixinPublicSettingFactoryBo)ctx
                .GetObject("WeixinPublicBoFactory");

            Entity.Weixin.WeixinPublicSetting entity = new Entity.Weixin.WeixinPublicSetting();
            entity.CId = 1;
            iboFactory.GetWeixinPublicBo().Insert(entity);
        }
    }
}
