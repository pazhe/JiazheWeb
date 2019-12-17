using Jiazhe.Web.Entity.Taobao.Tbk;
using NHibernate;
using Spring.Data.NHibernate.Generic;
using Spring.Data.NHibernate.Generic.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.DAL.Taobao.Tbk
{
    /// <summary>
    /// 选品库产品 数据访问 实现层
    /// </summary>
    public class FavoriteItemDao : HibernateDaoSupport, IDAL.Taobao.Tbk.FavoriteItemIdao
    {

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Insert(FavoriteItem entity)
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
        public bool Delete(FavoriteItem entity)
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
        public bool Update(FavoriteItem entity)
        {
            HibernateTemplate.Update(entity);
            return true;
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据选品库id获取该选品库在数据库中的产品集合
        /// </summary>
        /// <param name="fId">参数：选品库id</param>
        /// <returns></returns>
        public IList<FavoriteItem> GetByFId(long fId)
        {
            return HibernateTemplate.Find<FavoriteItem>
                (
                "from FavoriteItem p  where p.FavoritesId=?",
                fId
                );
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据商品id 获取数据库产品信息
        /// </summary>
        /// <param name="numIid">参数：商品id</param>
        /// <returns></returns>
        public FavoriteItem GetByNumIid(long numIid)
        {
            return (FavoriteItem)HibernateTemplate.Execute
                (new HibernateDelegate<FavoriteItem>(delegate (ISession session)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("from FavoriteItem p  where p.NumIid=?");
                    IQuery query = session.CreateQuery(sb.ToString());
                    query.SetParameter(0, numIid);
                    return query.UniqueResult() as FavoriteItem;
                }), true);

            throw new NotImplementedException();
        }
    }
}
