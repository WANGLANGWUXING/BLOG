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
        /// 查最新的三个评论
        /// </summary>
        /// <returns>返回集合</returns>
        public static List<Comments_M> CommentsListTop3()
        {
            return Comments_D.CommentsListTop3();
        }
    }
}
