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
            
            ////获取客户端IP地址
            //HttpRequest request = HttpContext.Current.Request; 
            //string result = request.ServerVariables["HTTP_X_FORWARDED_FOR"]; 
            //if (string.IsNullOrEmpty(result))
            //{ 
            //    result = request.ServerVariables["REMOTE_ADDR"];
            //} 
            //if (string.IsNullOrEmpty(result))
            //{ 
            //    result = request.UserHostAddress; 
            //} 
            //if (string.IsNullOrEmpty(result))
            //{ 
            //    result = "0.0.0.0"; 
            //}
            ////result为IP地址
        }

        protected void btnComment_Click(object sender, EventArgs e)
        {
            if()
        }
    }
}