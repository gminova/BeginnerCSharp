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
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int numCakes = int.Parse(Console.ReadLine());
            int numWaffles = int.Parse(Console.ReadLine());
            int numPancakes = int.Parse(Console.ReadLine());
            double cakes = numCakes * 45.00;
            double waffles = numWaffles * 5.80;
            double pancakes = numPancakes * 3.20;
            double profit = days * bakers * (cakes + waffles + pancakes);
            double donation = profit - (profit / 8);
            Console.WriteLine($"{donation:f2}");
        }
    }
}