﻿using BlogModel;
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




    }
}
