using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    oddSum += num;
                    if (oddMin > num)
                    {
                        oddMin = num;
                    }
                    if (oddMax < num)
                    {
                        oddMax = num;
                    }
                }
                else if (i % 2 == 0)
                {
                    evenSum += num;
                    if (evenMin > num)
                    {
                        evenMin = num;
                    }
                    if (evenMax < num)
                    {
                        evenMax = num;
                    }
                }
            }
            if (oddSum != 0 && evenSum != 0)
            {
                Console.WriteLine($"OddSum={oddSum}");
                Console.WriteLine($"OddMin={oddMin}");
                Console.WriteLine($"OddMax={oddMax}");
                Console.WriteLine($"EvenSum={evenSum}");
                Console.WriteLine($"EvenMin={evenMin}");
                Console.WriteLine($"EvenMax={evenMax}");
            }
            else
            {
                if (oddSum == 0 && evenSum != 0)
                {
                    Console.WriteLine($"OddSum={oddSum}");
                    Console.WriteLine("OddMin=No");
                    Console.WriteLine("OddMax=No");
                    Console.WriteLine($"EvenSum={evenSum}");
                    Console.WriteLine($"EvenMin={evenMin}");
                    Console.WriteLine($"EvenMax={evenMax}");
                }
                else if (evenSum == 0 && oddSum != 0)
                {
                    Console.WriteLine($"OddSum={oddSum}");
                    Console.WriteLine($"OddMin={oddMin}");
                    Console.WriteLine($"OddMax={oddMax}");
                    Console.WriteLine($"EvenSum={evenSum}");
                    Console.WriteLine("EvenMin=No");
                    Console.WriteLine("EvenMax=No");
                }
                else
                {
                    Console.WriteLine($"OddSum={oddSum}");
                    Console.WriteLine("OddMin=No");
                    Console.WriteLine("OddMax=No");
                    Console.WriteLine($"EvenSum={evenSum}");
                    Console.WriteLine($"EvenMin=No");
                    Console.WriteLine($"EvenMax=No");
                }
            }
        }
    }
}