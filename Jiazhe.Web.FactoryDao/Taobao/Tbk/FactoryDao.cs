using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.FactoryDao.Taobao.Tbk
{
    public class FactoryDao
    {
        public IDAL.Taobao.Tbk.DiplomaIdao DiplomaDao { get; set; }
        public IDAL.Taobao.Tbk.FavoritesIdao FavoritesDao { get; set; }
        public IDAL.Taobao.Tbk.FavoriteItemIdao FavoriteItemDao { get; set; }
    }
}
