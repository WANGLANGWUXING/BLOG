﻿using BlogDAL;
using BlogModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL
{
    public class Admin_B
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="Admin"></param>
        /// <returns></returns>
        public static bool Login(Admin_M Admin)
        {
            return Admin_D.Login(Admin);
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="Admin"></param>
        /// <returns></returns>
        public static bool Register(Admin_M Admin)
        {
            return Admin_D.Register(Admin);

        }
    }
}
