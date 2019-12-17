using Jiazhe.Web.Entity.Weixin;
using NHibernate;
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
    /// 微信公众号 数据访问 实现层
    /// </summary>
    public class WeixinPublicSettingDao : HibernateDaoSupport, IDAL.Weixin.WeixinPublicSettingIdao
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Insert(WeixinPublicSetting entity)
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
        public bool Delete(WeixinPublicSetting entity)
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
        public bool Update(WeixinPublicSetting entity)
        {
            HibernateTemplate.Update(entity);
            return true;
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据主键查找 公众号信息
        /// </summary>
        /// <param name="id">参数：主键 WxId</param>
        /// <returns></returns>
        public WeixinPublicSetting GetById(long id)
        {
            return (WeixinPublicSetting)HibernateTemplate.Execute(new HibernateDelegate<WeixinPublicSetting>(delegate (NHibernate.ISession session)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("from WeixinPublicSetting p  where p.WxId=?");
                IQuery query = session.CreateQuery(sb.ToString());
                query.SetParameter(0, id);
                return query.UniqueResult() as WeixinPublicSetting;
            }), true);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据原始id查找 公众号信息
        /// </summary>
        /// <param name="originalId">原始id WxOriginalId</param>
        /// <returns></returns>
        public WeixinPublicSetting GetByOriginalId(string originalId)
        {
            return (WeixinPublicSetting)HibernateTemplate.Execute(new HibernateDelegate<WeixinPublicSetting>(delegate (NHibernate.ISession session)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("from WeixinPublicSetting p  where p.WxOriginalId=?");
                IQuery query = session.CreateQuery(sb.ToString());
                query.SetParameter(0, originalId);
                return query.UniqueResult() as WeixinPublicSetting;
            }), true);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取所有公众号信息集合
        /// </summary>
        /// <returns></returns>
        public IList<WeixinPublicSetting> GetIList()
        {
            return HibernateTemplate.LoadAll<WeixinPublicSetting>();
            throw new NotImplementedException();
        }
    }
}
