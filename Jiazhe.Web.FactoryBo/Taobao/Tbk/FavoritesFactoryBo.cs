using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.FactoryBo.Taobao.Tbk
{
    public class FavoritesFactoryBo
    {
        public IBLL.Taobao.Tbk.FavoritesIbo FavoritesBo { get; set; }

        public IBLL.Taobao.Tbk.FavoritesIbo GetFavoritesBo()
        {
            return FavoritesBo;
        }

        public static FavoritesFactoryBo GetObject(string Object)
        {
            return
                (Jiazhe.Web.FactoryBo.Taobao.Tbk.FavoritesFactoryBo)
                Jiazhe.Web.FactoryBo.Factory.Context.GetContextRegistry.GetContext()
                .GetObject(Object);
        }
    }
}
