using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jiazhe.Web.Entity.Owner;

namespace Jiazhe.Web.BLL.Owner
{
    public class ConsumerBo : IBLL.Owner.ConsumerIbo
    {

        private FactoryDao.Owner.ConsumerFactoryDao FactoryDao { get; set; }

        #region 业务逻辑接口实现
        public bool InsertConsumer(Consumer entity)
        {
            return FactoryDao.GetConsumerDao().InsertConsumer(entity);
            throw new NotImplementedException();
        }

        public bool DeleteConsumer(Consumer entity)
        {
            FactoryDao.GetConsumerDao().DeleteConsumer(entity);
            throw new NotImplementedException();
        }

        public bool UpdateConsumer(Consumer entity)
        {
            FactoryDao.GetConsumerDao().UpdateConsumer(entity);
            throw new NotImplementedException();
        }

        public Consumer GetConsumerById(long id)
        {
            FactoryDao.GetConsumerDao().GetConsumerById(id);
            throw new NotImplementedException();
        }

        public Consumer GetConsumerIsExist(string name, string pwd)
        {
            try
            {
                return FactoryDao.GetConsumerDao().GetConsumerIsExist(name, pwd);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public bool GetConsumerIsExist(Consumer entity)
        {
            throw new NotImplementedException();
        }

        public IList<Consumer> GetConsumerList()
        {
            return FactoryDao.GetConsumerDao().GetConsumerList();
            throw new NotImplementedException();
        }
        #endregion

        #region 自定义业务逻辑
        public bool ConsumerLogin(Consumer entity)
        {
            if (GetConsumerIsExist(entity.CName, entity.CPassword) != null)
                return true;
            else
                return false;
        }

        #endregion

    }
}
