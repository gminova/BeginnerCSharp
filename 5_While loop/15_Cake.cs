using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int availableSlices = width * lenght;
            bool cakeLeft = true;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    break;
                }

                availableSlices -= int.Parse(command);
                if (availableSlices < 0)
                {

                    break;
                }


            }
            if (availableSlices < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(availableSlices)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{availableSlices} pieces are left.");
            }

        }
    }
}