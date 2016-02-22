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
    public partial class AdminWritePost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlcate.DataSource = Taxonomy_B.TaxList();
                ddlcate.DataValueField = "TaxonomyId";
                ddlcate.DataTextField = "TaxonomyName";
                ddlcate.DataBind();
                if (!string.IsNullOrWhiteSpace(Request.QueryString["postId"]))
                {
                    Posts_M post = Posts_B.PostByID(Request.QueryString["postId"]);
                    txtTitle.Text = post.Title;
                    ddlcate.Text = post.TaxonomyId.ToString();
                    postdesc.Text = post.Post;
                    btnaddpost.Text = "修改";
                }
            }

        }

        protected void btnaddpost_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["postId"]))
            {
                Posts_M post = new Posts_M();
                post.PostId = Convert.ToInt32(Request.QueryString["postId"]);
                post.Title = txtTitle.Text;
                post.TaxonomyId = Convert.ToInt32(ddlcate.Text);
                post.Post = postdesc.Text;
                if (Posts_B.updatePost(post))
                {
                    ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('修改成功');location.href='AdminPost.aspx';</script>");

                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('修改失败');</script>");

                }
            }
            else
            {
                Posts_M post = new Posts_M();
                post.Title = txtTitle.Text;
                post.TaxonomyId = Convert.ToInt32(ddlcate.Text);
                post.Post = postdesc.Text;
                if (Posts_B.addPost(post))
                {
                    ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('添加成功');</script>");
                    txtTitle.Text = "";
                    postdesc.Text = "";
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('添加失败');</script>");

                }
            }
        }
    }
}