using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.Entity.Taobao.Tbk
{
    /// <summary>
    /// 选品库
    /// </summary>
    public class Favorites
    {

        /// <summary>
        /// 主键
        /// </summary>
        public long FId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        public long CId { get; set; }

        /// <summary>
        /// 选品库类型，1：普通类型，2高佣金类型
        /// </summary>
        public long Type { get; set; }

        /// <summary>
        /// 选品库id
        /// </summary>
        public long FavoritesId { get; set; }

        /// <summary>
        /// 选品库组名称
        /// </summary>
        public string FavoritesTitle { get; set; }

        /// <summary>
        /// 选品库产品总数
        /// </summary>
        public long TotalResults { get; set; }
    }
}
