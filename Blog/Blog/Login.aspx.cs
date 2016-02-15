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
            if (!IsPostBack)
            {
                HttpCookie cookieUserName = Request.Cookies["UserName"];
                if (cookieUserName != null)
                {
                    AdminName.Text = Server.UrlDecode(cookieUserName.Value);
                    rememberCB.Checked = true;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (AdminName.Text != "" && AdminPwd.Text != "")
            {
                Admin_M admin = new Admin_M();
                admin.Adminlogin = AdminName.Text;
                admin.Adminpassword = AdminPwd.Text;
                if (Admin_B.Login(admin))
                {
                    if (rememberCB.Checked)
                    {
                        HttpCookie cookieUserName = new HttpCookie("UserName");
                        cookieUserName.Value = Server.UrlEncode(AdminName.Text);
                        cookieUserName.Expires = DateTime.MaxValue;
                        Response.Cookies.Add(cookieUserName);
                    }
                    Session["UserName"] = AdminName.Text;
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('登录成功！');location.href='Admin/AdminIndex.aspx'</script>");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('登录失败！')</script>");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('用户名或密码不能为空！')</script>");
            }
        }
    }
}