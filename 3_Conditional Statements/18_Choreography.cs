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
            double steps = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());
            double percentPerDay = (steps / days) / steps * 100;
            percentPerDay = Math.Ceiling(percentPerDay);
            double percentPerDancer = percentPerDay / dancers;
            if (percentPerDay <= 13.0)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0}%.", $"{percentPerDancer:f2}");
            }
            else
            {
                Console.WriteLine("No, They will not succeed in that goal! Required {0}% steps to be learned per day.", $"{percentPerDancer:f2}");
            }
        }
    }
}