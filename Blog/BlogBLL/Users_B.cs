using BlogDAL;
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
    public class Users_B
    {
        /// <summary>
        /// 添加访客及其评论
        /// </summary>
        /// <param name="PostId">帖子id</param>
        /// <param name="UserName">访客姓名</param>
        /// <param name="UserEmail">访客邮箱</param>
        /// <param name="CommentMeta">评论内容</param>
        /// <param name="UserIP">访客IP</param>
        /// <returns>返回是否添加成功</returns>
        public static bool AddComment(string PostId, string UserName, string UserEmail, string CommentMeta, string UserIP)
        {
            return Users_D.AddComment(PostId, UserName, UserEmail, CommentMeta, UserIP);
        }
    }
}
