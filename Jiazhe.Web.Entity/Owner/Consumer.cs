using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.Entity.Owner
{
    /// <summary>
    /// 实体类：用户
    /// </summary>
    public class Consumer : BaseEntity
    {
        /// <summary>
        /// 字段:用户Id
        /// </summary>
        public virtual long CId{ get; set; }

        /// <summary>
        /// 字段：用户级别ID（外键）
        /// </summary>
        public virtual long LevelId { get; set; }

        /// <summary>
        /// 字段：用户名
        /// </summary>
        public virtual string CName { get; set; }

        /// <summary>
        /// 字段：用户密码
        /// </summary>
        public virtual string CPassword { get; set; }

        /// <summary>
        /// 字段：性别
        /// </summary>
        public virtual string CSex { get; set; }

        /// <summary>
        /// 字段：真实姓名
        /// </summary>
        public virtual string CRealName { get; set; }

        /// <summary>
        /// 字段：支付宝账号
        /// </summary>
        public virtual string CAlipay { get; set; }

        /// <summary>
        /// 字段：QQ号
        /// </summary>
        public virtual string CTencent { get; set; }

        /// <summary>
        /// 字段：邮箱
        /// </summary>
        public virtual string CEmail { get; set; }

        /// <summary>
        /// 字段：身份证号
        /// </summary>
        public virtual string CIdenCard { get; set; }

        /// <summary>
        /// 字段：手机号
        /// </summary>
        public virtual string CTelphone { get; set; }

        /// <summary>
        /// 字段：注册时间
        /// </summary>
        public virtual string CDate { get; set; }
    }
}
