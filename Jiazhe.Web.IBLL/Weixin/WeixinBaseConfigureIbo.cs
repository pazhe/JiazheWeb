using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.IBLL.Weixin
{
    /// <summary>
    /// 业务逻辑接口 ：微信公众号开发基本配置
    /// </summary>
    public interface WeixinBaseConfigureIbo
    {
        bool Insert(Entity.Weixin.WeixinBaseConfigure entity);

        bool Delete(Entity.Weixin.WeixinBaseConfigure entity);

        bool Update(Entity.Weixin.WeixinBaseConfigure entity);

        Entity.Weixin.WeixinBaseConfigure GetById(long id);

        IList<Entity.Weixin.WeixinBaseConfigure> GetIListById(long id);

        IList<Entity.Weixin.WeixinBaseConfigure> GetIList();
    }
}
