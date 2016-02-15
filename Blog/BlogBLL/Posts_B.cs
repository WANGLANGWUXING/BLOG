using BlogDAL;
using BlogModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL
{
    /// <summary>
    ///业务逻辑类
    /// </summary>
    public class Posts_B
    {
        /// <summary>
        /// 查出所有帖子集合
        /// </summary>
        /// <returns>返回集合</returns>
        public static List<Posts_M> PostList()
        {
            return Posts_D.PostList();
        }
        /// <summary>
        /// 根据ID查找帖子
        /// </summary>
        /// <param name="PostID">获取PostID</param>
        /// <returns>返回一个对象</returns>
        public static Posts_M PostByID(string PostID)
        {
            return Posts_D.PostByID(PostID);
        }
        /// <summary>
        /// 查出最新的三个帖子
        /// </summary>
        /// <returns>返回集合</returns>
        public static List<Posts_M> PostListTop3()
        {
            return Posts_D.PostListTop3();
        }

        public static List<Posts_M> PostListByTaxID(string TaxID)
        {
            return Posts_D.PostListByTaxID(TaxID);
        }

    }
}
