using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Account
    {
        public string AccountNo { get; set; }
        public string OpeningDate { get; set; }
        public double Balance { get; private set; }


        public bool Deposit(double amount)
        {
            Balance += amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            Balance -= amount;
            return true;
        }

    }
}
