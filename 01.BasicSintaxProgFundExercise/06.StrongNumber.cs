using System;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            string numStr = num.ToString();

            for (int i = 0; i < numStr.Length; i++)
            {
                int fact = int.Parse(numStr[i].ToString());
                if (fact != 0)
                {
                    for (int j = fact -1; j > 1; j--)
                    {
                        fact *= j;
                        
                    }
                    sum += fact;
                }
                else
                {
                    sum++;
                }

                
                
            }
            if (num == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
