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
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
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
            try
            {
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
                throw ex;
            }

        }
        /// <summary>
        /// 调用存储过程进行查询  
        /// </summary>
        /// <param name="procName">存储过程名</param>
        /// <param name="sqlParams">存储过程参数</param>
        /// <returns>返回读取器</returns>
        public static SqlDataReader ExecuteReader(string procName, params SqlParameter[] sqlParams)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(procName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            if (sqlParams != null)
            {
                foreach (SqlParameter item in sqlParams)
                {
                    cmd.Parameters.Add(item);
                }
            }
            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }
        /// <summary>
        /// 调用存储过程进行增删改
        /// </summary>
        /// <param name="procName">存储过程名</param>
        /// <param name="sqlParams">存储过程参数</param>
        /// <returns>返回执行行数是否大于0</returns>
        public static bool ExecuteNonQuery(string procName, params SqlParameter[] sqlParams)
        {
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(procName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            if (sqlParams != null)
            {
                foreach (SqlParameter item in sqlParams)
                {
                    cmd.Parameters.Add(item);
                }
            }
            try
            {
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result > 0;
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
                throw ex;
            }
        }
    }
}
