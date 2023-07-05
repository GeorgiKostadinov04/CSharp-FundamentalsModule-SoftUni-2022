

namespace Methods___Lab
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string keyword = IsnumberPositiveNegativeOrZero(num);

            Console.WriteLine($"The number {num} is {keyword}.");
        }

        static string IsnumberPositiveNegativeOrZero(int number)
        {
            if (number < 0)
            {
                return "negative";
            }
            else if(number > 0)
            {
                return "positive";
            }
            return "zero";
        }
    }
}
