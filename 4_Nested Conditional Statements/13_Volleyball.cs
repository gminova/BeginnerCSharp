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
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int home = int.Parse(Console.ReadLine());
            switch (year)
            {
                case "leap": Console.WriteLine(Math.Floor(1.15 * ((3.0 / 4.0 * (48 - home)) + home + (2.0 / 3.0 * holidays)))); break;
                case "normal": Console.WriteLine(Math.Floor((3.0 / 4.0 * (48 - home)) + home + (2.0 / 3.0 * holidays))); break;
            }
        }
    }
}