using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double avrHeight = double.Parse(Console.ReadLine());
            double spaceshipVol = width * length * height;
            double room = (avrHeight + 0.4) * 2 * 2;
            double spaceLeft = Math.Floor(spaceshipVol / room);
            if (spaceLeft >= 3 && spaceLeft <= 10)
            {
                Console.WriteLine($"The spacecraft holds {spaceLeft} astronauts.");
            }
            else if (spaceLeft < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (spaceLeft > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}