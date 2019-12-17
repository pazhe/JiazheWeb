using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jiazhe.Web.Entity.Taobao.Tbk;

namespace Jiazhe.Web.BLL.Taobao.Tbk
{
    /// <summary>
    /// 淘宝API应用证书 业务逻辑类
    /// </summary>
    public class DiplomaBo : IBLL.Taobao.Tbk.DiplomaIbo
    {
        private FactoryDao.Taobao.Tbk.DiplomaFactoryDao FactoryDao { get; set; }

        public bool Insert(Diploma entity)
        {
            return FactoryDao.DiplomaDao.Insert(entity);
            throw new NotImplementedException();
        }

        public bool Delete(Diploma entity)
        {
            FactoryDao.DiplomaDao.Delete(entity);
            throw new NotImplementedException();
        }

        public bool Update(Diploma entity)
        {
            FactoryDao.DiplomaDao.Update(entity);
            throw new NotImplementedException();
        }

        public Diploma GetById(long id)
        {
            return FactoryDao.DiplomaDao.GetById(id);
            throw new NotImplementedException();
        }

        public IList<Diploma> GetIList()
        {
            return FactoryDao.DiplomaDao.GetIList();
            throw new NotImplementedException();
        }

        public IList<Diploma> GetIListById(long id)
        {
            return FactoryDao.DiplomaDao.GetIListById(id);
            throw new NotImplementedException();
        }
    }
}
