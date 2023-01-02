using System;
using System.Collections.Generic;
using System.Drawing;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // Input
            int lostGame = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            //Logic
            int headsetCnt = lostGame / 2;
            int mouseCnt = lostGame / 3;
            int keyboardCnt = lostGame / 6;
            int displayCnt = lostGame / 12;

            double totalCost = headsetCnt * headsetPrice + mouseCnt * mousePrice + 
                keyboardCnt * keyboardPrice + displayCnt *displayPrice;

            // Output
            Console.WriteLine($"Rage expenses: {totalCost:f2} lv.");
        }
    }
}
