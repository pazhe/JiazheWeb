using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Demo Product 业务逻辑接口
/// </summary>
namespace Jiazhe.Web.IBLL.Demo
{
    /// <summary>
    /// Demo Product 业务逻辑接口
    /// </summary>
    public interface DemoProductIbo
    {
        /// <summary>
        /// 业务逻辑接口：添加单个实体对象信息
        /// </summary>
        /// <param name="entity">参数：Product 实体对象</param>
        /// <returns>返回：bool</returns>
        bool InsertProducts(Entity.Demo.DemoProduct entity);

        /// <summary>
        /// 业务逻辑接口：删除单个实体对象信息
        /// </summary>
        /// <param name="entity">参数：Product 实体对象</param>
        /// <returns>返回：bool</returns>
        bool DeleteProducts(Entity.Demo.DemoProduct entity);

        /// <summary>
        /// 业务逻辑接口：修改单个实体对象信息
        /// </summary>
        /// <param name="entity">参数：Product 实体对象</param>
        /// <returns>返回：bool</returns>
        bool UpdateProducts(Entity.Demo.DemoProduct entity);

        /// <summary>
        /// 业务逻辑接口：根据id 获取单个实体对象信息
        /// </summary>
        /// <param name="id">参数：实体对象PId</param>
        /// <returns>返回：单个实体对象（DemoProduct）</returns>
        Entity.Demo.DemoProduct GetProductsById(long id);

        /// <summary>
        /// 业务逻辑接口：获取所有实体对象信息
        /// </summary>
        /// <returns>返回：IList（Entity.Demo.DemoProduct）</returns>
        IList<Entity.Demo.DemoProduct> GetProductsList();
    }
}
