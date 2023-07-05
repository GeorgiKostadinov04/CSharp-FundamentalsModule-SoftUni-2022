

namespace task11
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double totalMoney = 0.0;

            for(int i = 1; i <= n; i++)
            {
                double currMoney = 0.0;
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
                currMoney = (days * capsuleCount) * pricePerCapsule;
                totalMoney += currMoney;
                Console.WriteLine($"The price for the coffee is: ${currMoney:f2}");
            }
            Console.WriteLine($"Total: ${totalMoney:f2}");
        }
    }
}
