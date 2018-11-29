using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeSpaceWidth = int.Parse(Console.ReadLine());
            int freeSpaceLegth = int.Parse(Console.ReadLine());
            int freeSpaceHeight = int.Parse(Console.ReadLine());
            int freeSpaceVolume = freeSpaceWidth * freeSpaceLegth * freeSpaceHeight;
            int boxesVolume = 0;
            while (boxesVolume <= freeSpaceVolume)
            {
                string command = Console.ReadLine();
                if (command == "Done")
                {
                    break;
                }
                else
                {
                    int boxCount = int.Parse(command);
                    boxesVolume += boxCount;
                }
            }
            if (freeSpaceVolume >= boxesVolume)
            {
                Console.WriteLine($"{freeSpaceVolume - boxesVolume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {boxesVolume - freeSpaceVolume} Cubic meters more.");
            }
        }
    }
}