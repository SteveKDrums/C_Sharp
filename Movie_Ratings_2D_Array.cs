using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_Lb1_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Movie Ratings – 2D Array.
          //Create a 2D array which has movie ratings for 3 films.  Each film has 3 reviews.  Output the average rating for each film.

            double[] reviews = new double[3];

            double average;

            int[,] ratings = {

                            {3,4,5},
                            {1,2,1},
                            {5,4,2}
                       
                            };

            //loop for each row
            for (int i = 0; i < 2; i++)
            {
                //loop for each review
                average = 0;
                for (int j = 0; j < 3 ; j++)
                {
                    average = average + ratings[1,2];   
                }
                reviews[i] = average / 3;
            }
            //loop output
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("The average rating is {0} is {1:F}", i + 1, reviews[i]);
            }

            Console.ReadLine();




        }
    }
}
