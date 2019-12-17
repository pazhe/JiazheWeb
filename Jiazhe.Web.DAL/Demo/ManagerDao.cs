using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Spring.Data.NHibernate.Generic.Support;
using Spring.Data.NHibernate.Generic;
namespace Jiazhe.Web.DAL.Demo
{
    public class ManagerDao : HibernateDaoSupport, IDAL.ManagerIDao
    {
        public IList<VO.ManagersVO> GetAllUsers()
        {
           return HibernateTemplate.LoadAll<VO.ManagersVO>();
            //return "执行查询语句";
        
        }

        public bool AddUser(VO.ManagersVO mvo)
        {
            //if (HibernateTemplate.Save(mvo) != null)
            //{
            //    return true;
            //}

            HibernateTemplate.Update(mvo);

            return true;
        }
    }
}
