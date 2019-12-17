using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.IDAL.Taobao.Tbk
{
    public interface DiplomaIdao
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Insert(Entity.Taobao.Tbk.Diploma entity);

        /// <summary>
        /// 数据实现接口：删除选品库
        /// </summary>
        /// <param name="tfvo">参数：选品库对象（Entity.Taobao.Tbk.Favorites）</param>
        /// <returns>bool</returns>
        bool Delete(Entity.Taobao.Tbk.Diploma entity);

        /// <summary>
        /// 数据实现接口：更新选品库
        /// </summary>
        /// <param name="tfvo">参数：选品库对象（Entity.Taobao.Tbk.Favorites）</param>
        /// <returns>bool</returns>
        bool Update(Entity.Taobao.Tbk.Diploma entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">用户CId</param>
        /// <returns></returns>
        Entity.Taobao.Tbk.Diploma GetById(long id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IList<Entity.Taobao.Tbk.Diploma> GetIListById(long id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IList<Entity.Taobao.Tbk.Diploma> GetIList();
    }
}
