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
            double count4 = 0;
            double count5 = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    count1++;
                }
                else if (number >= 200 && number <= 399)
                {
                    count2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    count3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    count4++;
                }
                else if (number >= 800)
                {
                    count5++;
                }
            }
            Console.WriteLine($"{(count1 / n * 100):f2}%");
            Console.WriteLine($"{(count2 / n * 100):f2}%");
            Console.WriteLine($"{(count3 / n * 100):f2}%");
            Console.WriteLine($"{(count4 / n * 100):f2}%");
            Console.WriteLine($"{(count5 / n * 100):f2}%");
        }
    }
}