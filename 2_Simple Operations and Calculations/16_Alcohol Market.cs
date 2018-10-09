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
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakiya = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());
            double rakiyaPrice = whiskeyPrice / 2.00;
            double beerPrice = rakiyaPrice - (0.8 * rakiyaPrice);
            double winePrice = rakiyaPrice - (0.4 * rakiyaPrice);
            double cost = (beer * beerPrice) + (wine * winePrice) + (rakiya * rakiyaPrice) + (whiskey * whiskeyPrice);
            Console.WriteLine($"{cost:f2}");
        }
    }
}