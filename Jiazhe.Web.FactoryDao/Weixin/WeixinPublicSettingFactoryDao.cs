using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.FactoryDao.Weixin
{
    /// <summary>
    /// 数据访问接口工厂 ：微信公众号 WeixinPublicSetting
    /// </summary>
    public class WeixinPublicSettingFactoryDao
    {
        /// <summary>
        /// 数据访问接口实例 ：微信公众号 WeixinPublicSetting
        /// </summary>
        public IDAL.Weixin.WeixinPublicSettingIdao WeixinPublicDao { get; set; }

        /// <summary>
        /// 数据访问接口实例方法
        /// </summary>
        /// <returns>返回：数据访问接口实例</returns>
        public IDAL.Weixin.WeixinPublicSettingIdao GetWeixinPublicDao()
        {
            return WeixinPublicDao;
        }
    }
}
