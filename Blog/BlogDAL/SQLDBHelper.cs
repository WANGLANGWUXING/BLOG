using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL
{
    /// <summary>
    /// ADO.NET
    /// </summary>
    public class SQLDBHelper
    {
        /// <summary>
        /// 链接字符串
        /// </summary>
        static string connStr = "server=.;database=BLOGDB;uid=sa;pwd=123456";
        /// <summary>
        /// 获取读取器
        /// </summary>
        /// <param name="sql">接收SQL语句</param>
        /// <returns>返回读取器</returns>
        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection conn=new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd=new SqlCommand(sql,conn);
            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }
        /// <summary>
        /// 受影响行数是否大于0
        /// </summary>
        /// <param name="sql">接收SQL语句</param>
        /// <returns>返回bool值</returns>
        public static bool ExecuteNonQuery(string sql)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }
    }
}
