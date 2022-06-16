using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    internal class Administrator : User
    {
        private String admin_name;

        public Administrator(String name, String id, String pass) :base(id, pass)
        {

        }
        public void updatePassword(String newPassword)
        {

        }
        public void updateAdminName(String name)
        {

        }
    }
}
