using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jiazhe.Web.Entity.Taobao.Tbk;
using NHibernate;
using Spring.Data.NHibernate.Generic;
using Spring.Data.NHibernate.Generic.Support;

namespace Jiazhe.Web.DAL.Taobao.Tbk
{
    /// <summary>
    /// 选品库 数据访问 实现层
    /// </summary>
    public class FavoritesDao : HibernateDaoSupport, IDAL.Taobao.Tbk.FavoritesIdao
    {

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Insert(Favorites entity)
        {
            HibernateTemplate.Save(entity);
            return true;
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(Favorites entity)
        {
            HibernateTemplate.Delete(entity);
            return true;
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(Favorites entity)
        {
            HibernateTemplate.Update(entity);
            return true;
            throw new NotImplementedException();
        }

        public Favorites GetById(long id)
        {
            return (Favorites)HibernateTemplate.Execute
                (new HibernateDelegate<Favorites>(delegate (NHibernate.ISession session)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("from Favorites p  where p.FavoritesId=?");
                IQuery query = session.CreateQuery(sb.ToString());
                query.SetParameter(0, id);
                return query.UniqueResult() as Favorites;
            }), true);
            throw new NotImplementedException();
        }

        public IList<Favorites> GetIListById(long id)
        {
            return HibernateTemplate.Find<Favorites>
                (
                "from WeixinBaseConfigure p  where p.WxcId=?",
                id
                );
            throw new NotImplementedException();
        }

        public IList<Favorites> GetIList()
        {
            return HibernateTemplate.LoadAll<Favorites>();
            throw new NotImplementedException();
        }
    }
}
