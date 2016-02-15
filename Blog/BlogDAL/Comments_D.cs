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
    /// 数据访问类
    /// </summary>
    public class Comments_D
    {
        /// <summary>
        /// 查询所有评论
        /// </summary>
        /// <returns>返回集合</returns>
        public static List<Comments_M> CommentsList()
        {
            List<Comments_M> list = new List<Comments_M>();
            string sql = "select * from Comments";
            SqlDataReader dr = SQLDBHelper.ExecuteReader(sql);
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    Comments_M comment = new Comments_M();
                    if (dr["CommentId"] != DBNull.Value)
                    {
                        comment.CommentId = Convert.ToInt32(dr["CommentId"]);
                    }
                    if (dr["PostId"] != DBNull.Value)
                    {
                        comment.PostId = Convert.ToInt32(dr["PostId"]);
                    }
                    if (dr["UserId"] != DBNull.Value)
                    {
                        comment.UserId = Convert.ToInt32(dr["UserId"]);
                    }
                    if (dr["Commentsmeta"] != DBNull.Value)
                    {
                        comment.Commentsmeta = Convert.ToString(dr["Commentsmeta"]);
                    }
                    if (dr["CommentsTime"] != DBNull.Value)
                    {
                        comment.CommentsTime = Convert.ToDateTime(dr["CommentsTime"]);
                    }
                    list.Add(comment);
                }
            }
            dr.Close();
            return list;
        }
        /// <summary>
        /// 查最新的三个评论
        /// </summary>
        /// <returns>返回集合</returns>
        public static List<Comments_M> CommentsListTop3()
        {
            List<Comments_M> list = new List<Comments_M>();
            string sql = "select top 3 * from Comments order by CommentsTime desc";
            SqlDataReader dr = SQLDBHelper.ExecuteReader(sql);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Comments_M comment = new Comments_M();
                    if (dr["CommentId"] != DBNull.Value)
                    {
                        comment.CommentId = Convert.ToInt32(dr["CommentId"]);
                    }
                    if (dr["PostId"] != DBNull.Value)
                    {
                        comment.PostId = Convert.ToInt32(dr["PostId"]);
                    }
                    if (dr["UserId"] != DBNull.Value)
                    {
                        comment.UserId = Convert.ToInt32(dr["UserId"]);
                    }
                    if (dr["Commentsmeta"] != DBNull.Value)
                    {
                        comment.Commentsmeta = Convert.ToString(dr["Commentsmeta"]);
                    }
                    if (dr["CommentsTime"] != DBNull.Value)
                    {
                        comment.CommentsTime = Convert.ToDateTime(dr["CommentsTime"]);
                    }
                    list.Add(comment);
                }
            }
            dr.Close();
            return list;
        }
    }
}
