using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Demo Product 数据访问接口
/// </summary>
namespace Jiazhe.Web.IDAL.Demo
{
    /// <summary>
    /// Demo Product 数据访问接口类
    /// </summary>
    public interface DemoProductIdao
    {
        /// <summary>
        /// 数据访问接口：添加单个实体对象信息
        /// </summary>
        /// <param name="entity">参数：Product 实体对象</param>
        /// <returns>返回：bool</returns>
        bool InsertProducts(Entity.Demo.DemoProduct entity);

        /// <summary>
        /// 数据访问接口：删除单个实体对象信息
        /// </summary>
        /// <param name="entity">参数：Product 实体对象</param>
        /// <returns>返回：bool</returns>
        bool DeleteProducts(Entity.Demo.DemoProduct entity);

        /// <summary>
        /// 数据访问接口：修改单个实体对象信息
        /// </summary>
        /// <param name="entity">参数：Product 实体对象</param>
        /// <returns>返回：bool</returns>
        bool UpdateProducts(Entity.Demo.DemoProduct entity);

        /// <summary>
        /// 数据访问接口：根据id 获取单个实体对象信息
        /// </summary>
        /// <param name="id">参数：实体对象PId</param>
        /// <returns>返回：单个实体对象（DemoProduct）</returns>
        Entity.Demo.DemoProduct GetProductsById(long id);

        /// <summary>
        /// 数据访问接口：获取所有实体对象信息
        /// </summary>
        /// <returns>返回：IList（DemoProduct）</returns>
        IList<Entity.Demo.DemoProduct> GetProductsList();
    }
}
