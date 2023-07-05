

namespace _4._Printing_Triangle
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            for(int rows = 1; rows <= n; rows++)
            {
                for(int cols = 1; cols <= rows; cols++)
                {
                    Console.Write(cols+ " ");
                }
                Console.WriteLine();
            }
            PrintingTheRestOfTriangle(n);
        }

        static void PrintingTheRestOfTriangle(int number)
        {
            for (int i = number-1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
