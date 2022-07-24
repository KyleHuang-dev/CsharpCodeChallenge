using System;

namespace bus_discount_220
{
    /*
*A city offers the following prices for monthly bus passes:

Age 0 - 5: $0
Age 6 - 17: $80
Age 18+ and less than $15,000 income: $30
Age 65+ and less than $30,000 income: $70
City employee: $50
General population: $100
Write a program that finds the best bus price for a given user.
*/

    using System;

    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your income?");
            int income = int.Parse(Console.ReadLine());
            Console.WriteLine("Are you work for City? y/n");
            string cityWorker = Console.ReadLine();

            bool isCityWorker = cityWorker == "y" ? true : false;

            if (age <= 5)
                Console.WriteLine("The price for your monthly pass is $0");
            else if (age >= 18 && income < 15000)
                Console.WriteLine("The price for your monthly pass is $30");
            else if (isCityWorker)
                Console.WriteLine("The price for your monthly pass is $50");
            else if (age >= 65 && income < 30000)
                Console.WriteLine("The price for your monthly pass is $70");
            else if (age >= 6 && age <= 17)
                Console.WriteLine("The price for your monthly pass is $80");
            else
                Console.WriteLine("The price for your monthly pass is $100");
        }
    }
}

