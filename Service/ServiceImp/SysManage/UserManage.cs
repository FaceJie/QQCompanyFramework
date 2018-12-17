﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceImp
{
    public class UserManage : RepositoryBase<Orm.User>, IService.IUserManage
    {
        /// <summary>
        /// 管理用户登录验证
        /// </summary>
        /// <param name="useraccount">用户名</param>
        /// <param name="password">加密密码（AES）</param>
        /// <returns></returns>
        public Orm.User UserLogin(string useraccount, string password)
        {

            return null;
        }

        /// <summary>
        /// 是否超级管理员
        /// </summary>
        public bool IsAdmin(int userId)
        {
            //这里我们还没有做用户角色 所以先返回个True，后面我们做角色的时候再回来修改
            return true;
        }

        /// <summary>
        /// 根据用户ID获取用户名
        /// </summary>
        /// <param name="Id">用户ID</param>
        /// <returns></returns>
        public string GetUserName(int Id)
        {
           
            return "";
        }
    }
}
