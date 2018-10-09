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
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobeA = double.Parse(Console.ReadLine());
            double danceroom = length * 100 * width * 100;
            double wardrobe = wardrobeA * 100 * wardrobeA * 100;
            double bench = danceroom / 10.0;
            double dancer = 7040;
            double dancefloor = danceroom - bench - wardrobe;
            var num = dancefloor / dancer;
            Console.WriteLine(Math.Floor(num));
        }
    }
}