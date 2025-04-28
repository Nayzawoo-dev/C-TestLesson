using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZPay
{
    internal class Data
    {
        //public static int UserId = 0;
        public static List<User> Users = new List<User>()
        {
            new User("Nay Zaw Oo","09783418411",5000),
            new User("Thin Ya Na","09670726814",10000)
        };
    }
}
