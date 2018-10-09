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
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            if ((minutes + 15) < 60)
            {
                Console.WriteLine("{0}:{1}", hours, minutes + 15);
            }
            else if ((hours + 1) <= 23 && (minutes + 15) >= 60)
            {
                if ((minutes + 15 - 60) < 10)
                {
                    Console.WriteLine("{0}:0{1}", hours + 1, minutes + 15 - 60);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", hours + 1, minutes + 15 - 60);
                }
            }
            else if ((hours + 1) > 23 && (minutes + 15 - 60) < 10)
            {
                Console.WriteLine("{0}:0{1}", hours + 1 - 24, minutes + 15 - 60);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hours + 1 - 24, minutes + 15 - 60);
            }
        }
    }
}