using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jiazhe.Web.Entity.Demo;
using Spring.Data.NHibernate.Generic.Support;
using Spring.Data.NHibernate.Generic;
using NHibernate;

/// <summary>
/// Demo Product 数据访问
/// </summary>
namespace Jiazhe.Web.DAL.Demo
{
    /// <summary>
    /// Demo Product 数据访问 实现类
    /// </summary>
    public class DemoProductDao : HibernateDaoSupport, IDAL.Demo.DemoProductIdao
    {
        /// <summary>
        /// 数据访问实现:添加单个实体对象信息
        /// </summary>
        /// <param name="entity">参数：Product 实体对象</param>
        /// <returns>返回：bool</returns>
        public bool InsertProducts(DemoProduct entity)
        {
            //HibernateTemplate.Save(entity);
            if (HibernateTemplate.Save(entity) != null)
            {
                return true;
            }
            return false;
            throw new NotImplementedException();
        }

        /// <summary>
        /// 数据访问实现:删除单个实体对象信息
        /// </summary>
        /// <param name="entity">参数：Product 实体对象</param>
        /// <returns>返回：bool</returns>
        public bool DeleteProducts(DemoProduct entity)
        {
            HibernateTemplate.Delete(entity);
            return true;
            throw new NotImplementedException();
        }

        /// <summary>
        /// 数据访问实现:修改单个实体对象信息
        /// </summary>
        /// <param name="entity">参数：Product 实体对象</param>
        /// <returns>返回：bool</returns>
        public bool UpdateProducts(DemoProduct entity)
        {
            HibernateTemplate.Update(entity);
            return true;
            throw new NotImplementedException();
        }

        /// <summary>
        /// 数据访问实现:根据id 获取单个实体对象信息
        /// </summary>
        /// <param name="id">参数：实体对象PId</param>
        /// <returns>返回：单个实体对象（DemoProduct）</returns>
        public DemoProduct GetProductsById(long id)
        {
            return (DemoProduct)HibernateTemplate.Execute(new HibernateDelegate<DemoProduct>(delegate (NHibernate.ISession session)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("from DemoProduct d  where d.PId=?");
                IQuery query = session.CreateQuery(sb.ToString());
                query.SetParameter(0, id);
                return query.UniqueResult() as DemoProduct;
            }), true);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 数据访问：
        /// 获取所有产品
        /// </summary>
        /// <returns>返回：IList（DemoProduct）</returns>
        public IList<DemoProduct> GetProductsList()
        {
            return HibernateTemplate.LoadAll<DemoProduct>();
            throw new NotImplementedException();
        }

    }
}
