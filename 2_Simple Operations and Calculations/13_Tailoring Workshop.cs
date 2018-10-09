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
            int number = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double tablecloth = (length + 0.6) * (width + 0.6) * number;
            double kare = (length / 2) * (length / 2) * number;
            double priceUSD = tablecloth * 7.00 + kare * 9.00;
            double priceBGN = priceUSD * 1.85;
            Console.WriteLine("{0} USD", $"{priceUSD:F2}");
            Console.WriteLine("{0} BGN", $"{priceBGN:F2}");
        }
    }
}