using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3_Lab4_Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter salary
            Console.WriteLine("Enter your salary");
            //read as decimal
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            //Enter yearsworked
            Console.WriteLine("Enter years worked");
            //read as decimal
            decimal yearsWorked = Convert.ToDecimal(Console.ReadLine());
            
            //Calculate
            //if salary is >= 30,000 or yearsworked >=2
            if (salary >= 30000 && yearsWorked >= 2)

                //Output You qualfy for the loan
                Console.WriteLine("You qualify for the loan");

            //else //Output You do not qualify for the loan
            else
                Console.WriteLine("You don't qualify for the loan");

            //Pause Program

            Console.ReadLine();


        }
    }
}
