using BlogBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                navPostRpt.DataSource = Posts_B.PostListTop3();
                navPostRpt.DataBind();
                navTaxRpt.DataSource = Taxonomy_B.TaxListTop2();
                navTaxRpt.DataBind();
                RptComments.DataSource = Comments_B.CommentsListTop3();
                RptComments.DataBind();
            }
        }

        protected void RptComments_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            HiddenField UserID = e.Item.FindControl("UserID") as HiddenField;
            HiddenField PostID = e.Item.FindControl("PostID") as HiddenField;
            Label UserName = e.Item.FindControl("UserName") as Label;
            Label PostTitle = e.Item.FindControl("PostTitle") as Label;
            if (!string.IsNullOrWhiteSpace(UserID.Value))
            {
                UserName.Text = Users_B.UserByID(UserID.Value).Username;
            }
            if (!string.IsNullOrWhiteSpace(PostID.Value))
            {
                PostTitle.Text = Posts_B.PostByID(PostID.Value).Title;
            }
        }
    }
}
