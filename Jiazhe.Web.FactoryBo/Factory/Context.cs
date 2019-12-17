using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.FactoryBo.Factory
{
    public class Context
    {
        private static Context instance = null;
        private static readonly object padlock = new object();
        IApplicationContext ctx;
        /// <summary>
        /// 定义Context的个单态以获取该类的一个实例
        /// </summary>
        public static Context GetContextRegistry
        {
            get
            {
                lock (padlock)
                {
                    try
                    {
                        if (instance == null)
                            instance = new Context();
                        return instance;
                    }
                    catch (Exception erro) { throw erro; }
                }
            }
        }

        public IApplicationContext GetContext()
        {
            if (ctx == null)
                ctx= ContextRegistry.GetContext();
                return ctx;
        }
    }
}
