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
    public partial class AdminComment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int order = Comments_B.CommentsList().Count();
                CommentPager.RecordCount = order;
                Bind();
            }
            if (!string.IsNullOrWhiteSpace(Request.QueryString["commentid"]))
            {
                if (Comments_B.delcomment(Request.QueryString["commentid"]))
                {
                    ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('删除成功');location.href='AdminComment.aspx';</script>");
                }
            }
        }

        void Bind()
        {
            CommentList.DataSource = Comments_B.CommentsListPager(CommentPager.PageSize.ToString(), CommentPager.CurrentPageIndex.ToString());
            CommentList.DataBind();
        }
        protected void CommentList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            HiddenField UserId = e.Item.FindControl("UserId") as HiddenField;
            Label userName = e.Item.FindControl("userName") as Label;
            if (!string.IsNullOrWhiteSpace(UserId.Value))
            {
                Users_M user = Users_B.UserByID(UserId.Value);
                userName.Text = user.Username;
            }
            HiddenField PostId = e.Item.FindControl("PostId") as HiddenField;
            Label PostTitle = e.Item.FindControl("PostTitle") as Label;
            if (!string.IsNullOrWhiteSpace(PostId.Value))
            {
                Posts_M post = Posts_B.PostByID(PostId.Value);
                PostTitle.Text = post.Title;
            }
        }

        protected void CommentPager_PageChanged(object sender, EventArgs e)
        {
            Bind();
        }
    }
}