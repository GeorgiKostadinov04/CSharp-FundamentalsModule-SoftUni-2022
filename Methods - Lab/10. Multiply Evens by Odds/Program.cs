

namespace _10._Multiply_Evens_by_Odds
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num1 = GetSumOfEvenDigits(n);
            int num2 = GetSumOfOddDigits(n);

            Console.WriteLine(num1*num2);
        }

        static int GetSumOfEvenDigits(int number)
        {
            int newNumber = Math.Abs(number);

            
            int evenNumSum = 0;

            while(newNumber > 0)
            {
                int currNum = newNumber % 10;
                newNumber /= 10;

                if(currNum %2 == 0)
                {
                    evenNumSum += currNum;
                }
            }
            return evenNumSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int newNumber = Math.Abs(number);

            
            int oddNumSum = 0;

            while (newNumber > 0)
            {
                int currNum = newNumber % 10;
                newNumber /= 10;

                if (currNum % 2 == 1)
                {
                    oddNumSum += currNum;
                }
            }
            return oddNumSum;
        }
    }
}
