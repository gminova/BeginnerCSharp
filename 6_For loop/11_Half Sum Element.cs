using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int largestNumber = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number >= largestNumber)
                {
                    largestNumber = number;
                }
                sum += number;
            }
            if (sum - largestNumber == largestNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum - largestNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - 2 * largestNumber)}");
            }
        }
    }
}