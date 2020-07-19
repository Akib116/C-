using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class main
    {
        static void Main(string[] args)
        {
            SavingAccount s1 = new SavingAccount();
            s1.AccountNo = "001";
            s1.OpeningDate = "19/07/2020";
            s1.InterestAmount = 100;
            s1.Deposit(500);
            s1.Withdraw(200);

            Console.WriteLine(s1.AccountNo);
            Console.WriteLine(s1.OpeningDate);
            Console.WriteLine(s1.InterestAmount);
            Console.WriteLine(s1.Balance);
            Console.ReadKey();


        }
    }
}
