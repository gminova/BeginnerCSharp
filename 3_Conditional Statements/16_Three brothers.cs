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
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double totalhours = 1 / (1 / a + 1 / b + 1 / c);
            double rest = totalhours * 0.15;
            double cleaningtime = totalhours + rest;
            double timeleft = d - cleaningtime;
            Console.WriteLine("Cleaning time: {0}", $" {cleaningtime:f2}");
            if (timeleft > 0)
            {
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(timeleft));
            }
            else
            {
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Ceiling(Math.Abs(timeleft)));
            }
        }
    }
}