using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Context;
using Spring.Context.Support;

namespace Jiazhe.Web.Tests.Unit.Weixin
{
    [TestClass]
    public class WeixinBaseConfigure
    {
        [TestMethod]
        public void ContextTest()
        {
            //非单例模式
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Weixin.WeixinBaseConfigureIbo ibo =
                (IBLL.Weixin.WeixinBaseConfigureIbo)ctx.GetObject("WeixinConfigureBo");

            FactoryBo.Weixin.WeixinBaseConfigureFactoryBo iboFactory =
                (FactoryBo.Weixin.WeixinBaseConfigureFactoryBo)ctx
                .GetObject("WeixinConfigureBoFactory");

            //单例模式
            //FactoryBo.Weixin.WeixinPublicSettingFactoryBo.GetFactory.GetWeixinPublicBo().GetWeixinPublicList();

            //封装模式
            FactoryBo.Weixin.WeixinBaseConfigureFactoryBo iboFactory1 =
                (FactoryBo.Weixin.WeixinBaseConfigureFactoryBo)
                FactoryBo.Factory.Context.GetContextRegistry.GetContext()
                .GetObject("WeixinConfigureBoFactory");
        }
    }
}
