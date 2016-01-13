using BlogDAL;
using BlogModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL
{
    public class Admin_B
    {
        public static bool Login(Admin_M Admin)
        {
            return Admin_D.Login(Admin);
        }
    }
}
