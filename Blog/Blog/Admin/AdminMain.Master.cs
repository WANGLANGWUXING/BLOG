using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Admin
{
    public partial class AdminMain : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                AdminName.Text = Session["UserName"].ToString();
            }
            else
            {
                Response.Redirect("../Login.aspx");
            }
        }

        protected void btnOut_Click(object sender, EventArgs e)
        {
            Session["UserName"] = null;
            Session["UserPwd"] = null;
            Response.Redirect("../Login.aspx");
        }
    }
}