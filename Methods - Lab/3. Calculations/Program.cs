

namespace _3._Calculations
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result;

            if(command == "add")
            {
                result = AddMethod(num1, num2);
            }
            else if(command == "multiply")
            {
                result = MultiplyMethod(num1, num2);
            }
            else if (command == "subtract")
            {
                result = SubtractMethod(num1, num2);
            }
            else
            {
                result = DivideMethod(num1, num2);
            }
            Console.WriteLine(result);
        }

        static int AddMethod(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        static int MultiplyMethod(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }

        static int SubtractMethod(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }

        static int DivideMethod(int numberOne, int numberTwo)
        {
            return numberOne / numberTwo;
        }
    }
}
