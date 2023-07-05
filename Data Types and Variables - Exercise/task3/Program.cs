

namespace task3
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            double courses = n / p;

            Console.WriteLine(Math.Ceiling(courses));
            



        }
    }
}
