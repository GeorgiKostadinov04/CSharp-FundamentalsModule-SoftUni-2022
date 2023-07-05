

namespace arraysExercise
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] passengers = new int[n];
            int totalSum = 0;

            for (int i = 0; i < n; i++)
            {
               int currNum = int.Parse(Console.ReadLine());
                passengers[i] = currNum;
                totalSum += currNum;

            }
            Console.Write(String.Join(" ", passengers));
            Console.WriteLine();
            Console.WriteLine(totalSum);
        }
    }
}
