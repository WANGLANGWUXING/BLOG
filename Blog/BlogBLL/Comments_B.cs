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
    /// 业务逻辑类
    /// </summary>
    public class Comments_B
    {
        /// <summary>
        /// 查询所有评论
        /// </summary>
        /// <returns>返回集合</returns>
        public static List<Comments_M> CommentsList()
        {
            return Comments_D.CommentsList();
        }
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageSize">每页数据</param>
        /// <param name="pageIndex">页码</param>
        /// <returns></returns>
        public static List<Comments_M> CommentsListPager(string pageSize, string pageIndex)
        {
            return Comments_D.CommentsListPager(pageSize, pageIndex);
        }
        /// <summary>
        /// 查最新的三个评论
        /// </summary>
        /// <returns>返回集合</returns>
        public static List<Comments_M> CommentsListTop3()
        {
            return Comments_D.CommentsListTop3();
        }
        /// <summary>
        /// 所有评论数
        /// </summary>
        /// <returns>返回评论数</returns>
        public static int commentCount()
        {
            return Comments_D.commentCount();
        }
        /// <summary>
        /// 根据帖子ID查评论数
        /// </summary>
        /// <param name="postId">接收帖子ID</param>
        /// <returns>返回评论数</returns>
        public static int commentCountByPostID(string postId)
        {
            return Comments_D.commentCountByPostID(postId);
        }
        /// <summary>
        /// 删
        /// </summary>
        /// <param name="commentid">接收评论id</param>
        /// <returns>返回是否删除成功</returns>
        public static bool delcomment(string commentid)
        {
            return Comments_D.delcomment(commentid);
        }
    }
}
