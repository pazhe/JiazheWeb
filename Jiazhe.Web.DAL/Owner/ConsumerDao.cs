using Jiazhe.Web.Entity.Demo;
using Jiazhe.Web.Entity.Owner;
using NHibernate;
using Spring.Data.NHibernate.Generic;
using Spring.Data.NHibernate.Generic.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.DAL.Owner
{
    /// <summary>
    /// 数据访问:Consumer 用户
    /// </summary>
    public class ConsumerDao : HibernateDaoSupport, IDAL.Owner.ConsumerIdao
    {
        /// <summary>
        /// 数据访问实现：添加用户
        /// </summary>
        /// <param name="entity">参数：实体对象（Consumer：用户）</param>
        /// <returns></returns>
        public bool InsertConsumer(Consumer entity)
        {
            if (HibernateTemplate.Save(entity) != null)
            {
                return true;
            }
            return false;
            throw new NotImplementedException();
        }

        /// <summary>
        /// 数据访问实现：删除用户
        /// </summary>
        /// <param name="entity">参数：实体对象（Consumer：用户）</param>
        /// <returns></returns>
        public bool DeleteConsumer(Consumer entity)
        {
            HibernateTemplate.Delete(entity);
            return true;
            throw new NotImplementedException();
        }

        /// <summary>
        /// 数据访问实现：修改用户
        /// </summary>
        /// <param name="entity">参数：实体对象（Consumer：用户）</param>
        /// <returns></returns>
        public bool UpdateConsumer(Consumer entity)
        {
            HibernateTemplate.Update(entity);
            return true;
            throw new NotImplementedException();
        }

        /// <summary>
        /// 数据访问实现：查找用户根据id
        /// </summary>
        /// <param name="id">参数：用户id</param>
        /// <returns></returns>
        public Consumer GetConsumerById(long id)
        {
            return (Consumer)HibernateTemplate.Execute(new HibernateDelegate<Consumer>(delegate (NHibernate.ISession session)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("from Consumer c  where c.CId=?");
                IQuery query = session.CreateQuery(sb.ToString());
                query.SetParameter(0, id);
                return query.UniqueResult() as Consumer;
            }), true);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 数据访问实现：查找用户根据用户名密码
        /// </summary>
        /// <param name="name">参数：用户名</param>
        /// <param name="pwd">参数：密码</param>
        /// <returns>返回：实体对象（Consumer：用户）</returns>
        public Consumer GetConsumerIsExist(string name, string pwd)
        {
            return (Consumer)HibernateTemplate.Execute(new HibernateDelegate<Consumer>(delegate (NHibernate.ISession session)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("from Consumer c  where c.CName=? and c.CPassword=?");
                IQuery query = session.CreateQuery(sb.ToString());
                query.SetParameter(0, name);
                query.SetParameter(1, pwd);
                return query.UniqueResult() as Consumer;
            }), true);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 数据访问实现：查找所有用户
        /// </summary>
        /// <returns>返回：实体集合对象（IList）</returns>
        public IList<Consumer> GetConsumerList()
        {
            return HibernateTemplate.LoadAll<Consumer>();
            throw new NotImplementedException();
        }
    }
}
