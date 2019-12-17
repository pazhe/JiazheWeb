using Jiazhe.Web.Entity.Taobao.Tbk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;
namespace Jiazhe.Web.Tools.Taobao.Tbk
{
    public class RequestApi
    {
        /// <summary>
        /// 获取选品库产品淘口令
        /// </summary>
        /// <param name="favoriteItem">参数：选品库产品</param>
        /// <param name="diploma">参数：淘宝API应用证书</param>
        /// <returns>返回：淘口令</returns>
        public string TpwdCreate(FavoriteItem favoriteItem, Diploma diploma)
        {
            try
            {
                TbkTpwdCreateRequest req = new TbkTpwdCreateRequest();
                if (favoriteItem.CouponClickUrl == null)
                    req.Url = favoriteItem.ClickUrl;
                else req.Url = favoriteItem.CouponClickUrl;
                req.Text = favoriteItem.Title;

                req.Logo = favoriteItem.PictUrl;
                req.Ext = "{}";
                TbkTpwdCreateResponse rsp = DefaultTopClient.Get(diploma.AppUrl, diploma.AppKey, diploma.AppSecret).Execute(req);
                return rsp.Data.Model;
            }
            catch
            {
                return "未开通淘客佣金";
            }
        }
        public string TbkTpwdParse(string TbkTpwd, Diploma diploma)
        {
            TbkTpwdParseRequest req = new TbkTpwdParseRequest();
            req.PasswordContent = "￥asaff￥";
            TbkTpwdParseResponse rsp = DefaultTopClient.Get(diploma.AppUrl, diploma.AppKey, diploma.AppSecret).Execute(req);
            return rsp.Data.Model;
        }
    }
}
