using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppLog.Models
{
    public class Auth
    {
        public String Email { get; set; }

        public String Password { get; set; }

        public static User GetUser()
        {
            return new User();
        }

        public static void SetUser(User user)
        {

        }
    }
}