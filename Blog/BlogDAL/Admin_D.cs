using BlogModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL
{
    public class Admin_D
    {
        /// <summary>
        /// 登录判断
        /// </summary>
        /// <param name="Admin"></param>
        /// <returns></returns>
        public static bool Login(Admin_M Admin)
        {
            SqlParameter paramAdminName = new SqlParameter();
            paramAdminName.ParameterName = "@AdminName";
            paramAdminName.DbType = DbType.String;
            paramAdminName.Value = Admin.Adminlogin;
            SqlParameter paramAdminPwd = new SqlParameter();
            paramAdminPwd.ParameterName = "@AdminPwd";
            paramAdminPwd.DbType = DbType.String;
            paramAdminPwd.Value = Admin.Adminpassword;
            SqlDataReader dr = SQLDBHelper.ExecuteReader("proc_Login", paramAdminName, paramAdminPwd); 
            if (dr.HasRows)
            {
                dr.Close();
                return true;
            }
            else
            {
                dr.Close();
                return false;
            }
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="Admin"></param>
        /// <returns></returns>
        public static bool Register(Admin_M Admin)
        {
            SqlParameter paramAdminName = new SqlParameter();
            paramAdminName.ParameterName = "@AdminName";
            paramAdminName.DbType = DbType.String;
            paramAdminName.Value = Admin.Adminlogin;
            SqlParameter paramAdminPwd = new SqlParameter();
            paramAdminPwd.ParameterName = "@AdminPwd";
            paramAdminPwd.DbType = DbType.String;
            paramAdminPwd.Value = Admin.Adminpassword;
            return SQLDBHelper.ExecuteNonQuery("proc_Register", paramAdminName, paramAdminPwd);
        }
    }
}
