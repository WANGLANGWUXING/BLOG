using BlogDAL;
using BlogModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL
{
    public class Taxonomy_B
    {
        public static Taxonomy_M getTaxonomyByID(string id)
        {
            return Taxonomy_D.getTaxonomyByID(id);
        }
    }
}
