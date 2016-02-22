using BlogBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Admin
{
    public partial class AdminTax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int order = Taxonomy_B.TaxList().Count();
                pagerCate.RecordCount = order;
                Bind();
            }
            if (!string.IsNullOrWhiteSpace(Request.QueryString["taxId"]))
            {
                if (Taxonomy_B.delTax(Request.QueryString["taxId"]))
                {
                    ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('删除成功');location.href='AdminTax.aspx';</script>");
                }
            }

        }

        void Bind()
        {
            cateList.DataSource = Taxonomy_B.TaxListPager(pagerCate.PageSize.ToString(), pagerCate.CurrentPageIndex.ToString());
            cateList.DataBind();
        }
        protected void pagerCate_PageChanged(object sender, EventArgs e)
        {
            Bind();
        }
    }
}