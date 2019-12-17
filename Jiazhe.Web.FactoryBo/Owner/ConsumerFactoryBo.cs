using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.FactoryBo.Owner
{
    /// <summary>
    /// 业务逻辑访问接口工厂 : 用户 Consumer
    /// </summary>
    public class ConsumerFactoryBo
    {
        /// <summary>
        /// 业务逻辑访问接口实例 ： 用户 Consumer
        /// </summary>
        public IBLL.Owner.ConsumerIbo ConsumerBo { get; set; }

        //private static IApplicationContext ctx = ContextRegistry.GetContext();

        //private static ConsumerFactoryBo instance = null;
        //private static readonly object padlock = new object();

        ///// <summary>
        ///// 定义ConsumerFactoryBo的个单态以获取该类的一个实例
        ///// </summary>
        //public static ConsumerFactoryBo GetFactory
        //{
        //    get
        //    {
        //        lock (padlock)
        //        {
        //            try
        //            {
        //                if (instance == null)
        //                    instance = (FactoryBo.Owner.ConsumerFactoryBo)FactoryBo.Factory.Context.GetContext.GetContextRegistry().GetObject("ConsumerBoFactory");
        //                return instance;
        //            }
        //            catch (Exception erro) { throw erro; }
        //        }
        //    }
        //}

        /// <summary>
        /// 业务逻辑访问接口实例方法
        /// </summary>
        /// <returns>返回：业务逻辑访问接口实例 用户 Consumer</returns>
        public IBLL.Owner.ConsumerIbo GetConsumerBo()
        {
            return ConsumerBo;
        }
        
        /// <summary>
        /// 业务逻辑访问工厂实例 用户 ConsumerFactoryBo
        /// </summary>
        /// <param name="Object">上下文</param>
        /// <returns>返回：业务逻辑工厂实例 用户 ConsumerFactoryBo</returns>
        public static ConsumerFactoryBo GetObject(string Object)
        {
            return 
                (FactoryBo.Owner.ConsumerFactoryBo)
                FactoryBo.Factory.Context.GetContextRegistry.GetContext()
                .GetObject(Object);
        }
    }
}
