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
            int runner1 = int.Parse(Console.ReadLine());
            int runner2 = int.Parse(Console.ReadLine());
            int runner3 = int.Parse(Console.ReadLine());
            int totalTimeSec = runner1 + runner2 + runner3;
            int minutes = totalTimeSec / 60;
            int seconds = totalTimeSec % 60;
            if (totalTimeSec >= 60)
            {
                if (seconds < 10)
                {
                    Console.WriteLine("{0}:0{1}", minutes, seconds);
                }
                else
                {
                    Console.WriteLine("{0}:{1}", minutes, seconds);
                }
            }
            else
            {
                if (seconds < 10)
                {
                    Console.WriteLine("0:0{0}", totalTimeSec);
                }
                else
                {
                    Console.WriteLine("0:{0}", totalTimeSec);
                }
            }
        }
    }
}