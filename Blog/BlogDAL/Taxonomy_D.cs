using BlogModel;
using System;
using System.Collections.Generic;
using System.Data;
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
        /// 分页查询
        /// </summary>
        /// <param name="pageSize">每页数据行数</param>
        /// <param name="pageIndex">页码</param>
        /// <returns>返回集合</returns>
        public static List<Taxonomy_M> TaxListPager(string pageSize, string pageIndex)
        {
            List<Taxonomy_M> list = new List<Taxonomy_M>();
            string sql = string.Format("select top ({0}) *from Taxonomy where TaxonomyId not in(select top (({1}-1)*{0}) TaxonomyId from Taxonomy order by TaxonomyId) order by TaxonomyId", pageSize, pageIndex);
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
        /// <summary>
        /// 所有类型数
        /// </summary>
        /// <returns>返回数量</returns>
        public static int TaxCount()
        {
            string sql = "select count(*) from Taxonomy";
            return SQLDBHelper.ExecuteScalar(sql);
        }
        /// <summary>
        /// 删
        /// </summary>
        /// <param name="taxId"></param>
        /// <returns></returns>
        public static bool delTax(string taxId)
        {
            string sql = "delete from Taxonomy where TaxonomyId=" + taxId;
            return SQLDBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 增
        /// </summary>
        /// <param name="tax"></param>
        /// <returns></returns>
        public static bool addTax(Taxonomy_M tax)
        {
            SqlParameter paramTaxName = new SqlParameter();
            paramTaxName.ParameterName = "@TaxonomyName";
            paramTaxName.DbType = DbType.String;
            paramTaxName.Value = tax.TaxonomyName;
            SqlParameter paramTaxdesc = new SqlParameter();
            paramTaxdesc.ParameterName = "@Taxonomydesc";
            paramTaxdesc.DbType = DbType.String;
            paramTaxdesc.Value = tax.Taxonomydesc;
            return SQLDBHelper.ExecuteNonQuery("proc_Insert_Tax", paramTaxName, paramTaxdesc);

        }
        /// <summary>
        /// 改
        /// </summary>
        /// <param name="tax"></param>
        /// <returns></returns>
        public static bool updateTax(Taxonomy_M tax)
        {
            SqlParameter paramTaxName = new SqlParameter();
            paramTaxName.ParameterName = "@TaxonomyName";
            paramTaxName.DbType = DbType.String;
            paramTaxName.Value = tax.TaxonomyName;
            SqlParameter paramTaxdesc = new SqlParameter();
            paramTaxdesc.ParameterName = "@Taxonomydesc";
            paramTaxdesc.DbType = DbType.String;
            paramTaxdesc.Value = tax.Taxonomydesc;
            SqlParameter paramTaxId = new SqlParameter();
            paramTaxId.ParameterName = "@TaxonomyId";
            paramTaxId.DbType = DbType.String;
            paramTaxId.Value = tax.TaxonomyId;
            return SQLDBHelper.ExecuteNonQuery("proc_Update_Tax", paramTaxName, paramTaxdesc,paramTaxId);
        }
    }
}
