using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.FactoryBo.Taobao.Tbk
{
    public class FactoryBo
    {
        public static FactoryBo GetObject(string Object)
        {
            return
                (Jiazhe.Web.FactoryBo.Taobao.Tbk.FactoryBo)
                Jiazhe.Web.FactoryBo.Factory.Context.GetContextRegistry.GetContext()
                .GetObject(Object);
        }
        public IBLL.Taobao.Tbk.DiplomaIbo DiplomaBo { get; set; }
        public IBLL.Taobao.Tbk.FavoritesIbo FavoritesBo { get; set; }
        public IBLL.Taobao.Tbk.FavoriteItemIbo FavoriteItemBo { get; set; }
    }
}
