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

        protected void rptPostList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            HiddenField categoryID = e.Item.FindControl("CategoryID") as HiddenField;
            LinkButton CategoryName = e.Item.FindControl("CategoryName") as LinkButton;
            if (!string.IsNullOrWhiteSpace(categoryID.Value))
            {
                Taxonomy_M tax = Taxonomy_B.getTaxonomyByID(categoryID.Value);
                CategoryName.Text = tax.TaxonomyName;
            }
        }
    }
}