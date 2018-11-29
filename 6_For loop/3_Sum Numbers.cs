using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double num = 0;
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                num += input;
            }
            Console.WriteLine($"The sum is: {num}");
        }
    }
}