using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZPay
{
    internal class User
    {
        public int id;
        public string Name;
        public string Ph_No;
        public int Amount;
        public User(int Id,string name,string Phone,int amount) { 
        id = Id; 
        Name = name;
        Ph_No = Phone;
        Amount = amount;
        }
    }
}
