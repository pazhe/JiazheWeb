using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jiazhe.Web.Entity.Weixin;

namespace Jiazhe.Web.BLL.Weixin
{
    /// <summary>
    /// 
    /// </summary>
    public class WeixinPublicSettingBo : IBLL.Weixin.WeixinPublicSettingIbo
    {
        private FactoryDao.Weixin.WeixinPublicSettingFactoryDao FactoryDao { get; set; }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Insert(WeixinPublicSetting entity)
        {
            return FactoryDao.GetWeixinPublicDao().Insert(entity);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(WeixinPublicSetting entity)
        {
            return FactoryDao.GetWeixinPublicDao().Delete(entity);
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(WeixinPublicSetting entity)
        {
            return FactoryDao.GetWeixinPublicDao().Update(entity);
            throw new NotImplementedException();
        }

        public WeixinPublicSetting GetById(long id)
        {
            return FactoryDao.GetWeixinPublicDao().GetById(id);
            throw new NotImplementedException();
        }

        public WeixinPublicSetting GetByOriginalId(string originalId)
        {
           return FactoryDao.GetWeixinPublicDao().GetByOriginalId(originalId);
            throw new NotImplementedException();
        }

        public IList<WeixinPublicSetting> GetIList()
        {
            return FactoryDao.GetWeixinPublicDao().GetIList();
            throw new NotImplementedException();
        }

        
    }
}
