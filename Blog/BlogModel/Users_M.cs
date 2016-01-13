using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogModel
{
    /// <summary>
    /// 访客类
    /// </summary>
    public class Users_M
    {
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Users_M() { }
        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="userId">访客ID</param>
        /// <param name="username">访客姓名</param>
        /// <param name="userEmail">访客邮箱</param>
        /// <param name="userIP">访客IP</param>
        public Users_M(int userId, string username, string userEmail, string userIP)
        {
            this.UserIP = userIP;
            this.Username = username;
            this.UserEmail = userEmail;
            this.UserIP = userIP;
        }      
        private int userId;
        /// <summary>
        /// 访客ID
        /// </summary>
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        private string username;
        /// <summary>
        /// 访客姓名
        /// </summary>
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string userEmail;
        /// <summary>
        /// 访客邮箱
        /// </summary>
        public string UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; }
        }
        private string userIP;
        /// <summary>
        /// 访客IP
        /// </summary>
        public string UserIP
        {
            get { return userIP; }
            set { userIP = value; }
        }
    }
}
