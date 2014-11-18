using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Lab_1_Q4
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
            decimal hoursWorked = Convert.ToDecimal(Console.ReadLine());
            //Calculate

            //are hours greater than 40
            if (hoursWorked > 40m)
            {
                //if they are by how many
                decimal overTimehours = hoursWorked - 40;
                //Overtime rate
                decimal overTimerate = rate * 1.5m;
                //work out basic
                decimal basic = 40 * rate;
                //work out overtime
                decimal overTimetotal = overTimehours * overTimerate;
                //work out total
                decimal total = basic + overTimetotal;

                Console.WriteLine("Your pay is {0:f)", total);

            }

            //if not simple calculation
            else
            {
                Console.WriteLine("Your rate of pay is {0:f}", rate * hoursWorked);


            }

            //Readline

            Console.ReadLine();

        }


    }

}