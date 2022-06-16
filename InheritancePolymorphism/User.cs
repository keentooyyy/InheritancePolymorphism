using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    internal class User 
    {
        private String user_id;
        protected String user_password;

        public User(String id, String pass)
        {
            user_id = "user";
            user_password = "userpass";
        }
        public bool verifyLogin(String id, String pass)
        {
            id = user_id;
            pass = user_password;

            if (id.Equals(user_id) && pass.Equals(user_password)) {
                return true;
            }
            else
            {
                return false;
            }
                
        }
        public void UpdatePassword(String password)
        {
            user_password = password;
        }
    }
}
