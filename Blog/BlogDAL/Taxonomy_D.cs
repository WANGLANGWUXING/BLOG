using BlogModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDAL
{
    /// <summary>
    /// 数据操作类
    /// </summary>
    public class Taxonomy_D
    {
        /// <summary>
        /// 根据类型ID获取类型
        /// </summary>
        /// <param name="id">类型id</param>
        /// <returns>返回类型对象</returns>
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
        /// <summary>
        /// 查询所有类型
        /// </summary>
        /// <returns>返回集合</returns>
        public static List<Taxonomy_M> TaxList()
        {
            List<Taxonomy_M> list = new List<Taxonomy_M>();
            string sql = "select * from Taxonomy";
            SqlDataReader dr = SQLDBHelper.ExecuteReader(sql);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Taxonomy_M tax = new Taxonomy_M();
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
                    list.Add(tax);
                }
            }
            dr.Close();
            return list;
        }
        /// <summary>
        /// 查询前2个类型
        /// </summary>
        /// <returns>返回集合</returns>
        public static List<Taxonomy_M> TaxListTop2()
        {
            List<Taxonomy_M> list = new List<Taxonomy_M>();
            string sql = "select Top 2 *from Taxonomy";
            SqlDataReader dr = SQLDBHelper.ExecuteReader(sql);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Taxonomy_M tax = new Taxonomy_M();
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
                    list.Add(tax);
                }
            }
            dr.Close();
            return list;
        }
    }
}
