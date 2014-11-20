using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3_Lab1_Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for name
            Console.WriteLine("What is your name?");
            //Read name
            string name = Console.ReadLine();
            //Calculate
            if (name != "Keith")
            //Output
                Console.WriteLine("You are welcome");
            else
                Console.WriteLine("You cannot come into the club");
            

            //Pause
            Console.ReadLine();
        }
    }
}
