using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.FactoryDao.Weixin
{
    /// <summary>
    /// 数据访问接口工厂 ：微信公众号开发基本配置 WeixinBaseConfigure
    /// </summary>
    public class WeixinBaseConfigureFactoryDao
    {
        /// <summary>
        /// 数据访问接口实例 ：微信公众号开发基本配置 WeixinBaseConfigure
        /// </summary>
        public IDAL.Weixin.WeixinBaseConfigureIdao WeixinConfigureDao { get; set; }

        /// <summary>
        /// 数据访问接口实例方法
        /// </summary>
        /// <returns>返回：数据访问接口实例</returns>
        public IDAL.Weixin.WeixinBaseConfigureIdao GetWeixinConfigureDao()
        {
            return WeixinConfigureDao;
        }
    }
}
