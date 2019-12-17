using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Context;
using Spring.Context.Support;

namespace Jiazhe.Web.Tests.Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();

            IBLL.ManagerIBO ibo = (IBLL.ManagerIBO)ctx.GetObject("managerBo");
            ibo.GetAllUsers();
        }

        [TestMethod]
        public void TestMethodProduct()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Demo.DemoProductIbo ibo = (IBLL.Demo.DemoProductIbo)ctx.GetObject("DemoProductBo");
            ibo.GetProductsList();
        }
    }
}
