

namespace task4
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(" ");

            for(int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i]+ " ");
            }
        }
    }
}
