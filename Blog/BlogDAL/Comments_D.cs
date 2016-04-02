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
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageSize">每页数据</param>
        /// <param name="pageIndex">页码</param>
        /// <returns>返回集合</returns>
        public static List<Comments_M> CommentsListPager(string pageSize, string pageIndex)
        {
            List<Comments_M> list = new List<Comments_M>();
            string sql = string.Format("select top ({0}) *from Comments where CommentId not in(select top (({1}-1)*{0}) CommentId from Comments order by CommentId)order by CommentId",pageSize,pageIndex);
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
        /// <summary>
        /// 所有评论数
        /// </summary>
        /// <returns>返回评论数</returns>
        public static int commentCount()
        {
            string sql = "select count(*) from Comments";
            return SQLDBHelper.ExecuteScalar(sql);
        }
        /// <summary>
        /// 根据帖子ID查评论数
        /// </summary>
        /// <param name="postId">接收帖子ID</param>
        /// <returns>返回评论数</returns>
        public static int commentCountByPostID(string postId)
        {
            string sql = "select count(*) from Comments where PostId=" + postId;
            return SQLDBHelper.ExecuteScalar(sql);
        }
        /// <summary>
        /// 删
        /// </summary>
        /// <param name="commentid">接收评论id</param>
        /// <returns>返回是否删除成功</returns>
        public static bool delcomment(string commentid)
        {
            string sql = "delete from Comments where CommentId=" + commentid;
            return SQLDBHelper.ExecuteNonQuery(sql);
        }
    }
}
