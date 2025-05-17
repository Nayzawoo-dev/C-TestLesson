using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KPZPay
{
    internal class KBZService
    {
        public bool Login()
        {
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine()!;
            var isTrue = Data.Users.FirstOrDefault(x => x.Name == name);
            if (isTrue == null)
            {
                Console.WriteLine("User Name Not Found!");
                return false;
            }
            else {
            BeforePhone:
                Console.Write("Enter Your Phone Number : ");
                string ph = Console.ReadLine()!;
                var isPhone = Data.Users.FirstOrDefault(y => y.Ph_No == ph);
                if (isPhone == null) {
                    Console.WriteLine("Invalid Phone Number!");
                    goto BeforePhone;
                }
                else { 
                    
                    Console.WriteLine("Login Successful!");
                    Console.WriteLine($"Name : {isTrue.Name} , Phone Number : {isTrue.Ph_No} , Balance : {isTrue.Amount}");
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


        public void InsertMoney()
        {
         Console.Write("Enter Insert Money Phone Number : ");
         string ph = Console.ReadLine()!;
         var ph_no = Data.Users.FirstOrDefault(x => x.Ph_No == ph);
            if (ph_no == null) {
                Console.WriteLine("Your Phone Number Not Found!");

            }
            else
            {
                Console.WriteLine("Enter Your Insert Money Amount : ");
                int amt = Convert.ToInt32(Console.ReadLine()!);
                ph_no.Amount += amt;
                Console.WriteLine($"Successfully Insert Money This Phone Number {ph_no.Ph_No}");
            }
         
         
        }

        public void TransferMoney() {
            Console.Write("Enter Your Phone Number : ");
            string ph = Console.ReadLine()!;
            var ph_no = Data.Users.FirstOrDefault(x => x.Ph_No == ph);
            if (ph_no == null) { 
            Console.WriteLine("Phone Number Not Found!");
            }
            else
            {
            amt:
                Console.Write("Enter Your Transfer Money Amount : ");
                int amt = Convert.ToInt32(Console.ReadLine()!);
            again:
                Console.Write("Enter Your Transfer Phone Number : ");
                string phNum = Console.ReadLine()!;
                var isphoneNum = Data.Users.FirstOrDefault(y => y.Ph_No == phNum);
                if (isphoneNum == null) {
                    Console.WriteLine("Your Transfer Phone Number Not Found");
                    goto again;
                }
                else
                {
                    if(ph_no.Amount < amt)
                    {
                        Console.WriteLine("Your Balance is Not Enough");
                        goto again;
                    }
                    else
                    {   
                        ph_no.Amount -= amt;
                        isphoneNum.Amount += amt;
                        Console.WriteLine($"You are Successfully This Phone Number {isphoneNum.Ph_No}");
                        Console.WriteLine($"Your Balance is {ph_no.Amount}");
                    }
                    
                }
               
            }
        }

        public void withDraw()
        {
            Console.Write("Enter WithDraw Money Phone Number : ");
            string ph = Console.ReadLine()!;
            var ph_no = Data.Users.FirstOrDefault(x => x.Ph_No == ph);
            if (ph_no == null)
            {
                Console.WriteLine("Your Phone Number Not Found!");

            }
            else
            {
            again:
                Console.Write("Enter WithDraw Money : ");
                int amt = Convert.ToInt32(Console.ReadLine())!;
                if (ph_no.Amount < amt)
                {
                    Console.WriteLine("Not Enough Money");
                    goto again;
                }
                else
                {
                    ph_no.Amount -= amt;
                    Console.WriteLine("You are Successfully WithDraw!");
                    Console.WriteLine($"Your Balance is {ph_no.Amount}");
                }
            }


        }

        public void CreateAcc()
        {
        rename:
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine()!;
                Data.UserId++;
                Console.Write("Enter Your Phone Number : 09");
                string phone = Console.ReadLine()!;
                string ph_no = "09" + phone;
                Console.Write("Enter Your Amount : ");
                int amt = Convert.ToInt32(Console.ReadLine());
                User user = new User(Data.UserId,name,ph_no,amt);
                Data.Users.Add(user);
            
        }
    }
}
