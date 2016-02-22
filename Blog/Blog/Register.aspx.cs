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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            if (AdminName.Text != "" && AdminPwd.Text != "")
            {
                Admin_M admin = new Admin_M();
                admin.Adminlogin = AdminName.Text;
                admin.Adminpassword = AdminPwd.Text;
                if (Admin_B.Register(admin))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('注册成功！进入登录页面……');location.href='Login.aspx'</script>");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('注册失败！继续注册');</script>");

                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('用户名或密码不能为空');</script>");

            }
        }
    }
}