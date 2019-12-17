using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jiazhe.Web.IBLL
{
    public interface ManagerIBO
    {
        IList<VO.ManagersVO> GetAllUsers();
        bool AddUser(VO.ManagersVO mvo);
    }
}
