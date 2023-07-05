

namespace task8
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestVolume = 0;
            string biggestVolumeKeg = string.Empty;

            for(int i = 1; i <= n; i++)
            {
                string kegModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if(volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestVolumeKeg = kegModel;
                }

            }
            Console.WriteLine(biggestVolumeKeg);
        }
    }
}
