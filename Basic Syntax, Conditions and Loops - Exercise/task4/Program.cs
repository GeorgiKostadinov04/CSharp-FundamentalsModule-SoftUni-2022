

namespace task4
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for(int i = n; i <= j; i++)
            {
                Console.Write(i+ " ");
                totalSum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
