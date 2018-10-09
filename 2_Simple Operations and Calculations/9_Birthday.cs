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
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volumeCM = length * width * height;
            double volumeL = volumeCM * 0.001;
            double volumeWater = volumeL - (volumeL * percent * 0.01);
            Console.WriteLine($"{volumeWater:F3}");
        }
    }
}