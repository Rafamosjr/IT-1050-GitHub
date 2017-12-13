using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmoscosoLabAssignment4
{
    class Program
    {
       
        static void Main(string[] args)
        {

            int adults;
            int tickets;
            double price;
            double totalCostPerAdult;
            double totalCostOfTrip;
            double totalAmountOfCandies;
            double totalCostOfCandies;
            double candies;
            



            System.Console.Write("How many adults?");
            adults =  int.Parse(System.Console.ReadLine());
            System.Console.ReadKey();

            System.Console.Write("How many tickets?");
            tickets = int.Parse(System.Console.ReadLine());
            System.Console.ReadKey();

            System.Console.Write("Enter price of ticket.");
            price = double.Parse(System.Console.ReadLine());
            System.Console.ReadKey();

            System.Console.Write("Enter price of candies.");
            candies = double.Parse(System.Console.ReadLine());
            System.Console.ReadKey();

            System.Console.Write("Enter amount of candies.");
            candies = int.Parse(System.Console.ReadLine());
            System.Console.ReadKey();

            System.Console.Write("Enter number of candies.");
            string inputString = System.Console.ReadLine();
            int inputInteger = int.Parse(inputString);

            if (inputInteger >= 5)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("You qualify for a 4th candy for free!");
            }

            else 
            {
                System.Console.WriteLine("You do not qualify for our promotion :(");
            }

            System.Console.ReadKey();

            totalCostPerAdult = tickets * adults;
            totalCostOfTrip = totalCostPerAdult * 2 + candies;
            totalAmountOfCandies = candies = int.Parse(System.Console.ReadLine());
            totalCostOfCandies = candies * 2;




        }
    }
}
