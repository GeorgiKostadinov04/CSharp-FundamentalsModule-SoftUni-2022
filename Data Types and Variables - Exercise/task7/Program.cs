

namespace task7
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            int totalLiters = 0;

            for (int i = 1; i <= n; i++)
            {
                int currLiters = int.Parse(Console.ReadLine());
                totalLiters += currLiters;
                if(totalLiters >255)
                {
                    totalLiters -= currLiters;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(totalLiters);
        }
    }
}
