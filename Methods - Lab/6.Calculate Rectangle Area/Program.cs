

namespace _6.Calculate_Rectangle_Area
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int side1 = int.Parse(Console.ReadLine());
            int side2 = int.Parse(Console.ReadLine());

            int finalResult = CalculateTheAreaOfRectangle(side1, side2);
            Console.WriteLine(finalResult);

        }

        static int CalculateTheAreaOfRectangle(int firstSide, int secondSide)
        {
            return firstSide * secondSide;
        }
    }
}
