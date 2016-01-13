using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogModel
{
    /// <summary>
    /// 管理员类
    /// </summary>
    public class Admin_M
    {
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Admin_M() { }
        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="adminId">管理员id</param>
        /// <param name="adminlogin">管理员账号</param>
        /// <param name="adminpassword">管理员密码</param>
        public Admin_M(int adminId, string adminlogin, string adminpassword)
        {
            this.AdminId = adminId;
            this.Adminlogin = adminlogin;
            this.Adminpassword = adminpassword;
        }
        private int adminId;
        /// <summary>
        /// 管理员id
        /// </summary>
        public int AdminId
        {
            get { return adminId; }
            set { adminId = value; }
        }
        private string adminlogin;
        /// <summary>
        /// 管理员账号
        /// </summary>
        public string Adminlogin
        {
            get { return adminlogin; }
            set { adminlogin = value; }
        }
        private string adminpassword;
        /// <summary>
        /// 管理员密码
        /// </summary>
        public string Adminpassword
        {
            get { return adminpassword; }
            set { adminpassword = value; }
        }

    }
}
