

namespace task2
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;
            
            while(n > 0)
            {
                int currNum = n % 10;
                n /= 10;
                totalSum += currNum;
            }
            Console.WriteLine(totalSum);

        }
    }
}
