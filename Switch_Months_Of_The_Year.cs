using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3_Lab1_Q13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for month
            Console.WriteLine("What month?");
            //Store month as int
            string month = (Console.ReadLine());
            //Switch statement for month
            switch (month)

            {
                case "January":
                case "March":
                case "May":
                case "July":
                case "August":
                case "October":
                case "December":
                    Console.WriteLine("There are 31 days in {0}", month);
                    break;

                case "April":
                case "June":
                case "September":
                    Console.WriteLine("There are 30 days in {0}", month);
                        break;
               
                case "February":
                    Console.WriteLine("There are 28 days in {0}", month);
                    break;

                default:
                    Console.WriteLine("Not a month");
                    break; 
            }


            //Pause program
            Console.ReadLine();
        }
    }
}
