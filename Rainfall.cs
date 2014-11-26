using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk6_Lab1_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] rainFall = { 3.9, 0.7, 9.8, 0.1, 6.5, 3.2, 1 };
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            double total = 0;
            for (int i = 0; i < rainFall.Length; i++)
            {
                Console.WriteLine("{0} : {1}", weekDays[i], rainFall[i]);

                total = total + rainFall[i];
            }// end of for loop


            //output numbers
            Console.WriteLine("Total is {0}", total);
            Console.ReadLine();
        }
    }
}
