using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    class Constructor
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("SADMAN", "SHAKIB", "AKIB");

            string fullname = p1.GetFullName();
            Console.WriteLine(fullname);
            Console.ReadKey();
        }
    }
}
