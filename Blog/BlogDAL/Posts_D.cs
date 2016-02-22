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
            SqlDataReader dr = SQLDBHelper.ExecuteReader(sql);
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
                    if (dr["PublishTime"] != DBNull.Value)
                    {
                        post.PublishTime = Convert.ToDateTime(dr["PublishTime"]);
                    }
                    list.Add(post);
                }
            }
            dr.Close();
            return list;
        }
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageSize">页数大小</param>
        /// <param name="pageIndex">页码</param>
        /// <returns>返回集合</returns>
        public static List<Posts_M> PostListPager(string pageSize, string pageIndex)
        {
            List<Posts_M> list = new List<Posts_M>();
            string sql = string.Format("select top ({0}) *from Posts where PostId not in (select top (({1}-1)*{0}) PostId from Posts order by PostId) order by PostId", pageSize, pageIndex);
            SqlDataReader dr = SQLDBHelper.ExecuteReader(sql);
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
                    if (dr["PublishTime"] != DBNull.Value)
                    {
                        post.PublishTime = Convert.ToDateTime(dr["PublishTime"]);
                    }
                    list.Add(post);
                }
            }
            dr.Close();
            return list;
        }
        /// <summary>
        /// 根据帖子ID删除
        /// </summary>
        /// <param name="postID">接收帖子ID</param>
        /// <returns>返回是否删除成功</returns>
        public static bool delBypostId(string postID)
        {
            string sql = "delete from Posts where PostId=" + postID;
            return SQLDBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 查出最新的三个帖子
        /// </summary>
        /// <returns>返回集合</returns>
        public static List<Posts_M> PostListTop3()
        {
            List<Posts_M> list = new List<Posts_M>();
            string sql = "select top 3 * from Posts order by PublishTime desc";
            SqlDataReader dr = SQLDBHelper.ExecuteReader(sql);
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
                    if (dr["PublishTime"] != DBNull.Value)
                    {
                        post.PublishTime = Convert.ToDateTime(dr["PublishTime"]);
                    }
                    list.Add(post);
                }
            }
            dr.Close();
            return list;
        }
        /// <summary>
        /// 根据ID查找帖子
        /// </summary>
        /// <param name="PostID">获取PostID</param>
        /// <returns>返回一个对象</returns>
        public static Posts_M PostByID(string PostID)
        {
            Posts_M Post = new Posts_M();
            string sql = "select * from Posts where PostId=" + PostID;
            SqlDataReader dr = SQLDBHelper.ExecuteReader(sql);
            if (dr.HasRows)
            {
                dr.Read();
                if (dr["PostId"] != DBNull.Value)
                {
                    Post.PostId = Convert.ToInt32(dr["PostId"]);
                }
                if (dr["TaxonomyId"] != DBNull.Value)
                {
                    Post.TaxonomyId = Convert.ToInt32(dr["TaxonomyId"]);
                }
                if (dr["Title"] != DBNull.Value)
                {
                    Post.Title = Convert.ToString(dr["Title"]);
                }
                if (dr["Post"] != DBNull.Value)
                {
                    Post.Post = Convert.ToString(dr["Post"]);
                }
                if (dr["PublishTime"] != DBNull.Value)
                {
                    Post.PublishTime = Convert.ToDateTime(dr["PublishTime"]);
                }
            }
            dr.Close();
            return Post;
        }
        /// <summary>
        /// 通过类型ID查找帖子集合
        /// </summary>
        /// <param name="TaxID">获取类型ID</param>
        /// <returns>返回集合</returns>
        public static List<Posts_M> PostListByTaxID(string TaxID)
        {
            List<Posts_M> list = new List<Posts_M>();
            string sql = "select * from Posts  where TaxonomyId =" + TaxID;
            SqlDataReader dr = SQLDBHelper.ExecuteReader(sql);
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
                    if (dr["PublishTime"] != DBNull.Value)
                    {
                        post.PublishTime = Convert.ToDateTime(dr["PublishTime"]);
                    }
                    list.Add(post);
                }
            }
            dr.Close();
            return list;
        }
        /// <summary>
        /// 所有帖子数
        /// </summary>
        /// <returns>返回总计</returns>
        public static int countPost()
        {
            string sql = "select count(*) from Posts";
            return SQLDBHelper.ExecuteScalar(sql);
        }
        /// <summary>
        /// 添加帖子
        /// </summary>
        /// <param name="post">接收类</param>
        /// <returns>返回影响行数是否大于0</returns>
        public static bool addPost(Posts_M post)
        {
            SqlParameter paramTaxID = new SqlParameter();
            paramTaxID.ParameterName = "@TaxonomyId";
            paramTaxID.DbType = DbType.String;
            paramTaxID.Value = post.TaxonomyId;
            SqlParameter paramTitle = new SqlParameter();
            paramTitle.ParameterName = "@Title";
            paramTitle.DbType = DbType.String;
            paramTitle.Value = post.Title;
            SqlParameter paramPost = new SqlParameter();
            paramPost.ParameterName = "@Post";
            paramPost.DbType = DbType.String;
            paramPost.Value = post.Post;
            return SQLDBHelper.ExecuteNonQuery("proc_Insert_Post", paramTaxID, paramTitle, paramPost);
        }
        /// <summary>
        /// 修改帖子
        /// </summary>
        /// <param name="post">接收类</param>
        /// <returns>返回影响行数是否大于0</returns>
        public static bool updatePost(Posts_M post)
        {
            SqlParameter paramTaxID = new SqlParameter();
            paramTaxID.ParameterName = "@TaxonomyId";
            paramTaxID.DbType = DbType.String;
            paramTaxID.Value = post.TaxonomyId;
            SqlParameter paramTitle = new SqlParameter();
            paramTitle.ParameterName = "@Title";
            paramTitle.DbType = DbType.String;
            paramTitle.Value = post.Title;
            SqlParameter paramPost = new SqlParameter();
            paramPost.ParameterName = "@Post";
            paramPost.DbType = DbType.String;
            paramPost.Value = post.Post;
            SqlParameter paramPostID = new SqlParameter();
            paramPostID.ParameterName = "@PostId";
            paramPostID.DbType = DbType.String;
            paramPostID.Value = post.PostId;
            return SQLDBHelper.ExecuteNonQuery("proc_Update_Post",paramTaxID,paramTitle,paramPost,paramPostID);
        }
    }
}
