using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jiazhe.Web.IDAL
{
    public interface ManagerIDao
    {
        IList<VO.ManagersVO> GetAllUsers();
     
        bool AddUser(VO.ManagersVO mvo);
    }
}
