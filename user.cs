using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakebook
{
    class user
    {
        private int password;
        private string username;

        public void setPass(int passwordEntered)
        {
            password = passwordEntered;
        }
        public void setUser(string userEntered)
        {
            username = userEntered;
        }
        public int getPass()
        {
            return password;
        }
        public string getUser()
        {
            return username;
        }
    }
}
