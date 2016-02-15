using BlogDAL;
using BlogModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL
{
    /// <summary>
    /// 业务逻辑类
    /// </summary>
    public class Taxonomy_B
    {
        /// <summary>
        /// 根据类型ID获取类型
        /// </summary>
        /// <param name="id">类型id</param>
        /// <returns>返回类型对象</returns>
        public static Taxonomy_M getTaxonomyByID(string id)
        {
            return Taxonomy_D.getTaxonomyByID(id);
        }
        /// <summary>
        /// 查询所有类型
        /// </summary>
        /// <returns>返回集合</returns>
        public static List<Taxonomy_M> TaxList()
        {
            return Taxonomy_D.TaxList();
        }
        /// <summary>
        /// 查询前2个类型
        /// </summary>
        /// <returns>返回集合</returns>
        public static List<Taxonomy_M> TaxListTop2()
        {
            return Taxonomy_D.TaxListTop2();
        }
    }
}
