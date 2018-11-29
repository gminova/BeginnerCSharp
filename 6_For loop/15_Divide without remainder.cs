using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double count1 = 0;
            double count2 = 0;
            double count3 = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    count1++;
                    if (number % 3 == 0)
                    {
                        count2++;
                    }
                    if (number % 4 == 0)
                    {
                        count3++;
                    }
                }
                else if (number % 3 == 0)
                {
                    count2++;
                }

            }
            Console.WriteLine($"{(count1 / n * 100):f2}%");
            Console.WriteLine($"{(count2 / n * 100):f2}%");
            Console.WriteLine($"{(count3 / n * 100):f2}%");
        }
    }
}