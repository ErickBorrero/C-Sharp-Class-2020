using System;

namespace BasicIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GetUserData();
            Console.ReadLine();
        }
        private static void GetUserData()
        {
            System.Console.Write("Your Name: ");
            string userName = Console.ReadLine();
            System.Console.Write("Your Age: ");
            string userAge = Console.ReadLine();

            System.Console.WriteLine("Hello {0}! You are {1} years old!", userName, userAge);
        }

    }
}
