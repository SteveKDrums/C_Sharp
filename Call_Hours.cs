using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk_3_Lab_1_Ex_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter how many calls made
            Console.WriteLine("Enter the amount of calls made");
           
            //Read calls as double
            double calls = Convert.ToDouble(Console.ReadLine());
           
            //Enter how many minutes spent on the phone
            Console.WriteLine("How many minutes have you spent on the phone?");
           
            //Read as double
            double minutes = Convert.ToDouble(Console.ReadLine());
            //Calculate

                // If > 100 call or > 500 minutes
            if (calls > 100 || minutes > 500)

                //Print extra charge of 20 euro
                Console.WriteLine("There is an extra charge of 20 euro this month");

                    //else print no extra charge
            else
                Console.WriteLine("There is no extra charge");
                //Pause Program

            Console.ReadLine();


        }
    }
}
