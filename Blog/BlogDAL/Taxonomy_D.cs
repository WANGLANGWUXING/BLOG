using BlogModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL
{
    public class Taxonomy_D
    {
        public static Taxonomy_M getTaxonomyByID(string id)
        {
            Taxonomy_M tax = new Taxonomy_M();
            string sql = "select * from Taxonomy where TaxonomyId=" + id;
            SqlDataReader dr = SQLDBHelper.ExecuteReader(sql);
            if (dr.HasRows)
            {
                dr.Read();
                if (dr["TaxonomyId"] != DBNull.Value)
                {
                    tax.TaxonomyId = Convert.ToInt32(dr["TaxonomyId"]);
                }
                if (dr["TaxonomyName"] != DBNull.Value)
                {
                    tax.TaxonomyName = dr["TaxonomyName"].ToString();
                }
                if (dr["Taxonomydesc"] != DBNull.Value)
                {
                    tax.Taxonomydesc = dr["Taxonomydesc"].ToString();
                }
            }
            return tax;
        }
    }
}
