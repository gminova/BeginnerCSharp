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
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());
            double friction = Math.Floor(distance / 15) * 12.5;
            double time = (speed * distance) + friction; ;
            if (time < record)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0} seconds.", $"{Math.Abs(time):f2}");
            }
            else
            {
                Console.WriteLine("No, he failed! He was {0} seconds slower.", $"{(Math.Abs(record - time)):f2}");
            }
        }
    }
}