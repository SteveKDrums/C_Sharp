using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3_Lab1_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter Age
            Console.WriteLine("Enter your age");

            //Declare Age as Int and read to console
            int age = Convert.ToInt32 (Console.ReadLine());
           
            //Calculate
            //If < 16 || or //Or > 65
            if (age < 16 || age > 65)
                
                //Output
                Console.WriteLine("You are entitled to a discount");
            
            //Pause Program
            Console.ReadLine();
        }
    }
}
