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
    public partial class AdminTaxWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrWhiteSpace(Request.QueryString["taxId"]))
                {
                    Taxonomy_M tax = Taxonomy_B.getTaxonomyByID(Request.QueryString["taxId"]);
                    txtTaxName.Text = tax.TaxonomyName;
                    txtTaxDesc.Text = tax.Taxonomydesc;
                    btnaddTax.Text = "编辑分类";
                }
            }
        }

        protected void btnaddTax_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["taxId"]))
            {
                Taxonomy_M tax = new Taxonomy_M();
                tax.TaxonomyId = Convert.ToInt32(Request.QueryString["taxId"]);
                tax.TaxonomyName = txtTaxName.Text;
                tax.Taxonomydesc = txtTaxDesc.Text;
                if (Taxonomy_B.updateTax(tax))
                {
                    ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('修改成功');location.href='AdminTax.aspx';</script>");

                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('修改失败');</script>");

                }
            }
            else
            {
                Taxonomy_M tax = new Taxonomy_M();
                tax.TaxonomyName = txtTaxName.Text;
                tax.Taxonomydesc = txtTaxDesc.Text;
                if (Taxonomy_B.addTax(tax))
                {
                    ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('添加成功');</script>");
                    txtTaxName.Text = "";
                    txtTaxDesc.Text = "";
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('添加失败');</script>");

                }
            }
        }
    }
}