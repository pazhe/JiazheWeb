using Jiazhe.Web.Entity.Weixin;
using NHibernate;
using Spring.Data.NHibernate;
using Spring.Data.NHibernate.Generic;
using Spring.Data.NHibernate.Generic.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.DAL.Weixin
{
    /// <summary>
    /// 微信公众号 开发配置 数据访问 实现层
    /// </summary>
    public class WeixinBaseConfigureDao : HibernateDaoSupport, IDAL.Weixin.WeixinBaseConfigureIdao
    {
        
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Insert(WeixinBaseConfigure entity)
        {
            if (HibernateTemplate.Save(entity) != null)
            {
                return true;
            }
            return false;
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(WeixinBaseConfigure entity)
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
        public bool Update(WeixinBaseConfigure entity)
        {
            HibernateTemplate.Update(entity);
            return true;
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据公众号主键 获取该公众号开发配置信息
        /// </summary>
        /// <param name="id">参数：公众号 主键</param>
        /// <returns></returns>
        public WeixinBaseConfigure GetById(long id)
        {
            return (WeixinBaseConfigure)HibernateTemplate.Execute(new HibernateDelegate<WeixinBaseConfigure>(delegate (NHibernate.ISession session)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("from WeixinBaseConfigure p  where p.WxId=?");
                IQuery query = session.CreateQuery(sb.ToString());
                query.SetParameter(0, id);
                return query.UniqueResult() as WeixinBaseConfigure;
            }), true);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据该开发配置的主键获取 该开发配置的信息
        /// </summary>
        /// <param name="id">参数：开发配置主键</param>
        /// <returns></returns>
        public IList<WeixinBaseConfigure> GetIListById(long id)
        {
            return HibernateTemplate.Find<WeixinBaseConfigure>("from WeixinBaseConfigure p  where p.WxcId=?", id);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取 所有公众号的开发配置信息
        /// </summary>
        /// <returns></returns>
        public IList<WeixinBaseConfigure> GetIList()
        {
            return HibernateTemplate.LoadAll<WeixinBaseConfigure>();
            throw new NotImplementedException();
        }

        
    }
}
