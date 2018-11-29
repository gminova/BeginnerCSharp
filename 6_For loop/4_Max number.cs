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
            double num = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                while (input > num)
                {
                    num = input;
                }
            }
            Console.WriteLine($"The largest number is: {num}");
        }
    }
}