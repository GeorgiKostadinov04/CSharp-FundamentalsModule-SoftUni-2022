

namespace task5
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int i = startNum; i <= endNum; i++)
            {
                char currChar = (char)i;
                Console.Write(currChar + " ");
            }
        }
    }
}
