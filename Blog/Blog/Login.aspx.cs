using BlogBLL;
using BlogModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (AdminName.Text != "" && AdminPwd.Text != "")
            {
                Admin_M admin=new Admin_M();
                admin.Adminlogin=AdminName.Text;
                admin.Adminpassword=AdminPwd.Text;
                if (Admin_B.Login(admin))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('登录成功！')</script>");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('登录失败！')</script>");
                }
            }
        }
    }
}