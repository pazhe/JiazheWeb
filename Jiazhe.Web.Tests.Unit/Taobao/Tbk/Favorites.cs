using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Context;
using Spring.Context.Support;

namespace Jiazhe.Web.Tests.Unit.Taobao.Tbk
{
    [TestClass]
    public class Favorites
    {
        [TestMethod]
        public void ContextTest()
        {
            //非单例模式
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Taobao.Tbk.FavoritesIbo ibo = (IBLL.Taobao.Tbk.FavoritesIbo)ctx.GetObject("FavoritesBo");
            FactoryBo.Taobao.Tbk.FavoritesFactoryBo iboFactory =
                (FactoryBo.Taobao.Tbk.FavoritesFactoryBo)ctx.GetObject("FavoritesBoFactory");

            //单例模式
            //FactoryBo.Owner.ConsumerFactoryBo.GetFactory.GetConsumerBo().GetConsumerList();

            //封装模式
            FactoryBo.Taobao.Tbk.FavoritesFactoryBo iboFactory1 =
                (FactoryBo.Taobao.Tbk.FavoritesFactoryBo)
                FactoryBo.Factory.Context.GetContextRegistry.GetContext()
                .GetObject("FavoritesBoFactory");

            //View 直接调用
            FactoryBo.Taobao.Tbk.FavoritesFactoryBo.GetObject("FavoritesBoFactory").GetFavoritesBo().GetIList();

            //Test
            FactoryBo.Taobao.Tbk.FavoritesFactoryBo.GetObject("FavoritesBoFactory").FavoritesBo.GetIList();
        }
    }
}
