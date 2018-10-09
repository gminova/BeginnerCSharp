using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            double moneyLeft = 0;

            switch (season)
            {
                case "Spring": totalPrice = 3000; break;
                case "Summer": totalPrice = 4200; break;
                case "Autumn": totalPrice = 4200; break;
                case "Winter": totalPrice = 2600; break;
                default:
                    break;
            }

            if (fishermanCount <= 6)
            {
                totalPrice = totalPrice - (totalPrice * 0.10);
            }
            else if (fishermanCount > 6 && fishermanCount <= 11)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }
            else if (fishermanCount > 12)
            {
                totalPrice = totalPrice - (totalPrice * 0.25);
            }

            if (!(season == "Autumn") && (fishermanCount % 2 == 0))
            {
                totalPrice = totalPrice - (totalPrice * 0.05);
            }


            moneyLeft = budget - totalPrice;

            if (moneyLeft >= 0)
            {
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):F2} leva.");
            }
        }
    }
}