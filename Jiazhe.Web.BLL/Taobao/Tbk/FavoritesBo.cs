using System;
using System.Collections.Generic;
using Jiazhe.Web.Entity.Taobao.Tbk;
using Top.Api.Request;
using Top.Api.Response;

namespace Jiazhe.Web.BLL.Taobao.Tbk
{
    public class FavoritesBo : IBLL.Taobao.Tbk.FavoritesIbo
    {
        private FactoryDao.Taobao.Tbk.FavoritesFactoryDao FactoryDao { get; set; }

        public bool Insert(Favorites entity)
        {
            return FactoryDao.FavoritesDao.Insert(entity);
            throw new NotImplementedException();
        }

        public bool Delete(Favorites entity)
        {
            FactoryDao.FavoritesDao.Delete(entity);
            throw new NotImplementedException();
        }

        public bool Update(Favorites entity)
        {
            return FactoryDao.FavoritesDao.Update(entity);
            throw new NotImplementedException();
        }

        public Favorites GetById(long id)
        {
            return FactoryDao.FavoritesDao.GetById(id);

            throw new NotImplementedException();
        }

        //public IList<Favorites> GetIListById(long id)
        //{
        //    return FactoryDao.FavoritesDao.GetIListById(id);
        //    throw new NotImplementedException();
        //}

        public IList<Favorites> GetIList()
        {
            return FactoryDao.FavoritesDao.GetIList();
            throw new NotImplementedException();
        }

        public IList<Favorites> GetIList(long pageNo, long pageSize, Diploma diploma)
        {
            TbkUatmFavoritesGetResponse rsp = new TbkUatmFavoritesGetResponse();
            IList<Favorites> list = new List<Favorites>();
            rsp = GetByPageNoSize(pageNo, pageSize, diploma);
            if (rsp.TotalResults > 100)
            {
                list= AddToIlist(list,GetByPageNoSize(pageNo, pageSize, diploma));
                list = AddToIlist(list,GetByPageNoSize(pageNo + 1, pageSize, diploma));
            }else list = AddToIlist(list,GetByPageNoSize(pageNo, pageSize, diploma));
            return list;
            throw new NotImplementedException();
        }

        //public Favorites isExist(long FavoritesId)
        //{
        //    throw new NotImplementedException();
        //}


        public TbkUatmFavoritesGetResponse GetByPageNoSize(long pageNo,long pageSize, Diploma diploma)
        {
            TbkUatmFavoritesGetRequest req = new TbkUatmFavoritesGetRequest();
            req.PageNo = pageNo;//第几页，从1开始计数
            req.PageSize = pageSize;//默认20，页大小，即每一页的活动个数
            req.Fields = "favorites_title,favorites_id,type";//需要返回的字段列表，不能为空，字段名之间使用逗号分隔
            req.Type = 1L;//默认值-1；选品库类型，1：普通选品组，2：高佣选品组，-1，同时输出所有类型的选品组
            return Tools.Taobao.DefaultTopClient.Get(diploma.AppUrl, diploma.AppKey, diploma.AppSecret).Execute(req);
        }

        public Favorites GetFavorites(TbkUatmFavoritesGetResponse rsp, int row)
        {
            Favorites favorites = new Favorites();
            favorites.FavoritesId = rsp.Results[row].FavoritesId;
            favorites.FavoritesTitle = rsp.Results[row].FavoritesTitle;
            favorites.Type= rsp.Results[row].Type;
            favorites.TotalResults= rsp.TotalResults;
            return favorites;

        }

        public IList<Favorites> AddToIlist(IList<Favorites> list,TbkUatmFavoritesGetResponse rsp)
        {
            for (int row = 0; row < rsp.Results.Count; row++)
            {
                Favorites favorites = new Favorites();
                favorites.FavoritesId = rsp.Results[row].FavoritesId;
                favorites.FavoritesTitle = rsp.Results[row].FavoritesTitle;
                favorites.Type = rsp.Results[row].Type;
                favorites.TotalResults = rsp.TotalResults;
                list.Add(favorites);
            }
            return list;
        }

    }
}
