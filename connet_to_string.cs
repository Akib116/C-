using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_two_string
{
    class connet_to_string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First name=");
            String Firstname = Console.ReadLine();
            Console.WriteLine("Enter Second name=");
            String Secondname = Console.ReadLine();
            String Fullname = Firstname + Secondname;
            Console.WriteLine("Full name is={0}", Fullname);
            Console.ReadKey();
        }
    }
}
