/*
 * Program to calculate fuel consumption
 * Date: 24/10/13
 * Author: Stephen Kohlmann
 * 
 * 
 * Reads the capacity and fuel consumption of a car from user.
 * Asks for the distance to be travelled of a journey. 
 * Calculates the required miles and fuel for 10 gallons.
 * 
 * 
 * 1.0 Read Capacity
 * 2.0 Read fuel consumtion
 * 3.0 Read distance
 * 4.0 Cars range = Capacity * Distance
 * 5.0 Fills = Distance / Range
 * 6.0 Round Fills to the nest whole number
 * 7.0 Miles per litre = consumption / 1.609344
 * 8.0 Miles per gallon = miles per litre / 0.2199
 * 9.0 Miles for 10 gallons = miles per gallon * 10
 * 10.0 Write fills
 * 11.0 Write miles for 10 gallons
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2_Lab_1_Ex12
{
    class Program
    {
        static void Main(string[] args)
        {

            //read capacity
            Console.WriteLine("Enter the capacity of your engine");
            string input1 = Console.ReadLine();
            double capacity = Convert.ToDouble(input1);

            //read fuel consumption
            Console.WriteLine("Enter fuel consumption per 100km");
            string input2 = Console.ReadLine();
            double consumption = Convert.ToDouble(input2);

            //read distance
            Console.WriteLine("Please enter the distance you need to travel");
            string input3 = Console.ReadLine();
            double distance = Convert.ToDouble(input3);

            //cars range =capacity * consumption
            double kmPerLitre = (100 / consumption);
            double carsRange = (capacity * kmPerLitre);

            //Fills = Distance/Range
            double fills = (distance / carsRange);

            //Miles per litre
            double milesPerLitre = (consumption / 1.609);

            //Miles per gallon
            double milesPerGallon = (milesPerLitre / 0.21);
            
            //Miles for 10 gallons
            double milesFor10Gallons = (milesPerGallon * 10);

            //Write number of fills required
            Console.WriteLine("The number of fills required is {0}", Math.Ceiling (fills));

            //Write miles for 10 gallons
            Console.WriteLine("You can travel {0:f) miles on 10 gallons", milesFor10Gallons);

            //Pause Program
            Console.ReadLine();


        }
    }
}
