using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPrime = 0;
            int sumNonPrime = 0;
            bool isPrime = true;
            while (true)
            {
                string digit = Console.ReadLine();
                if (digit == "stop")
                {
                    Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
                    Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
                    break;
                }
                int num = int.Parse(digit);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                isPrime = true;
                for (var i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && num != 1)
                {
                    sumPrime += num;
                }
                else
                {
                    sumNonPrime += num;
                }
            }
        }
    }
}