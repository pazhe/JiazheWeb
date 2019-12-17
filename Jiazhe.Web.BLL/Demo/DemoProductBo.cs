using Jiazhe.Web.Entity.Demo;
using Jiazhe.Web.IBLL.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.BLL.Demo
{
    /// <summary>
    /// Demo Product 业务逻辑实现类
    /// </summary>
    public class DemoProductBo : DemoProductIbo
    {
        private IDAL.Demo.DemoProductIdao dao { get; set; }

        /// <summary>
        /// 业务逻辑实现：添加单个实体对象信息
        /// </summary>
        /// <param name="entity">参数：Product 实体对象</param>
        /// <returns>返回：bool</returns>
        public bool InsertProducts(DemoProduct entity)
        {
            return dao.InsertProducts(entity);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 业务逻辑实现：删除单个实体对象信息
        /// </summary>
        /// <param name="entity">参数：Product 实体对象</param>
        /// <returns>返回：bool</returns>
        public bool DeleteProducts(DemoProduct entity)
        {
            return dao.DeleteProducts(entity);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 业务逻辑实现：修改单个实体对象信息
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>返回：bool</returns>
        public bool UpdateProducts(DemoProduct entity)
        {
            return dao.UpdateProducts(entity);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 业务逻辑实现：根据id 获取单个实体对象信息
        /// </summary>
        /// <param name="id">参数：实体对象PId</param>
        /// <returns>返回：单个实体对象（DemoProduct）</returns>
        public DemoProduct GetProductsById(long id)
        {
            return dao.GetProductsById(id);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 业务逻辑实现：获取所有实体对象信息
        /// </summary>
        /// <returns>返回：IList（Entity.Demo.DemoProduct）</returns>
        public IList<DemoProduct> GetProductsList()
        {
            return dao.GetProductsList();
            throw new NotImplementedException();
        }
    }
}
