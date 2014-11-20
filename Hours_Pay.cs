using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3_Lb1_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for hourly pay
            Console.WriteLine("What is your hourly pay");
            //Read in and store
            decimal rate = Convert.ToDecimal(Console.ReadLine());
            //Ask for hours worked
            Console.WriteLine("Enter hours worked");
            //Read in and store
            int hoursWorked = Convert.ToInt32(Console.ReadLine());

            //are hours worked > 40
            if (hoursWorked > 40)
            {
                //if so
                int overTimeHours = hoursWorked - 40;
 
                decimal totalPay = 40 * rate  + (overTimeHours * (rate * 1.5m));

                //total pay

                Console.WriteLine("Total pay is {0}", totalPay);

            }

            //if hours< 40 * rate by hours
            else
            {
                decimal pay = hoursWorked * rate;
                Console.WriteLine("Total pay is {0}", pay);
            }
            Console.ReadLine();
        }
    }
}
