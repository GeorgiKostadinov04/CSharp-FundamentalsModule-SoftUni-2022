

namespace task5
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = String.Empty;
            int counter = 1;

            for(int i = username.Length-1; i >=0; i--)
            {
                password = password + username[i];
            }
            string guess;

            while((guess = Console.ReadLine()) != password)
            {
                if(counter >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    Environment.Exit(0);
                }
                counter++;
                Console.WriteLine("Incorrect password. Try again.");

            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
