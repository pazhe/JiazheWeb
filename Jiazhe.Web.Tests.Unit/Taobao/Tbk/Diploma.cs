using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Context;
using Spring.Context.Support;

namespace Jiazhe.Web.Tests.Unit.Taobao.Tbk
{
    [TestClass]
    public class Diploma
    {
        [TestMethod]
        public void ContextTest()
        {
            //非单例模式
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Taobao.Tbk.DiplomaIbo ibo = (IBLL.Taobao.Tbk.DiplomaIbo)ctx.GetObject("DiplomaBo");
            FactoryBo.Taobao.Tbk.DiplomaFactoryBo iboFactory =
                (FactoryBo.Taobao.Tbk.DiplomaFactoryBo)ctx.GetObject("DiplomaBoFactory");

            //单例模式
            //FactoryBo.Owner.ConsumerFactoryBo.GetFactory.GetConsumerBo().GetConsumerList();

            //封装模式
            FactoryBo.Taobao.Tbk.DiplomaFactoryBo iboFactory1 =
                (FactoryBo.Taobao.Tbk.DiplomaFactoryBo)
                FactoryBo.Factory.Context.GetContextRegistry.GetContext()
                .GetObject("DiplomaBoFactory");

            //View 直接调用
            FactoryBo.Taobao.Tbk.DiplomaFactoryBo.GetObject("DiplomaBoFactory").GetDiplomaBo().GetIList();

            //Test
            FactoryBo.Taobao.Tbk.DiplomaFactoryBo.GetObject("DiplomaBoFactory").DiplomaBo.GetIList();
        }
    }
}
