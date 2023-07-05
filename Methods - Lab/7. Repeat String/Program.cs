

namespace _7._Repeat_String
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string finalResult = MultiplyingStringNumbersOfTime(str, count);
            Console.WriteLine(finalResult);
        }

        static string MultiplyingStringNumbersOfTime(string str, int count)
        {
            string finalResult = str;
            for (int i = 1; i < count; i++)
            {
                finalResult += str;
            }
            return finalResult;
        }
    }
}
