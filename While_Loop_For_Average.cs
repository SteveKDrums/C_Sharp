using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4_Lab1_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int total = 0;
            int counter = 1;

            while (counter <= 3)
            {
                Console.WriteLine("Enter number",num1);
                Console.ReadLine();
                counter++;
            
            }
            total = num1;
            int average = (3 / num1 );

            Console.WriteLine("The average number is {0}", average);
            Console.ReadLine();


        }

    }
}
