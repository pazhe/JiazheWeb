using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using VO;
using Jiazhe.Web.IDAL;
using NHibernate.Criterion;
using NHibernate.Linq;
using Spring.Data.NHibernate.Support;
using NHibernate.Cfg;


namespace Jiazhe.Web.DAL
{
    [Spring.Stereotype.Repository]
    public class NHibernateDao<T>:IDAL.IdaoFather<T>
    {
        public ISessionFactory SessionFactory { get; set; }
        /// <summary>
        /// 获取Session
        /// </summary>
        public ISession Session
        {
            get
            {
                return SessionFactory.GetCurrentSession();
            }
        }

        /// <summary>
        /// 当前实体对应的表名
        /// </summary>
        public string TableName
        {
            get { return typeof(T).ToString().Substring(typeof(T).ToString().LastIndexOf('.') + 1); }
        }
        /// <summary>
        /// 添加实体
        /// </summary>
        /// <param name="entity"></param>
        public int Add(T entity)
        {
            using (ITransaction transaction = Session.BeginTransaction())
            {
                try
                {
                    int id = (int)Session.Save(entity);
                    Session.Flush();
                    transaction.Commit();
                    return id;
                }
                catch (HibernateException)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// 修改实体
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            using (ITransaction transaction = Session.BeginTransaction())
            {
                try
                {
                    Session.Update(entity);
                    Session.Flush();
                    transaction.Commit();
                }
                catch (HibernateException)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        /// <summary>
        /// 保存或修改实体
        /// </summary>
        /// <param name="customer"></param>
        public void SaveOrUpdate(IList<T> list)
        {
            using (ITransaction transaction = Session.BeginTransaction())
            {
                try
                {
                    foreach (var entity in list)
                    {
                        Session.SaveOrUpdate(entity);
                    }
                    Session.Flush();
                    transaction.Commit();
                }
                catch (HibernateException)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            using (ITransaction transaction = Session.BeginTransaction())
            {
                try
                {
                    Session.Delete(entity);
                    Session.Flush();
                    transaction.Commit();
                }
                catch (HibernateException)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// 按条件删除
        /// </summary>
        /// <param name="sqlWhere">删除条件</param>
        public void Delete(string sqlWhere)
        {
            using (ITransaction transaction = Session.BeginTransaction())
            {
                try
                {
                    Session.Delete(string.Format("from {0} Where {1}", TableName, sqlWhere));
                    Session.Flush();
                    transaction.Commit();
                }
                catch (HibernateException)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// 根据ID得到实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T Get(int id)
        {
            return Session.Get<T>(id);
        }
        /// <summary>
        /// 根据ID得到实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T Load(int id)
        {
            return Session.Load<T>(id);
        }
        /// <summary>
        /// 得到所有实体
        /// </summary>
        /// <returns></returns>
        public IList<T> LoadAll()
        {
            return Session.Query<T>().ToList();
        }

        /// <summary>
        /// 按条件排序得到前N条记录
        /// </summary>
        /// <param name="top">获取条数</param>
        /// <param name="field">排序字段</param>
        /// <param order="field">排序方式，升序asc,降序desc</param>
        /// <returns></returns>
        public IList<T> QueryTop(int top, string field, string order)
        {
            if (order == "asc")
            {
                return Session.CreateCriteria(typeof(T)).SetMaxResults(top).AddOrder(Order.Asc(field)).List<T>();
            }
            else
            {
                return Session.CreateCriteria(typeof(T)).SetMaxResults(top).AddOrder(Order.Desc(field)).List<T>();
            }
        }

        /// <summary>
        /// 根据条件得到实体
        /// </summary>
        /// <param name="sqlWhere">查询条件</param>
        /// <returns></returns>
        public IList<T> Where(string sqlWhere)
        {
            StringBuilder strSql = new StringBuilder(string.Format("from {0} c", TableName));
            if (!string.IsNullOrEmpty(sqlWhere))
            {
                strSql.Append(string.Format(" where {0}", sqlWhere));
            }
            return Session.CreateQuery(strSql.ToString()).List<T>();
        }

        /// <summary>
        /// 得到统计数量
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <returns></returns>
        public int GetRecordCount(string sqlWhere)
        {
            StringBuilder strSql = new StringBuilder(string.Format("select count(1) from {0} c", TableName));
            if (!string.IsNullOrEmpty(sqlWhere))
            {
                strSql.Append(string.Format(" where {0}", sqlWhere));
            }
            return (int)Session.CreateSQLQuery(strSql.ToString()).UniqueResult();
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        /// <param name="PageSize">每页获取数据条数</param>
        /// <param name="PageIndex">当前页是第几页</param>
        /// <param name="strWhere">查询条件</param>
        /// <returns></returns>
        public IList<T> GetPageList(int PageSize, int PageIndex, string sqlWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(string.Format("select top {0} * from {1} where ID not in(select top  ", PageSize,
                TableName));
            strSql.Append(PageSize * (PageIndex - 1));
            strSql.Append(string.Format(" ID from {0}", TableName));
            if (!string.IsNullOrEmpty(sqlWhere))
            {
                strSql.Append(string.Format(" where {0} ) and {0}", sqlWhere));
            }
            else
            {
                strSql.Append(")");
            }
            return Session.CreateSQLQuery(strSql.ToString()).AddEntity(typeof(T)).List<T>();
        }

        /// <summary>
        /// 根据数据字典父编码和编码获取名称
        /// </summary>
        /// <param name="parentNumber">父编码</param>
        /// <param name="number">编码</param>
        /// <returns></returns>
        public string GetName(string parentNumber, string number)
        {
            //string[] num = number.Split(',');
            //List<string> list = new List<string>();
            //list.AddRange(num);
            //IQueryable<string> name = from q in Session.Query<T_Dictionary>()
            //                          where q.ParentNumber == parentNumber && list.Contains(q.Number)
            //                          orderby q.Number
            //                          select q.Name;
            //string nameStr = "";
            //foreach (string n in name)
            //{
            //    nameStr += n + ",";
            //}
            //return nameStr.Contains(",") ? nameStr.Substring(0, nameStr.Length - 1) : nameStr;
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取该父编码下最大编码
        /// </summary>
        /// <param name="parentNumber">父编码</param>
        /// <returns></returns>
        public int GetMaxNumber(string parentNumber)
        {
            string strSql =
                string.Format(
                    "select case when MAX(cast(substring(Number,len(Number)-3,4) as int)) is null then 0 else MAX(cast(substring(Number,len(Number)-3,4) as int)) end  from {0} where ParentNumber='{1}'",
                    TableName, parentNumber);
            return ++Session.CreateQuery(strSql).List<int>()[0];
        }
    }
}
