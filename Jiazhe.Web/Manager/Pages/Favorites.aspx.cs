using Jiazhe.Web.Entity.Taobao.Tbk;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Top.Api.Response;

namespace Jiazhe.Web.Manager.Pages
{
    public partial class Favorites : System.Web.UI.Page
    {
        private Entity.Owner.Consumer consumer = new Entity.Owner.Consumer();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!this.IsPostBack)
            {
                if (this.Session["Consumer"] == null)
                {
                    this.Response.Redirect("../Login.aspx");
                }
                else
                {
                    lblConsumerName.Text = consumer.CName;
                    BindToDataGrid(1,200);
                }
            }
        }

        /// <summary>
        /// DataGrid 初始化数据
        /// </summary>
        public void BindToDataGrid(long pageNum,long pageSize)
        {
            consumer = (Entity.Owner.Consumer)this.Session["Consumer"];
            IList<Entity.Taobao.Tbk.Favorites> list =
                FactoryBo.Taobao.Tbk.FavoritesFactoryBo.GetObject("FavoritesBoFactory")
                .FavoritesBo.GetIList(pageNum, pageSize,
                FactoryBo.Taobao.Tbk.DiplomaFactoryBo.GetObject("DiplomaBoFactory")
                .DiplomaBo.GetById(consumer.CId));

            //list=list.OrderByDescending(a=>a.FavoritesId).ToList();//降序
            //list=list.OrderBy(a => a.FavoritesId).ToList();//升序
            this.DataGrid1.DataSource = list.OrderBy(a => a.FavoritesId).ToList();
            this.DataGrid1.PageSize =int.Parse(pageSize.ToString());
            DataGrid1.DataBind();
        }

        #region CheckBox 全选事件

        //DataGrid全选事件调用全选方法
        /// <summary>
        /// DataGrid全选事件调用全选方法
        /// </summary>
        /// <param name="sender"></param>
        public void DataGridCheckBoxSelectAll(object sender)
        {
            CheckBox obj = (CheckBox)sender;
            if (obj.Checked) { CheckBoxSelectAll(true); }
            else { CheckBoxSelectAll(false); }
        }

        //遍历循环 DataGrid中的CheckBox控件 并赋值
        /// <summary>
        ///遍历循环 DataGrid中的CheckBox控件 并赋值
        /// </summary>
        /// <param name="isTrue">bool</param>
        public void CheckBoxSelectAll(bool isTrue)
        {
            for (int i = 0; i < this.DataGrid1.Items.Count; i++)
            {
                ((CheckBox)this.DataGrid1.Items[i].FindControl("chkSelect")).Checked = isTrue;
            }
        }

        //DataGrid中的CheckBox控件Checked发生变化激发全选事件
        /// <summary>
        /// DataGrid中的CheckBox控件Checked发生变化激发全选事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            DataGridCheckBoxSelectAll(sender);
        }

        #endregion

        #region DataGrid 控件事件

        //单独更新产品库产品
        /// <summary>
        /// 单独更新产品库产品
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void DataGrid1_UpdateCommand(object source, DataGridCommandEventArgs e)
        {
            //long favorites_id = long.Parse(e.Item.Cells[0].Text);//获取对应的选品库id
            //string favorites_title = e.Item.Cells[1].Text;//获取对应的选品组名称
            //UpdateTaobaokeItemsByFavoritesId(favorites_id, favorites_title);//调用业方法
            //HttpContext.Current.Response.Write(favorites_title + "更新完成...<br/>");
        }

        //分页
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void DataGrid1_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            this.DataGrid1.CurrentPageIndex = e.NewPageIndex;
            BindToDataGrid(1, DataGrid1.PageSize);
        }

        //鼠标移动变色
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DataGrid1_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                e.Item.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#ccc'");
                e.Item.Attributes.Add("onmouseout", "c=this.style.backgroundColor=c");
            }
        }

        //排序
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        protected void DataGrid1_SortCommand(object source, DataGridSortCommandEventArgs e)
        {
            if (ViewState["Order"] == null)
            {
                ViewState["Order"] = "ASC";
            }
            else
            {
                if (ViewState["Order"].ToString() == "ASC")
                {
                    ViewState["Order"] = "DESC";
                }
                else
                {
                    ViewState["Order"] = "ASC";
                }
            }

            //TbkUatmFavoritesGetRequest req = new TbkUatmFavoritesGetRequest();
            //req.PageNo = 1L;//第几页，从1开始计数
            //req.PageSize = 200;//默认20，页大小，即每一页的活动个数
            //req.Fields = "favorites_title,favorites_id,type";//需要返回的字段列表，不能为空，字段名之间使用逗号分隔
            //req.Type = 1L;//默认值-1；选品库类型，1：普通选品组，2：高佣选品组，-1，同时输出所有类型的选品组
            //TbkUatmFavoritesGetResponse rsp = Tools.GetAppkeyTaoke.GetClient().Execute(req);
            //Console.WriteLine(rsp.Body);
            //HttpContext.Current.Response.Write(rsp.Body);
            //rsp.Results.Sort();
            //DataGrid1.DataSource = rsp.Results;
            //DataGrid1.DataBind();
        }

        #endregion

        /// <summary>
        /// 批量更新选品库到数据库中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void updateAllFavorites_Click(object sender, EventArgs e)
        {
            Tools.Base.ProgressBar pb = new Tools.Base.ProgressBar(this);
            IList<Entity.Taobao.Tbk.Favorites> list = new List<Entity.Taobao.Tbk.Favorites>();
            
            string favorites_title = "开始更新选品库......";
            for (int i = 0; i < DataGrid1.Items.Count; i++)
            {
                CheckBox chk = (CheckBox)DataGrid1.Items[i].FindControl("chkSelect");
                if (chk.Checked == true)
                {
                    Entity.Taobao.Tbk.Favorites favorites = new Entity.Taobao.Tbk.Favorites();
                    favorites.CId= ((Entity.Owner.Consumer)this.Session["Consumer"]).CId;
                    favorites.FavoritesId= long.Parse(DataGrid1.Items[i].Cells[0].Text); ;
                    favorites.FavoritesTitle = DataGrid1.Items[i].Cells[1].Text; ;
                    favorites.Type = long.Parse(DataGrid1.Items[i].Cells[2].Text);
                    favorites.TotalResults = 200;
                    list.Add(favorites);
                }
            }

            pb.SetMaxValue(list.Count);
            pb.InitProgress();
            pb.SetTitle("开始更新选品库.......");
            pb.SetHeader(favorites_title);

            //IsTotalResultsNumber(pb, tfvo, list);
            for (int i = 0; i < list.Count; i++)
            {
                long favorites_id = list[i].FavoritesId;//获取对应的选品库id
                favorites_title = list[i].FavoritesTitle;//获取对应的选品组名称

                pb.AddProgress(1);
                //此处用线程休眠代替实际的操作，如加载数据等
                System.Threading.Thread.Sleep(int.Parse(ConfigurationManager.AppSettings["ProgressBarSleep"].ToString()));
                //IsUpdateOrInsertFavorites(favorites_id, favorites, i, list);
                Entity.Taobao.Tbk.Favorites favorites = FactoryBo.Taobao.Tbk.FavoritesFactoryBo.GetObject("FavoritesBoFactory")
                .FavoritesBo.GetById(favorites_id);
                if (favorites==null)
                {
                    
                    FactoryBo.Taobao.Tbk.FavoritesFactoryBo.GetObject("FavoritesBoFactory")
                                    .FavoritesBo.Insert(list[i]);
                }
                else {
                    list[i].FId = favorites.FId;
                    FactoryBo.Taobao.Tbk.FavoritesFactoryBo.GetObject("FavoritesBoFactory")
                                  .FavoritesBo.Update(list[i]);
                                  }

                pb.SetTitle("数据加载中......" + (i + 1) + "/" + list.Count);
                pb.SetHeader("开始更新选品库.......【" + favorites_title + "】");
            }

            pb.DisponseProgress();

        }

        protected void updateAllFavoritesItems_Click(object sender, EventArgs e)
        {
            Tools.Base.ProgressBar pb = new Tools.Base.ProgressBar(this);// 新建线程
            IList<Entity.Taobao.Tbk.Favorites> listFavorites = new List<Entity.Taobao.Tbk.Favorites>();
            IList<FavoriteItem> listFavoriteItem = new List<FavoriteItem>();
            consumer = (Entity.Owner.Consumer)this.Session["Consumer"];

            //被选中的 选品库集合
            for (int i = 0; i < DataGrid1.Items.Count; i++)
            {
                CheckBox chk = (CheckBox)DataGrid1.Items[i].FindControl("chkSelect");
                if (chk.Checked == true)
                {
                    //list.Add(GetTaobaokeFavoritesCheckBoxSelectList(tfvo, i, dg));
                    Entity.Taobao.Tbk.Favorites favorites = new Entity.Taobao.Tbk.Favorites();
                    favorites.CId = ((Entity.Owner.Consumer)this.Session["Consumer"]).CId;
                    favorites.FavoritesId = long.Parse(DataGrid1.Items[i].Cells[0].Text); ;
                    favorites.FavoritesTitle = DataGrid1.Items[i].Cells[1].Text; ;
                    favorites.Type = long.Parse(DataGrid1.Items[i].Cells[2].Text);
                    favorites.TotalResults = 200;
                    listFavorites.Add(favorites);
                }
            }

            if (listFavorites.Count > 0)
            {
                pb.InitProgress();
                pb.SetTitle("开始更新选品库.......");

                //获取选品库List 集合
                for (int i = 0; i < listFavorites.Count; i++)
                {//循环遍历选中项
                    pb.SetHeader("开始更新选品库......." + listFavorites[i].FavoritesTitle);
                    listFavoriteItem =FactoryBo.Taobao.Tbk.FactoryBo.GetObject("FavoriteItemBoFactory")
                        .FavoriteItemBo.GetIList(listFavorites, i, 1, 100, 42120264,
                        FactoryBo.Taobao.Tbk.DiplomaFactoryBo.GetObject("DiplomaBoFactory").DiplomaBo.GetById(consumer.CId));

                    pb.SetMaxValue(listFavoriteItem.Count);
                    pb.SetThisValue(0);
                    System.Threading.Thread.Sleep(int.Parse(ConfigurationManager.AppSettings["ProgressBarSleep"].ToString()));
                    //IsTotalResultsNumber(pb, list[i].FavoritesId, rsp);

                    for (int row=0; row< listFavoriteItem.Count; row++)
                    {
                        pb.AddProgress(1);
                        System.Threading.Thread.Sleep(int.Parse(ConfigurationManager.AppSettings["ProgressBarSleep"].ToString()));
                        FavoriteItem favoriteItem = new FavoriteItem();
                        //判断数据库中是否存在该产品 如果存在就进行更新操作
                        if (FactoryBo.Taobao.Tbk.FactoryBo.GetObject("FavoriteItemBoFactory")
                        .FavoriteItemBo.GetByNumIid(listFavoriteItem[row].NumIid) != null)
                        {
                            //主键赋值
                            listFavoriteItem[row].IId = FactoryBo.Taobao.Tbk.FactoryBo.GetObject("FavoriteItemBoFactory")
                        .FavoriteItemBo.GetByNumIid(listFavoriteItem[row].NumIid).IId;
                            //淘口令生成
                            listFavoriteItem[row].Model = (new Tools.Taobao.Tbk.RequestApi())
                                .TpwdCreate(listFavoriteItem[row],
                                FactoryBo.Taobao.Tbk.DiplomaFactoryBo.GetObject("DiplomaBoFactory").DiplomaBo.GetById(consumer.CId));

                            FactoryBo.Taobao.Tbk.FactoryBo.GetObject("FavoriteItemBoFactory")
                        .FavoriteItemBo.Update(listFavoriteItem[row]);
                        }
                        else
                        {//如果不存在就进行插入操作
                            FactoryBo.Taobao.Tbk.FactoryBo.GetObject("FavoriteItemBoFactory")
                        .FavoriteItemBo.Insert(listFavoriteItem[row]);

                        }
                        pb.SetTitle("数据加载中......" + (row + 1) + "/" + listFavoriteItem.Count);
                    }
                }
                pb.DisponseProgress();
            }

        }

        protected void ddlPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}