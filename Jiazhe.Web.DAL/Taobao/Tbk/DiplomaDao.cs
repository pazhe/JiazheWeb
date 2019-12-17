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
    /// 淘宝APP应用证书 数据访问 实现层
    /// </summary>
    public class DiplomaDao : HibernateDaoSupport, IDAL.Taobao.Tbk.DiplomaIdao
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Insert(Diploma entity)
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
        public bool Delete(Diploma entity)
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
        public bool Update(Diploma entity)
        {
            HibernateTemplate.Update(entity);
            return true;
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据用户id查找淘宝APP应用证书信息
        /// </summary>
        /// <param name="id">参数：用户CId</param>
        /// <returns></returns>
        public Diploma GetById(long id)
        {
            return (Diploma)HibernateTemplate.Execute
                (new HibernateDelegate<Diploma>(delegate (NHibernate.ISession session)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("from Diploma p  where p.CId=?");
                    IQuery query = session.CreateQuery(sb.ToString());
                    query.SetParameter(0, id);
                    return query.UniqueResult() as Diploma;
                }), true);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取所有淘宝APP 应用证书信息
        /// </summary>
        /// <returns></returns>
        public IList<Diploma> GetIList()
        {
            return HibernateTemplate.LoadAll<Diploma>();
            throw new NotImplementedException();
        }

        public IList<Diploma> GetIListById(long id)
        {
            throw new NotImplementedException();
        }

    }
}
