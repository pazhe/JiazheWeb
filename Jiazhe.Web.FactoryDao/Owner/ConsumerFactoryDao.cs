using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.FactoryDao.Owner
{
    /// <summary>
    /// 数据访问接口工厂
    /// </summary>
    public class ConsumerFactoryDao
    {
        /// <summary>
        /// 直接可以使用这个数据访问接口实例
        /// </summary>
        public IDAL.Owner.ConsumerIdao ConsumerDao { get; set; }

        /// <summary>
        /// 获取数据接口访问实例
        /// </summary>
        /// <returns></returns>
        public IDAL.Owner.ConsumerIdao GetConsumerDao()
        {
            return ConsumerDao;
        }
    }
}
