using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.IDAL.Weixin
{
    /// <summary>
    /// 数据访问接口:WeixinPublicSetting 微信公众号
    /// </summary>
    public interface WeixinPublicSettingIdao
    {
        /// <summary>
        /// 数据访问接口：添加微信公众号
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Insert(Entity.Weixin.WeixinPublicSetting entity);

        /// <summary>
        /// 数据访问接口：删除微信公众号
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(Entity.Weixin.WeixinPublicSetting entity);

        /// <summary>
        /// 数据访问接口：修改微信公众号
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Update(Entity.Weixin.WeixinPublicSetting entity);

        /// <summary>
        /// 数据访问接口：根据id查找微信公众号
        /// </summary>
        /// <param name="id"></param>
        /// <returns>单个实体</returns>
        Entity.Weixin.WeixinPublicSetting GetById(long id);

        Entity.Weixin.WeixinPublicSetting GetByOriginalId(string originalId);

        /// <summary>
        /// 数据访问接口：查找所有微信公众号
        /// </summary>
        /// <returns></returns>
        IList<Entity.Weixin.WeixinPublicSetting> GetIList();
    }
}
