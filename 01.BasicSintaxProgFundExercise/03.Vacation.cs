using System;
using System.Security.Cryptography;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            decimal price = 0;
            decimal totalPrice = 0;

            switch (day)
            {
                case "Friday":
                    switch (type)
                    {
                        case "Students":
                            price = 8.45m;
                            break;
                        case "Business":
                            price = 10.9m;
                            break;
                        case "Regular":
                            price = 15;
                            break;
                    }
                    break;
                case "Saturday":
                    switch (type)
                    {
                        case "Students":
                            price = 9.8m;
                            break;
                        case "Business":
                            price = 15.6m;
                            break;
                        case "Regular":
                            price = 20;
                            break;
                    }
                    break;
                case "Sunday":
                    switch (type)
                    {
                        case "Students":
                            price = 10.46m;
                            break;
                        case "Business":
                            price = 16.0m;
                            break;
                        case "Regular":
                            price = 22.5m;
                            break;
                    }
                    break;
            }


            if (type == "Students")
            {
                totalPrice = price * people;
                if (people >= 30)
                {
                    totalPrice *= 0.85;
                }
            }
            if (type == "Business")
            {
                
                if (people >= 100)
                {
                    totalPrice = price * (people - 10);
                }
                else
                {
                    totalPrice = price * people;
                }
            }
            if (type == "Regular")
            {
                using System;
                using System.Security.Cryptography;

namespace _03.Vacation
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int people = int.Parse(Console.ReadLine());
                string type = Console.ReadLine();
                string day = Console.ReadLine();
                decimal price = 0;
                decimal totalPrice = 0;

                switch (day)
                {
                    case "Friday":
                        switch (type)
                        {
                            case "Students":
                                price = 8.45m;
                                break;
                            case "Business":
                                price = 10.9m;
                                break;
                            case "Regular":
                                price = 15;
                                break;
                        }
                        break;
                    case "Saturday":
                        switch (type)
                        {
                            case "Students":
                                price = 9.8m;
                                break;
                            case "Business":
                                price = 15.6m;
                                break;
                            case "Regular":
                                price = 20;
                                break;
                        }
                        break;
                    case "Sunday":
                        switch (type)
                        {
                            case "Students":
                                price = 10.46m;
                                break;
                            case "Business":
                                price = 16;
                                break;
                            case "Regular":
                                price = 22.5m;
                                break;
                        }
                        break;
                }


                if (type == "Students")
                {
                    totalPrice = price * people;
                    if (people >= 30)
                    {
                        totalPrice *= 0.85m;
                    }
                }
                if (type == "Business")
                {
                    totalPrice = price * people;
                    if (people >= 100)
                    {
                        totalPrice = price * (people - 10);
                    }
                }
                if (type == "Regular")
                {
                    totalPrice = price * people;
                    if (people >= 10 && people <= 20)
                    {
                        totalPrice *= 0.95m;
                    }
                }
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
        }
    }

    totalPrice = price * people;
                if (people >= 10 && people <= 20)
                {
                    totalPrice *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
