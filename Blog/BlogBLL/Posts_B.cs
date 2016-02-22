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
        /// 分页查询
        /// </summary>
        /// <param name="pageSize">每页数据条数</param>
        /// <param name="pageIndex">页码</param>
        /// <returns>返回集合</returns>
        public static List<Posts_M> PostListPager(string pageSize, string pageIndex)
        {
            return Posts_D.PostListPager(pageSize, pageIndex);
        }
        /// <summary>
        /// 根据帖子ID删除
        /// </summary>
        /// <param name="postID">接收帖子ID</param>
        /// <returns>返回是否删除成功</returns>
        public static bool delBypostId(string postID)
        {
            return Posts_D.delBypostId(postID);
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
        /// <summary>
        /// 通过类型ID查找帖子集合
        /// </summary>
        /// <param name="TaxID">获取类型ID</param>
        /// <returns>返回集合</returns>
        public static List<Posts_M> PostListByTaxID(string TaxID)
        {
            return Posts_D.PostListByTaxID(TaxID);
        }
        /// <summary>
        /// 所有帖子数
        /// </summary>
        /// <returns>返回总计</returns>
        public static int countPost()
        {
            return Posts_D.countPost();
        }
        /// <summary>
        /// 添加帖子
        /// </summary>
        /// <param name="post">接收类</param>
        /// <returns>返回影响行数是否大于0</returns>
        public static bool addPost(Posts_M post)
        {
            return Posts_D.addPost(post);
        }
        /// <summary>
        /// 修改帖子
        /// </summary>
        /// <param name="post">接收类</param>
        /// <returns>返回影响行数是否大于0</returns>
        public static bool updatePost(Posts_M post)
        {
            return Posts_D.updatePost(post);
        }
    }
}
