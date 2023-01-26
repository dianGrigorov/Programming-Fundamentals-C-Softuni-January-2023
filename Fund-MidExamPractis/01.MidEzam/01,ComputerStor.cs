using System;

namespace ComputerStor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string command;
            decimal sum = 0;
            while ((command = Console.ReadLine()) != "special")
            {
                if (command == "regular")
                {
                    break;
                }
                decimal partPrice = decimal.Parse(command);
                if (partPrice < 0)
                {
                    Console.WriteLine("Invalid price!");

                }
                else
                {
                    sum += partPrice;
                }

            }
            decimal taxesPrice = sum * 0.2m;
            decimal totalSum = sum + taxesPrice;

            if (command == "special")
            {
                totalSum *= 0.9m;
            }
            if (sum <= 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {taxesPrice:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalSum:f2}$");

            }
        }
    }
}
