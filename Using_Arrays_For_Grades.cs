using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk6_Lab1_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Tom", "Mary", "Joe" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(names[i]);
            }
            
            
            int[] grades = new int[5];
            int[] grades = { 40, 50, 60, 70, 80 };

            int total = 0;

            for (int i = 0; i < grades.Length; i++)

            {
                total = total + grades[i];
               // 0 = 0 + 40;
                //40 = 40 + 50;
                //90 = 90 + 60;

            }

            Console.WriteLine(total);

            int sum = 0;

            sum = grades[0] = grades[1];

            Console.WriteLine("The sum of {0} and {1} is {2}", grades[0], grades[1], sum);

            grades[0] = 200;
            grades[4] = 15;
           // grades[5] = 10;
            //grades[0] = "Tom";

           // int num = "tom";


            sum = grades[0] + grades[1];
            Console.WriteLine("The sum of {0} and {1} is {2}", grades[0], grades[1], sum);

            Console.ReadLine();






        }
    }
}
