using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4_Lab1_Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            string x = "goofy";
            
            Console.WriteLine("Please enter password");
            password = Console.ReadLine();
            while (password != x)
            {
                Console.WriteLine("Incorrect password, please try again");
                password = Console.ReadLine();
            
            }

            Console.WriteLine("Correct Password");
                Console.ReadLine();
        }
    }
}
