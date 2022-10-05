using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopApp
{
    public class adminData
    {
        // To be develop
        public string userId { get; set; }
        public string userPassword { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public adminData()
        {
            this.userId = "admin";
            this.userPassword = "admin";
            this.Name = "AdminName";
            this.LastName = "AdminLastName";
        }

        public static bool LoginVerification(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return true;
            } else
            {
                return false;
            }
        }


    }
}
