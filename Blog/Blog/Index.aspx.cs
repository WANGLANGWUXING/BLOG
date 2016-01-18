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
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Posts_M> postlist = Posts_B.PostList();
            rptPostList.DataSource = postlist;
            rptPostList.DataBind();
            //ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('欢迎')</script>");
        }
    }
}