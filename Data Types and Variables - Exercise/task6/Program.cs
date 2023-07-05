

namespace task6
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int final = 97 + n;
            
            for(int i = 97; i < final; i++)
            {
                for(int j = 97; j < final; j++)
                {
                    for(int k = 97; k < final; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
