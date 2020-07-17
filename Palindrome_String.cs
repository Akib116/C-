using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_String
{
    class Palindrome_String
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide input string");
            string input = Console.ReadLine();
            string reverse = string.Empty;
            int length = input.Length - 1;

            while(length>=0)
            {
                reverse = reverse + input[length];
                length--;
            }
            if (input == reverse)
            {
                Console.WriteLine($"{input} is palindrome string");
            }
            else
            {
                Console.WriteLine($"{input} is not palindrome string");

            }
            Console.ReadKey();
        }
    }
}
