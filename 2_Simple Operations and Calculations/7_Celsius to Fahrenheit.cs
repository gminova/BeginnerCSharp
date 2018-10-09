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
            Console.Write("Celsius = ");
            var C = double.Parse(Console.ReadLine());
            var F = (C * 1.8000) + 32.00;
            //Console.WriteLine("{0} °C = {1} °F", C, Math.Round(F, 2));
            Console.WriteLine(Math.Round(F, 2));
        }
    }
}