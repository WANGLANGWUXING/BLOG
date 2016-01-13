using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogModel
{
    /// <summary>
    /// 评论类
    /// </summary>
    public class Comments_M
    {
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Comments_M() { }
        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="commentId">评论ID</param>
        /// <param name="postId">帖子id</param>
        /// <param name="userId">访客id</param>
        /// <param name="commentsmeta">帖子内容</param>
        /// <param name="commentsTime">评论时间</param>
        public Comments_M(int commentId, int postId, int userId, string commentsmeta, DateTime commentsTime)
        {
            this.CommentId = commentId;
            this.PostId = postId;
            this.UserId = userId;
            this.Commentsmeta = commentsmeta;
            this.CommentsTime = commentsTime;
        }
        private int commentId;
        /// <summary>
        /// 评论ID
        /// </summary>
        public int CommentId
        {
            get { return commentId; }
            set { commentId = value; }
        }
        private int postId;
        /// <summary>
        /// 帖子id
        /// </summary>
        public int PostId
        {
            get { return postId; }
            set { postId = value; }
        }
        private int userId;
        /// <summary>
        /// 访客id
        /// </summary>
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        private string commentsmeta;
        /// <summary>
        /// 帖子内容
        /// </summary>
        public string Commentsmeta
        {
            get { return commentsmeta; }
            set { commentsmeta = value; }
        }
        private DateTime commentsTime;
        /// <summary>
        /// 评论时间
        /// </summary>
        public DateTime CommentsTime
        {
            get { return commentsTime; }
            set { commentsTime = value; }
        }
    }
}
