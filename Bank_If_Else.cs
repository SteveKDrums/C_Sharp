using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3_Lab1_Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
           decimal balance = rand.Next(100);
           
            //Enter How much to withdraw
            Console.WriteLine("How much would you like to withdraw?");
           
            //declare decimal
            decimal withDraw = Convert.ToDecimal(Console.ReadLine());
           
            //Display balance of account random

            Console.WriteLine(balance);
           
  

            //Program decide if sufficent funds available and Output Approved or declined
            if (withDraw > balance)
                Console.WriteLine("Declined");
            else
                Console.WriteLine("Approved");

            

            //Pause program
            Console.ReadLine();
        }
    }
}
