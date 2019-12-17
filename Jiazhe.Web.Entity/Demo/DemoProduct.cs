using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.Entity.Demo 
{
    /// <summary>
    /// Demo Product 实体对象
    /// </summary>
    public class DemoProduct : BaseEntity
    {
        /// <summary>
        /// ID
        /// </summary>
        public virtual long PId { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public virtual string PCode { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public virtual string PName { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        public virtual string PQuantityPerUnit { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        public virtual string PUnit { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        public virtual string PSellPrice { get; set; }

        /// <summary>
        /// 进价
        /// </summary>
        public virtual string PBuyPrice { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public virtual string PRemark { get; set; }
    }
}
