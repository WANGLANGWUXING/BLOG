using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogModel
{
    /// <summary>
    /// 帖子类
    /// </summary>
    public class Posts_M
    {
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Posts_M() { }
        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="postId">帖子id</param>
        /// <param name="taxonomyId">类型id</param>
        /// <param name="title">标题</param>
        /// <param name="post">帖子内容</param>
        /// <param name="publishTime">发布时间</param>
        public Posts_M(int postId, int taxonomyId, string title, string post, DateTime publishTime)
        {
            this.PostId = postId;
            this.TaxonomyId = taxonomyId;
            this.Title = title;
            this.Post = post;
            this.PublishTime = publishTime;
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
        private int taxonomyId;
        /// <summary>
        /// 类型id
        /// </summary>
        public int TaxonomyId
        {
            get { return taxonomyId; }
            set { taxonomyId = value; }
        }
        private string title;
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string post;
        /// <summary>
        /// 帖子内容
        /// </summary>
        public string Post
        {
            get { return post; }
            set { post = value; }
        }
        private DateTime publishTime;
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime PublishTime
        {
            get { return publishTime; }
            set { publishTime = value; }
        }
    }
}
