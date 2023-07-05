namespace task9
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int oddCounter = int.Parse(Console.ReadLine());
            int totalsum = 0;
            int currNum = 1;
            for (int i = 1; i <= oddCounter; i++)
            {
                Console.WriteLine(currNum);
                totalsum += currNum;
                currNum += 2;

            }
            Console.WriteLine($"Sum: {totalsum}");
        }
    }
}
