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
            string connStr = "server=.;database=BLOGDB;uid=sa;pwd=123456";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_Login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter paramAdminName = new SqlParameter();
            paramAdminName.ParameterName = "@AdminName";
            paramAdminName.DbType = DbType.String;
            paramAdminName.Value = Admin.Adminlogin;
            cmd.Parameters.Add(paramAdminName);
            SqlParameter paramAdminPwd = new SqlParameter();
            paramAdminPwd.ParameterName = "@AdminPwd";
            paramAdminPwd.DbType = DbType.String;
            paramAdminPwd.Value = Admin.Adminpassword;
            cmd.Parameters.Add(paramAdminPwd);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

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
    }
}
