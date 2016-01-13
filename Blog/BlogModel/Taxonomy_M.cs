using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogModel
{
    /// <summary>
    /// 帖子类型类
    /// </summary>
    public class Taxonomy_M
    {
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Taxonomy_M() { }
        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="taxonomyId">分类id</param>
        /// <param name="taxonomyName">分类名</param>
        /// <param name="taxonomydesc">分类描述</param>
        public Taxonomy_M(int taxonomyId, int taxonomyName, int taxonomydesc)
        {
            this.TaxonomyId = taxonomyId;
            this.TaxonomyName = taxonomyName;
            this.Taxonomydesc = taxonomydesc;
        }
        //TaxonomyId       
        //TaxonomyName 
        //Taxonomydesc  
        private int taxonomyId;
        /// <summary>
        /// 分类id
        /// </summary>
        public int TaxonomyId
        {
            get { return taxonomyId; }
            set { taxonomyId = value; }
        }
        private int taxonomyName;
        /// <summary>
        /// 分类名
        /// </summary>
        public int TaxonomyName
        {
            get { return taxonomyName; }
            set { taxonomyName = value; }
        }
        private int taxonomydesc;
        /// <summary>
        /// 分类描述
        /// </summary>
        public int Taxonomydesc
        {
            get { return taxonomydesc; }
            set { taxonomydesc = value; }
        }

    }
}
