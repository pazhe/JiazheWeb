using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.Entity.Weixin
{
    /// <summary>
    /// 实体类：微信公众号
    /// </summary>
    public class WeixinPublicSetting : BaseEntity
    {
        /// <summary>
        /// 字段：公众号id（主键自动增长）
        /// </summary>
        public virtual long WxId { get; set; }

        /// <summary>
        /// 字段：用户id（外键）
        /// </summary>
        public virtual long CId { get; set; }

        /// <summary>
        /// 字段：微信名称
        /// </summary>
        public virtual string WxName { get; set; }

        /// <summary>
        /// 字段：微信号
        /// </summary>
        public virtual string WxNumber { get; set; }

        /// <summary>
        /// 字段：微信类型
        /// </summary>
        public virtual string WxType { get; set; }

        /// <summary>
        /// 字段：微信登录邮箱
        /// </summary>
        public virtual string WxEmali { get; set; }

        /// <summary>
        /// 字段：原始id
        /// </summary>
        public virtual string WxOriginalId { get; set; }
    }
}
