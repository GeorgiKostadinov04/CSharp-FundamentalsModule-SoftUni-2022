

namespace task4
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int rotationCount = int.Parse(Console.ReadLine());
            if(rotationCount == numbers.Length)
            {
                Console.WriteLine(String.Join(" ",numbers));
                return;
            }

            for(int i = 1; i <= rotationCount; i++)
            {
                int toLastIndex = numbers[0];
                for(int j = 1; j <= numbers.Length-1 ; j++)
                {
                    numbers[j - 1] = numbers[j];
                }
                numbers[numbers.Length-1] = toLastIndex;
            }
            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
