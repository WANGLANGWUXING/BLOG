using BlogDAL;
using BlogModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL
{
    public class Posts_B
    {
        public static List<Posts_M> PostList()
        {
            return Posts_D.PostList();
        }
    }
}
