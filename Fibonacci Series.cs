using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, add = 1, i = 0, j = 1;
            Console.Write("Please enter Limit :");
            max = Convert.ToInt32(Console.ReadLine());
            Console.Write(i);

            while(add<=max)
            {
                Console.Write(" "+ add +" ");
                add = i + j;
                i = j;
                j = add;
            }
            Console.ReadLine();
        }
    }
}
