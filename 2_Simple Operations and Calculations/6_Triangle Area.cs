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
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine("Square area = {0}", Math.Round(a * h / 2, 2));
        }
    }
}