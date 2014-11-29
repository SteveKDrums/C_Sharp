using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk6_Lab1_Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            //User enters rainfall for each day
            Console.WriteLine("Enter rainfall for Monday");
            double Monday = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter rainfall for Tuesday");
            double Tuesday = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter rainfall for Wednesday");
            double Wednesday = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter rainfall for Thursday");
            double Thursday = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter rainfall for Friday");
            double Friday = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter rainfall for Saturday");
            double Saturday = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter rainfall for Sunday");
            double Sunday = Convert.ToDouble(Console.ReadLine());


            //Rainfall 4

            double[] rainFall = { 3.9, 0.7, 9.8, 0.1, 6.5, 3.2, 1 };
            rainFall[0] = Monday;
            rainFall[1] = Tuesday;
            rainFall[2] = Wednesday;
            rainFall[3] = Thursday;
            rainFall[4] = Friday;
            rainFall[5] = Saturday;
            rainFall[6] = Sunday;

            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            double total = 0;
            for (int i = 0; i < rainFall.Length; i++)
            {
                Console.WriteLine("The rainfall for {0} : {1}", weekDays[i], rainFall[i]);


                total = total + rainFall[i];
            }// end of for loop


            //output numbers
            Console.WriteLine("Total is {0}", total);
            Console.ReadLine();
        }
    }
}
