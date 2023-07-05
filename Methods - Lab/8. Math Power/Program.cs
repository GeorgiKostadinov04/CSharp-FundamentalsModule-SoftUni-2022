

namespace _8._Math_Power
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double finalResult = CalculatorOfNumber(n, power);
            Console.WriteLine(finalResult);

            
        }

        static double CalculatorOfNumber(double number, int power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}
