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
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", 0.9 * budget);
            }
            switch (season)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine("Camp - {0:f2}", 0.3 * budget);
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine("Camp - {0:f2}", 0.4 * budget);
                    }
                    break;
                case "winter":
                    if (budget <= 100)
                    {
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine("Hotel - {0:f2}", 0.7 * budget);
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine("Hotel - {0:f2}", 0.8 * budget);
                    }
                    break;
                default: break;
            }
        }
    }
}