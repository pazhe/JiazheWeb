using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.Entity.Taobao.Tbk
{
    /// <summary>
    /// 淘宝API应用证书
    /// </summary>
    public class Diploma
    {
        /// <summary>
        /// 主键
        /// </summary>
        public long DId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public long CId { get; set; }

        /// <summary>
        /// API服务地址
        /// </summary>
        public string AppUrl { get; set; }

        /// <summary>
        /// APP证书：App Key
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// APP证书：App Secret
        /// </summary>
        public string AppSecret { get; set; }
    }
}
