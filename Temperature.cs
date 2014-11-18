using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lab2Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the temperature");
            int temperature = Convert.ToInt32 (Console.ReadLine());

            if (temperature<15)
            Console.WriteLine("Put on your coat");

            Console.ReadLine();

        }
    }
}
