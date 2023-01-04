using System;

namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char firstChar = 'a';
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                {
                    
                    for (int k = 0; k < n; k++)
                    {
                        firstChar = (char)('a' + i);
                        Console.Write(firstChar);

                        firstChar = (char)('a' + j);
                        Console.Write(firstChar);

                        firstChar = (char)('a' + k);
                        Console.Write(firstChar);

                        Console.WriteLine();
                    }
                    



                }
                

            }
            
        }
    }
}
