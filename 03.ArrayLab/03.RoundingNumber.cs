using System;
using System.Linq;

namespace _03.RoundingNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numb = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] roundedNum = new int[numb.Length];
            for (int i = 0; i < numb.Length; i++)
            {
                roundedNum[i] = (int)Math.Round(numb[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < roundedNum.Length; i++)
            {
                Console.WriteLine(numb[i] + " => " + roundedNum[i]);
            }
        }
    }
}
