using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jiazhe.Web.Entity.Weixin;

namespace Jiazhe.Web.BLL.Weixin
{
    public class WeixinBaseConfigureBo : IBLL.Weixin.WeixinBaseConfigureIbo
    {
        private FactoryDao.Weixin.WeixinBaseConfigureFactoryDao FactoryDao { get; set; }

        public bool Insert(WeixinBaseConfigure entity)
        {
            return FactoryDao.WeixinConfigureDao.Insert(entity);
            throw new NotImplementedException();
        }

        public bool Delete(WeixinBaseConfigure entity)
        {
            FactoryDao.WeixinConfigureDao.Delete(entity);
            throw new NotImplementedException();
        }

        public bool Update(WeixinBaseConfigure entity)
        {
            FactoryDao.WeixinConfigureDao.Update(entity);
            throw new NotImplementedException();
        }

        public WeixinBaseConfigure GetById(long id)
        {
            return FactoryDao.WeixinConfigureDao.GetById(id);
            throw new NotImplementedException();
        }

        public IList<WeixinBaseConfigure> GetIListById(long id)
        {
            return FactoryDao.WeixinConfigureDao.GetIListById(id);
            throw new NotImplementedException();
        }

        public IList<WeixinBaseConfigure> GetIList()
        {
            return FactoryDao.WeixinConfigureDao.GetIList();
            throw new NotImplementedException();
        }

    }  
}
