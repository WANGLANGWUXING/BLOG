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
    public class Users_D
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
            SqlParameter paramPostId = new SqlParameter();
            paramPostId.ParameterName = "@PostId";
            paramPostId.DbType = DbType.String;
            paramPostId.Value = PostId;
            SqlParameter paramUserName = new SqlParameter();
            paramUserName.ParameterName = "@Username";
            paramUserName.DbType = DbType.String;
            paramUserName.Value = UserName;
            SqlParameter paramUserEmail = new SqlParameter();
            paramUserEmail.ParameterName = "@UserEmail";
            paramUserEmail.DbType = DbType.String;
            paramUserEmail.Value = UserEmail;
            SqlParameter paramCommentMeta = new SqlParameter();
            paramCommentMeta.ParameterName = "@Commentsmeta";
            paramCommentMeta.DbType = DbType.String;
            paramCommentMeta.Value = CommentMeta;
            SqlParameter paramUserIP = new SqlParameter();
            paramUserIP.ParameterName = "@UserIP";
            paramUserIP.DbType = DbType.String;
            paramUserIP.Value = UserIP;
            return SQLDBHelper.ExecuteNonQuery("proc_Insert_Comment", paramPostId, paramUserName, paramUserEmail, paramCommentMeta, paramUserIP);
        }
    }
}
