
namespace task4
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine()) + 30;

            if(min > 60)
            {
                hour++;
                min -= 60;
            }
            if(hour > 23)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{min:d2}");
        }
    }
}
