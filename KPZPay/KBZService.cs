using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZPay
{
    internal class KBZService
    {
        public bool Login()
        {
        BeforeName:
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine()!;
            var isTrue = Data.Users.FirstOrDefault(x => x.Name == name);
            if (isTrue == null)
            {
                Console.WriteLine("User Name Not Found");
                goto BeforeName;
            }
            else {
            BeforePhone:
                Console.Write("Enter Your Phone Number : ");
                string ph = Console.ReadLine()!;
                var isPhone = Data.Users.FirstOrDefault(y => y.Ph_No == ph);
                if (isPhone == null) {
                    Console.WriteLine("Invalid Phone Number");
                    goto BeforePhone;
                }
                else { 
                    
                    Console.WriteLine("Login Successful");
                    return true;
                }
            }
        }

        public void ViewUser()
        {
            foreach (var item in Data.Users)
            {
                Console.WriteLine($"Name : {item.Name}, Phone : {item.Ph_No}, Amount : {item.Amount}");
            }
            

        }
    }
}
