using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Lab1Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter Grade 1
            Console.WriteLine("Please enter your grade one e.g 65");
            //Read Grade1 as int
            int gradeOne = Convert.ToInt32(Console.ReadLine());        
         
            //calculate
            {
                //If grade1 is >80 A
                if (grade1 > 80)
                    Console.WriteLine("Your grade 1 is A");
                //else if grade is > 70 B
                else if (grade > 70)
                    Console.WriteLine("Your grade 1 is B");
                //else if grade is > 60 C
                else if (grade > 60)
                    Console.WriteLine("Your grade 1 is C");
                //else if grade is > 50 D
                else if (grade > 50)
                    Console.WriteLine("Your grade 1 is D");
                //else if grade is < 50 F
                else if (grade < 50)
                    Console.WriteLine("Your grade 1 is F");
            
            
            //Enter Grade 2
            Console.WriteLine("Please enter your grade 2 e.g 65");
            //Read Grade as int
            int grade2 = Convert.ToInt32(Console.ReadLine());

                 //If grade2 is >80 A
                if (grade2 > 80)
                    Console.WriteLine("Your grade 2 is A");
                //else if grade is > 70 B
                else if (grade2 > 70)
                    Console.WriteLine("Your grade 2 is B");
                //else if grade is > 60 C
                else if (grade2 > 60)
                    Console.WriteLine("Your grade 2 is C");
                //else if grade is > 50 D
                else if (grade2 > 50)
                    Console.WriteLine("Your grade 2 is D");
                //else if grade is < 50 F
                else if (grade2 < 50)
                    Console.WriteLine("Your grade 2 is F");

           
            //Enter Grade 3
            Console.WriteLine("Please enter your grade 3 e.g 65");
            //Read Grade1 as int
            int grade3 = Convert.ToInt32(Console.ReadLine());
            

                 //If grade3 is >80 A
                if (grade3 > 80)
                    Console.WriteLine("Your grade 3 is A");
                //else if grade is > 70 B
                else if (grade3 > 70)
                    Console.WriteLine("Your grade 3 is B");
                //else if grade is > 60 C
                else if (grade3 > 60)
                    Console.WriteLine("Your grade 3 is C");
                //else if grade is > 50 D
                else if (grade3 > 50)
                    Console.WriteLine("Your grade 3 is D");
                //else if grade is < 50 F
                else if (grade3 < 50)
                    Console.WriteLine("Your grade 3 is F");
            }
            //Read output
            
            //Pause program
            Console.ReadLine();
        }
    }
}
