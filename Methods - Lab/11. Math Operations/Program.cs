

namespace _11._Math_Operations
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
           int num1 = int.Parse(Console.ReadLine());
           char mathOperator = char.Parse(Console.ReadLine());
           int num2 = int.Parse(Console.ReadLine());

            int finalResult = Calculate(num1, mathOperator, num2);
            Console.WriteLine(finalResult);
        }
        static int Calculate(int a, char mathOperator, int b)
        {
            int result = 0;

            switch (mathOperator)
            {
                case '/':
                    result = a / b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '+':
                    result = a + b;
                    break;
                default:
                    result = a - b;
                    break;
            }
            return result;
        }
    }
}
