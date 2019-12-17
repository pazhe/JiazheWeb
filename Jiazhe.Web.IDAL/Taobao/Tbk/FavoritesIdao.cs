using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.IDAL.Taobao.Tbk
{
    public interface FavoritesIdao
    {
        //数据实现接口：添加选品库到数据库
        /// <summary>
        /// 数据实现接口：添加选品库到数据库
        /// </summary>
        /// <param name="fvo">参数：选品库对象Entity.Taobao.Tbk.Favorites</param>
        /// <returns>bool</returns>
        bool Insert(Entity.Taobao.Tbk.Favorites entity);

        //数据实现接口：删除选品库
        /// <summary>
        /// 数据实现接口：删除选品库
        /// </summary>
        /// <param name="tfvo">参数：选品库对象（Entity.Taobao.Tbk.Favorites）</param>
        /// <returns>bool</returns>
        bool Delete(Entity.Taobao.Tbk.Favorites entity);

        //数据实现接口：更新选品库
        /// <summary>
        /// 数据实现接口：更新选品库
        /// </summary>
        /// <param name="tfvo">参数：选品库对象（Entity.Taobao.Tbk.Favorites）</param>
        /// <returns>bool</returns>
        bool Update(Entity.Taobao.Tbk.Favorites entity);

        //数据实现接口：根据选品库id（FavoritesId） 获取选品库
        /// <summary>
        /// 数据实现接口：根据选品库FavoritesId 获取选品库
        /// </summary>
        /// <param name="FavoritesId">参数：选品库id（FavoritesId）</param>
        /// <returns>bool</returns>
        Entity.Taobao.Tbk.Favorites GetById(long id);

        IList<Entity.Taobao.Tbk.Favorites> GetIListById(long id);

        IList<Entity.Taobao.Tbk.Favorites> GetIList();
    }
}
