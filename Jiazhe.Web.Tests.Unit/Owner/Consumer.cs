using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Context;
using Spring.Context.Support;

namespace Jiazhe.Web.Tests.Unit.Owner
{
    [TestClass]
    public class Consumer
    {
        [TestMethod]
        public void ContextTest()
        {
            //非单例模式
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Owner.ConsumerIbo ibo = (IBLL.Owner.ConsumerIbo)ctx.GetObject("ConsumerBo");
            FactoryBo.Owner.ConsumerFactoryBo iboFactory =
                (FactoryBo.Owner.ConsumerFactoryBo)ctx.GetObject("ConsumerBoFactory");

            //单例模式
            //FactoryBo.Owner.ConsumerFactoryBo.GetFactory.GetConsumerBo().GetConsumerList();

            //封装模式
            FactoryBo.Owner.ConsumerFactoryBo iboFactory1 =
                (FactoryBo.Owner.ConsumerFactoryBo)
                FactoryBo.Factory.Context.GetContextRegistry.GetContext()
                .GetObject("ConsumerBoFactory");

            //View 直接调用
            FactoryBo.Owner.ConsumerFactoryBo.GetObject("ConsumerBoFactory").GetConsumerBo().GetConsumerList();

            //Test
            FactoryBo.Owner.ConsumerFactoryBo.GetObject("ConsumerBoFactory").ConsumerBo.GetConsumerList();
        }

        [TestMethod]
        public void InsertConsumer()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Owner.ConsumerIbo ibo = (IBLL.Owner.ConsumerIbo)ctx.GetObject("ConsumerBo");
            FactoryBo.Owner.ConsumerFactoryBo iboFactory = (FactoryBo.Owner.ConsumerFactoryBo)ctx.GetObject("ConsumerBoFactory");
            Entity.Owner.Consumer consumer = new Entity.Owner.Consumer();
            consumer.LevelId = 1;
            consumer.CName = "tianixao";
            consumer.CPassword = "123456";
            consumer.CDate = DateTime.Now.ToString();
            //ibo.InsertConsumer(consumer);
            iboFactory.GetConsumerBo().InsertConsumer(consumer);

        }

        [TestMethod]
        public void DeleteConsumer()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Owner.ConsumerIbo ibo = (IBLL.Owner.ConsumerIbo)ctx.GetObject("ConsumerBo");
            Entity.Owner.Consumer consumer = new Entity.Owner.Consumer();
            consumer.CId = 4;
            ibo.DeleteConsumer(consumer);
        }

        [TestMethod]
        public void UpdateConsumer()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Owner.ConsumerIbo ibo = (IBLL.Owner.ConsumerIbo)ctx.GetObject("ConsumerBo");
            Entity.Owner.Consumer consumer = new Entity.Owner.Consumer();
            consumer.CId = 2;
            consumer.LevelId = 1;
            consumer.CName = "wanghewei";
            consumer.CPassword = "456789";
            ibo.UpdateConsumer(consumer);
        }

        [TestMethod]
        public void GetConsumer()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Owner.ConsumerIbo ibo = (IBLL.Owner.ConsumerIbo)ctx.GetObject("ConsumerBo");
            ibo.GetConsumerList();
        }

        [TestMethod]
        public void GetConsumerById()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Owner.ConsumerIbo ibo = (IBLL.Owner.ConsumerIbo)ctx.GetObject("ConsumerBo");
            ibo.GetConsumerById(1);
        }

        [TestMethod]
        public void GetConsumerIsExist()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Owner.ConsumerIbo ibo = (IBLL.Owner.ConsumerIbo)ctx.GetObject("ConsumerBo");
            ibo.GetConsumerIsExist("wanghewei","tianxiao");
        }
    }
}
