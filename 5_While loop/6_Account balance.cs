using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int currentCount = 0;
            double balance = 0.0;
            while (currentCount < count)
            {
                double deposit = double.Parse(Console.ReadLine());
                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += deposit;
                Console.WriteLine($"Increase: {deposit:f2}");
                currentCount++;
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}