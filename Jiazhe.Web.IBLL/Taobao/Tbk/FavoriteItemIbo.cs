using Jiazhe.Web.Entity.Taobao.Tbk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.IBLL.Taobao.Tbk
{
    public interface FavoriteItemIbo
    {
        bool Insert(FavoriteItem entity);

        /// <summary>
        /// 数据实现接口：删除产品
        /// </summary>
        /// <param name="ivo">FavoriteItem</param>
        /// <returns></returns>
        bool Delete(FavoriteItem entity);

        bool Update(FavoriteItem entity);

        /// <summary>
        /// 数据实现接口：根据产品id来获取淘客产品
        /// </summary>
        /// <param name="NumIid">产品id：NumIid</param>
        /// <returns>淘宝客产品对象：FavoriteItem</returns>
        FavoriteItem GetByNumIid(long numIid);

        /// <summary>
        /// 数据实现接口：根据选品库id（FavoritesId）查找所有淘宝客产品
        /// </summary>
        /// <param name="FavoritesId">参数：选品库id（FavoritesId）</param>
        /// <returns>选品库商品集合（List:VO.ItemsTbkVO）</returns>
        IList<FavoriteItem> GetByFId(long fId);

        IList<FavoriteItem> GetIList(IList<Favorites> listFavorites, int row, long pageNo, long pageSize, long adzoneId, Diploma diploma);
        IList<FavoriteItem> GetIList(long favorites_id, long pageNo, long pageSize, long adzoneId, Diploma diploma);

    }
}
