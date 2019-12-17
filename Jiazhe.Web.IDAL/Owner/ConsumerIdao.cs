﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiazhe.Web.IDAL.Owner
{
    /// <summary>
    /// 数据访问接口：Consumer 用户
    /// </summary>
    public interface ConsumerIdao
    {
        /// <summary>
        /// 数据访问接口：添加用户
        /// </summary>
        /// <param name="entity">参数：实体对象（Consumer：用户）</param>
        /// <returns></returns>
        bool InsertConsumer(Entity.Owner.Consumer entity);

        /// <summary>
        /// 数据访问接口：删除用户
        /// </summary>
        /// <param name="entity">参数：实体对象（Consumer：用户）</param>
        /// <returns></returns>
        bool DeleteConsumer(Entity.Owner.Consumer entity);

        /// <summary>
        /// 数据访问接口：修改用户
        /// </summary>
        /// <param name="entity">参数：实体对象（Consumer：用户）</param>
        /// <returns></returns>
        bool UpdateConsumer(Entity.Owner.Consumer entity);

        /// <summary>
        /// 数据访问接口：查找用户根据id
        /// </summary>
        /// <param name="id">参数：用户id</param>
        /// <returns></returns>
        Entity.Owner.Consumer GetConsumerById(long id);

        /// <summary>
        /// 数据访问接口：查找用户根据用户名密码
        /// </summary>
        /// <param name="name">参数：用户名</param>
        /// <param name="pwd">参数：密码</param>
        /// <returns>返回：实体对象（Consumer：用户）</returns>
        Entity.Owner.Consumer GetConsumerIsExist(string name, string pwd);

        /// <summary>
        /// 数据访问接口：查找所有用户
        /// </summary>
        /// <returns>返回：实体集合对象（IList）</returns>
        IList<Entity.Owner.Consumer> GetConsumerList();
    }
}
