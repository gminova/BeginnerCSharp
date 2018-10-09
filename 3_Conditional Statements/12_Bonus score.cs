using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            if (points <= 100)
            {
                int bonus = 5;
                int total = 5 + points;
                if (points % 2 == 0)
                {
                    Console.WriteLine(bonus + 1);
                    Console.WriteLine(points + bonus + 1);
                }
                else if (points % 5 == 0)
                {
                    Console.WriteLine(bonus + 2);
                    Console.WriteLine(points + bonus + 2);
                }
                else
                {
                    Console.WriteLine(bonus);
                    Console.WriteLine(points + bonus);
                }
            }
            else if (points > 100 && points <= 1000)
            {
                double bonus = 0.2 * points;
                double total = bonus + points;
                if (points % 2 == 0)
                {
                    Console.WriteLine(bonus + 1);
                    Console.WriteLine(points + bonus + 1);
                }
                else if (points % 5 == 0)
                {
                    Console.WriteLine(bonus + 2);
                    Console.WriteLine(points + bonus + 2);
                }
                else
                {
                    Console.WriteLine(bonus);
                    Console.WriteLine(points + bonus);
                }
            }
            else if (points > 1000)
            {
                double bonus = 0.1 * points;
                double total = bonus + points;
                if (points % 2 == 0)
                {
                    Console.WriteLine(bonus + 1);
                    Console.WriteLine(points + bonus + 1);
                }
                else if (points % 5 == 0)
                {
                    Console.WriteLine(bonus + 2);
                    Console.WriteLine(points + bonus + 2);
                }
                else
                {
                    Console.WriteLine(bonus);
                    Console.WriteLine(points + bonus);
                }
            }
        }
    }
}