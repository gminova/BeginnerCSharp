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
            string typeProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            switch (typeProjection)
            {
                case "Premiere": Console.WriteLine("{0:f2} leva", rows * columns * 12.00); break;
                case "Normal": Console.WriteLine("{0:f2} leva", rows * columns * 7.50); break;
                case "Discount": Console.WriteLine("{0:f2} leva", rows * columns * 5.00); break;
            }
        }
    }
}