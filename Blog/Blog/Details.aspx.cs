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
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(Request.QueryString["PostId"]))
            {

                Posts_M Post = Posts_B.PostByID(Request.QueryString["PostId"]);
                Page.Title = Post.Title;
                lblTitle.Text = Post.Title;
                PostDesc.Text = Post.Post;
                PublishTime.Text = Post.PublishTime.ToShortDateString();
                int CategoryId = Post.TaxonomyId;
                CategoryName.Text = Taxonomy_B.getTaxonomyByID(CategoryId.ToString()).TaxonomyName;
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }

        protected void btnComment_Click(object sender, EventArgs e)
        {
            if (txtComment.Text != "" || txtName.Text != "" || txtEmail.Text != "")
            {
                string PostId = Request.QueryString["PostId"];
                string UserName = txtName.Text;
                string UserEmail = txtEmail.Text;
                string CommentMeta = txtComment.Text;
                //HttpRequest类：使 ASP.NET 能够读取客户端在 Web 请求期间发送的 HTTP 值。
                //System.Web.HttpContext.Current：
                //一般在web应用程序里,你的程序都是为了处理客户端过来的http请求而执行的,当前正在处理的这个请求的一些上下文信息就保存在一个HttpContext对象里,你通过HttpContext的静态属性Current得到当前这个上下文,然后去取你需要的信息,比如查询字符串等。
                HttpRequest request = HttpContext.Current.Request;
                //request.ServerVariables["HTTP_X_FORWARDED_FOR"];可以知道代理服务器的服务器名以及端口
                string result = request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                //判断是否使用代理服务器
                if (string.IsNullOrEmpty(result))
                {
                    //发出请求的远程主机的 IP 地址
                    result = request.ServerVariables["REMOTE_ADDR"];
                }
                if (string.IsNullOrEmpty(result))
                {
                    //没有代理时直接获取客户端IP地址
                    result = request.UserHostAddress;
                }
                if (string.IsNullOrEmpty(result))
                {
                    result = "0.0.0.0";
                }
                string UserIP = result;
                if (Users_B.AddComment(PostId, UserName, UserEmail, CommentMeta, UserIP))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('评论成功')</script>");
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('必填项未填')</script>");
            }
        }
    }
}