using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.FactoryBo.Weixin
{
    /// <summary>
    /// 业务逻辑访问接口工厂 ： 微信公众号 WeixinPublicSetting
    /// </summary>
    public class WeixinPublicSettingFactoryBo
    {
        /// <summary>
        /// 业务逻辑访问接口实例 ： 微信公众号 WeixinPublicSetting
        /// </summary>
        public IBLL.Weixin.WeixinPublicSettingIbo WeixinPublicBo { get; set; }

        //private static IApplicationContext ctx = ContextRegistry.GetContext();

        //private static WeixinPublicSettingFactoryBo instance = null;
        //private static readonly object padlock = new object();

        ///// <summary>
        ///// 定义WeixinPublicSettingFactoryBo的个单态以获取该类的一个实例
        ///// </summary>
        //public static WeixinPublicSettingFactoryBo GetFactory
        //{
        //    get
        //    {
        //        lock (padlock)
        //        {
        //            if (instance == null)
        //                instance = (FactoryBo.Weixin.WeixinPublicSettingFactoryBo)ctx.GetObject("WeixinPublicBoFactory");
        //            return instance;
        //        }
        //    }
        //}

        /// <summary>
        /// 业务逻辑访问 接口实例方法
        /// </summary>
        /// <returns>返回 ：业务逻辑访问接口实例 微信公众号 WeixinPublicSetting</returns>
        public IBLL.Weixin.WeixinPublicSettingIbo GetWeixinPublicBo()
        {
            return WeixinPublicBo;
        }

        /// <summary>
        /// 业务逻辑访问 工厂实例 ：微信公众号 WeixinPublicSetting
        /// </summary>
        /// <param name="Object">上下文</param>
        /// <returns>返回：业务逻辑工厂实例 微信公众号 WeixinPublicSetting</returns>
        public static WeixinPublicSettingFactoryBo GetObject(string Object)
        {
            return
                (FactoryBo.Weixin.WeixinPublicSettingFactoryBo)
                FactoryBo.Factory.Context.GetContextRegistry.GetContext()
                .GetObject(Object);
        }
    }
}
