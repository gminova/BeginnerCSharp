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
            Console.Write("Enter side of square 'a' = ");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Area = ");
            Console.WriteLine(area);
        }
    }
}