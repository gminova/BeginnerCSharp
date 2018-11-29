using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double gifts = double.Parse(Console.ReadLine());
            double hotel = double.Parse(Console.ReadLine());
            double cost = (420 * 0.07 * 1.85) + (hotel * 0.9 + hotel * 0.85 + hotel * 0.80 + 3 * (gifts + food));
            Console.WriteLine($"Money needed: {cost:f2}");
        }
    }
}