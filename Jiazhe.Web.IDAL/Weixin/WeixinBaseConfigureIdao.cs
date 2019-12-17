using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.IDAL.Weixin
{
    public interface WeixinBaseConfigureIdao
    { 
        /// <summary>
      /// 数据访问接口：添加微信公众号开发基本配置
      /// </summary>
      /// <param name="entity"></param>
      /// <returns></returns>
        bool Insert(Entity.Weixin.WeixinBaseConfigure entity);

        /// <summary>
        /// 数据访问接口：删除微信公众号开发基本配置
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(Entity.Weixin.WeixinBaseConfigure entity);

        /// <summary>
        /// 数据访问接口：修改微信公众号开发基本配置
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Update(Entity.Weixin.WeixinBaseConfigure entity);

        /// <summary>
        /// 数据访问接口：根据id查找微信公众号开发基本配置
        /// </summary>
        /// <param name="id"></param>
        /// <returns>单个实体</returns>
        Entity.Weixin.WeixinBaseConfigure GetById(long id);

        IList<Entity.Weixin.WeixinBaseConfigure> GetIListById(long id);

        /// <summary>
        /// 数据访问接口：查找所有微信公众号开发基本配置
        /// </summary>
        /// <returns></returns>
        IList<Entity.Weixin.WeixinBaseConfigure> GetIList();
    }
}
