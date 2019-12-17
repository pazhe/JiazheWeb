using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.FactoryBo.Weixin
{
    public class WeixinBaseConfigureFactoryBo
    {
        public IBLL.Weixin.WeixinBaseConfigureIbo WeixinConfigureBo { get; set; }

        /// <summary>
        /// 业务逻辑访问接口实例方法
        /// </summary>
        /// <returns>返回 ：业务逻辑访问 接口实例 微信公众号 WeixinBaseConfigure</returns>
        public IBLL.Weixin.WeixinBaseConfigureIbo GetWeixinConfigureBo()
        {
            return WeixinConfigureBo;
        }

        /// <summary>
        /// 业务逻辑访问 工厂实例 ：微信公众号开发基本配置 WeixinBaseConfigure
        /// </summary>
        /// <param name="Object">上下文</param>
        /// <returns>返回：业务逻辑工厂实例 微信公众号 WeixinBaseConfigure</returns>
        public static WeixinBaseConfigureFactoryBo GetObject(string Object)
        {
            return
                (FactoryBo.Weixin.WeixinBaseConfigureFactoryBo)
                FactoryBo.Factory.Context.GetContextRegistry.GetContext()
                .GetObject(Object);
        }
    }
}
