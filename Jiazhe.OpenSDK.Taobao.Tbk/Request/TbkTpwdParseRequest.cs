using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top.Api.Util;

namespace Top.Api.Request
{
    public class TbkTpwdParseRequest : BaseTopRequest<Top.Api.Response.TbkTpwdParseResponse>
    {
        public string PasswordContent { get; set; }

        #region ITopRequest Members

        public override string GetApiName()
        {
            return "taobao.tbk.tpwd.parse";
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("password_content", this.PasswordContent);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("password_content", this.PasswordContent);
        }
        #endregion
    }
}
