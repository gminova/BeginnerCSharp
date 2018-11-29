using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyCost = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    sum += toyCost;
                }
                else
                {
                    sum += (i * 5) - 1;
                }
            }
            if (sum >= washingMachine)
            {
                Console.WriteLine($"Yes! {(sum - washingMachine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMachine - sum):f2}");
            }
        }
    }
}