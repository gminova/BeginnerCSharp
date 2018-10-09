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
            string flower = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double cost = 0.00;
            switch (flower)
            {
                case "Roses":
                    if (number > 80)
                    {
                        cost = number * 5.0 * 0.9;
                    }
                    else
                    {
                        cost = number * 5.00;
                    }
                    break;
                case "Dahlias":
                    if (number > 90)
                    {
                        cost = number * 3.8 * 0.85;
                    }
                    else
                    {
                        cost = number * 3.80;
                    }
                    break;
                case "Tulips":
                    if (number > 80)
                    {
                        cost = number * 2.80 * 0.85;
                    }
                    else
                    {
                        cost = number * 2.80;
                    }
                    break;
                case "Narcissus":
                    if (number < 120)
                    {
                        cost = number * 3.0 * 1.15;
                    }
                    else
                    {
                        cost = number * 3.00;
                    }
                    break;
                case "Gladiolus":
                    if (number < 80)
                    {
                        cost = number * 2.5 * 1.2;
                    }
                    else
                    {
                        cost = number * 2.50;
                    }
                    break;
                default:
                    break;
            }
            double moneyLeft = budget - cost;
            if (moneyLeft >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {number} {flower} and {moneyLeft:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(moneyLeft):F2} leva more.");
            }
        }
    }
}