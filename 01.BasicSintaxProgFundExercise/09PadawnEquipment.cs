using System;
using System.Text.RegularExpressions;

namespace _09PadawnEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            int freeBelt = students / 6;
            double moneyNeaded = 0;



            //Logik

            moneyNeaded = lightsabersPrice * (students + Math.Ceiling(students * 0.1)) +
                    robesPrice * students +
                    (students - freeBelt) * beltPrice;
            if (moneyNeaded <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeaded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(moneyNeaded - money):f2}lv more.");
            }



            //Output
        }
    }
}
