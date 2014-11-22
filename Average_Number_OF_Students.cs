using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4_Lab4_Q8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of students in the class");
            int students = Convert.ToInt32(Console.ReadLine());

            int num1 = 0;
            int total = 0;
            int counter = 1;

            while (counter <= 3)
            {
                Console.WriteLine("Enter Grade or -1");
                num1 = Convert.ToInt32(Console.ReadLine());
                total = total + num1;

                counter++;

            }

            int average = (total / students);

            Console.WriteLine("The average number is {0}", average);
            Console.ReadLine();
        }
    }
}
