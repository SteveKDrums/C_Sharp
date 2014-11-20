using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3_Lab1_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare an integer x
           
            int x = Convert.ToInt32(Console.ReadLine());
            //x=0
            x = 0;
            //subtract 3 from x
            int subtract = 3 - x;
            Console.WriteLine("3-x ={0}",subtract);
            //multiply x by 10
            int multiply = x * 10;
            Console.WriteLine("x * 10 ={0}",multiply);
            //divide x by 2
            int divide = x / 2;
            Console.WriteLine("x / 2 ={0}",divide);
            //assign the remainder of x to 4 by x
            int remainder = x % 4;
            Console.WriteLine("x % 4 * x ={0}",remainder);

            Console.ReadLine();
        }
    }
}
