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
    public partial class TaxPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["TaxID"]))
            {
                string TaxID = Request.QueryString["TaxID"];
                Taxonomy_M tax = Taxonomy_B.getTaxonomyByID(TaxID);
                txtTax.Text = tax.TaxonomyName;
                rptPostList.DataSource = Posts_B.PostListByTaxID(TaxID);
                rptPostList.DataBind();
            }
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