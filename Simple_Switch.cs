using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3_Lab1_Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user do you like programming
            Console.WriteLine("Do you like programming? Yes/No/Maybe");
            //Read in string
            string answer = Console.ReadLine();
            //Switch statement yes/no/maybe
            switch (answer)
            {
                case  "Yes":
                case  "Maybe":
                    Console.WriteLine("Great");
                    break;
                case "No":
                    Console.WriteLine("Oh well");
                    break;   
            }
           
            //pause program
            Console.ReadLine();
        }
    }
}
