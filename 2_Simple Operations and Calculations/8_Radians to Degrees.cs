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
            Console.Write("Radians = ");
            var rad = double.Parse(Console.ReadLine());
            var degree = rad * 180 / Math.PI;
            Console.WriteLine(Math.Round(degree, 2));
        }
    }
}