using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3_Lab1_Q14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user to withdraw etc
            Console.WriteLine("Please choose an option Withdraw/Deposit/Check balance/Pay a bill/Exit");

            //read in do as string
            string option = Console.ReadLine();
           

           //switch statement
                switch (option)
                {
                    case "Withdraw":
                        Console.WriteLine("How much would you like to withdraw?");
                        break;
                    case "Deposit":
                        Console.WriteLine("How much would you like to deposit?");
                        break;
                    case "Check balance":
                        Console.WriteLine("Your balance is");
                        break;
                    case "Pay a bill":
                        Console.WriteLine("Please insert amount");
                        break;
                    case "Exit":
                        Console.WriteLine("Have a nice day");
                        break;
                    default:
                        Console.WriteLine("That is not a valid selection");
                        break;
                
                }
 
            //pause program
            Console.ReadLine();
        }
    }
}
