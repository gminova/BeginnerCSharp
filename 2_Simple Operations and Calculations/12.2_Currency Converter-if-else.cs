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
            decimal sum = decimal.Parse(Console.ReadLine());
            string currency1 = Console.ReadLine();
            string currency2 = Console.ReadLine();
            decimal rate1 = 0.0m;
            decimal rate2 = 0.0m;
            if (currency1 == "BGN")
            {
                rate1 = 1;
            }
            else if (currency1 == "USD")
            {
                rate1 = 1.79549m;
            }
            else if (currency1 == "EUR")
            {
                rate1 = 1.95583m;
            }
            else if (currency1 == "GBP")
            {
                rate1 = 2.53405m;
            }
            if (currency2 == "BGN")
            {
                rate2 = 1;
            }
            else if (currency2 == "USD")
            {
                rate2 = 1.79549m;
            }
            else if (currency2 == "EUR")
            {
                rate2 = 1.95583m;
            }
            else if (currency2 == "GBP")
            {
                rate2 = 2.53405m;
            }
            decimal result = sum * (rate1 / rate2);
            Console.WriteLine("{0} {1}", Math.Round(result, 2), currency2);
        }
    }
}