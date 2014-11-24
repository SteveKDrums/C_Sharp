using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4_Lab1_Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter valid number
            Console.WriteLine("Please enter a valid number");

            //Read number as int
            int num = Convert.ToInt32(Console.ReadLine());

            //Declare counter
            

            //Calculate with while statement  //While number is <0 >20 //Print repeated question
            while (num <0 ||num >20)

            {Console.WriteLine("{0} is not a valid",num);

            Console.ReadLine();
            
            }

            Console.ReadLine();
        
            //if number is >=0 or <=20
            if (num >= 0 || num <= 20)

            //Print that is a valid number
            {
                Console.WriteLine("That is a valid number"); 
            
            }

            //Pause Program
            Console.ReadLine();

        }
    }
}
