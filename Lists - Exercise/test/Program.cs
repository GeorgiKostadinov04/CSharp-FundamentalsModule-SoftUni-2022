using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = new List<string>();
            for(int i = 0; i < 5; i++)
            {
                string currCar = Console.ReadLine();
                cars.Add(currCar);
            }
            

            cars = cars.Where(x => x.Contains("a")).ToList();
            Console.WriteLine(string.Join(" ", cars));


        }
    }
}
