using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jiazhe.Web.Entity.Taobao.Tbk;
using Jiazhe.Web.Tools.Taobao;
using Top.Api.Request;
using Top.Api.Response;

namespace Jiazhe.Web.BLL.Taobao.Tbk
{
    /// <summary>
    /// 选品库产品 业务逻辑类
    /// </summary>
    public class FavoriteItemBo : IBLL.Taobao.Tbk.FavoriteItemIbo
    {
        private FactoryDao.Taobao.Tbk.FactoryDao FactoryDao { get; set; }

        public bool Insert(FavoriteItem entity)
        {
            return FactoryDao.FavoriteItemDao.Insert(entity);
            throw new NotImplementedException();
        }

        public bool Delete(FavoriteItem entity)
        {
            FactoryDao.FavoriteItemDao.Delete(entity);
            throw new NotImplementedException();
        }

        public bool Update(FavoriteItem entity)
        {
            return FactoryDao.FavoriteItemDao.Update(entity);
            throw new NotImplementedException();
        }

        public IList<FavoriteItem> GetByFId(long fId)
        {
            FactoryDao.FavoriteItemDao.GetByFId(fId);
            throw new NotImplementedException();
        }

        public FavoriteItem GetByNumIid(long numIid)
        {
            return FactoryDao.FavoriteItemDao.GetByNumIid(numIid);
            throw new NotImplementedException();
        }

        public IList<FavoriteItem> GetIList(IList<Favorites> listFavorites,int row,long pageNo, long pageSize, long adzoneId, Diploma diploma)
        {
            IList<FavoriteItem> list = new List<FavoriteItem>();
            TbkUatmFavoritesItemGetResponse rsp = 
                GetByPageNoSize(listFavorites[row].FavoritesId, pageNo, pageSize, adzoneId, diploma);
            if (rsp.TotalResults > 100)
            {
                list = AddToIlist(list, GetByPageNoSize(listFavorites[row].FavoritesId, pageNo, pageSize, adzoneId, diploma), listFavorites[row].FavoritesId);
                list = AddToIlist(list, GetByPageNoSize(listFavorites[row].FavoritesId, pageNo + 1, pageSize, adzoneId, diploma), listFavorites[row].FavoritesId);
            }
            else list = AddToIlist(list, GetByPageNoSize(listFavorites[row].FavoritesId, pageNo, pageSize, adzoneId, diploma), listFavorites[row].FavoritesId);
            return list;
        }

        public IList<FavoriteItem> GetIList(long favorites_id, long pageNo, long pageSize, long adzoneId, Diploma diploma)
        {
            IList<FavoriteItem> list = new List<FavoriteItem>();
            TbkUatmFavoritesItemGetResponse rsp = GetByPageNoSize(favorites_id, pageNo, pageSize, adzoneId, diploma);
            list = AddToIlist(list, rsp, favorites_id);
            return list;
        }

        public TbkUatmFavoritesItemGetResponse GetByPageNoSize(long favorites_id, long pageNo,long pageSize,long adzoneId, Diploma diploma)
        {
            
            TbkUatmFavoritesItemGetRequest req = new TbkUatmFavoritesItemGetRequest();
            req.Platform = 1;//链接形式：1：PC，2：无线，默认：１
            req.PageSize = pageSize;//页大小，默认20，1~100
            req.AdzoneId = adzoneId;//推广位id
            req.Unid = "3456";//自定义输入串，英文和数字组成，长度不能大于12个字符，区分不同的推广渠道
            req.FavoritesId = favorites_id;//选品库的id
            req.PageNo = pageNo;//第几页，默认：1，从1开始计数
            req.Fields = @"num_iid,title,pict_url,small_images,reserve_price,
                        zk_final_price,user_type,provcity,item_url,click_url,
                        nick,seller_id,volume,tk_rate,zk_final_price_wap,shop_title,
                        event_start_time,event_end_time,type,status,category,
                        coupon_click_url,coupon_end_time,coupon_info,coupon_start_time,
                        coupon_total_count,coupon_remain_count";
            return Tools.Taobao.DefaultTopClient.Get(diploma.AppUrl, diploma.AppKey, diploma.AppSecret).Execute(req);
        }

