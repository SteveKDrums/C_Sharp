using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wee4_Lab1_Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare random number
            Random rand1 = new Random();
            int randomNumber = rand1.Next(0, 21);
            int guesses = 1;
            //Random rand1 = new Random();
            //int randomNumber =rand1.Next (0,21);
            //int guesses = 1

            //Write please pick a number between 0-20
            Console.WriteLine("Please pick a number between 0-20");

            //Declare int as guess
            int guess = Convert.ToInt32 (Console.ReadLine());

            //While loop While (gues != randomNumber)  //Write (incorrect please try again) guesses ++
            while (guess != randomNumber)
            {
                Console.WriteLine("Incorrect number, please try again");
                guess = Convert.ToInt32(Console.ReadLine());
                guesses++; 
            
            }
           
            //Write (Well done it took {0}, guesses)
            Console.WriteLine("Well done it took {0} guesses", guesses);

            //Read Program
            Console.ReadLine();
        }
    }
}
