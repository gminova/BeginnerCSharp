using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine($"Yes sum = {oddSum}");
            }
            else
            {
                Console.WriteLine($"No Diff = {Math.Abs(oddSum - evenSum)}");
            }
        }
    }
}