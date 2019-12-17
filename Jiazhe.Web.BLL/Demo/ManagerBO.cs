using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jiazhe.Web.BLL
{
    public class ManagerBO: IBLL.ManagerIBO
    {
        private IDAL.ManagerIDao managerDao;

        public IDAL.ManagerIDao ManagerDao
        {
            get { return managerDao; }
            set { managerDao = value; }
        }
       
        public IList<VO.ManagersVO> GetAllUsers()
        {
            //IDAL.ManagerIDao ido = new DAL.ManagerDao();
            //ido.selectManagerById();
            //Console.Write( "执行业务");      
      
            //spring
            return managerDao.GetAllUsers();
        }

        public bool AddUser(VO.ManagersVO mvo)
        {
            return managerDao.AddUser(mvo);
        }

    }
}
