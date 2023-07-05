

namespace Lection2Exe
{
    using System;
    using System.Numerics;
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());
            int fourthInt = int.Parse(Console.ReadLine());

            long firstResult = firstInt + secondInt;
            long secondResult = firstResult / thirdInt;
            BigInteger finalResult = secondResult * fourthInt;

            Console.WriteLine(finalResult);
        }
    }
}
