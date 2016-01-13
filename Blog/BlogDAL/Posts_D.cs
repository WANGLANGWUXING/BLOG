using BlogModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL
{
    /// <summary>
    /// 数据操作类
    /// </summary>
    public class Posts_D
    {
        /// <summary>
        /// 查出所有帖子集合
        /// </summary>
        /// <returns>返回集合</returns>
        public static List<Posts_M> PostList()
        {
            List<Posts_M> list = new List<Posts_M>();
            string sql = "select * from Posts";
            SqlDataReader dr= SQLDBHelper.ExecuteReader(sql);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Posts_M post = new Posts_M();
                    if (dr["PostId"] != DBNull.Value)
                    {
                        post.PostId = Convert.ToInt32(dr["PostId"]);
                    }
                    if (dr["TaxonomyId"] != DBNull.Value)
                    {
                        post.TaxonomyId = Convert.ToInt32(dr["TaxonomyId"]);
                    }
                    if (dr["Title"] != DBNull.Value)
                    {
                        post.Title = Convert.ToString(dr["Title"]);
                    }
                    if (dr["Post"] != DBNull.Value)
                    {
                        post.Post = Convert.ToString(dr["Post"]);
                    }
                }
            }
            dr.Close();
            return list;
        }


    }
}
