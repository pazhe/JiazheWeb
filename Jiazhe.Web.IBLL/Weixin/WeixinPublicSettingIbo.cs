using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.IBLL.Weixin
{
    /// <summary>
    /// 业务逻辑接口：微信公众号 WeixinPublicSetting
    /// </summary>
    public interface WeixinPublicSettingIbo
    {
        bool Insert(Entity.Weixin.WeixinPublicSetting entity);

        bool Delete(Entity.Weixin.WeixinPublicSetting entity);

        bool Update(Entity.Weixin.WeixinPublicSetting entity);

        Entity.Weixin.WeixinPublicSetting GetById(long id);

        Entity.Weixin.WeixinPublicSetting GetByOriginalId(string originalId);

        IList<Entity.Weixin.WeixinPublicSetting> GetIList();
    }
}
