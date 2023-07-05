

namespace Lection3Lab
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] dayOfWeek = new string[7];

            dayOfWeek[0] = "Monday";
            dayOfWeek[1] = "Tuesday";
            dayOfWeek[2] = "Wednesday";
            dayOfWeek[3] = "Thursday";
            dayOfWeek[4] = "Friday";
            dayOfWeek[5] = "Saturday";
            dayOfWeek[6] = "Sunday";
            
            if(n >0 && n <= 7)
            {
                Console.WriteLine(dayOfWeek[n-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
            


        }
    }
}
