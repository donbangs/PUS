using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService
{
    public class User
    {
        public static string Us { get; set; } = "Maks";
        public  static string Pass { get; set; } = "maks";
        public static bool AdminAuth(string adminid, string adminpassword)
        {
            if (Us == adminid && adminpassword == Pass)
                return true;
            else return false;
          
        }
    }

}