        public string TpwdCreate(string text, string url, string logo, Diploma diploma)
        {
            TbkTpwdCreateRequest req = new TbkTpwdCreateRequest();
            req.Text = text;
            req.Url = url;
            req.Logo = logo;
            req.Ext = "{}";
            TbkTpwdCreateResponse rsp = DefaultTopClient.Get(diploma.AppUrl, diploma.AppKey, diploma.AppSecret).Execute(req);
            return rsp.Data.Model;
        }
        public FavoriteItem GetFavoriteItem(TbkUatmFavoritesItemGetResponse rsp, int row, long favorites_id)
        {
            FavoriteItem favoriteItem = new FavoriteItem();
            favoriteItem.CId = 1;
            favoriteItem.FavoritesId = favorites_id;
            favoriteItem.NumIid = rsp.Results.ToList()[row].NumIid;
            favoriteItem.Title = rsp.Results.ToList()[row].Title;
            favoriteItem.PictUrl = rsp.Results.ToList()[row].PictUrl;
            //ivo.SmallImages = rsp.Results.ToList()[i].SmallImages;
            favoriteItem.ReservePrice = rsp.Results.ToList()[row].ReservePrice;
            favoriteItem.ZkFinalPrice = rsp.Results.ToList()[row].ZkFinalPrice;
            favoriteItem.UserType = rsp.Results.ToList()[row].UserType;
            favoriteItem.Provcity = rsp.Results.ToList()[row].Provcity;

            favoriteItem.ItemUrl = rsp.Results.ToList()[row].ItemUrl;
            favoriteItem.ClickUrl = rsp.Results.ToList()[row].ClickUrl;
            favoriteItem.Nick = rsp.Results.ToList()[row].Nick;
            favoriteItem.SellerId = rsp.Results.ToList()[row].SellerId;
            favoriteItem.Volume = rsp.Results.ToList()[row].Volume;
            favoriteItem.TkRate = rsp.Results.ToList()[row].TkRate;
            favoriteItem.ZkFinalPriceWap = rsp.Results.ToList()[row].ZkFinalPriceWap;

            favoriteItem.ShopTitle = rsp.Results.ToList()[row].ShopTitle;
            favoriteItem.EventStartTime = rsp.Results.ToList()[row].EventStartTime;
            favoriteItem.EventEndTime = rsp.Results.ToList()[row].EventEndTime;
            favoriteItem.Type = rsp.Results.ToList()[row].Type;
            favoriteItem.Status = rsp.Results.ToList()[row].Status;
            favoriteItem.Category = rsp.Results.ToList()[row].Category;
            favoriteItem.CouponClickUrl = rsp.Results.ToList()[row].CouponClickUrl;

            favoriteItem.CouponEndTime = rsp.Results.ToList()[row].CouponEndTime;
            favoriteItem.CouponInfo = rsp.Results.ToList()[row].CouponInfo;
            favoriteItem.CouponStartTime = rsp.Results.ToList()[row].CouponStartTime;
            favoriteItem.CouponTotalCount = rsp.Results.ToList()[row].CouponTotalCount;
            favoriteItem.CouponRemainCount = rsp.Results.ToList()[row].CouponRemainCount;
            favoriteItem.Model = "";
            return favoriteItem;

        }

        public IList<FavoriteItem> AddToIlist(IList<FavoriteItem> list, TbkUatmFavoritesItemGetResponse rsp, long favorites_id)
        {
            for (int row = 0; row < rsp.Results.Count; row++)
            {
                list.Add(GetFavoriteItem(rsp,row,favorites_id));
            }
            return list;
        }
    }
}
