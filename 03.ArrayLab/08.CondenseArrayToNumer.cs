using System;
using System.Linq;

namespace _08.CondenseArrayToNumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[arr.Length -1];

            while (arr.Length > 1 )
            {

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    condensed[i] = arr[i] + arr[i + 1];

                    if (i == condensed.Length - 1)
                    {
                        arr = condensed;
                        condensed = new int[arr.Length - 1];
                    }
                }
                
            }


            Console.WriteLine(arr[0]);


        }
    }
}
