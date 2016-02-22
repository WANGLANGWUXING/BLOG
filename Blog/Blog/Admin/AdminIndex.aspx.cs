using BlogBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Admin
{
    public partial class AdminIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Posts_B.countPost() > 0)
            {
                post.Text = Posts_B.countPost().ToString() + "篇文章";
            }
            if (Comments_B.commentCount() > 0)
            {
                comment.Text = Comments_B.commentCount().ToString() + "条评论";
            }
            if (Taxonomy_B.TaxCount() > 0)
            {
                cate.Text = Taxonomy_B.TaxCount().ToString() + "个分类";
            }
        }
    }
}