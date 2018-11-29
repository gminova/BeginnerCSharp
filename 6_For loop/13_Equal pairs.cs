using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i <= n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    sum1 = num1 + num2;
                }
                else
                {
                    sum2 = num1 + num2;
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, value={sum2}");
            }
            else if (sum1 != sum2 && n == 1)
            {
                Console.WriteLine($"Yes, value={Math.Abs(sum1 - sum2)}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={Math.Abs(sum1 - sum2)}");
            }
        }
    }
}