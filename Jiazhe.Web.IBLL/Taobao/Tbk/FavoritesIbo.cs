using Jiazhe.Web.Entity.Taobao.Tbk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Jiazhe.Web.IBLL.Taobao.Tbk
{
    public interface FavoritesIbo
    {

        //业务逻辑接口：添加淘宝客产品到数据库
        /// <summary>
        /// 业务逻辑接口：添加淘宝客产品到数据库
        /// </summary>
        /// <param name="eneity">参数：淘宝客选品库对象（Entity.Taobao.Tbk.Favorites）</param>
        /// <returns>返回：bool</returns>
        bool Insert(Entity.Taobao.Tbk.Favorites entity);

        //业务逻辑接口：删除淘宝客选品库
        /// <summary>
        /// 业务逻辑接口：删除淘宝客选品库
        /// </summary>
        /// <param name="eneity">参数：淘宝客选品库对象（Entity.Taobao.Tbk.Favorites）</param>
        /// <returns>返回：bool</returns>
        bool Delete(Entity.Taobao.Tbk.Favorites entity);

        //业务逻辑接口：更新淘宝客选品库
        /// <summary>
        /// 业务逻辑接口：更新淘宝客选品库
        /// </summary>
        /// <param name="eneity">参数：淘宝客选品库对象（Entity.Taobao.Tbk.Favorites）</param>
        /// <returns>返回：bool</returns>
        bool Update(Entity.Taobao.Tbk.Favorites entity);

        //业务逻辑接口：根据淘宝客选品库id（FavoritesId）判断是否存在
        /// <summary>
        /// 业务逻辑接口：根据淘宝客选品库id（FavoritesId）判断是否存在
        /// </summary>
        /// <param name="FavoritesId">参数：选品库id（FavoritesId）</param>
        /// <returns>返回：bool</returns>
        Entity.Taobao.Tbk.Favorites GetById(long id);

        //IList<Entity.Taobao.Tbk.Favorites> GetIListById(long id);



        //业务逻辑接口：根据DataGrid选中数据对象更新到数据库中
        /// <summary>
        /// 业务逻辑接口：根据DataGrid选中数据对象更新到数据库中
        /// </summary>
        /// <param name="favorites_title"></param>
        /// <param name="pb">参数：线程句柄</param>
        /// <param name="eneity">参数：淘宝客选品库对象（Entity.Taobao.Tbk.Favorites）</param>
        /// <param name="dg"></param>
        //void UpdateTaobaokeFavorites(string favorites_title, ProgressBar pb, Favorites eneity, DataGrid dg, System.Web.UI.Page page);

        //业务逻辑接口：获取淘宝客选品库对象集合
        /// <summary>
        ///业务逻辑接口：获取淘宝客选品库对象集合 
        /// </summary>
        /// <param name="tfvo">参数：淘宝客选品库对象（TaobaokeFavoritesVO）</param>
        /// <param name="rsp"></param>
        /// <param name="list"></param>
        /// <returns>淘宝客选品库对象List集合</returns>
        IList<Entity.Taobao.Tbk.Favorites> GetIList(long pageNo, long pageSize, Diploma diploma);

        IList<Entity.Taobao.Tbk.Favorites> GetIList();
    }
}
