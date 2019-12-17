using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Context;
using Spring.Context.Support;

namespace Jiazhe.Web.Tests.Unit.Demo
{
    [TestClass]
    public class Product
    {
        /// <summary>
        /// 获取所有实体对象信息
        /// </summary>
        [TestMethod]
        public void GetProductsList()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Demo.DemoProductIbo ibo = (IBLL.Demo.DemoProductIbo)ctx.GetObject("DemoProductBo");
            ibo.GetProductsList();
        }

        /// <summary>
        /// 添加实体对象信息
        /// </summary>
        [TestMethod]
        public void InsertProducts()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Demo.DemoProductIbo ibo = (IBLL.Demo.DemoProductIbo)ctx.GetObject("DemoProductBo");
            Entity.Demo.DemoProduct entity = new Entity.Demo.DemoProduct();
            entity.PCode = "DemoCode";
            ibo.InsertProducts(entity);
        }

        /// <summary>
        /// 删除实体对象信息
        /// </summary>
        [TestMethod]
        public void DeleteProducts()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Demo.DemoProductIbo ibo = (IBLL.Demo.DemoProductIbo)ctx.GetObject("DemoProductBo");
            Entity.Demo.DemoProduct entity = new Entity.Demo.DemoProduct();
            entity.PId = 2;
            entity.PCode = "Code";
            ibo.DeleteProducts(entity);
        }

        /// <summary>
        /// 修改实体对象信息
        /// </summary>
        [TestMethod]
        public void UpdateProducts()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Demo.DemoProductIbo ibo = (IBLL.Demo.DemoProductIbo)ctx.GetObject("DemoProductBo");
            Entity.Demo.DemoProduct entity = new Entity.Demo.DemoProduct();
            entity.PId = 2;
            entity.PCode = "CodeUpdate";
            ibo.UpdateProducts(entity);
        }

        /// <summary>
        /// 根据id 获取单个实体对象信息
        /// </summary>
        [TestMethod]
        public void GetProductsById()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IBLL.Demo.DemoProductIbo ibo = (IBLL.Demo.DemoProductIbo)ctx.GetObject("DemoProductBo");
            Entity.Demo.DemoProduct entity = new Entity.Demo.DemoProduct();
            entity = ibo.GetProductsById(2);
        }

    }
}
