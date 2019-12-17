using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.FactoryBo.Taobao.Tbk
{
    public class DiplomaFactoryBo
    {
        public IBLL.Taobao.Tbk.DiplomaIbo DiplomaBo { get; set; }

        public IBLL.Taobao.Tbk.DiplomaIbo GetDiplomaBo()
        {
            return DiplomaBo;
        }

        public static DiplomaFactoryBo GetObject(string Object)
        {
            return
                (Jiazhe.Web.FactoryBo.Taobao.Tbk.DiplomaFactoryBo)
                Jiazhe.Web.FactoryBo.Factory.Context.GetContextRegistry.GetContext()
                .GetObject(Object);
        }
    }
}
