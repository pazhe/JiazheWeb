using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.Entity.Weixin
{
    /// <summary>
    /// 实体类 ：微信公众号开发基本配置
    /// </summary>
    public class WeixinBaseConfigure
    {
        /// <summary>
        /// 字段 ：主键
        /// </summary>
        public virtual long WxcId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public virtual long WxId { get; set; }

        /// <summary>
        /// 开发者ID(AppID)
        /// </summary>
        public virtual string WxAppId { get; set; }

        /// <summary>
        /// 开发者密码(AppSecret)
        /// </summary>
        public virtual string WxAppSecret { get; set; }

        /// <summary>
        /// 服务器地址（Url）
        /// </summary>
        public virtual string WxServicesUrl { get; set; }

        /// <summary>
        /// 令牌(Token)
        /// </summary>
        public virtual string WxServerToken { get; set; }

        /// <summary>
        /// 消息加解密密钥(EncodingAESKey)
        /// </summary>
        public virtual string WxEncodingAESKey { get; set; }

        /// <summary>
        /// 消息加解密方式
        /// </summary>
        public virtual string WxEncodingType { get; set; }

        /// <summary>
        /// 是否通过
        /// </summary>
        public virtual long WxIsFlag { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public virtual string WxBeginDate { get; set; }

        /// <summary>
        /// 有效时间
        /// </summary>
        public virtual string WxStopDate { get; set; }
    }
}
