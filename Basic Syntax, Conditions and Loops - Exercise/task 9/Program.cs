
namespace task_9
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double jonhMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double totalPrice = 0.0;

            int freeBelts = studentsCount/6;
            
            totalPrice = lightsaberPrice * Math.Ceiling(studentsCount * 1.1) + robePrice * studentsCount + beltPrice*(studentsCount-freeBelts);

            if(jonhMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(jonhMoney-totalPrice):f2}lv more.");
            }
        }
    }
}
