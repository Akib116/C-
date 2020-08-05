using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linear_Search
{
    class LinearSearch
    {
        static void Main(string[] args)
        {
            int[] value = { 1, 3, 5, 6, 9, 7, 11, 13, 17, 21, 18, 15, 20 };
            Console.WriteLine("Enter seach number: ");
            int givenNumber = Convert.ToInt32(Console.ReadLine());
            bool searchFound = false;

            for(int i=0;i<value.Length; i++)
            {
                if (value[i] == givenNumber) {
                Console.WriteLine("Search is Successful");
                Console.WriteLine($"The given number {givenNumber} is in {i} index or {i+1} position");
                    searchFound = true;
                }
            }
            if (!searchFound)
                Console.WriteLine("Search is unsuccessful");
            Console.ReadKey();
        }

    }
}
