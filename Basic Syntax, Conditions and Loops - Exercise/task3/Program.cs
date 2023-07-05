

namespace task3
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCounter = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string typeOfDay = Console.ReadLine();
            double totalSum = 0.0;
            double priceForFriday = 10.90;
            double priceForSaturday = 15.60;
            double priceForSunday = 16;

            switch (typeOfGroup)
            {
                case "Students":
                    if(typeOfDay == "Friday")
                    {
                        totalSum = peopleCounter * 8.45;
                    }
                    else if(typeOfDay == "Saturday")
                    {
                        totalSum = peopleCounter * 9.80;
                    }
                    else
                    {
                        totalSum = peopleCounter * 10.46;
                    }
                    break;

                case "Business":
                    if (typeOfDay == "Friday")
                    {
                        totalSum = peopleCounter * priceForFriday;
                    }
                    else if (typeOfDay == "Saturday")
                    {
                        totalSum = peopleCounter * priceForSaturday;
                    }
                    else
                    {
                        totalSum = peopleCounter * priceForSunday;
                    }
                    break;

                default:
                    if (typeOfDay == "Friday")
                    {
                        totalSum = peopleCounter * 15;
                    }
                    else if (typeOfDay == "Saturday")
                    {
                        totalSum = peopleCounter * 20;
                    }
                    else
                    {
                        totalSum = peopleCounter * 22.50;
                    }
                    break;
            }
            if(typeOfGroup == "Students" && peopleCounter >= 30)
            {
                totalSum = totalSum * 0.85;
            }
            if(typeOfGroup == "Business" && peopleCounter >= 100)
            {
                if(typeOfDay == "Friday")
                {
                    totalSum = totalSum - (10 * priceForFriday);
                }
                else if(typeOfDay == "Saturday")
                {
                    totalSum = totalSum - (10 * priceForSaturday);
                }
                else
                {
                    totalSum = totalSum - (10 * priceForSunday);
                }
            }
            if(typeOfGroup == "Regular" && peopleCounter >=10 && peopleCounter <= 20)
            {
                totalSum = totalSum * 0.95;
            }
            Console.WriteLine($"Total price: {totalSum:f2}");
        }
    }
}
