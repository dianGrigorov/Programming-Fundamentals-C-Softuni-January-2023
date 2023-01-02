using System;
using System.Linq;

namespace _05.LogIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string logIn = Console.ReadLine();
            string password = Console.ReadLine();
            string reversedPass = string.Empty;
            int cnt = 0;
            for (int i = logIn.Length -1 ; i >= 0; i--)
            {
                reversedPass += logIn[i];
            }
            while (password != reversedPass)
            {
                cnt++;
                if (cnt >=4)
                {
                    Console.WriteLine($"User {logIn} blocked!");
                    return;
                }
               
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                password = Console.ReadLine();
            }
            if (password == reversedPass)
            {
                Console.WriteLine($"User {logIn} logged in.");
            }
        }
    }
}
