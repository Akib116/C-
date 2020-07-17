using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome_number
{
    class Palindrome_number
    {
        static void Main(string[] args)
        {
            int num, temp, revNum = 0, rem;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;

            while(num>0)
            {
                rem = num % 10;
                revNum = revNum * 10 + rem;
                num = num / 10;
            }
            if(revNum==temp)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not palindrome");
            }
            Console.ReadKey();
        }
    }
}
