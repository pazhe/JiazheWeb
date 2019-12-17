using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.IBLL.Taobao.Tbk
{
    public interface DiplomaIbo
    {
        bool Insert(Entity.Taobao.Tbk.Diploma entity);

        bool Delete(Entity.Taobao.Tbk.Diploma entity);

        bool Update(Entity.Taobao.Tbk.Diploma entity);

        Entity.Taobao.Tbk.Diploma GetById(long id);

        IList<Entity.Taobao.Tbk.Diploma> GetIListById(long id);

        IList<Entity.Taobao.Tbk.Diploma> GetIList();
    }
}
