using BlogBLL;
using BlogModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Admin
{
    public partial class AdminPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int order = Posts_B.PostList().Count();
                pagerPost.RecordCount = order;
                Bind();
            }
            if(!string.IsNullOrWhiteSpace(Request.QueryString["postId"]))
            {
                if (Posts_B.delBypostId(Request.QueryString["postId"]))
                {
                    ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('删除成功');location.href='AdminPost.aspx';</script>");
                }
            }
        }
        void Bind()
        {
            postList.DataSource = Posts_B.PostListPager(pagerPost.PageSize.ToString(), pagerPost.CurrentPageIndex.ToString());
            postList.DataBind();
        }

        protected void postList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            HiddenField cateID = e.Item.FindControl("cateID") as HiddenField;
            Label cateName = e.Item.FindControl("cateName") as Label;
            if (!string.IsNullOrWhiteSpace(cateID.Value))
            {
                Taxonomy_M cate = Taxonomy_B.getTaxonomyByID(cateID.Value);
                cateName.Text = cate.TaxonomyName;
            }
            HiddenField postID = e.Item.FindControl("postID") as HiddenField;
            Label commentCount = e.Item.FindControl("commentCount") as Label;
            if (!string.IsNullOrWhiteSpace(postID.Value))
            {
                int count = Comments_B.commentCountByPostID(postID.Value);
                commentCount.Text = count.ToString() + "条评论";
            }
        }

        protected void pagerPost_PageChanged(object sender, EventArgs e)
        {
            Bind();
        }
    }
}